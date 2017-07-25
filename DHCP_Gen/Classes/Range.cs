using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHCP_Gen.Classes
{
    public class Range
    {
        private string _name;
        private string _descr;
        private int _min;
        private int _max;
        public Range():this(string.Empty,string.Empty,0,0) { }
        public Range(string name, string descr, int min, int max) {
            this._name = name;
            this._descr = descr;
            this._min = min;
            this._max = max;
        }

        public string Name { get => _name; set => _name = value; }
        public string Description { get => _descr; set => _descr = value; }
        public int Min { get => _min; set => _min = value; }
        public int Max { get => _max; set => _max = value; }
    }
}
