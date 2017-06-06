using Nancy;
using System;
using System.Collections.Generic;
using InputNumber.Objects;

namespace InputNumber
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        PingPongGenerator.DeleteAll();
        return View["index.cshtml"];
      };
      Post["/ping_pong"] = _ => {
        List<string> ListResult = PingPongGenerator.GenerateList(Request.Form["numInput"]);
        return View["ping_pong.cshtml", ListResult];
      };
    }
  }
}
