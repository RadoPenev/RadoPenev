function solve(input) {
    let juiceBottles = new Map()
    
    while (input.length != 0) {
        let [flavor, quantity] = input.shift().split(' => ')
        if (!juiceBottles.has(flavor)) {
            juiceBottles.set(flavor, Number(quantity))
        } else {  let currQuantity=juiceBottles.get(flavor)
            juiceBottles.set(flavor,juiceBottles.get(flavor)+currQuantity)
        }
       
    }
    
    for (let [key, value] of juiceBottles) {
        if (Math.floor(value/1000) > 0){ console.log(`${key} => ${Math.floor(value/1000)}`);}
        
    }

   
} 

solve(['Kiwi => 234',
'Pear => 2345',
'Watermelon => 3456',
'Kiwi => 4567',
'Pear => 5678',
'Watermelon => 6789']
)