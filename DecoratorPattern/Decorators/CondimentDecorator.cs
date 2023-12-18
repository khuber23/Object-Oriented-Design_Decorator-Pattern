using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorators
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override decimal Cost { get ; set ; }
        public abstract override string Description { get ; set ; }
    }
}
