using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExample
{
    class Rectangle
    {
        private int width;
        private int height;

         public void Area()
        {
            Console.WriteLine("enter your width");
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your height");
            height = Convert.ToInt32(Console.ReadLine());
        }
        public void Logic()
        {
            return height * width;
        }
        public void Display()
        {
            Console.WriteLine("length:{0}",height);
            Console.WriteLine("width:{0}", width);
            Console.WriteLine("area:{0}", Logic());
        }


       
    }
    class ExecuteRectangle
    {
        static void Main()
        {
            Rectangle obj = new Rectangle();
            obj.Area();
            obj.Display();
            Console.ReadLine();

        }
    }
}
