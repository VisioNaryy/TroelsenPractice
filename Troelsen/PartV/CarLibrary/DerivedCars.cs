using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CarLibrary
{
    public class SportsCar: Car
    {
        public SportsCar()
        {

        }
        public SportsCar(string name, int maxSp, int currSp):base(name, maxSp, currSp)
        {

        }
        public override void TurboBoost()
        {
            //MessageBox.Show("Ramming speed!", "Faster is better..."); 
            Console.WriteLine("Ramming speed!", "Faster is better...");
        }
    }
    public class MiniVan : Car
    {
        public MiniVan() { }
        public MiniVan(string name, int maxSp, int currSp) : base(name, maxSp, currSp) { }
        public override void TurboBoost()
        {
            // Minivans have poor turbo capabilities!
            egnState = EngineState.engineDead;
            //MessageBox.Show("Eek!", "Your engine block exploded!");
            Console.WriteLine("Eek!", "Your engine block exploded!");
        }
    }
}
