using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramandoAndoForms.Models.MVCModels.InabilityExercise
{
    public abstract class Impairment
    {
        public string Name { get; set; }

        public int Days { get; set; }

        protected Impairment(string _Name, int _Days)
        {
            Name = _Name;
            Days = _Days;

        }

        public override string ToString()
        {
            return $"{Name} - {Days} días";
        }

    }
}
