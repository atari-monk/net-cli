using Html.Code.Gen.Lib.TestData;

namespace Html.Code.Gen.Tests.TutorialGenerator2;

public class TutorialGenerator2OnDataSetCTests
{
  [Fact]
  public void TestData2SetC()
  {
    Assert.Equal(Data2SetC.GetExpected(), Data2SetC.GetActualNotes());
  }
}