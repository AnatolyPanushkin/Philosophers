using System;
using System.Threading;

namespace Philosophers
{
    public class Philosophers
    {
        public Philosophers()
        {
            Thread thread = new Thread(new ThreadStart(CreatePhilosopher));
        }

        public void PhilosopherEating(Fork fork1,Fork fork2)
        {
            if (fork1.Condition == false || fork2.Condition == false)
            {
                
            }
        }

        private void CreatePhilosopher()
        {
            Console.WriteLine($"Создан философ с Id - {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}