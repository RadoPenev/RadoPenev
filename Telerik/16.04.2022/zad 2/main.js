const Game = new Phaser.Game(800, 800, Phaser.AUTO, 'game-canvas', { preload, create,update })
let sfera1,sfera2,sfera3,sfera4,sfera5,sfera

function preload() {
    Game.load.image("sfera1","sphere_1.png")
    Game.load.image("sfera2","sphere_2.png")
  
    
    Game.load.audio("ponk","ponk.wav")
}

function create() {
    Game.stage.backgroundColor="fff"
 

}
function update(){
 

}
const Camera=function()
{
    Game.camera.flash(0xff0000)
}
const createSphere =function(_key)
{
 //const sfera=Game.add.sprite(_x,_y,_key)
  const sfera=Game.add.sprite(Game.world.randomX,Game.world.randomY,_key)
  sfera.scale.setTo(0.2)
  Game.physics.arcade.enable(sfera)
  sfera.body.velocity.setTo(Game.rnd.integerInRange(-100,400),Game.rnd.integerInRange(100,400))
  sfera.body.collideWorldBounds=true
  sfera.body.bounce.setTo(1)
 return sfera

}
const myCollideFunction=function()
{
   Game.add.audio("ponk").play()
}
const myCollideFunction2=function()
{
    console.log("sfera 1 i 3")
}