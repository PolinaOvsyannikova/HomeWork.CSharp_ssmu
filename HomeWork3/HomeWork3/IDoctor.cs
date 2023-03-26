using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    public interface IDoctor
    {
        public void Diagnosis(Patient patient);
        public void Cure(Patient patient);
    }
}
