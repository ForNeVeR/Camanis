namespace Gyges

open Microsoft.Xna.Framework.Content
open Microsoft.Xna.Framework.Graphics

type Content =
    { Ship: Texture2D
      Bullet: Texture2D
      Enemy: Texture2D
      ScoreFont: SpriteFont }

module Content =    
    let load (contentManager: ContentManager): Content =
        { Ship        = contentManager.Load("ship")
          Bullet      = contentManager.Load("bullet")
          Enemy       = contentManager.Load("enemy")
          ScoreFont   = contentManager.Load("score") }

