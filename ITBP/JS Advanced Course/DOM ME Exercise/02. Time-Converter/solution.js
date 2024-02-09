function attachEventsListeners() {
let convertBtnDays=document.getElementById('daysBtn')
let convertBtnHours=document.getElementById('hoursBtn')
let convertBtnMinutes=document.getElementById('minutesBtn')
let convertBtnSeconds=document.getElementById('secondsBtn')
let inputDays=document.getElementById('days')
let inputHours=document.getElementById('hours')
let inputMinutes=document.getElementById('minutes')
let inputSeconds=document.getElementById('seconds')
convertBtnDays.addEventListener('click',(e)=>{
    if(e){
      inputHours.value=inputDays.value*24
      inputMinutes.value=inputHours.value*60
      inputSeconds.value=inputMinutes.value*60
    }
})
convertBtnHours.addEventListener('click',(e)=>{
    if(e){
      inputDays.value=inputHours.value/24
      inputMinutes.value=inputHours.value*60
      inputSeconds.value=inputMinutes.value*60
    }
})
convertBtnMinutes.addEventListener('click',(e)=>{
    if(e){
  inputHours.value=inputMinutes.value/60
  inputDays.value=inputHours.value/24
  inputSeconds.value=inputMinutes.value*60
    }
})

convertBtnSeconds.addEventListener('click',(e)=>{
    inputMinutes.value=inputSeconds.value/60
    inputHours.value=inputMinutes.value/60
    inputDays.value=inputHours.value/24
})
}