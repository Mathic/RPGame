using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPCharacter
{
    class Monster : ICharacter
    {
        private Guid _id;
        private string _name;
        private string _dialog;

        public Monster(Guid id, string name, string dialog)
        {
            _id = id;
            _name = name;
            _dialog = dialog;
        }

        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Dialog
        {
            get { return _dialog; }
            set { _dialog = value; }
        }
    }
}
