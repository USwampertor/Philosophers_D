using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dining_Philosophers
{
    enum ForkState { Taken, OnTheTable }
    class Fork
    {

        public string ForkID { get; set; }
        public ForkState State { get; set; }
        public string TakenBy { get; set; }

        public bool Take(string takenBy)
        {
            lock (this)
            {
                if (this.State == ForkState.OnTheTable)
                {
                    State = ForkState.Taken;
                    TakenBy = takenBy;
                    //Console.WriteLine("||| {0} is taken by {1}", ForkID, TakenBy);
                    return true;
                }

                else
                {
                    State = ForkState.Taken;
                    return false;
                }
            }
        }

        public void Put()
        {
            State = ForkState.OnTheTable;
            //Console.WriteLine("||| {0} is place on the table by {1}", ForkID, TakenBy);
            TakenBy = String.Empty;
        }
    }
}
