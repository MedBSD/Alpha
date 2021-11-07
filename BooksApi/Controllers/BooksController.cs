using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BooksApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
      

        public WeatherForecastController(
        {
          
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
           
        }
    }
}