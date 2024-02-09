function ticketSeller(input,sortType){
    class Ticket{
        constructor(destination,price,status){
            this.destination=destination
            this.price=price
            this.status=status
        }
    }

    let result=[]
    input.map(el=>{
        let [destination,price,status]=el.split('|')
        price=Number(price)
        let ticket=new Ticket(destination,price,status)
        result.push(ticket)
    })
    result.sort((a, b) => {
        let fa = a[sortType],
            fb = b[sortType];
 
        if (fa < fb) {
            return -1;
        }
        if (fa > fb) {
            return 1;
        }
        return 0;
    });
    return result
    
}

ticketSeller(['Philadelphia|94.20|available',
'New York City|95.99|available',
'New York City|95.99|sold',
'Boston|126.20|departed'],
'destination'
)