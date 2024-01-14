using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class Project
    {
        public BindingList<ToDo> ToDos { get; set; }

        public string Name { get; set; }

        public Project(string name)
        {
            ToDos = new BindingList<ToDo>();
            Name = name;
        }
        public Project() : this("") { }
        public override string ToString() => $"{Name}";
    }
}
