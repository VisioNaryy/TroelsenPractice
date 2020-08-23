using System;
using System.Collections.Generic;
using System.Text;

namespace CarEvents
{
    public class Car
    {
        //1. Определить тип делегата.
        public delegate void CarEngineHandler(object sender, CarEventArgs e);
        //events
        public event CarEngineHandler Exploded;
        public event CarEngineHandler AboutToBlow;
        //public event EventHandler<CarEngineHandler> Exploded;
        //public event EventHandler<CarEngineHandler> AboutToBlow;

        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }
        private bool carIsDead;
        public Car()
        {

        }
        public Car(string name, int currSp, int maxSp)
        {
            PetName = name;
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
        }
        // 4. Реализовать метод Accelerate () для обращения к списку
        // вызовов делегата в подходящих обстоятельствах.
        public void Accelerate(int delta)
        {
            // Если этот автомобиль сломан, то отправить сообщение об этом,
            if (carIsDead)
            {
                Exploded?.Invoke(this, new CarEventArgs("Sorry, this car is dead..."));
            }
            else
            {
                CurrentSpeed += delta;
                // Автомобиль почти сломан?
                if(10==(MaxSpeed - CurrentSpeed))
                {
                    AboutToBlow?.Invoke(this, new CarEventArgs("Careful buddy! Gonna blow up!"));
                }

                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine($"Current speed: {CurrentSpeed}");
            }
        }
    }
    
}
