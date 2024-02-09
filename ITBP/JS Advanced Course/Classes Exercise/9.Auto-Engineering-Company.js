function solve(input) {
console.log(typeof input);
  let cars = new Map()

  while (input.length > 0) {
    let [brand, model, quantity] = input.shift().split(' | ')
    if (cars.has(brand)) {

      if (cars.get(brand).has(model)) {
        let existingQuantity = cars.get(brand).get(model);
        cars.get(brand).set(model, existingQuantity + parseInt(quantity));
      } else {
        cars.get(brand).set(model, parseInt(quantity));
      }
    } else {

      const models = new Map();
      models.set(model, parseInt(quantity));
      cars.set(brand, models);
    }
  }

  for (const [brand, models] of cars) {
    console.log(brand);
    for (const [model, quantity] of models) {
      console.log(`###${model} -> ${quantity}`);
    }
  }

}

solve(['Audi | Q7 | 1000',
  'Audi | Q6 | 100',
  'BMW | X5 | 1000',
  'BMW | X6 | 100',
  'Citroen | C4 | 123',
  'Volga | GAZ-24 | 1000000',
  'Lada | Niva | 1000000',
  'Lada | Jigula | 1000000',
  'Citroen | C4 | 22',
  'Citroen | C5 | 10']
)