using Microsoft.Xna.Framework;

namespace Game1
{
    static class Helper
    {
        public static void SetRes(int width, int height, ref GraphicsDeviceManager graphics)
        {
            graphics.PreferredBackBufferWidth = width;  // set this value to the desired width of your window
            graphics.PreferredBackBufferHeight = height;   // set this value to the desired height of your window
            graphics.ApplyChanges();
        }
    }
}
