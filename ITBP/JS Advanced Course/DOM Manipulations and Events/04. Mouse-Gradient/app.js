function attachGradientEvents() {
    let divElemenet=document.getElementById("gradient-box")
    let result=document.getElementById('result')
    divElemenet.addEventListener('mousemove',(e)=>{
      result.textContent=`${Math.floor(e.offsetX/e.target.offsetWidth*100)}%`
    })
}