using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
    class Client : Base
    {
        public Client(string name, string telephone, string id)
        {
            this.Name = name;
            this.Telephone = telephone;
            this.ID = id;
        }
        public Client() { }
        // Constructors that are inheriting from Base class that are defining the name, telephone and id.
    }
}
