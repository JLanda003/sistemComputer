import {Piece} from './Piece.js';

export class PieceL extends Piece {
    constructor() {
        super(
            [
              [ [1, 0],
                [1, 0],
                [1, 1] ],
              [ [1, 1],
                [0, 1],
                [0, 1] ],
              [ [1, 1, 1],
                [1, 0, 0] ],
              [ [0, 0, 1],
                [1, 1, 1] ],

              [ [0, 1],
                [0, 1],
                [1, 1] ],
              [ [1, 1],
                [1, 0],
                [1, 0] ],
              [ [1, 1, 1],
                [0, 0, 1] ],
              [ [1, 0, 0],
                [1, 1, 1] ],
            ],
            "orange"
        );
    }
}

export class PieceInverseS extends Piece {
    constructor() {
        super(
            [
              [ [0, 1],
                [1, 1],
                [1, 0] ],
              [ [1, 0],
                [1, 1],
                [0, 1] ],

              [ [1, 1, 0],
                [0, 1, 1] ],
              [ [0, 1, 1],
                [1, 1, 0] ]
            ],
            "darkred"
        );
    }
}

export class PiecePodium extends Piece {
    constructor() {
        super(
            [
              // T abajo
            [ [0, 1, 0],
              [1, 1, 1] ],
            // T dizquierda
            [ [1, 0],
              [1, 1],
              [1, 0] ],
            // T arriba
            [ [1, 1, 1],
              [0, 1, 0] ],
            // T izquierda
            [ [0, 1],
              [1, 1],
              [0, 1] ]
            ],
            "purple"
        );
    }
}

export class PieceBar extends Piece {
    constructor() {
        super(
            [
              // barra vertical
              [ [1],
                [1],
                [1],
                [1] ],
              // barra horizontal
              [ [1, 1, 1, 1] ]
            ],
            "darkcyan"
        );
    }
}

export class PieceCube extends Piece {
    constructor() {
        super(
            [
              // Cubo
              [ [1, 1],
                [1, 1] ]
            ],
            "pink"
        );
    }
}
