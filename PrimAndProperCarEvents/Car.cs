using System;

namespace PrimAndProperCarEvents
{
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }
        private bool carIsDead;

        public Car() { MaxSpeed = 100; }
        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }

        // Нет необходимости создавать собственный делегат
        // используем обобщенный делегат EventHandler<T>
        // public delegate void CarEngineHandler(object sender, CarEventArgs e);
        public event EventHandler<CarEventArgs> Exploded;
        public event EventHandler<CarEventArgs> AboutToBlow;

        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                if (Exploded != null)
                    Exploded(this, new CarEventArgs("Sorry, this car is dead"));
            }
            else
            {
                CurrentSpeed += delta;

                if ((MaxSpeed - CurrentSpeed) <= 10 && AboutToBlow != null)
                    AboutToBlow(this, new CarEventArgs("Careful buddy! Gonna blow!"));
                
                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
            }
        }
    }
}
