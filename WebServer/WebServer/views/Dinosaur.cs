using Nancy;
using Nancy.ModelBinding;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServer
{
    public class Dinosaur
    {
        public string Name { get; set; }
        public int HeightInFeet { get; set; }
        public string Status { get; set; }
    }

    public class DinosaurModule : NancyModule
    {
        private static List<Dinosaur> dinosaur = new List<Dinosaur>()
        {
            new Dinosaur()
            {
                Name = "Kierkegaard",
                HeightInFeet = 0,
                Status = "Deflated"
            }

        };
        //private object interactiveDiagnostics;

        public DinosaurModule() //: base("/dinosaur")
        {
            Get["/views/dinosaur{id}"] = parameters => dinosaur[parameters.id-1];
            Post["/dinosaur"] = parameters =>
            {
                string json = JsonConvert.SerializeObject(dinosaur);
                json = this.Bind<Dinosaur>();
                dinosaur.Add(json);
                return dinosaur.Count.GetType();
            };
        }
    }


}
