using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTall.Engine.Entities.Attributes
{
    public enum Attribute
    {
        Confidence,
        Height,
        ShoeSize,
        Aggression,
    }
    public class AttributeSet : Dictionary<Attribute, int>
    {
        public AttributeSet()
        {
            foreach (Attribute attribute in Enum.GetValues(typeof(Attribute)))
            {
                this.Add(attribute, 0);
            }
        }




    }
}
