using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class Board
    {
      // IList<Tile> m_tiles;

        Tile m_tiles;

        public Board()
        {
            m_tiles = new Tile();

        }

        public bool initilze()
        {
            m_tiles.Init(TILE_TYPE.WHITE);
            return true;
        }

        public void Load(ContentManager a_content)
        {
            m_tiles.Load(a_content);
        }

        public bool Destory()
        {
            return true;
        }

        public void UpDate()
        {

        }
        public void Draw(SpriteBatch sb, ContentManager a_content)
        {
            m_tiles.Draw(sb, a_content);
        }
    }
}
