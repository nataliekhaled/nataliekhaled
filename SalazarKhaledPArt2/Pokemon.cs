using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class Pokemon
    {
        public int height { get; set; }

        public string name { get; set; }

        public int weight { get; set; }

        public Sprite sprites { get; set; }


        public override string ToString()
        {
            return $"{name} is {height} inches tall and {weight} pounds heavy.";
        }
    }
}
