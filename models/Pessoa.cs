using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace desafio_net_hotelaria.models
{
    public class Pessoa(string name, string lastName)
    {
        public string Name { get; set; } = name;
        public string LastName { get; set; } = lastName;
        public string FullName => $"{Name} {LastName}".ToUpper();
    }
}