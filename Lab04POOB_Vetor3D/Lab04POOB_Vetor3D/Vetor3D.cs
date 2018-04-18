using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04POOB_Vetor3D
{
    class Vetor3D : Vetor2D
    {
        protected Double z;

        public Vetor3D() : base()
        {
            this.z = 0.0;
        }

        public Vetor3D(double _x, double _y, double _z) : base(_x, _y)
        {
            this.z = _z;
        }

        //Getter and Setter
        public void setZ(double z)
        {
            this.z = z;
        }

        public Double getZ()
        {
            return z;
        }

        public override double mod()
        {
            base.mod();
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public Vetor3D prod_vet(Vetor3D vetorB)
        {
            Double xres = (this.y * vetorB.z) + (-(this.z * vetorB.y));
            Double yres = (this.z * vetorB.x) + (-(this.x * vetorB.z));
            Double zres = (this.x * vetorB.y) + (-(this.y * vetorB.x));
            Vetor3D vetorC = new Vetor3D(xres, yres, zres);
            return vetorC;
        }
        
    }
}
