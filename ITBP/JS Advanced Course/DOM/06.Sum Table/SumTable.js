function sumTable() {
let tableElements=document.querySelectorAll('tr td:nth-of-type(2)')
let sum=Array.from(tableElements).reduce((a,x) => {
    let currentValue=Number(x.textContent) || 0
    return a+currentValue
},0)

let resultElement=document.getElementById('sum')
resultElement.textContent=sum
}