﻿using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Card:IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string CardNameSurname { get; set; }
        public string CardNumber { get; set; }
        public string ValidDate { get; set; }
        public string CVV { get; set; }
    }
}
