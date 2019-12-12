using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipleLS
{
    public class WothOutLS
    {

        
    }
    public class AppleWithoutLS
    {
        public virtual string GetColor()
        {
            return "Red";
        }
    }
    public class OrangeWithoutLS : AppleWithoutLS
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
