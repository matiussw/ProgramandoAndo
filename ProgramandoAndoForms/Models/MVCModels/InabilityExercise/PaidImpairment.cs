using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProgramandoAndoForms.Models.MVCModels.InabilityExercise
{
    public class PaidImpairment
    {

        public double Salary { get; set; }
        public Inability DiseaseSelect { get; set; }


        public double Discount()
        {
            if (Salary < 750000)
            {
                return Salary / 30.0 * DiseaseSelect.Days;
            }
            else if (Salary <= 750000 && Salary <= 1500000 && DiseaseSelect.Days > 3)
            {
                return Salary / 30.0 * DiseaseSelect.Days - Salary / 30 * 3;
            }
            else if (Salary <= 750000 && Salary <= 1500000 && DiseaseSelect.Days <= 3)
            {
                return 0;
            }
            else
            {
                return Salary / 30 * 65.0 / 100.0 * DiseaseSelect.Days;
            }

        }



        public double SalaryTotal()
        {
            if (Salary < 750000)
            {
                return Salary;
            }
            else if (Salary <= 750000 && Salary <= 1500000 && DiseaseSelect.Days == 2)
            {
                return Salary - Salary / 30 * 2;
            }
            else
            {
                return Salary - Discount();
            }
        }
    }
}
