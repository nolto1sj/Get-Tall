using GetTall.Engine.Entities.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTall.Engine.Entities
{
    //an entity carries the attributes and ability to participate in the 1v1 combat system
    public abstract class Entity
    {
        public abstract AttributeSet Attributes { get; set; }
        public abstract List<string> FlavorText { get; set; }
        public abstract void SetAttributes();
        public abstract int Kick();
        public abstract int ReceiveDamage();
        //entity needs to be able to initialize attributes, attack, receive damage based on attributes and dice rolls
        //as well as have their properties modified based on these things
    }
}
