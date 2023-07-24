namespace TDMPW_412_3P_EX.MVVM.Views;
using TDMPW_412_3P_EX.MVVM.ViewModels;
public partial class SemesterView : ContentPage
{
	public SemesterView()
	{
		InitializeComponent();
		BindingContext = new SemesterViewModel();
	}
}