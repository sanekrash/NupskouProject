using Microsoft.Xna.Framework.Graphics;

namespace NupskouProject
{
    public class Assets
    {
        public Texture2D SidePanel;

        public void Load (ContentManager content) {
            SidePanel = content.Load<Texture2D>("nupskou-side-panel");
        }
    }
}
