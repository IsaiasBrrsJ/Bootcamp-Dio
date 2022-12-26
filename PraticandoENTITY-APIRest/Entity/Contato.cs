using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PraticandoENTITY_APIRest.Entity
{
    public class Contato
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public bool ReceiveMessage { get; set; }
    }
}