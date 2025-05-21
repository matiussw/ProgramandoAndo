using ProgramandoAndoForms.Models.MVCModels.InabilityExercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramandoAndoForms.Controller.MVCController.InabilityExercise
{
    public class DiseaseController
    {
        public PaidImpairment _Paid { get; set; }

        public DiseaseController()
        {
            _Paid = new PaidImpairment();
        }

        public List<Inability> GetTypeDiseases()
        {
            return TypeDisease.GetImpairment();
        }

        public void SelectDisease(Inability inability)
        {
            _Paid.DiseaseSelect = inability;
        }

        public void SetSalary(double Salary)
        {
            _Paid.Salary = Salary;
        }
        public double GetDiscount()
        {
            return _Paid.Discount();
        }

        public double GetSalaryTotal()
        {
            return _Paid.SalaryTotal();
        }


    }
}
