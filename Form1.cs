using System;
using System.Windows.Forms;

namespace AsynchPattern
{
    public partial class Form1 : Form
    {
        // ComputeDel cd = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonSynchCall_Click(object sender, EventArgs e)
        {
            MyCompute mc = new MyCompute();
            ComputeDel cd = new ComputeDel(mc.Compute);

            // call via delegate
            double res = cd(5, 7);
            MessageBox.Show(res.ToString());
        }

        private void ButtonAsynchCall_Click(object sender, EventArgs e)
        {
            MyCompute mc = new MyCompute();
            ComputeDel cd = new ComputeDel(mc.Compute);
            AsyncCallback acb = new AsyncCallback(this.ComputeCallBack);
            cd.BeginInvoke(5, 7, acb, cd);
            // i.e., launches a thread iternally
        }

        private void ComputeCallBack(IAsyncResult ar)
        {
            // to collect results
            // call BeginInvoke to trigger the asynch call
            // call EndInvoke to collect the results
            // the EndInvoke has to be triggered on the same delgate tha triggered BeginInvoke
            ComputeDel cd = (ComputeDel)ar.AsyncState;
            double result = cd.EndInvoke(ar);
            MessageBox.Show("Result = " + result.ToString());
        }
    }
}