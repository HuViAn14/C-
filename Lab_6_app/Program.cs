using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_6_app
{
    public class Circle
    {
        private double r;

        public Circle(double[] coord, double r)
        {
            this.r = r;
        }

        public Circle(double d)
        {
            this.r = d / 2;
        }

        public Circle(double[] coord_r, double[] coord_p)
        {
            this.r = Math.Sqrt(Math.Pow(coord_p[0] - coord_r[0], 2) + (Math.Pow(coord_p[1] - coord_r[1], 2)));
        }

        public double getS()
        {
            return r * Math.PI;
        }

        public double getL()
        {
            return 2 * Math.PI * r;
        }

        public double getV()
        {
            return (3.0 / 4.0) * Math.PI * Math.Pow(r, 2);
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
