using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Character
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private ClassType characterClass;
        public ClassType CharacterClass { get { return characterClass; } set { characterClass = value; } }

        private int level;
        public int Level { get { return level; } set { level = value; } }

        private string str;
        public string Str { get { return str; } set { str = value; } }

        private string cos;
        public string Cos { get { return cos; } set { cos = value; } }

        private string des;
        public string Des { get { return des; } set { des = value; } }

        private string inte;
        public string Inte { get { return inte; } set { inte = value; } }

        private string sag;
        public string Sag { get { return sag; } set { sag = value; } }

        private string car;
        public string Car { get { return car; } set { car = value; } }

        public enum ClassType { Barbaro, Bardo, Chierico, Ladro, Ranger, Druido, Condottiero };

        public Character()
        {

        }
    }
}
