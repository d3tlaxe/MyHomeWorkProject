﻿using Core.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEntities.Concrete
{
    public class Customer : IEntity
    {
        [Key]
        public int UserId { get; set; }
        public string CompanyName { get; set; }

    }
}
