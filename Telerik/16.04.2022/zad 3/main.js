const Game = new Phaser.Game(800, 800, Phaser.AUTO, 'game-canvas', { preload, create,update })
let dude,cursor
let spheres
const dudeSpeed=400
function preload() {
   
    
    
}
const createPlayer=function()
{
    
}
function create() {


}
function update(){
 
   
   
}


const movePlayer=function()
{
   


}
const myFunction=function()
{
    Game.camera.flash(0xff0000)
    spheres.add(createSphere())
    
}
const createSphere =function()
{
 //const sfera=Game.add.sprite(_x,_y,_key)
  const sfera=Game.add.sprite(Game.world.randomX,Game.world.randomY,"sfera1")
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
