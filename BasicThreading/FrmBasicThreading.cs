using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicThreading
{
    public partial class FrmBasicThreading : Form
    {

        public FrmBasicThreading()
        {
            InitializeComponent();
        }

        private void FrmBasicThreading_Load(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(lblThreadStart.Text);

            ThreadStart delThread= new ThreadStart(MyThreadClass.Thread1);
            Thread ThreadA = new Thread(delThread);
            Thread ThreadB = new Thread(delThread);

            ThreadA.Name = "Thread A Process";
            ThreadB.Name = "Thread B Process";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();


            lblThreadStart.Text = "-End of thread-";
            Console.WriteLine(lblThreadStart.Text);
        }        
    }
}
