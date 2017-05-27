using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;

namespace Game1
{
    enum TILE_TYPE
    {
        BLACK,
        WHITE
    }

    class Tile
    {
        Gem m_gem;
        Texture2D m_backGroundTexture;
        Rectangle m_source;
        TILE_TYPE m_type;

        public void Init(TILE_TYPE a_type)
        {
            m_type = a_type;


            switch(m_type)
            {
                case TILE_TYPE.BLACK:
                   m_source = new Rectangle(32, 0, 64, 32);
                    break;
                case TILE_TYPE.WHITE:
                    m_source = new Rectangle(0, 0, 32, 32);
                    break;
            }
        }

        public void Load(ContentManager a_content)
        {
            m_backGroundTexture = a_content.Load<Texture2D>("TileBackGround");
        }
        public void UnLoad()
        {
    
        }

        public void Draw(SpriteBatch sb, ContentManager a_content)
        {
            sb.Draw(m_backGroundTexture, new Rectangle(0, 0, 64, 64), m_source, Color.White);
        }
    }
}
