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
        Rectangle m_destnation;
        Vector2 m_postion;
        TILE_TYPE m_type;

        public Tile(TILE_TYPE a_type, Vector2 a_postion)
        {
            m_type = a_type;
            m_postion = a_postion;
        

            m_destnation = new Rectangle((int)m_postion.X, (int)m_postion.Y, 64, 64);

            switch (m_type)
            {
                case TILE_TYPE.BLACK:
                    m_source = new Rectangle(32, 0, 64, 32);
                    break;
                case TILE_TYPE.WHITE:
                    m_source = new Rectangle(0, 0, 32, 32);
                    break;
            }
        }

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
            sb.Draw(m_backGroundTexture, m_destnation, m_source, Color.White);
        }
    }
}
