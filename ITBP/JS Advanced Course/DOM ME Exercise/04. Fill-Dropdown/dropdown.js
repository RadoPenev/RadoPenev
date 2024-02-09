function addItem() {
    let dropDown=document.querySelector('#menu')
    let inputText=document.querySelector('#newItemText')
    let inputValue=document.querySelector('#newItemValue')
    let addBtn=document.querySelector('input[value="Add"]')

    addBtn.addEventListener('click',(e)=>{
        if(e){
            let newOption=document.createElement('option')
           newOption.text=inputText.value
            dropDown.appendChild(newOption) 
        }
        inputText.value=""
        inputValue.value=""
    })

}