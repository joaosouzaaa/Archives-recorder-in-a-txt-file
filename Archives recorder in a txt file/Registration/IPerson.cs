using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
    interface IPerson
    {
        void SetName(string name);
        void SetTelephone(string telephone);
        void SetID(string id);
        void Record();
        // Interface - The class that inherit the interface has to have record, name, telephone and zip code.
    }
}