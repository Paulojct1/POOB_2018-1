using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04POOB_Vetor3D
{
    class Vetor2D
    {
        //Declaração das Variaveis
        protected double x;
        protected double y;

        //Construtor Vazio
        public Vetor2D()
        {
            this.x = 0.0;
            this.y = 0.0;
        }

        //Contrutor que recebe os valores
        public Vetor2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        //Getters and setters
        public void setX(double x)
        {
            this.x = x;
        }

        public void setY(double y)
        {
            this.y = y;
        }

        public double getX()
        {
            return x;
        }

        public double getY()
        {
            return y;
        }

        //Função Membro que retorna o produto escalar entre dois vetores
        public double produto_escalar(double x_1, double y_1)
        {
            double part_1 = x * x_1;
            double part_2 = y * y_1;
            return (part_1 + part_2);
        }

        //Função Membro que retorna o modulo do vetor
        public virtual double mod()
        {
            return Math.Sqrt((x * x) + (y * y));
        }

        //Função modulo que retorna o modulo quando é dado duas entradas
        public void mod_in(double x_1, double y_1)
        {
            double valor = Math.Sqrt((x_1 * x_1) + (y_1 * y_1));
        }
    }
}
