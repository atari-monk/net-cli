using Html.Code.Gen.Lib.TestData;

namespace Html.Code.Gen.Tests.TutorialGenerator2;

public class TutorialGenerator2OnDataSetATests
{
  [Fact]
  public void TestData2SetABlock1()
  {
    Assert.Equal(Data2SetABlock1.GetExpected(), Data2SetABlock1.GetData().GetBlock1());
  }

  [Fact]
  public void TestData2SetABlock2()
  {
    Assert.Equal(Data2SetABlock2.GetExpected(), Data2SetABlock2.GetData().GetBlock2());
  }

  [Fact]
  public void TestData2SetABlock3()
  {
    Assert.Equal(Data2SetABlock3.GetExpected(), Data2SetABlock3.GetData().GetBlock3());
  }

  [Fact]
  public void TestData2SetABlock4()
  {
    Assert.Equal(Data2SetABlock4.GetExpected(), Data2SetABlock4.GetData().GetBlock4());
  }

  [Fact]
  public void TestData2SetABlock12()
  {
    Assert.Equal(Data2SetABlock12.GetExpected(), Data2SetABlock12.GetData().GetBlock12());
  }

  [Fact]
  public void TestData2SetABlock123()
  {
    Assert.Equal(Data2SetABlock123.GetExpected(), Data2SetABlock123.GetData().GetBlock123());
  }

  [Fact]
  public void TestData2SetABlock1234()
  {
    Assert.Equal(Data2SetABlock1234.GetExpected(), Data2SetABlock1234.GetData().GetBlock1234());
  }

  [Fact]
  public void TestData2SetA()
  {
    Assert.Equal(Data2SetA.GetExpected(), Data2SetA.GetData().GetStep());
  }
}