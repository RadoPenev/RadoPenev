function solve() {

   let buttons = document.getElementsByClassName('add-product')
   let btnAdd = Array.from(buttons)
   let output = document.querySelector('textarea')
   let index=0
   let sum = 0;
   let information = []
   btnAdd.forEach(x => {
      x.addEventListener('click', (e) => {
         if (e) {
            let info={
               name: e.target.parentNode.parentNode.querySelector('.product-title').textContent,
               price:e.target.parentNode.parentNode.querySelector('.product-line-price').textContent}
           
            information.push(info)
            
            let result = `You added ${information[index].name} for ${Number(information[index].price).toFixed(2)} \n`
           
            sum += Number(information[index].price)
            output.textContent += result
            index++
         }
      })

   })
let checkoutElement=document.querySelector('.checkout')
   checkoutElement.addEventListener('click', ()=>{
      output.textContent += `\n`
      let tmp = `You bought:` 
      console.log(information)
      for(let i = 0; i<information.length;i++){
        
            tmp += `${information[i].name},`
            console.log(information)
         
      }

      tmp+= `total: $${sum.toFixed(2)}`

      output.textContent+=tmp})


}