function validate() {
    let emailElement = document.getElementById('email')

    emailElement.addEventListener('change', ()=>{
        const emailPattern = /^[a-z]+@[a-z]+.[a-z]+$/
        const email = emailElement.value.trim()
        if(!emailPattern.test(email)){
            emailElement.classList.add('error')
        }
        else{
            emailElement.classList.remove('error')
        }
    })
}