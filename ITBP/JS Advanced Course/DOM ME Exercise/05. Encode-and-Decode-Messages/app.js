function encodeAndDecodeMessages() {
    let textToCode = document.querySelector('textarea[placeholder="Write your message here..."]')
    let textToEncode = document.querySelector('textarea[placeholder="No messages..."]')
    let codeBtn = document.querySelector('button')
    let encodeBtn=document.querySelectorAll('button')[1]
    codeBtn.addEventListener('click', (e) => {
        if (e) {
            let tmp = textToCode.value
            let encoded = ""
            for (let i = 0; i < tmp.length; i++) {
                let deCoded = tmp.charCodeAt(i)
                encoded += String.fromCharCode(deCoded + 1)
            }
          textToCode.value=""
          textToEncode.textContent=encoded
        }
    })
    encodeBtn.addEventListener('click',(e)=>{
        if(e){
            let tmp=textToEncode.value
            let decoded=""
            for(let i=0;i<tmp.length;i++){
                let deCoded=tmp.charCodeAt(i)
                decoded+=String.fromCharCode(deCoded-1)
            }
            
        textToEncode.value=decoded
        }
        
    })
    

}