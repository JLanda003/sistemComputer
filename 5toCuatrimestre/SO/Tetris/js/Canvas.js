import {Board} from './Board.js';

export class Canvas {
    static SEPARATION = 2;
    #painting = false;
    #element = null;
    #board = null;
    #piece = null;

    constructor(element, board) {
        element.width = 5 + (board.columns * Board.PIXEL_SIZE);
        element.height = 5 + (board.rows * Board.PIXEL_SIZE);

        this.#board = board;
        this.#element = element;
    }

    get piece() {
        return this.#piece;
    }

    set piece(value) {
        this.#piece = value;
    }

    get board() {
        return this.#board;
    }

    paint() {
        if (this.#painting) {
            return;
        }

        const ctx = this.#element.getContext("2d");
        const SEP = Canvas.SEPARATION;

        this.#painting = true;
        this.clear();

        this.paintBoard(ctx, SEP);
        
        if (this.#piece) {
            this.paintPiece(ctx, SEP);
        }

        this.#painting = false;
    }

    paintBoard(ctx, SEP) {
        ctx.lineWidth = 1;
        ctx.strokeStyle = this.#board.color;
        
        ctx.strokeRect(
            1,
            1,
            this.#element.width - 1,
            this.#element.height - 1
        );

        for (let numRow = 0; numRow < this.#board.rows; ++numRow) {
            const row = this.#board.getRow(numRow);

            for (let numColumn = 0; numColumn < row.length; ++numColumn) {
                if (Boolean(row[numColumn])) {
                    ctx.lineWidth = 1;
                    ctx.strokeStyle = row[numColumn];
                    ctx.fillStyle = row[numColumn];
                    
                    ctx.fillRect(
                        SEP + (Board.PIXEL_SIZE * numColumn),
                        SEP + (Board.PIXEL_SIZE * numRow),
                        Board.PIXEL_SIZE,
                        Board.PIXEL_SIZE
                    );
                    
                    ctx.strokeRect(
                        SEP + (Board.PIXEL_SIZE * numColumn),
                        SEP + (Board.PIXEL_SIZE * numRow),
                        Board.PIXEL_SIZE,
                        Board.PIXEL_SIZE
                    );
                }
            }
        }
    }

    paintPiece(ctx, SEP) {
        const SHAPE = this.#piece.shape;

        for (let numRow = 0; numRow < SHAPE.length; ++numRow) {
            const ROW = SHAPE[numRow];

            for (let numColumn = 0; numColumn < ROW.length; ++numColumn) {
                if (Boolean(ROW[numColumn])) {
                    ctx.lineWidth = 1;
                    ctx.strokeStyle = this.#piece.color;
                    ctx.fillStyle = this.#piece.color;
                    
                    ctx.fillRect(
                        SEP + (this.#piece.column * Board.PIXEL_SIZE) + (Board.PIXEL_SIZE * numColumn),
                        SEP + (this.#piece.row * Board.PIXEL_SIZE) + (Board.PIXEL_SIZE * numRow),
                        Board.PIXEL_SIZE,
                        Board.PIXEL_SIZE
                    );
                    
                    ctx.strokeRect(
                        SEP + (this.#piece.column * Board.PIXEL_SIZE) + (Board.PIXEL_SIZE * numColumn),
                        SEP + (this.#piece.row * Board.PIXEL_SIZE) + (Board.PIXEL_SIZE * numRow),
                        Board.PIXEL_SIZE,
                        Board.PIXEL_SIZE
                    );
                }
            }
        }
    }

    clear() {
        const ctx = this.#element.getContext("2d");
        ctx.clearRect(0, 0, this.#element.width, this.#element.height);
    }
}
