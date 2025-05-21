using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramandoAndoForms.Models.MVCModels.InabilityExercise

{
    public static class TypeDisease
    {
        public static List<Inability> GetImpairment()
        {
            return new List<Inability>
            {
                new Inability("Viral", 2),
                new Inability("Bacterial", 5),
                new Inability("Cirugia Menor", 7),
                new Inability("Cirugia Mayor", 15),
                new Inability("Gripa", 0)

            };
        }
    }
}
