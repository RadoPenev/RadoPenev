const Game = new Phaser.Game(720, 400, Phaser.AUTO, 'game-canvas', { preload, create, update,createBackground })

let player

function preload() {
   Game.load.image("platform","platform.png")
   Game.load.image("desert","desert.png")
Game.load.spritesheet("dude","dude.png",288/9,48/1)
}

function create() {
  createBackground()
  createPlayer()
}

function update(){
}

    const createBackground=function(){
    const background=Game.add.sprite(0,0,"background")
    background.width=Game.width
    background.height=Game.height
    }

    const createPlayer=function(){
        player=Game.add.sprite(10,60,"dude")
        player.anchor.setTo=0.5
        player.animations.add("left",[0,1,2,3],10,true)
        player.animations.add("right",[4,5,6,7,8],10,true)
        player.frame=4
        Game.physics.arcade.enable(player)
        player.body.gravity.y=100
    }