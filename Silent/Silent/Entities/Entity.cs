﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silent.Entities
{
    public class Entity
    {

        private Model m_model;

        public Entity(Model model)
        {
            m_model = model;
        }

        public Model getModel()
        {
            return m_model;
        }


    }
}