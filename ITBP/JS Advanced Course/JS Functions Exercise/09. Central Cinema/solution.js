function solve() {
  let movieSectionElement = document.querySelector('#movies ul')
    let onScreenButton = document.querySelector('#container button')

    let archivedSectionElement = document.querySelector('#archive ul')
    let clearElement = document.querySelector('#archive button')
  onScreenButton.addEventListener('click',(event)=>{
    event.preventDefault();
    let nameElement = document.querySelector('[placeholder="Name"]');
    let hallElement = document.querySelector('[placeholder="Hall"]');
    let ticketPriceElement = document.querySelector('[placeholder="Ticket Price"]');
    let name = nameElement.value;
    let hall = hallElement.value;
    let ticketPrice = ticketPriceElement.value;

    if(name!=""&&hall!=""&&ticketPrice!=""){
        let movieElement = document.createElement('li');
        let spanElement = document.createElement('span');
        let strongElement = document.createElement('strong');

        let divTicketElement = document.createElement('div');
        let strongTicketElement = document.createElement('strong');
        let placeholderElement = document.createElement('input');
        let buttonElement = document.createElement('button')

        spanElement.textContent = name;
        strongElement.textContent = `Hall: ${hall}`;
        movieElement.appendChild(spanElement);
        movieElement.appendChild(strongElement);

        strongTicketElement.textContent = Number(ticketPrice).toFixed(2);
        placeholderElement.placeholder = "Tickets sold"
        buttonElement.textContent = 'Archive'
        divTicketElement.appendChild(strongTicketElement)
        divTicketElement.appendChild(placeholderElement)
        divTicketElement.appendChild(buttonElement)
        movieElement.appendChild(divTicketElement)

        movieSectionElement.appendChild(movieElement);
buttonElement.addEventListener('click',()=>{
            if(placeholderElement.value!=""&& !isNaN(placeholderElement.value)){
                let ticketCount = Number(placeholderElement.value)
                let totalTickets = ticketCount*ticketPrice;

                let totalTicketElement = document.createElement('strong')
                totalTicketElement.textContent = `Total ammount: ${totalTickets}`

                let archivedElement = document.createElement('li')
                let archivedNameSpan = document.createElement('span')
                archivedNameSpan.textContent = name

                let deleteButtonElement = document.createElement('button')
                deleteButtonElement.textContent = 'Delete'


                archivedElement.appendChild(archivedNameSpan)
                archivedElement.appendChild(totalTicketElement)
                archivedElement.appendChild(deleteButtonElement)

                archivedSectionElement.appendChild(archivedElement)
                deleteButtonElement.addEventListener('click',()=>{
                    archivedSectionElement.removeChild(archivedElement)
                })
            }
        })
    }
  })
}