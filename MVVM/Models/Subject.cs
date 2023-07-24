using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertyChanged;

namespace TDMPW_412_3P_EX.MVVM.Models
{
    [AddINotifyPropertyChangedInterface]
    public class Subject
    {
        public string Name { get; set; }
        public string Rubric1  { get; set; }
        public string Rubric2 { get; set; }
        public string Rubric3 { get; set; }
        public double ValueRubric1 { get; set; }
        public double ValueRubric2 { get; set; }
        public double ValueRubric3 { get; set; }
        public double GradeRubric1 { get; set; }
        public double GradeRubric2 { get; set; }
        public double GradeRubric3 { get; set; }
        
    }
}
