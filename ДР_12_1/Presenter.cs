using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДР_12_1
{
    internal class Presenter
    {
        private Model model;
        private Program view;

        public Presenter()
        {
            model = new Model();
            Program.TextAdd += Program_TextAdd;
        }

        private void Program_TextAdd(string str)
        {
            Console.WriteLine(model.Logic(str));
        }
    }
}
