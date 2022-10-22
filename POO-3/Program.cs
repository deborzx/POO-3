using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //formas geométricas: line, quad, rect, tri, circ

            //instanciando pela class quad
            //IDrawable shape = new Quad();
            //shape.Draw();


            Drawable shape = new Line();
            shape.Draw();


        Console.ReadLine();

        }
    }


    //classe abstrata
    abstract class Drawable
    {
        public abstract void Draw();

        public abstract float Area();

    }





    
    //criando interface 
    interface IDrawable
    {
        //metodo
        void Draw();
        float Area();

    }



    //criando classes para as formas 
    class Line : Drawable
    {
        public override float Area()
        {
            return 0;
        }

        public override void Draw()
        {
            Console.WriteLine("-----linha-----");
        }
    }

    class Quad : IDrawable
    {
        public float Area()
        {
            return 2;
        }

        public void Draw()
        {
            Console.WriteLine("-----quadrado-----");
        }
    }
    class Rect : IDrawable
    {
        public float Area()
        {
            return 10;
        }

        public void Draw()
        {
            Console.WriteLine("-----retangulo-----");
        }
    }

}
