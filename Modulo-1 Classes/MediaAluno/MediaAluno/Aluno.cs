using System;

namespace MediaAluno
{
    internal class Aluno
    {
        public string Nome;
        public double NotaTrimestre1;
        public double NotaTrimentre2;
        public double NotaTrimestre3;

        public double notaFinal()
        {
            return NotaTrimestre1 + NotaTrimentre2 + NotaTrimestre3;
        }

        public bool Aprovado()
        {
            if(notaFinal() >= 60)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if(Aprovado())
            {
                return 0.0;
            } else
            {
                return 60.00 - notaFinal();
            }
        }


    }
}
