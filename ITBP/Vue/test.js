const app=Vue.createApp({
    data(){
        return {
            rating:0,
            show:false,
            name:"Gosho",
            car:"Golf",
            age: "Bezgreshen i vechen",
            description:"",
            IsFav:true
        }
    },
   methods:{ 
    information(){
        this.show=!this.show
      this.description="Goooosshhoooooo is a zobadjiq who drives golfu batko.He really likes to drive Golfu and to lupa komar."
    },
    toggleFav(){
        this.IsFav=!this.IsFav

    }
}
});


app.mount('#app')