using System;

namespace Figuras2
{
    class Vector2D
    {
        public int x,y;
        public Vector2D(int x,int y)
        {
            this.x= x; 
            this.y = y ;
        }
    }
    class Color
    {
        enum Name{red,blue,white,green,black,pink,yellow,none}//Enum es para crear una nueva variable//Name es para nombre de color
        public int R,G,B,I;
        public Color.Name colorName;
        public Color(int r, int g, int b, int i=1)
        {
            R=r;
            G=g;
            B=b;
            I=i;
            this.colorName=ColorName.Name.none;
        }
        public Color(Color.Name name)
        {
            colorName=name;
            if (name==Color.Name.red)
            {
              R=255;
              G=0;
              B=0;
              I=1;
            }
            else
            {
                R=0;G=0;B=255;I=1;
            }
        }
    }
    abstract class Figure
    {
        protected Vector2D position;
        protected Color fill, border;
        protected string Name;
        public Figure(Vector2D position,Color fill)
        {
            this.position=position;
            this.fill=fill;
        }
        public abstract void draw();
    }
    class Circle:Figure
    {
        public float radio;
        public Circle(Vector2D position,Color fill,float radio):base(position,fill)
        {
            this.radio=radio;
        }
        public override void draw() 
        {
            Console.WriteLine("Se dibuja un circulo color{0} en {1}", fill, position);
        }
    }
    class Pentagon : Figure
    {
        public float apotema;
        public Pentagon(Vector2D position,Color fill,float radio):base(position,fill)
        {
            this.apotema = apotema;
        }
        public override void draw()
        {
            Console.WriteLine("Se dibuja un pentagono de color{0} en {1}", fill, position);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c=new Circle(new Vector2D(10,10), new Color(Color.Name.red),10);
            c.draw();
            
        }
    }
}

