using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_event
{
    class CustomEventArgs : EventArgs
    {
        public string Name { get; set; }

        public CustomEventArgs(string name)
        {
            Name = name;
        }
    }

    class Publisher
    {
        string name;

        public event EventHandler<CustomEventArgs> ShowName;
        public event EventHandler<int> ShowNum;

        public void RaiseIntEvent(int num)
        {
            ShowNum?.Invoke(this, num);
        }

        public void RaiseEvent(string name)
        {
            this.name = name;
            ShowName?.Invoke(this, new CustomEventArgs("ENC"));
        }
    }

    class Subscriber
    {
        public void DisplayName(object sender, CustomEventArgs e)
        {
            MessageBox.Show(e.Name);
        }
        public void DisPlayNum(object sender, int num)
        {
            MessageBox.Show(num.ToString()); 
        }
    }
}
