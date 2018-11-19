using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GestionFigGeometrique
{
    interface IGeometrie
    {
        double Surface();
        double Perimetre();
    }
    public class Point
    {
        private int x;
        private int y;
        public int X { get; set; }
        public int Y { get; set; }
        public Boolean coincide(Point p)
        {
            return (this.X == p.X) && (this.Y == p.Y);
        }
        public Point Symetrique()
        {

            return new Point(1 * this.X, -1 * this.Y);
        }

        public Point()
        {
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;

        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
    public abstract class FormGeo : IGeometrie
    {
        private Point p = new Point();



        public abstract double Surface();
        public abstract double Perimetre();

        protected FormGeo()
        {
        }

        protected FormGeo(Point p)
        {
            P = p;
        }

        public override string ToString()
        {
            return base.ToString();
        }
        public Point P { get; set; }
    }
    class Rectangle : FormGeo
    {
        protected double longueur;
        protected double largeur;

        public Rectangle()
        {
        }

        public Rectangle(double longueur, double largeur, Point p) : base(p)
        {
            this.longueur = longueur;
            this.largeur = largeur;


        }
        public double Longueur { get; set; }
        public double Largeur { get; set; }


        public override double Perimetre()
        {
            double p;
            p = 2 * (longueur + largeur);
            return p;
        }

        public override double Surface()
        {
            double s;
            s = longueur * largeur;
            return s;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
    class Cercle : FormGeo
    {
        private double rayon;

        public Cercle()
        {
        }

        public Cercle(double rayon, Point p) : base(p)
        {
            this.rayon = rayon;
        }

        public override double Perimetre()
        {
            double pc;
            pc = 2 * (rayon * Math.PI);
            return pc;
        }

        public override double Surface()
        {
            double sc;
            sc = Math.PI * (rayon * rayon);
            return sc;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public double Rayon { get; set; }
    }
    class Carre : Rectangle
    {
        private double cote;

        public Carre()
        {
        }

        public Carre(double cote, Point p) : base(cote, cote, p)
        {
            longueur = cote;
            largeur = cote;
            this.cote = cote;
        }
        public double Cote { get; set; }
        //public override double Perimetre()
        //{
        //    double pcar;
        //    pcar = 4 * cote;
        //    return  pcar;
        //}

        //public override double Surface()
        //{
        //    double scar;
        //    scar = cote * cote;
        //    return scar;
        //}

        public override string ToString()
        {
            return base.ToString();
        }
    }




    class Program
    {
        static void Main(string[] args)

        {
            WriteLine("Faites Votre choix");
            WriteLine("1: Rectangle");
            WriteLine("2: Cercle");
            WriteLine("3: Carré");
            string figure = ReadLine();

            switch (figure)
            {
                case "1":
                    WriteLine("Rectangle");
                    WriteLine("Determiner la position x du rectangle");
                    int w = int.Parse(ReadLine());
                    WriteLine("Determiner la position y du rectangle");
                    int k = int.Parse(ReadLine());
                    Point p1 = new Point(w, k);

                    WriteLine("Merci de saisir une longeur");

                    int x = int.Parse(ReadLine());
                    WriteLine("Merci de saisir une largeur");
                    int y = int.Parse(ReadLine());

                    Rectangle r = new Rectangle(x, y, p1);

                    WriteLine($"Le Le Rectangle a un perimetre de  : {r.Perimetre()} et une surface de : {r.Surface()}");
                    ReadKey();
                    break;
                case "2":
                    WriteLine("Cercle");
                    WriteLine("Determiner la position x du rectangle");
                    int m = int.Parse(ReadLine());
                    WriteLine("Determiner la position y du rectangle");
                    int n = int.Parse(ReadLine());
                    Point p2 = new Point(m, n);

                    WriteLine("Merci de saisir le rayon de votre cercle");

                    int z = int.Parse(ReadLine());

                    Cercle cer = new Cercle(z, p2);

                    WriteLine($"Le Cercle a un perimetre de  : { cer.Perimetre()} et une surface de : {cer.Surface()}");
                    ReadKey();
                    break;
                case "3":
                    WriteLine("Carré");
                    WriteLine("Determiner la position x du rectangle");
                    int q = int.Parse(ReadLine());
                    WriteLine("Determiner la position y du rectangle");
                    int t = int.Parse(ReadLine());
                    Point p3 = new Point(q, t);
                    WriteLine("Merci de saisir le côté Carré");

                    int i = int.Parse(ReadLine());


                    Cercle car = new Cercle(i, p3);


                    WriteLine($"Le Carre a un perimetre de : { car.Perimetre()} et une surface de : {car.Surface()}");
                    ReadKey();
                    break;
                default:
                    WriteLine("C'est choix n'existe pas");
                    ReadKey();
                    break;

            }








        }
    }
}
