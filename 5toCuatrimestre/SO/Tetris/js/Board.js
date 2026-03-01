export class Board {
    static PIXEL_SIZE = 24;
    #color = "darkgreen";
    #rows;
    #columns;
    #board;

    constructor(rows, columns, color) {
        this.#rows = rows;
        this.#columns = columns;

        if (color !== null && color !== undefined) {
            this.#color = color;
        }

        this.#board = new Array(rows);
        for (let i = 0; i < rows; ++i) {
            this.#board[i] = new Array(columns).fill(0);
        }
    }

    get rows() {
        return this.#rows;
    }

    get columns() {
        return this.#columns;
    }

    get color() {
        return this.#color;
    }

    set color(value) {
        this.#color = value;
    }

    cells(row, column) {
        const { isInvalid, text } = this.validRC(row, column);

        if (isInvalid) {
            throw new RangeError(text);
        }

        return this.#board[row][column];
    }

    setCells(row, column, value) {
        if (value === null || value === undefined) value = 0;
        
        const { isInvalid, text } = this.validRC(row, column);

        if (isInvalid) {
            throw new RangeError(text);
        }

        this.#board[row][column] = value;
    }

    validRC(row, column) {
        let text = "";

        if (row < 0 || row >= this.rows) {
            text = `row: 0 - ${this.rows}: ${row}`;
        }

        if (column < 0 || column >= this.columns) {
            text = `column: 0 - ${this.columns}: ${column}`;
        }

        return {
            isInvalid: text.length > 0,
            text: text
        };
    }

    getRow(row) {
        return this.#board[row];
    }

    insertEmptyRows(numRows) {
        for (let i = 0; i < numRows; i++) {
            this.#board.unshift(new Array(this.#columns).fill(0));
        }
        this.#rows += numRows;
    }

    removeRows(listRows) {
        let newBoard = [];

        for (let numRow = 0; numRow < this.#board.length; ++numRow) {
            if (!listRows.includes(numRow)) {
                newBoard.push(this.#board[numRow]);
            }
        }

        this.#board = newBoard;
        this.#rows = this.#board.length;
    }

    canPlace(piece, row, column) {
        const shape = piece.shape;
        
        for (let r = 0; r < shape.length; r++) {
            for (let c = 0; c < shape[r].length; c++) {
                if (shape[r][c] === 1) {
                    const newRow = row + r;
                    const newCol = column + c;
                    
                    // Fuera del tablero: rechaza
                    if (newCol < 0 || newCol >= this.#columns) {
                        return false;
                    }
                    
                    if (newRow < 0) {
                        return false;
                    }
                    
                    // Si está fuera del fondo, rechaza
                    if (newRow >= this.#rows) {
                        return false;
                    }
                    
                    // Si hay colisión con bloque existente, rechaza
                    if (this.#board[newRow][newCol] !== 0) {
                        return false;
                    }
                }
            }
        }
        return true;
    }

    placePiece(piece) {
        const shape = piece.shape;
        const row = piece.row;
        const col = piece.column;

        for (let r = 0; r < shape.length; r++) {
            for (let c = 0; c < shape[r].length; c++) {
                if (shape[r][c] === 1) {
                    const boardRow = row + r;
                    const boardCol = col + c;
                    
                    // Solo coloca si está dentro del tablero
                    if (boardRow >= 0 && boardRow < this.#rows && 
                        boardCol >= 0 && boardCol < this.#columns) {
                        this.#board[boardRow][boardCol] = piece.color;
                    }
                }
            }
        }
    }

    checkFullRows() {
        const fullRows = [];
        
        for (let r = 0; r < this.#rows; r++) {
            let isFull = true;
            for (let c = 0; c < this.#columns; c++) {
                if (this.#board[r][c] === 0) {
                    isFull = false;
                    break;
                }
            }
            if (isFull) {
                fullRows.push(r);
            }
        }

        if (fullRows.length > 0) {
            this.removeRows(fullRows);
            this.insertEmptyRows(fullRows.length);
        }
        
        return fullRows.length;
    }
}
