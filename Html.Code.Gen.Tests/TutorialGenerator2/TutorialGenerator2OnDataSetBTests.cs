using Html.Code.Gen.Lib.TestData;

namespace Html.Code.Gen.Tests.TutorialGenerator2;

public class TutorialGenerator2OnDataSetBTests
{
  [Fact]
  public void TestData2SetA()
  {
    Assert.Equal(Data2SetB.GetExpected(), Data2SetB.GetData().GetStep());
  }
}