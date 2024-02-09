const Game = new Phaser.Game(800, 800, Phaser.AUTO, 'game-canvas', { preload, create,update })

let player
let player1
function preload() {
Game.load.spritesheet("monster","monster.904x176.4x1.png",904/4,176/1)

}

function create() {
   player=Game.add.sprite(200,0,"monster")
    player.animations.add("anim1",[],30,true).play()
    player.anchor.set(1,0)

    player1=Game.add.sprite(0,800,"monster")
    player1.animations.add("anim2",[],30,true).play()
    player1.anchor.set(0,1)

    player2=Game.add.sprite(800,0,"monster")
    player2.animations.add("anim3",[],30,true).play()
    player2.anchor.set(1,0)

    player3=Game.add.sprite(0,0,"monster")
    player3.animations.add("anim4",[],30,true).play()
    player3.anchor.set(0,1)
    let z=player3.width
    player3.x=Game.width-z
    player3.y=Game.height
}   

function update(){
   if(player.x<Game.width)
   {
   player.x++
   }
   else
   {
      player.animations.stop()
   }

   if(player3.x>0)
   {
   player3.x--
   }
   else
   {
      player3.animations.stop()
   }
  player1.y--
  player2.y++
 
}