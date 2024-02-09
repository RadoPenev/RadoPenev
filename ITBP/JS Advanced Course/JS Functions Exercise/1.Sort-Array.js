function solve(input,command){
    if(command=="asc"){
        input.sort((a,b)=> a-b)
    }else{
        input.sort((a,b)=> b-a)
    }

    return input
}

console.log(solve([14, 7, 17, 6, 8], 'des'))