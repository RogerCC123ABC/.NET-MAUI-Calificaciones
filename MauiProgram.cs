namespace TDMPW_412_3P_EX;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("TheStudentsTeacher-Regular.ttf", "students");
                fonts.AddFont("KGPrimaryItalics.ttf", "primaryI");
            });

		return builder.Build();
	}
}
