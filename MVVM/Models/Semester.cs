using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace TDMPW_412_3P_EX.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Semester
    {
        public string SubjectName { get; set; }
        public double ValueParcial1 { get; set; }
        public double ValueParcial2 { get; set; }
        public double ValueParcial3 { get; set; }
        public double GradeParcial1 { get; set; }
        public double GradeParcial2 { get; set; }
       


        
    }
}
