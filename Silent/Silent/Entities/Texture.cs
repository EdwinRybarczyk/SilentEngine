﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silent.Entities
{
    public class Silent_Texture
    {

        //ID of the texture needed for rendering
        private int m_textureID;


        //constructor takes in the texture ID
        public Silent_Texture(int textureID)
        {
            m_textureID = textureID;
        }

        //Return texture for rendering
        public int GetTextureID()
        {
            return m_textureID;
        }
    }
}
