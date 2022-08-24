using System.Windows.Forms;

namespace Sudoku.Ariel.CSharp.DP.Forms
{
    public partial class SudokuGame : Form
    {
        private SudokuGame()
        {
            InitializeComponent();
            this.startGame();
        }

        private static readonly object lock1 = new object ();   
        private static SudokuGame instance = null;
        public static SudokuGame Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lock1)
                        {
                            if (instance == null)
                            {
                                instance = new SudokuGame();
                            }
                        }
                }
                return instance;
            }
            }
    }
}
