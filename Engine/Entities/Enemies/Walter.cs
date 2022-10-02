using GetTall.Engine.Entities.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTall.Engine.Entities.Enemy.Enemies
{
    public class Walter : Entity
    {
        public override AttributeSet Attributes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override List<string> FlavorText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override int Attack()
        {
            throw new NotImplementedException();
        }

        public override int ReceiveDamage()
        {
            throw new NotImplementedException();
        }

        public override void SetAttributes()
        {
            foreach (AttributeSet.Attribute attr in AttributeSet.Attribute)
            {

            }
        }
    }
}
