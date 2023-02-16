using Html.Code.Gen.Lib.TestData;

namespace Html.Code.Gen.Tests.TutorialGenerator;

public class TutorialGeneratorOnDataSetBTests
{
  [Fact]
  public void TestMarkupV1()
  {
    Assert.Equal(DataSetB.GetExpected(), DataSetB.GetData().GetHtml());
  }
}