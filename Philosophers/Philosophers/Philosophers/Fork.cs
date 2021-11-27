using System;

namespace Philosophers
{
    public class Fork
    {
        private static int _idStatic=0;
        public int IdFork { get; set; }
        public bool Condition { get; set; }

        public Fork()
        {
            IdFork = _idStatic++;
            Condition = false;
        }

        public void TakeFork()
        {
            Condition = true;
        }

        public void PutFork()
        {
            Condition = false;
        }
        
    }
}