using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace InputNumber.Objects
{
  public class PingPongGenerator
  {
    public static List<string> _numList = new List<string>{};

    public static List<string> GenerateList(int inputNum)
    {
      for (int i=1;i<=inputNum;i++)
      {
        if (i % 15 == 0)
        {
          _numList.Add("ping-pong");
        }
        else if (i % 3 == 0)
        {
          _numList.Add("ping");
        }
        else if (i % 5 == 0)
        {
          _numList.Add("pong");
        }
        else
        {
          _numList.Add(i.ToString());
        }
      }
      return _numList;
    }
    // public List<string> GetList()
    // {
    //   return _numList;
    // }
    public static void DeleteAll()
    {
      _numList.Clear();
    }
  }
}
