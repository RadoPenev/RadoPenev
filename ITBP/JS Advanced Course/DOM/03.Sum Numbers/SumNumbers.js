function calc() {
    let firstNumElement=document.getElementById('num1')
    let secondNumElement=document.getElementById('num2')
    let resultElement=document.getElementById('sum')
    let firstNum=Number(firstNumElement.value);
    let secondNum=Number(secondNumElement.value);
    let result=firstNum+secondNum;
   resultElement.value=result
}
