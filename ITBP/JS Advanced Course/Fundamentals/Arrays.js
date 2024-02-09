/*function lastKNumbersSequence(n, k) {
    let resultarray = [1];
    let sum = 0;
    for (let i = 1; i < n; i++) {
      let array = resultarray.slice(-k);
      sum = array.reduce((p, c) => p + c, 0);
      resultarray.push(sum);
    }
    return console.log(resultarray);
  }
  lastKNumbersSequence(6, 3);
  lastKNumbersSequence(8, 2);

function processArray(inputArray) {
    const resultArray = inputArray.map((element) => (element < 0 ? element : undefined));
    resultArray.push(...inputArray.filter((element) => element >= 0));

    for (const element of resultArray) {
      if (element !== undefined) {
        console.log(element);
      }
    }
  }
    processArray([1, -2, 3, -4, 5, -6]);

function solve(arr) {
   arr.sort((a,b)=> a-b)
   let half=Math.ceil(arr.length/2)


   return console.log(arr.slice(half))
}

solve([3,5,1,7,2])


function solve(arr)
{
    let oddArray=arr.map((element,index) => index%2==1 ? element*2 : undefined)
                    .filter((element) => element != undefined).reverse()

    return console.log(oddArray.join(' '))
}

solve([10, 15, 20, 25])


function findBiggestElement(matrix) {
    let biggestElement = matrix[0][0]; // Initialize with the first element of the matrix

    for (let row = 0; row < matrix.length; row++) {
      for (let col = 0; col < matrix[row].length; col++) {
        if (matrix[row][col] > biggestElement) {
          biggestElement = matrix[row][col];
        }
      }
    }

    return console.log(biggestElement);
  }

  // Example usage:


   findBiggestElement([
    [3, 1, 4],
    [2, 8, 5],
    [7, 6, 9]
  ]);

function sumDiagonals(matrix) {
    let mainDiagonalSum = 0;
    let secondaryDiagonalSum = 0;
    let counter=0
    for (let i = 0; i < matrix.length; i++) {
      mainDiagonalSum += matrix[i][i];
      secondaryDiagonalSum += matrix[i][matrix.length - 1 - i];
    }

    console.log(mainDiagonalSum, secondaryDiagonalSum);
  }

  // Example usage:
  const matrix = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9]
  ];

  sumDiagonals(matrix);


function findBiggestElement(matrix) {
  let counter=0
  for (let row = 0; row < matrix.length; row++) {
    for (let col = 0; col < matrix[row].length; col++) {
      // Check to the right
      if (col < matrix[row].length - 1 && matrix[row][col] === matrix[row][col + 1]) {
        counter++;
      }
      console.log(matrix[row].length)
      // Check below
      if (row < matrix.length - 1 && matrix[row][col] === matrix[row + 1][col]) {
        counter++;
      }
    }
  }

    return console.log(counter);
  }
findBiggestElement([['2', '3', '4', '7', '0'],
                    ['4', '0', '5', '3', '4'],
                    ['2', '3', '5', '4', '2'],
                    ['9', '8', '7', '5', '4']]);*/

//                        Exercise Array
/*function solve(arr,separator)
{
    console.log(arr.join(`${separator}`))
}

solve(['How about no?', 
'I',
'will', 
'not', 
'do', 
'it!'], '_')*/


/*function solve(arr,index)
{
    let result=[]
    for(let i=0;i<arr.length;i+=index)
    {
      result.push(arr[i])
    }
    return console.log(result)
}


solve(['1', 
'2',
'3', 
'4', 
'5'], 6)*/


/*function solve(command) {
    let result = []
    let number = 1

    for (i = 0; i < command.length; i++) {
        if (command[i] == "add") {
            result.push(number)
        }
        else if (command[i] == "remove") {
            result.pop()
        }
        number++
    }

    if(result.length==0)
    {
        console.log("Empty")
    }

    return console.log(result)
}

solve(['remove', 
'remove', 
'remove'])*/


function solve(input,times)
{
    for(let i=0;i<times;i++)
    {
       let num=input.pop()
       input.unshift(num)
    }

    return console.log(input.join(' '));
}

solve(['Banana', 
'Orange', 
'Coconut', 
'Apple'], 
15

)

