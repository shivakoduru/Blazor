using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern
{
    class Octopus : Animal
    {
        public string Speak()
        {
            return "SQUAWCK";
        }

        public string GivenName(string Name)
        {
            return Name;

        }
    }
}
