function printDeckOfCards(cards) {
    function createCard(face, suit) {
        let posibilities = ['A', 'K', 'Q', 'J', '10', '9', '8', '7', '6', '5', '4', '3', '2']

        let obj = {
            'S': '\u2660',
            'H': '\u2665 ',
            'D': '\u2666',
            'C': '\u2663'
        }

        let card = {
            face,
            suit,
            toString() {
                if (!(posibilities.includes(face) && obj[suit])) {
                    throw new Error(`invalid card ${this.face}${this.suit}`)
                }
                else {
                    return this.face + obj[this.suit]
                }

            }
        }
        return card
    }
    let result = []
    try {
        for (let i = 0; i < cards.length; i++) {
            let card = cards[i]
            let suit = card[card.length - 1]
            let face = card.slice(0, card.length - 1)
            result.push(createCard(face, suit));
        }
        console.log(result.join(' '));
    }catch (e) {
        console.log(e.message)
    }
    
}
  
  


printDeckOfCards(['5S', '3D', 'QD', '1C'])