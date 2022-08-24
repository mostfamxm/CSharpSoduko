using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku.Ariel.CSharp.DP.Buttons
{
    class ButtonFactory
    {
        private string v;

       

        public ButtomB MakeButton(String i_button) {
            if (i_button == "C") { return new ClearButton(); }
            if (i_button == "Ch") { return new CheckCButtonLogic(); }
            else { return null; }
        }
    }
}
