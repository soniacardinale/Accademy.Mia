using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy.TestDelegate
{
    public class MyClass
    {
        private Button externalButton;

        public MyClass(Button button)
        {
            int x = 0;
            x += 3;

            string s = "nlk";
            s += "lkjkl";

            this.externalButton = button;
            this.externalButton.Click += new System.EventHandler(this.externalButton_Click);
        }

        private void externalButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click handled by MyClass instance");
        }
    }
}
