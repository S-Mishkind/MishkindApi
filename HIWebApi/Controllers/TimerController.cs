using Microsoft.AspNetCore.Mvc;

namespace HIWebApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TimerController : ControllerBase
{


     [HttpGet]
     //https://localhost:7025/api/Timer

      public List<Timer> Get()
    {
        DateTime now = DateTime.Now;
        List<Timer> retTimer = new List<Timer>(){
        new Timer(now.ToString("hh:mm tt"))
        };
        return retTimer;
    }

    
    [HttpPost]
    //https://localhost:7025/api/Timer?tComplete=true
    public void Post(bool tComplete)
    {
        bool timerComplete = tComplete;
    }

}