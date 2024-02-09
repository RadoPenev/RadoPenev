function solution(x){
    let startNUm=x
    return function add(n){
        startNUm+=n
        return startNUm
    }
}

let add5 = solution(5);
console.log(add5(2));
console.log(add5(3));

