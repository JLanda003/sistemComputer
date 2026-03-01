export class Piece {
    #shape = null;
    #color = 'black';
    #height = 1;
    #width = 1;
    #row = 0;
    #column = 0;
    #shapes = [];      // Array de formas para rotación
    #shapeNum = 0;     // Forma actual (índice)

    constructor(shapes, color) {
        this.#shapes = Array.isArray(shapes[0]) ? shapes : [shapes];
        this.#row = 0;
        this.#column = 0;
        this.#shapeNum = 0;
        this.#height = this.#shapes[0].length;
        this.#width = this.#shapes[0][0].length;
        
        if (color != null) {
            this.#color = color;
        }
    }

    // Getters
    get shape() {
        return this.#shapes[this.#shapeNum];
    }

    get width() {
        return this.#width;
    }

    get height() {
        return this.#height;
    }

    get row() {
        return this.#row;
    }

    get column() {
        return this.#column;
    }

    get color() {
        return this.#color;
    }

    get shapeNum() {
        return this.#shapeNum;
    }

    // Setters
    set row(value) {
        this.#row = value;
    }

    set column(value) {
        this.#column = value;
    }

    set shapeNum(value) {
        this.#shapeNum = value;
    }

    reset(boardWidth) {
        this.#row = 0;
        this.#column = Math.floor((boardWidth / 2) - 1);
        this.#shapeNum = 0;
        this.#height = this.#shapes[0].length;
        this.#width = this.#shapes[0][0].length;
    }

    rotate() {
        this.#shapeNum = (this.#shapeNum + 1) % this.#shapes.length;
        this.#height = this.#shapes[this.#shapeNum].length;
        this.#width = this.#shapes[this.#shapeNum][0].length;
    }
}
