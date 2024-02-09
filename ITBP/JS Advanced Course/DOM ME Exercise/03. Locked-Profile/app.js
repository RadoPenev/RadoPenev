function lockedProfile() {
  let lockEl = document.querySelectorAll('input[value="lock"]')
  let unlockEl = document.querySelectorAll('input[value="unlock"]')


  lockEl.forEach(el =>
    el.addEventListener('click', (e) => {
      if (e) {
        let btn = el.parentNode.querySelector('button')
        btn.disabled = true
      }
    }));
   
  unlockEl.forEach(el =>
    el.addEventListener('click', (e) => {
      if (e) {
        let btn = el.parentNode.querySelector('button')
        btn.addEventListener('click', () => {
          btn.disabled = false
          let info = el.parentNode.querySelector('div div')
          info.style.display = 'block'
          btn.textContent = "Hide it"
          btn.addEventListener('click', () => {
            let info = el.parentNode.querySelector('div div')
            info.style.display='none'
            btn.textContent="Show more"
          })
        
      
        })
        
      }
    })
  )

}