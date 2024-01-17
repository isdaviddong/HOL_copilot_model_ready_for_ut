// MyApiController.cs
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/bmi")]
public class BmiController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello from MyApi");
    }

    //支援post方法，可傳入身高體重，計算bmi的api
    [HttpPost]
    public IActionResult Post([FromBody] BmiModel model)
    {
        //使用 bmi 類別的 Calculate 方法計算 bmi
        var Bmi = new webtest.Bmi();
        Bmi.height = model.Height;
        Bmi.weight = model.Weight;
        var bmi = Bmi.Calculate();

        return Ok(bmi);
    }
}

// 建立 BmiModel 類別
public class BmiModel
{
    public double Height { get; set; }
    public double Weight { get; set; }
}

