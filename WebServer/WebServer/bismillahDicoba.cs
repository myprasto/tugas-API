/*using System.Linq;
using WebServer.models;
using Nancy;
using Nancy.Hosting.Self;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WebServer
{
    public class bismillahDicoba : NancyModule
    {
        public bismillahDicoba ()
        {
            Get["/views/dinosaur"] =  parameters =>
            {
                return View["staticview", this.Request.Url];
            };

            //Get("/", args =>
            //{
            //    return View["staticview", this.Request.Url];
            //});

            Get["/views/dinosaur/testing"] = parameters =>
            {
                return View["staticview", this.Request.Url];
            };

            Get["/views/dinosaur/fileupload"] = parameters =>
            {
                var model = new WebServer.models.models() { Name = "The First Scholar of Sin" };

                return View["fileupload", model];
            };

            Post["/views/dinosaur/fileupload"] = parameters =>
            {
                var model = new WebServer.models.models() { Name = "The First Scholar of Sin" };

                var file = this.Request.Files.FirstOrDefault();
                string fileDetails = "None";

                if (file != null)
                {
                    fileDetails = string.Format("{3} - {0} ({1}) {2}bytes", file.Name, file.ContentType, file.Value.Length, file.Key);
                }

                model.Posted = fileDetails;

                return View["fileupload", model];
            };
        }
    }
}*/
