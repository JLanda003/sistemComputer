import {Board} from './Board.js';
import {Canvas} from './Canvas.js';
import {PieceL, PieceInverseS, PiecePodium, PieceBar, PieceCube} from './Pieces.js';

export class Game {
    #board;
    #canvas;
    #currentPiece = null;
    #gameOver = false;
    #score = 0;
    #intervalId = null;
    #pieceClasses = [PieceL, PieceInverseS, PiecePodium, PieceBar, PieceCube];

    constructor(canvasElement, rows = 20, columns = 10) {
        this.#board = new Board(rows, columns, "#2d2d2d");
        this.#canvas = new Canvas(canvasElement, this.#board);
        
        this.spawnPiece();
        this.start();
        this.setupControls();
    }

    get board() {
        return this.#board;
    }

    get score() {
        return this.#score;
    }

    get gameOver() {
        return this.#gameOver;
    }

    get canvas() {
        return this.#canvas;
    }

    spawnPiece() {
        const RandomClass = this.#pieceClasses[Math.floor(Math.random() * this.#pieceClasses.length)];
        this.#currentPiece = new RandomClass();
        this.#currentPiece.reset(this.#board.columns);
        this.#canvas.piece = this.#currentPiece;
        console.debug('spawnPiece', this.#currentPiece);
        
        // Verifica si la nueva pieza cabe desde el inicio
        const can = this.#board.canPlace(this.#currentPiece, this.#currentPiece.row, this.#currentPiece.column);
        console.debug('canPlace new', can);
        if (!can) {
            console.debug('game over triggered on spawn');
            this.#gameOver = true;
            this.stop();
            this.showGameOver();
        }
    }

    showGameOver() {
        const gameOverModal = document.getElementById('gameOverModal');
        const finalScore = document.getElementById('finalScore');
        if (gameOverModal && finalScore) {
            finalScore.textContent = this.#score;
            gameOverModal.style.display = 'flex';
        }
    }

    start() {
        this.#gameOver = false;
        this.#intervalId = setInterval(() => this.update(), 1000);
        this.render();
    }

    stop() {
        if (this.#intervalId) {
            clearInterval(this.#intervalId);
            this.#intervalId = null;
        }
    }

    update() {
        if (this.#gameOver) return;
        this.movePieceDown();
    }

    movePieceDown() {
        if (!this.#currentPiece) return;

        const nextRow = this.#currentPiece.row + 1;
        const canGoCollision = this.#board.canPlace(this.#currentPiece, nextRow, this.#currentPiece.column);
        // también verificar que la pieza no exceda bordes inferiores basado en altura
        const maxRowAllowed = this.#board.rows - this.#currentPiece.height;
        const canGo = canGoCollision && (nextRow <= maxRowAllowed);
        console.debug('movePieceDown', {row: this.#currentPiece.row, nextRow, canGoCollision, maxRowAllowed, canGo});

        // Verifica si puede seguir bajando
        if (canGo) {
            // Sigue bajando
            this.#currentPiece.row = nextRow;
        } else {
            // No puede bajar más: coloca la pieza y genera nueva
            console.debug('placing piece at', this.#currentPiece.row);
            this.#board.placePiece(this.#currentPiece);
            
            const linesCleared = this.#board.checkFullRows();
            this.#score += linesCleared * 100;
            
            this.spawnPiece();
        }
        
        this.render();
    }

    moveLeft() {
        if (!this.#currentPiece || this.#gameOver) return;

        const nextCol = this.#currentPiece.column - 1;
        
        if (this.#board.canPlace(this.#currentPiece, this.#currentPiece.row, nextCol)) {
            this.#currentPiece.column = nextCol;
            this.render();
        }
    }

    moveRight() {
        if (!this.#currentPiece || this.#gameOver) return;

        const nextCol = this.#currentPiece.column + 1;
        
        if (this.#board.canPlace(this.#currentPiece, this.#currentPiece.row, nextCol)) {
            this.#currentPiece.column = nextCol;
            this.render();
        }
    }

    rotate() {
        if (!this.#currentPiece || this.#gameOver) return;

        this.#currentPiece.rotate();

        if (this.#board.canPlace(this.#currentPiece, this.#currentPiece.row, this.#currentPiece.column)) {
            this.render();
        } else {
            this.#currentPiece.rotate();
        }
    }

    render() {
        this.#canvas.paint();
        
        const scoreElement = document.getElementById('score');
        if (scoreElement) {
            scoreElement.textContent = this.#score;
        }
    }

    setupControls() {
        document.addEventListener('keydown', (e) => {
            if (this.#gameOver) return;

            switch(e.key.toLowerCase()) {
                case 'arrowleft':
                    e.preventDefault();
                    this.moveLeft();
                    break;
                case 'arrowright':
                    e.preventDefault();
                    this.moveRight();
                    break;
                case 'arrowdown':
                    e.preventDefault();
                    this.movePieceDown();
                    break;
                case 'arrowup':
                case 'x':
                    e.preventDefault();
                    this.rotate();
                    break;
                case 'p':
                    e.preventDefault();
                    if (this.#intervalId) {
                        this.stop();
                    } else {
                        this.start();
                    }
                    break;
            }
        });
    }
}
