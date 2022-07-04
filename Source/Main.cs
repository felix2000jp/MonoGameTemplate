using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Mono.Source
{
    public class Main : Game {
        private GraphicsDeviceManager graphics;
        private SpriteBatch batch;

        public Main() {
            Content.RootDirectory = "Public";
            this.graphics = new GraphicsDeviceManager(this);
        }

        protected override void Initialize() {
            base.Initialize();
        }

        protected override void LoadContent() {
            base.LoadContent();
            this.batch = new SpriteBatch(GraphicsDevice);
        }

        protected override void Update(GameTime gameTime) {
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime) {
            base.Draw(gameTime);
        }
    }
}
