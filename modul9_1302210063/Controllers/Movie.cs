using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection;
using modul9_1302210063;
using modul9_1302210063.Properties;
using System.IO;
using System.Runtime.InteropServices;
using modul9_1302210063.Properties;


namespace modul9_1302210063.Controllers.Movie
{
    [ApiController]
    [Route("api/Movies")]
    public class Movie : ControllerBase
    {
        public static List<MovieProperties> data = new List<MovieProperties>()
        {
            new MovieProperties("jarwo sopo", "supri", new List<string>(){"udin,baban"}, "bala bala"),


        };
        [HttpGet]
        public IEnumerable<MovieProperties> Get()
        {
            return data;
        }
        [HttpGet("{id}")]
        public MovieProperties Get(int id)
        {
            return data[id];
        }
        [HttpPost]
        public void Post([FromBody] MovieProperties value)
        {
            data.Add(value);

        }
        [HttpDelete("{id}")]
        public void Delete(int jdl)
        {
            if (jdl < 0 || jdl >= data.Count)
            {
                NotFound();
            }
            data.RemoveAt(jdl);
        }
        private void NotFound()
        {
            throw new NotImplementedException();
        }
    }

}