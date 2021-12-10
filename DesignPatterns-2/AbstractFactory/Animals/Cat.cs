using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_2.AbstractFactory
{
    public class Cat : ICat
    {
        public string Name { get; set; }
        public Cat(string name)
        {
            Name = name;
        }
    }
}
