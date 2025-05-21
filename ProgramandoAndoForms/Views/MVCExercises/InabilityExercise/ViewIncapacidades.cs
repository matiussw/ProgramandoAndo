using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProgramandoAndoForms.Controller.MVCController.InabilityExercise;
using ProgramandoAndoForms.Models.MVCModels.InabilityExercise;

namespace ProgramandoAndoForms.Views.MVCExercises
{
    public partial class ViewIncapacidades : Form
    {
        private DiseaseController diseaseController;
        public ViewIncapacidades()
        {
            InitializeComponent();
            diseaseController = new DiseaseController();

            this.Load += ViewInability_Load;
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtSalary.Text, out double Salary))
            {
                diseaseController.SetSalary(Salary);

                var selectedDisease = ComboDisease.SelectedItem as Inability;
                if (selectedDisease != null)
                {
                    diseaseController.SelectDisease(selectedDisease);

                    double descuento = diseaseController.GetDiscount();
                    double salarioFinal = diseaseController.GetSalaryTotal();

                    MostrarSalarioSub.Text = $"{Salary}";
                    MostrarValorIn.Text = diseaseController.GetDiscount().ToString("N2");
                    MostrarSalarioTotal.Text = diseaseController.GetSalaryTotal().ToString("N2");
                    ;
                }
                else
                {
                    MessageBox.Show("Por favor seleccione una enfermedad.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un salario válido.");
            }
        }

         private void ViewInability_Load(object sender, EventArgs e)
            {
            ComboDisease.DataSource = diseaseController.GetTypeDiseases();
        }
    }
}
