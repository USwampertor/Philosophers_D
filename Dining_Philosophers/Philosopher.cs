using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
namespace Dining_Philosophers
{
    enum PhilosopherState { Eating, Thinking }
    class Philosopher
    {
        public string Name { get; set; }

        public PhilosopherState State { get; set; }

        // determines number of continuose thinkings, without being considered starving
        readonly int StarvationThreshold;

        // defines the right and the left side fork of a philosopher
        public readonly Fork RightFork;
        public readonly Fork LeftFork;
        Label philosLabel= new Label();
        Random rand = new Random();
        CancellationToken token;
        int contThinkCount = 0;
        int timeToEat = 0;
        public Philosopher(Fork rightFork, Fork leftFork, string name,int eatingTime, int starvThreshold,Label labelname, CancellationToken cancel)
        {
            RightFork = rightFork;
            LeftFork = leftFork;
            Name = name;
            State = PhilosopherState.Thinking;
            StarvationThreshold = starvThreshold;
            philosLabel = labelname;
            philosLabel.Text = name;
            timeToEat = eatingTime * 1000;
        }

        public void Eat()
        {
            // take the fork in the right hand
            if (TakeForkInRightHand())
            {
                // if got the fork in the right hand immediatley try to take the fork in the left hand
                if (TakeForkInLeftHand())
                {
                    // if got both forks then eat
                    this.State = PhilosopherState.Eating;
                    philosLabel.Text = (Name + "\n IS EATING");
                    Thread.Sleep(timeToEat);

                    contThinkCount = 0;

                    // place the forks back
                    RightFork.Put();
                    LeftFork.Put();
                }
                // got the right fork but not the left one
                else
                {
                    // wait for a small random period and try agian to get left fork
                    Thread.Sleep(rand.Next(100, 400));
                    if (TakeForkInLeftHand())
                    {
                        // if got the left fork then eat
                        this.State = PhilosopherState.Eating;
                        philosLabel.Text = (Name + "\n IS EATING");
                        Thread.Sleep(timeToEat);

                        contThinkCount = 0;

                        RightFork.Put();
                        LeftFork.Put();
                    }
                    // if couldn't get the fork even after the wait, out the right fork on the table
                    else
                    {
                        RightFork.Put();
                    }
                }
            }
            // if couldn't get fork on the right hand
            else
            {
                // get a fork the left hand
                if (TakeForkInLeftHand())
                {
                    // wait for a small random time period and then try acquire the right one
                    Thread.Sleep(rand.Next(100, 400));
                    if (TakeForkInRightHand())
                    {
                        // if got the right one then eat
                        this.State = PhilosopherState.Eating;
                        philosLabel.Text = (Name + "\n IS EATING");
                        Thread.Sleep(timeToEat);

                        contThinkCount = 0;

                        RightFork.Put();
                        LeftFork.Put();
                    }
                    else
                    {
                        // else put the left fork back on the table
                        LeftFork.Put();
                    }
                }
            }
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Canceled");
                return;
            }
            Think();
        }

        public void Think()
        {
            this.State = PhilosopherState.Thinking;
            
            philosLabel.Text = (Name + "\n IS THINKING...");
            Thread.Sleep(1000*StarvationThreshold);
            contThinkCount++;

            if (contThinkCount > StarvationThreshold)
            {
                
                philosLabel.Text = (Name + "\n IS STARVING!!!");
            }
            if (token.IsCancellationRequested)
            {
                Console.WriteLine("Canceled");
                return;
            }
            Eat();
        }

        private bool TakeForkInLeftHand()
        {
            return LeftFork.Take(Name);
        }

        private bool TakeForkInRightHand()
        {
            return RightFork.Take(Name);
        }
    }
}
