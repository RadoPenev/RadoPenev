function search() {
   let searchEl = document.getElementById('searchText').value
   let listElements = Array.from(document.querySelectorAll('#towns li'))

   let match = document.getElementById('result')
   let count = 0

   for (let town of listElements) {
      if (town.textContent.includes(searchEl)) {
         town.style.fontWeight = 'bold'
         town.style.textDecoration = 'underline'
         count++
      } else {
         town.style.fontWeight = 'normal'
         town.style.textDecoration = 'none'
      }
   }

match.textContent=`${count} matches found`

}

