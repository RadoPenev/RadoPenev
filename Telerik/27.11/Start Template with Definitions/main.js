const Game = new Phaser.Game(1200, 400, Phaser.AUTO, 'game-canvas', { preload, create,update })
let sfera1,sfera2,sfera3,sfera4,sfera5
function preload() {
   Game.load.image("sfera1","sphere_1.png")
   Game.load.image("sfera2","sphere_2.png")
   Game.load.image("sfera3","sphere_3.png")
   Game.load.image("sfera4","sphere_4.png")
   Game.load.image("sfera5","sphere_5.png")
   Game.load.audio("ponk","ponk.wav")
}

function create() {
   Game.stage.backgroundColor="fff"
sfera1=createSphere(0,0,"sfera1")
sfera2=createSphere(100,10,"sfera2")
sfera3=createSphere(200,20,"sfera3")
sfera4=createSphere(300,30,"sfera4")
sfera5=createSphere(400,40,"sfera5")

}
function update(){
Game.physics.arcade.collide(sfera1,sfera2,myCollideFunction)
Game.physics.arcade.collide(sfera1,sfera3,myCollideFunction)
Game.physics.arcade.collide(sfera1,sfera4,myCollideFunction)
Game.physics.arcade.collide(sfera1,sfera5,myCollideFunction)
Game.physics.arcade.collide(sfera2,sfera1,myCollideFunction)
Game.physics.arcade.collide(sfera2,sfera3,myCollideFunction)
Game.physics.arcade.collide(sfera2,sfera4,myCollideFunction)
Game.physics.arcade.collide(sfera2,sfera5,myCollideFunction)
Game.physics.arcade.collide(sfera3,sfera1,myCollideFunction)
Game.physics.arcade.collide(sfera3,sfera2,myCollideFunction)
Game.physics.arcade.collide(sfera3,sfera4,myCollideFunction)
Game.physics.arcade.collide(sfera3,sfera5,myCollideFunction)
Game.physics.arcade.collide(sfera4,sfera1,myCollideFunction)
Game.physics.arcade.collide(sfera4,sfera2,myCollideFunction)
Game.physics.arcade.collide(sfera4,sfera3,myCollideFunction)
Game.physics.arcade.collide(sfera4,sfera5,myCollideFunction)
Game.physics.arcade.collide(sfera5,sfera1,myCollideFunction)
Game.physics.arcade.collide(sfera5,sfera2,myCollideFunction)
Game.physics.arcade.collide(sfera5,sfera3,myCollideFunction)
Game.physics.arcade.collide(sfera5,sfera4,myCollideFunction)
}


const createSphere=function(_x,_y,_key){
sfera=Game.add.sprite(_x,_y,_key)
sfera.scale.setTo(0.2)
Game.physics.arcade.enable(sfera)
sfera.body.velocity.setTo(Game.rnd.integerInRange(-100,400),Game.rnd.integerInRange(100,400))
sfera.body.collideWorldBounds=true
sfera.body.bounce.setTo(1)
return sfera
}

  const myCollideFunction=function(){
      Game.add.audio("ponk").play()
  }  

