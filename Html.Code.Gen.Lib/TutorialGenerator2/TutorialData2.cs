using System.Text.Json;
using Html.Code.Gen.Lib.TutorialGenerator2;

namespace Html.Code.Gen.Lib.TutorialGenerator;

public class TutorialData2{

    public List<TutorialStep2> Deserialize(string jsonPath)
    {
        var json = File.ReadAllText(jsonPath);
        var data = JsonSerializer.Deserialize<List<TutorialStep2>>(json);
        ArgumentNullException.ThrowIfNull(data);
        return data;
    }
} 