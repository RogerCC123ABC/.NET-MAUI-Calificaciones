namespace TDMPW_412_3P_EX.MVVM.Views;
using TDMPW_412_3P_EX.MVVM.ViewModels;

public partial class SubjectView : ContentPage
{
	public SubjectView()
	{
		InitializeComponent();
		BindingContext = new SubjectViewModel();

	}

   
}