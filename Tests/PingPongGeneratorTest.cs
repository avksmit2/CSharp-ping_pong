using System;
using Xunit;
using System.Collections.Generic;
using InputNumber.Objects;

namespace InputNumber
{
  public class InputNumberTest : IDisposable
  {
    [Fact]
    public void Test_GetList_GenerateList()
    {
      List<string> expectedResult = new List<string>{"1", "2", "ping", "4"};

      Assert.Equal(expectedResult, PingPongGenerator.GenerateList(4));
    }
    [Fact]
    public void Test_GetList_ThreeIsPing()
    {
      List<string> expectedResult = new List<string>{"1", "2", "ping", "4"};

      Assert.Equal(expectedResult, PingPongGenerator.GenerateList(4));
    }
    [Fact]
    public void Test_GetList_FiveIsPong()
    {
      List<string> expectedResult = new List<string>{"1", "2", "ping", "4", "pong"};

      Assert.Equal(expectedResult, PingPongGenerator.GenerateList(5));
    }
    [Fact]
    public void Test_GetList_FifteenIsPingPong()
    {
      List<string> expectedResult = new List<string>{"1", "2", "ping", "4", "pong", "ping", "7", "8", "ping", "pong", "11", "ping", "13", "14", "ping-pong", "16", "17", "ping", "19", "pong", "ping", "22", "23", "ping", "pong", "26", "ping", "28", "29", "ping-pong"};

      Assert.Equal(expectedResult, PingPongGenerator.GenerateList(30));
    }
    public void Dispose()
    {
      PingPongGenerator.DeleteAll();
    }
  }
}
