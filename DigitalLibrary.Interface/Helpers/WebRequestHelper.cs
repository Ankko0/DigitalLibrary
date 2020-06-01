using DigitalLibrary.DataAccess.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DigitalLibrary.Interface.Helpers
{
    class WebRequestHelper
    {

        public static List<LibraryEntityDTO> GetAPI(string path)

        {
            WebRequest request = WebRequest.Create(path);
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            List<LibraryEntityDTO> model = JsonConvert.DeserializeObject<List<LibraryEntityDTO>>(reader.ReadToEnd()); ;

            response.Close();
            stream.Close();
            reader.Close();


            return model;

        }
    }
}
