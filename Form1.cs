using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace labString
{
    public partial class Form1 : Form
    {
        private StringManipulator stringManipulator = new StringManipulator();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string data = txtElement.Text;
            if (!string.IsNullOrEmpty(data))
            {
                stringManipulator.Add(data);
                UpdateListDisplay();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string input = txtIndex.Text.Trim();

            if (input.EndsWith("+") && int.TryParse(input.TrimEnd('+'), out int removeIndex))
            {
                if (removeIndex >= 0 && removeIndex < stringManipulator.Count)
                {
                    stringManipulator.RemoveTailFrom(removeIndex);
                }
            }
            else if (int.TryParse(input, out int singleIndex))
            {
                if (singleIndex >= 0 && singleIndex < stringManipulator.Count)
                {
                    stringManipulator.RemoveAt(singleIndex);
                }
            }

            UpdateListDisplay();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            stringManipulator.Clear();
            UpdateListDisplay();
        }

        private void UpdateListDisplay()
        {
            txtListOutput.Text = stringManipulator.Display();
        }
    }

}
