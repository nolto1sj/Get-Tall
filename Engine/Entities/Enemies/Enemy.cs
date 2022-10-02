using GetTall.Engine.Entities.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetTall.Engine.Entities.Enemies
{
    public class Enemy : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public override AttributeSet Attributes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override List<string> FlavorText { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Enemy(string name, string description, AttributeSet attributes, List<string> flavorText)
        {
            Name = name;
            Description = description;
            Attributes = attributes;
            FlavorText = flavorText;
        }

        public override int ReceiveDamage()
        {
            throw new NotImplementedException();
        }

        public override void SetAttributes()
        {
            throw new NotImplementedException();
        }

        public override int Kick()
        {
            Console.WriteLine($"{this.Name} attempts to KICK!");
            return 1;
        }
    }
}
