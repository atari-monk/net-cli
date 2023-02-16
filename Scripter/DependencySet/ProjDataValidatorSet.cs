using DIHelper.Unity;
using Scripter.Lib;
using Unity;

namespace Scripter;

public class ProjDataValidatorSet 
	: UnityDependencySet
{
	public ProjDataValidatorSet(
		IUnityContainer container) 
		: base(container)
	{
	}

	public override void Register()
	{
		RegisterValidator<DefaultProjValidator>(
			ProjectTypes.Default);
        RegisterValidator<CsharpAppProjValidator>(
			ProjectTypes.App);
        RegisterValidator<WpfProjValidator>(
			ProjectTypes.Wpf);
        RegisterValidator<WpfAppProjValidator>(
			ProjectTypes.WpfApp);

        //Cpp
        RegisterValidator<CppAppProjValidator>(
			ProjectTypes.CppApp);
	}

    private void RegisterValidator<TValidator>(
		ProjectTypes validator)
		where TValidator : IProjDataValidator
	{
		Container.RegisterSingleton<IProjDataValidator, TValidator>(
			validator.ToString());
	}
}