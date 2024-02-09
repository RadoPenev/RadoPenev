function solve(arr,start,end){
    if(!Array.isArray(arr)){
        return NaN;
    }

    let startIndex=Math.max(start,0)
    let endIndex=Math.min(end,arr.length-1)

    let subNumbers=arr.slice(startIndex,endIndex+1)
    let sumNumbers=subNumbers.reduce((a,x)=> a+Number(x),0)

    return sumNumbers;

}
console.log(solve('text', 0, 2))
