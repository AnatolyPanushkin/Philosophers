using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;

namespace Philosophers
{
    public class Philosophers:IEnumerable
    {
        private Mutex _philosopherMustWait = new Mutex();
        public Thread _thread;
        public Philosophers()
        {
            _thread = new Thread(CreatePhilosopher);
            _thread.Start();
        }
        public Task PhilosopherThinking(Fork fork1,Fork fork2)
        {
            Thread.Sleep(2000);

            Console.WriteLine($"Философ - {_thread.Name}  думает");
            
            PhilosopherEating(fork1,fork2);
            
            return Task.CompletedTask;
        }

        public Task PhilosopherEating(Fork fork1, Fork fork2)
        {
            _philosopherMustWait.WaitOne();
            if (fork2.Condition == false & fork1.Condition == false)
            {
                fork1.Condition = true;
                fork2.Condition = true;
                
                Console.WriteLine($"Философ - {_thread.Name} кушает");
                
                Thread.Sleep(5000);
                
                Console.WriteLine($"Философ - {_thread.Name} поел");
                
                
                fork1.Condition = false;
                fork2.Condition = false;
                _philosopherMustWait.ReleaseMutex();
                PhilosopherThinking(fork1, fork2);
            }
            else
            {
                PhilosopherThinking(fork1,fork2);
            }
            return Task.CompletedTask;
        }

            
        public async Task PhilosopherProcessAsync(Fork fork1,Fork fork2)
        {
            if (fork2.Condition == false & fork1.Condition == false)
            {
               Task v1= Task.Run(()=>PhilosopherEating(fork1,fork2));
               //Thread.Sleep(10000);//Спросить
               await v1;
            }
            else
            {
                await Task.Run(()=>PhilosopherThinking(fork1,fork2)); 
            }
        }

        
        
        private static void CreatePhilosopher()
        {
            Console.WriteLine($"Создан философ");
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}