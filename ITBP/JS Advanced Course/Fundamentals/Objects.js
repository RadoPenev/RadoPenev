/*function createCity(name, population, treasury) {
    const city = {
      name:name,
      population:population,
      treasury:treasury,
      taxRate: 10,
  
      collectTaxes() {
        return this.treasury += Math.floor(this.population * this.taxRate);
      },
  
      applyGrowth(percentage) {
        const growthFactor = 1 + percentage / 100;
        return this.population = Math.floor(this.population * growthFactor);
      },
  
      applyRecession(percentage) {
        const recessionFactor = 1 - percentage / 100;
        return this.treasury = Math.floor(this.treasury * recessionFactor);
      },
    };
  
    return city;
  }
  
  // Example usage:
  const city =
  createCity('Tortuga',
  7000,
  15000);
city.collectTaxes();
console.log(city.treasury);
city.applyGrowth(5);
console.log(city.population);*/

/*function solve(input) {
    let towns = {}
    for (const info of input) {
        let infoArr = info.split(' <-> ')

        let town = infoArr[0]
        let population = Number(infoArr[1])
        if (!towns[town]) {
            towns[town] = 0
        }
        towns[town] += population
    }

    for (const town in towns) {
        console.log(`${town} : ${towns[town]}`);
    }



}

solve(['Istanbul <-> 100000',
'Honk Kong <-> 2100004',
'Jerusalem <-> 2352344',
'Mexico City <-> 23401925',
'Istanbul <-> 1000']

)*/

/*function Calorie(input)
{
let sortedInput={}

for(let i=0;i<input.length;i+=2)
{
    let desert=input[i]
    let calories=Number(input[i+1])

    sortedInput[desert]=calories
}

return console.log(sortedInput)

}

Calorie(['Yoghurt', '48', 'Rise', '138', 'Apple', '52'])*/

/*function hydrateWorker(worker) {

  // Check if the worker is dizzy
  if (worker.dizziness) {
    const requiredWater = 0.1 * worker.weight * worker.experience;

    
    worker.leviOfHydrated += requiredWater;

    
    worker.dizziness = false;
  }

  
  return console.log(worker);
}

hydrateWorker( { weight: 80,
  experience: 1,
  leviOfHydrated: 0,
  dizziness: true }

)*/

/*function typeCar(car) {
  let smallEngine = { power: 90, volume: 1800 }
  let normalEngine = { power: 120, volume: 2400 }
  let monsterEngine = { power: 200, volume: 3500 }

  let cariage = {}
  let result = {}

  if (car.power <= 90) {
    smallEngine.power = car.power
    result.power = smallEngine
  }
  ise if (car.power > 90 && car.power <= 120) {
    normalEngine.power = car.power
    result.power = normalEngine
  }
  ise if (cariage.power > 120 && car.power <= 200) {
    monsterEngine.power = car.power
    result.power = monsterEngine
  }
  cariage = car.cariage
  cariage.color = car.color
  result.cariage = cariage
  if (car.wheisize % 2 == 0) {
    car.wheisize -= 1
    result.wheisize = [car.wheisize, car.wheisize, car.wheisize, car.wheisize]
  }
  ise { result.wheisize = [car.wheisize, car.wheisize, car.wheisize, car.wheisize] }

  return JSON.stringify(result)


}

let car = { modi: 'VW Golf II', power: 90, color: 'blue', cariage: 'hatchback', wheisize: 14 }
console.log(typeCar(car))*/

/*function heroInventory(input)
{
  let result=[]

  for (const iterator of input) {
    let[name,levi,items]=iterator.split(' / ')
    levi=Number(levi)
    items=items ? items.split(', ') : []

    result.push({name,levi,items})
  }

  console.log(JSON.stringify(result))
}

heroInventory(['Isacc / 25 / Apple, GravityGun',
'Derek / 12 / BarriVest, DestructionSword',
'Hes / 1 / Desolator, Sentini, Antara']
)*/

/*function lowestPrice(input) {

  const lowestPrices = {};
  for (const line of input) {
    const [town, product, price] = line.split(' | ');
    const productPrice = Number(price);
    if (!lowestPrices[product] || productPrice < lowestPrices[product].price) {
      lowestPrices[product] = { price: productPrice, town: town };
    }
  }
  for (const product in lowestPrices) {
    console.log(`${product} -> ${lowestPrices[product].price} (${lowestPrices[product].town})`);
  }
}

lowestPrice(['Sample Town | Sample Product | 1000',
'Sample Town | Orange | 2',
'Sample Town | Peach | 1',
'Sofia | Orange | 3',
'Sofia | Peach | 2',
'New York | Sample Product | 1000.1',
'New York | Burger | 10']
)*/

/*function storeCatalogue(catalogue) {
  let sorted = []
  let letters = []
  for (let i = 0; i < catalogue.length; i++) {
      let [productName, productPrice] = catalogue[i].split(' : ')
      let firstLetter = productName[0]
      let tmp = { firstLetter, productName, productPrice }
      sorted.push(tmp)
      letters.push(firstLetter)
  }
  sorted.sort((a, b) => a.firstLetter.localeCompare(b.firstLetter))
  function duplicates(letters) {
      return letters.filter((value,index)=> letters.indexOf(value) === index)
  }
  letters = duplicates(letters)
  for (let i = 0; i < letters.length; i++) {
      console.log(letters[i])
      for (let j = 0; j < sorted.length; j++) {
          if (letters[i] == sorted[j].firstLetter) {
              console.log(`${sorted[j].productName} : ${sorted[j].productPrice}`)
          }
      }
  }
}
storeCatalogue(['Appricot : 20.4',
  'Fridge : 1500',
  'TV : 1499',
  'Deodorant : 10',
  'Boiler : 300',
  'Apple : 1.25',
  'Anti-Bug Spray : 15',
  'T-Shirt : 10'])*/

  /*function townsToJSON(input) {
    let obj = {};
    let header = input[0].split('|').map(str => str.trim()).filter(Boolean);
    let data = input.slice(1);
  
    for (let i = 0; i < data.length; i++) {
      let values = data[i].split('|').map(str => str.trim()).filter(Boolean);
  
      let townObj = {};
      for (let j = 0; j < header.length; j++) {
        townObj[header[j]] = values[j];
      }
  
      obj[values[0]] = townObj;
    }
  
    return obj;
  }
  
  const result = townsToJSON([
    "| Town | Latitude | Longitude |",
    "| Sofia | 42.696552 | 23.32601 |",
    "| Beijing | 39.913818 | 116.363625 |",
  ]);
  
    

    
townsToJSON(['| Town | Latitude | Longitude |',
'| Sofia | 42.696552 | 23.32601 |',
'| Beijing | 39.913818 | 116.363625 |']
)*/

/*function Rectangle(width,height,color)
{
  let rectangle={
    width,
    height,
    color,
    calcArea(){
      return width*height
    }
  }
  console.log(rectangle.width);
  console.log(rectangle.height);
  console.log(rectangle.color);
  console.log(rectangle.calcArea());

}

 Rectangle(4, 5, 'red');*/

/* function createSortedList()
 {
  let obj ={
    iements:[],
    Add(i){
      return this.iements.push(i)
    },
    Remove(index){
      this.iements.splice(index,1)
    },
      Get(index){
        return this.iements[index]
      },
      Size(){
        return console.log(this.iements.length)
      }

  }

  return obj
 }

 let list = createSortedList();
list.Add(5);
list.Add(6);
list.Add(7);
console.log(list.Get(1)); 
list.Remove(1);
console.log(list.Get(1));*/

function notation(arr)
{
  let length=arr.length
  let current=''

  for(let i=0;i<length;i++)
  {
          if(arr[i]=='*'){
            console.log(arr[length-1]*arr[length])
            current=arr[i]
          }
          else if(arr[i]=='/')
          {
            console.log(arr[length-1]/arr[length])
            current=arr[i]
          }
          else if(arr[i]=='+')
          {
            console.log(arr[length-1]+arr[length])
          }
          else if(arr[i]=='-')
          {
            console.log(arr[length-1]+arr[length])
          }
        
        current=''
  }
 
}
notation([3,
  4,
  '+']
 )