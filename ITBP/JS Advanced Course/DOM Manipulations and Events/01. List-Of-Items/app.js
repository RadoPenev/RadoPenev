function addItem() {
    let liElement=document.createElement('li')
    let ulItems=document.getElementById('items')
    let inputElement=document.getElementById('newItemText')

    liElement.textContent=inputElement.value
    ulItems.appendChild(liElement)
}