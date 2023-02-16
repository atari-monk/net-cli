using Config.Wrapper;
using DIHelper;
using Modern.CLI.App.Template;
using Unity;

var unity = new UnityContainer()
    .AddExtension(new Diagnostic());
var serviceSuite = new Modern.CLI.App.Template.ServiceSuite(unity);
serviceSuite.Register();
var suite = new SuiteConfig(
    unity.Resolve<IConfigReader>())
        .GetSuite(unity);
IBootstraper booter = new Bootstraper(suite);
booter.CreateApp();
booter.RunApp(args);