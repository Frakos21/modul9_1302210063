using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace modul9_1302210063.Properties
{
    public class MovieProperties
    {
        public String title { get; set; }
        public String director { get; set; }    
        public List<String> stars { get; set; }
        public String description { get; set; }

        public MovieProperties(string title, string director, List<string> stars, string description) 
        {
            this.stars = stars;
            this.title = title;
            this.director = director;
            this.description = description;
        }
    }
}
