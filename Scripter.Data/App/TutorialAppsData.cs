using Scripter.Data.Helper;

namespace Scripter.Data;

public class TutorialAppsData 
    : CodeData
{
    protected override void SetAllData()
    {
        SetTimCoreyTutorials();
        SetLesJacksonTutorials();
    }

    private void SetTimCoreyTutorials()
    {
        Set(
            "timco-retail"
            , "TRMApi"
            , isApp: true);
        Set(
            "timco-retail"
            , "TRMDesktopUI"
            , isApp: true
            , isWpf: true);
        Set(
            "timco-retail"
            , "Portal"
            , isApp: true);
        Set(
            "timco-suggestion-site-app"
            , "SuggestionAppUI"
            , isApp: true);
    }

    private void SetLesJacksonTutorials()
    {
        Set(
            "docker-api"
            , "DockerAPI"
            , isApp: true);
        Set(
            "commander"
            , "Commander"
            , isApp: true);
        Set(
            "microservices"
            , "CommandsService"
            , isApp: true);
        Set(
            "microservices"
            , "PlatformService"
            , isApp: true);
    }
}