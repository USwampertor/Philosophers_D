using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Dining_Philosophers
{
    public partial class Form1 : Form
    {
        int eatingTime = 0;
        int thinkTime = 0;
        int pauseTime = 0;
        Thread majorThread;
        CancellationTokenSource canceltoken = new CancellationTokenSource();
        CancellationToken token;
        public Form1()
        {
            InitializeComponent();
            InitializeDynamicComponents();
        }
        public void InitializeDynamicComponents()
        {
            token = canceltoken.Token;
            startButton.Enabled = true;
            pauseButton.Enabled = false;
            stopButton.Enabled = false;
            eatNum.KeyPress += new KeyPressEventHandler(OnNumKeyPress);
            thinkNum.KeyPress += OnNumKeyPress;
        }
        public void StartMajorThread()
        {
            if (eatNum.Value == 0 && thinkNum.Value == 0)
            {
                MessageBox.Show("Values must be higher than 0");
                return;
            }
            else
            {
                majorThread = new Thread(new ThreadStart(StartThisFuckingParty));
                majorThread.Start();
            }
        }
        public void ToEndThisFuckingParty()
        {
            majorThread.Abort();
            if (startButton.Enabled == false)
            {

                //philos1.Abort(); philos2.Abort(); philos3.Abort(); philos4.Abort(); philos5.Abort();
                startButton.Enabled = true;
                pauseButton.Enabled = false;
                stopButton.Enabled = false;
            }
        }
        public void PauseThisFuckingParty()
        {
            if(pauseNum.Value!=0)
            {
                pauseTime = Decimal.ToInt32(pauseNum.Value);
                Thread.Sleep(pauseTime*1000);
            }
        }
        public void StartThisFuckingParty()
        {
            
            eatingTime = Decimal.ToInt32(eatNum.Value);
            thinkTime = Decimal.ToInt32(thinkNum.Value);
           
            Philosopher aristoteles = new Philosopher
                (Table.Plastic, Table.Platinum, "Aristoteles",eatingTime, thinkTime,philosLabel1,token);
            Philosopher platon = new Philosopher
                (Table.Platinum, Table.Gold, "Platon", eatingTime, thinkTime, philosLabel2,token);
            Philosopher nietszche = new Philosopher
                (Table.Gold, Table.Silver, "Nietszche", eatingTime, thinkTime, philosLabel3,token);
            Philosopher eratostenes = new Philosopher
                (Table.Silver, Table.Wood, "Eratostenes", eatingTime, thinkTime, philosLabel4,token);
            Philosopher socrates = new Philosopher
                (Table.Wood, Table.Plastic, "Socrates", eatingTime, thinkTime, philosLabel5,token);
            new Thread(new ThreadStart(aristoteles.Think)).Start();
            new Thread(new ThreadStart(platon.Think)).Start();
            new Thread(new ThreadStart(nietszche.Think)).Start();
            new Thread(new ThreadStart(eratostenes.Think)).Start();
            new Thread(new ThreadStart(socrates.Think)).Start();
            //philos1.Start();philos2.Start();philos3.Start();philos4.Start();philos5.Start();
            startButton.Enabled = false;
            pauseButton.Enabled = true;
            stopButton.Enabled = true;
        }
        public void OnNumKeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                StartMajorThread();
            }
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartMajorThread();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            PauseThisFuckingParty();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {

        }
    }
}
