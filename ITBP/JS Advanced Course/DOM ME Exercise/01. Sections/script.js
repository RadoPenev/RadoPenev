function create(words) {
  let divContent=document.getElementById('content')

  words.forEach(element => {
   let div=document.createElement('div')
   let paragraph=document.createElement('p')

   paragraph.textContent=element
paragraph.style.display='none'
   div.addEventListener('click',(e)=>{
      if(e){
         if(paragraph.style.display==='none'){
            paragraph.style.display='block'
         }else{
            paragraph.style.display='none'
         }
      }
   })
   div.appendChild(paragraph)

   divContent.appendChild(div)
  });

 
}

window.onload = ()=> {
   create(['Section 1', 'Section 2', 'Section 3', 'Section 4']);
};