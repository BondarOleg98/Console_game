using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    abstract class PackageDecorator : Package
    {
        protected Package package;

        public PackageDecorator(string name, Package package) : base(name)
        {
            this.package = package;
        }
    }
}
