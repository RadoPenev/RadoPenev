function solve(face, suit) {
    let posibilities = ['A', 'K', 'Q', 'J','10','9','8','7','6','5','4','3','2']
    
    let obj={
        'S':'\u2660',
        'H':'\u2665 ',
        'D':'\u2666',
       'C':'\u2663'
    }
    if(!(posibilities.includes(face)&&obj[suit])){
throw new Error("Error")
    }
 
   let card={
    face,
    suit,
    toString(){
        return this.face + obj[this.suit]
    }
   }
  return card
}
let print = solve('10', 'H')
console.log(print.toString());

