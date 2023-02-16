using Html.Code.Gen.Lib.TestData;

namespace Html.Code.Gen.Tests.TutorialGenerator;

public class TutorialGeneratorOnDataSetATests
{
  [Fact]
  public void TestDataSetA1()
  {
    Assert.Equal(DataSetA1.GetExpected(), DataSetA1.GetData().GetHtml());
  }

  // [Fact]
  // public void TestDataSetA2()
  // {
  //   Assert.Equal(DataSetA2.GetExpected(), DataSetA2.GetData().GetHtml());
  // }
}