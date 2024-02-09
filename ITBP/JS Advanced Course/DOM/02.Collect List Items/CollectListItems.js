function extractText() {
    let ulElements=document.getElementById('items')

    let textTElements=document.getElementById('result')
    textTElements.textContent=ulElements.textContent
}