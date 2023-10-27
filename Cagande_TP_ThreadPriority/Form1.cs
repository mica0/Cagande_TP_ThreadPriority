using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cagande_TP_ThreadPriority
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            label1.Text = "-Thread Start-";
            Console.WriteLine("-Thread Start-");

            MyThreadClass ThreadClass = new MyThreadClass();

            ThreadStart thread1 = new ThreadStart(MyThreadClass.Thread1);
            ThreadStart thread2 = new ThreadStart(MyThreadClass.Thread2);

            Thread threadA = new Thread(thread1);
            Thread threadB = new Thread(thread2);
            Thread threadC = new Thread(thread1);
            Thread threadD = new Thread(thread2);

            threadA.Priority = ThreadPriority.Highest;
            threadB.Priority = ThreadPriority.Normal;
            threadC.Priority = ThreadPriority.AboveNormal;
            threadD.Priority = ThreadPriority.BelowNormal;

            threadA.Name = "Thread A Process";
            threadB.Name = "Thread B Process";
            threadC.Name = "Thread C Process";
            threadD.Name = "Thread D Process";

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            Console.WriteLine("-End of Thread-");
            label1.Text = "-End of Thread-";
        }
    }
}
