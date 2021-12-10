﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_2.AbstractFactory
{
    public class Dog : IDog
    {
        public string Name { get; set; }
        public Dog(string name)
        {
            Name = name;
        }
    }
}
