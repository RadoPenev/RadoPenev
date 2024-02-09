function subtract() {
    let firstNumber=document.getElementById('firstNumber').value
    let secondNumber=document.getElementById('secondNumber').value

    let result=firstNumber-secondNumber
    let resultEl=document.getElementById('result')
    resultEl.textContent=result
  
}