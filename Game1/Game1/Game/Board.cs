using Microsoft.Xna.Framework;
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
        List<Tile> m_tiles;

        int m_spacing = 64;


        public Board()
        {
            m_tiles = new List<Tile>();
        }

        public bool Initialize()
        {

            int x = 0;
            int y = 0;
            bool flip = false;
            for ( int i = 0; i < 64; i++)
            {
                if (flip)
                {
	                if ( i % 2 == 0)
	                {
	                    m_tiles.Add(new Tile(TILE_TYPE.WHITE, new Vector2(x, y)));
	                }
	                else
	                {
	                    m_tiles.Add(new Tile(TILE_TYPE.BLACK, new Vector2(x, y)));
	                }
                }
                else
                {
                    if (i % 2 != 0)
                    {
                        m_tiles.Add(new Tile(TILE_TYPE.WHITE, new Vector2(x, y)));
                    }
                    else
                    {
                        m_tiles.Add(new Tile(TILE_TYPE.BLACK, new Vector2(x, y)));
                    }
                }

                x += m_spacing;
                if ( x > m_spacing * 7)
                {
                    flip = !flip;
                    x = 0;
                    y += m_spacing;
                }
            }
            return true;
        }

        public void Load(ContentManager a_content)
        {
            Initialize();

            for ( int i = 0; i < m_tiles.Count; i++)
            {
                m_tiles[i].Load(a_content);
            }
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
            for (int i = 0; i < m_tiles.Count(); i++)
            {
                m_tiles[i].Draw(sb, a_content);
            }
        }
    }
}
