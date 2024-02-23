using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Publisher pub = new Publisher();

            Subscriber sub = new Subscriber();

            pub.ShowName += sub.DisplayName;
            pub.ShowNum += sub.DisPlayNum;

            pub.RaiseIntEvent(3);

            pub.RaiseEvent("ENC");

        }
    }
}
