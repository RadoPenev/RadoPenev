function addItem() {
    let inputElement=document.getElementById('newItemText')
    let ulElements=document.getElementById('items')
    let liElement=document.createElement('li')
    liElement.textContent=inputElement.value
    

    let deleteElement=document.createElement('a')
    deleteElement.href='#'
    deleteElement.textContent="[Delete]"
    deleteElement.addEventListener('click',(e)=>{
        e.currentTarget.parentNode.remove()
    })
    liElement.appendChild(deleteElement)
    ulElements.appendChild(liElement)
}