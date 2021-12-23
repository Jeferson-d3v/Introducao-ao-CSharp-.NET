using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Csharp;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa person = new Pessoa();
            person.Nome = "Jeferson";
            person.Idade = 27;
            person.Estado = "SP";

            var person2 = new Pessoa();
            person2.Nome = "Clarice";
            person2.Idade = 1;
            person2.Estado = "SP";
        }

        
    }
}
