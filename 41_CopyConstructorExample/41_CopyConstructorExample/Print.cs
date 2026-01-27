using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_CopyConstructorExample
{
    internal class Print
    {
        public int Id;
        public string Name;

        public Print(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Print (Print p)
        {
            Id = p.Id;
            Name = p.Name;
        }
    }
}
