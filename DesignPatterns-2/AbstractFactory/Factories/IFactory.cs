﻿using DesignPatterns_2.AbstractFactory.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_2.AbstractFactory.Factories
{
    public interface IFactory
    {
        IAnimal CreateAnimal(string name);
    }
}
