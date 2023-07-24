using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TDMPW_412_3P_EX.MVVM.Models;
using PropertyChanged;


namespace TDMPW_412_3P_EX.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class SubjectViewModel
    {
        public Subject subject { get; set; }
        public double average { get; set; }
        public ICommand CmdAverage => new Command(() =>
        {

            double addition = subject.ValueRubric1 + subject.ValueRubric2 + subject.ValueRubric3;


            if (subject.Name.Equals("") || subject.Rubric1.Equals("Rubro 1") || subject.Rubric1.Equals("") ||
            subject.Rubric2.Equals("Rubro 2") || subject.Rubric2.Equals("") || subject.Rubric3.Equals("Rubro 3")
            || subject.Rubric1.Equals("") || subject.ValueRubric1 == 0.0 || subject.ValueRubric2 == 0.0 || 
            subject.ValueRubric3 == 0.0)
            {
                App.Current.MainPage.DisplayAlert("Llenar campos", "Ingresa los datos requeridos para hacer la evaluación", "Aceptar");
            }
            else
            {
                if(addition == 1)
                {
                    if(subject.GradeRubric1 >=0 && subject.GradeRubric1<=10 && subject.GradeRubric2 >= 0 && subject.GradeRubric2 <= 10 && subject.GradeRubric3 >= 0 && subject.GradeRubric3 <= 10)
                    {
                        average = ((subject.ValueRubric1 * subject.GradeRubric1) + (subject.ValueRubric2 * subject.GradeRubric2) + (subject.ValueRubric3 * subject.GradeRubric3));

                        App.Current.MainPage.DisplayAlert("Calificación final", "Su calificación en la materia " + subject.Name + " es de: " + Math.Round(average, 1), "Aceptar");
                    }
                    else
                    {
                        App.Current.MainPage.DisplayAlert("Calificaciones inválidas", "Ingrese calificaciones válidas (0-10)", "Aceptar");
                    }
                    
                }
                else
                {
                    App.Current.MainPage.DisplayAlert("Valores no correspondientes", "La suma total de los valores de los rubros tiene que ser igual a 1 (100%) para que se pueda hacer la evaluación.", "Aceptar");
                }
               

            }
          
        });

        public ICommand CmdReboot => new Command(() =>
        {
                subject = new Subject
                {
                    Name = "",
                    Rubric1 = "Rubro 1",
                    Rubric2 = "Rubro 2",
                    Rubric3 = "Rubro 3",
                    ValueRubric1 = 0.0,
                    ValueRubric2 = 0.0,
                    ValueRubric3 = 0.0,
                    GradeRubric1 = 0,
                    GradeRubric2 = 0,
                    GradeRubric3 = 0

                };
           
        });

        public SubjectViewModel()
        {
            subject = new Subject
            {
                Name = "",
                Rubric1 = "Rubro 1",
                Rubric2 = "Rubro 2",
                Rubric3 = "Rubro 3",
                ValueRubric1 = 0,
                ValueRubric2 = 0,
                ValueRubric3 = 0,
                GradeRubric1 = 0,
                GradeRubric2 = 0,
                GradeRubric3 = 0,

            };
        }





    }
}
