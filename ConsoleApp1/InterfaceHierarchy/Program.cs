using System;

namespace InterfaceHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            BitmapImage img = new BitmapImage();
            img.DrawInBoundingBox(12, 12, 12, 12);
            img.Draw();
            img.DrawUpsideDown();
            Console.WriteLine();
            //Получить IAdvancedDraw явным образом.
            IAdvancedDraw iad = img as IAdvancedDraw;
            if(iad != null)
            {
                iad.DrawUpsideDown();
            }
            IAdvancedDraw iad2 = img;
            if(iad2 is BitmapImage)
            {
                iad2.DrawInBoundingBox(20, 20, 20, 20);
            }
            
        }
    }
}
