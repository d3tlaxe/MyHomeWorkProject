﻿using Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEntities.Concrete
{
    public class Color : IEntity
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
    }
}
