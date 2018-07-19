using Microsoft.Xna.Framework.Graphics;

namespace NupskouProject
{
    public class Assets
    {
        public Texture2D SidePanel;

        public void Load (ContentManager content) {
            SidePanel = Content.Load<Texture2D>("nupskou-side-panel");
        }
    }
}
