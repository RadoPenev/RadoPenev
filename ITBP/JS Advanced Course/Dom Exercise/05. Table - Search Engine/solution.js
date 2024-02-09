function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      let listElements = Array.from(document.querySelectorAll('tbody td'))
      let searchEl = document.getElementById('searchField').value
     
    for (const element of listElements) {
      if (element.textContent.includes(searchEl)) {
         element.parentNode.style.backgroundColor = "#FFF842"
         element.parentNode.style.color="black"
         element.parentNode.style.fontWeight="bold"
         element.parentNode.style.transform="translate3d(6px, -6px, 0)"
         element.parentNode.style.boxShadow=" #7F7C21 -1px 1px, #7F7C21 -2px 2px, #7F7C21 -3px 3px, #7F7C21 -4px 4px, #7F7C21 -5px 5px, #7F7C21 -6px 6px"
        
        
      } else{
         element.style.backgroundColor = 'none'
         element.style.color='none'
         element.style.fontWeight='none'
         element.style.transform='none'
         element.style.boxShadow=' none'
        
      }
    }
      
      
   }
}