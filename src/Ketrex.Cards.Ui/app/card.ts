var root = (function() {
    console.log("Function ran!");
})();

class Card {
    suit: Suit;
    rank: Rank;
}

class Deck {
    constructor(){

    }
    cards: Card[];
}

enum Suit {
    Clubs = 1,
    Diamonds,
    Hearts,
    Spades
}

enum Rank {
    Ace = 1,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten,
    Jack,
    Queen,
    King
}