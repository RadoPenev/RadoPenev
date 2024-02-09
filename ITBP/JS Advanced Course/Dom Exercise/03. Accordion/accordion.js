function toggle() {
    let btn=document.querySelector('.button')
    let text=document.querySelector('#extra')
    
    if(btn.textContent=='More'){
        btn.textContent='Less'
    }else{
        btn.textContent='More'
    }
     
    if(text.style.display==='block'){
        text.style.display='none'
    }else{
        text.style.display='block'
    }
}