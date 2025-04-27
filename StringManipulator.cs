using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labString
{
    public class StringManager
    {
        public string Text { get; private set; } = "";

        public void AddText(string input)
        {
            Text = Text + input ;
        }

        public void RemoveCharacter(char charToRemove)
        {
            Text = Text.Replace(charToRemove.ToString(), "");
        }

        public void DeleteFromCharacter(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                Text = "";
            }
            else
            {
                int index = Text.IndexOf(input);
                if (index != -1)
                {
                    Text = Text.Substring(0, index);
                }
            }
        }
    }
}
