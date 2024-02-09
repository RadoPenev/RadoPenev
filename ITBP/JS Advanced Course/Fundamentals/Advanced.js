/*function radius(input)
{
     let area=input[0]**2*Math.PI
console.log(area.toFixed(2))
}
radius('5')*/

/*function solve(str1, str2, str3) {
  let len1 = str1.length;
  let len2 = str2.length;
  let len3 = str3.length;
  let sumLength = len1 + len2 + len3;
  let averageLength = Math.floor(sumLength / 3);
  console.log(sumLength);
  console.log(averageLength);
}

solve('chocolate', 'ice cream', 'cake')*/

/*const readline = require('readline');

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});
 
rl.question('Please enter some data: ', (data) => {
  console.log(`You entered: ${data}`);
  rl.close();
});*/

/*function findGCD(a, b) {
    while (b !== 0) {
        let temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}
let number1 = 2154
let number2 = 458
const gcd = findGCD(number1, number2);
console.log(`The GCD of ${number1} and ${number2} is ${gcd}`);*/

/*function sameNumbers(number) {
    let check = false
    const digits = String(number).split("").map(Number)
    let string = "pesho" ? true : false
    for (let i = 0; i < digits.length - 1; i++) {
        if (digits[i] == digits[i + 1]) {
            check = true
        }
        else {
            check = false
        }
    }
    if (check) {
        console.log(check)
        let sum = 0
        for (let i = 0; i < digits.length; i++) {
            sum = sum + digits[i]
        }
        console.log(sum)
    }
    else {
        console.log(check)
        let sum1 = 0
        for (let i = 0; i < digits.length; i++) {
            sum1 = sum1 + digits[i]
        }
        console.log(sum1)
    }
}

sameNumbers("11111131111")*/

/*function previousDay(year, month, day) {

    let time = new Date()
    time.setUTCFullYear(year)
    time.setUTCMonth(month)
    time.setUTCDate(day - 1)
    console.log(time.toLocaleDateString())
}
previousDay(2016, 9, 30)
previousDay(2016, 10, 1)*/

/*function info(input)
{
    let steps=Number(input[0])
    let footprint=Number(input[1])
    let speed=Number(input[2])

  // Calculate the total distance in kilometers
  const distanceInKm = (steps * footprint) / 1000;

  // Calculate the time in hours
  const timeInHours = distanceInKm / speed;

  // Calculate the number of rest breaks
  const restBreaks = Math.floor(distanceInKm / 0.5); // A rest break every 0.5 kilometers

  // Calculate the total rest time in minutes
  const restTimeInMinutes = restBreaks;

  // Convert total time to hours, minutes, and seconds
  const totalMinutes = timeInHours * 60 + restTimeInMinutes;
  const hours = Math.floor(totalMinutes / 60);
  const minutes = Math.floor(totalMinutes % 60);
  const seconds = Math.floor((totalMinutes % 1) * 60);

  console.log(`${hours}:${minutes}:${seconds}`);
}

info([2564, 0.70, 5.5])*/