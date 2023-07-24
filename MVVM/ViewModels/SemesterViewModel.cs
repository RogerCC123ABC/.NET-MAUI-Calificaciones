using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PropertyChanged;
using TDMPW_412_3P_EX.MVVM.Models;

namespace TDMPW_412_3P_EX.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class SemesterViewModel
    {
        public Semester semester { get; set; }
        public double Ten { get; set; }
        public double Six { get; set; }

        public ICommand CmdShowResult => new Command(() =>
        {

            double operation1 = semester.ValueParcial1 * semester.GradeParcial1;
            double operation2 = semester.ValueParcial2 * semester.GradeParcial2;
            double finalOperation = operation1 + operation2;

            double addition = semester.ValueParcial1 + semester.ValueParcial2 + semester.ValueParcial3;

            if (semester.SubjectName.Equals("") || semester.ValueParcial1 == 0.0 || 
            semester.ValueParcial2 == 0.0 || semester.ValueParcial2 == 0.0)
            {
                App.Current.MainPage.DisplayAlert("Llenar campos", "Ingresa los datos requeridos para hacer la evaluación", "Aceptar");
            }
            else
            {
                if(addition == 1)
                {
                    if(semester.GradeParcial1 >=0 && semester.GradeParcial1 <=10 && semester.GradeParcial2 >=0 && semester.GradeParcial2 <= 10)
                    {

                        Ten = NecessaryGrade(10, semester.ValueParcial1, semester.ValueParcial2, semester.ValueParcial3, semester.GradeParcial1, semester.GradeParcial2);
                        Six = NecessaryGrade(6, semester.ValueParcial1, semester.ValueParcial2, semester.ValueParcial3, semester.GradeParcial1, semester.GradeParcial2);

                        if (semester.GradeParcial1 == 10 && semester.GradeParcial2 == 10)
                        {
                            App.Current.MainPage.DisplayAlert("Calificación necesaria", "¡Felicidades!, necesitas un " + Ten + $" para sacar un 10 en la materia de {semester.SubjectName}, ¡Eres de otro planeta!👽 ", "Aceptar");

                        }
                        else
                        {
                            if (Six <= 10)
                            {
                                App.Current.MainPage.DisplayAlert("Calificación necesaria", "Necesitas un " + Six + " para sacar un 6 en la materia de " + semester.SubjectName +
                               ". ¡Ánimo!😎 ", "Aceptar");
                            }
                            else
                            {
                                if (finalOperation >= 6)
                                {
                                    App.Current.MainPage.DisplayAlert("Calificación necesaria", "Puedes sacar cualquier calificación del tercer parcial, ya que con el promedio de las dos calificaciones de los parciales pasas la materia de " + semester.SubjectName + $" 😲 . Promedio de las dos calificaciones: {finalOperation}, ¡felicidades por ello!"
                               , "Aceptar");
                                }
                                else
                                {
                                    App.Current.MainPage.DisplayAlert("Calificación necesaria", "Ya no podrás pasar " + semester.SubjectName + " 😭"
                               , "Aceptar");
                                }

                            }


                        }


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
           
                semester = new Semester
                {
                    SubjectName = "",
                    ValueParcial1 = 0.0,
                    ValueParcial2 = 0.0,
                    ValueParcial3 = 0.0,
                    GradeParcial1 = 0,
                    GradeParcial2 = 0

                };
            

        });

        public SemesterViewModel()
        {
            semester = new Semester
            {
                SubjectName = "",
                ValueParcial1 = 0.0,
                ValueParcial2 = 0.0,
                ValueParcial3 = 0.0,
                GradeParcial1 = 0,
                GradeParcial2 = 0

            };
        }

        private double NecessaryGrade(double grade, double value1, double value2, double value3, double gradeP1, double gradeP2)
        {
            double operation1 = value1 * gradeP1;
            double operation2 = value2 * gradeP2;
            double gradeToAchieve = (grade - (operation1 + operation2)) /value3;
            return Math.Abs(Math.Round(gradeToAchieve, 1));  
        }

       

    }

   
}


