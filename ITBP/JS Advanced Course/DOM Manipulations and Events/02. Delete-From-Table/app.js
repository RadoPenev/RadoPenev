function deleteByEmail() {
 let inputElement=document.querySelector('input[name="email"]')
 let allTargetElements=document.querySelectorAll('tr td:nth-of-type(2)')
 let result=document.getElementById('result')
 let emailElements=Array.from(allTargetElements)
 let targetElement=emailElements.find(x=>x.textContent==inputElement.value)
 if(targetElement){
 targetElement.parentNode.remove()
 result.textContent="Deleted"
 }else{
    result.textContent="Not found"
 }
}