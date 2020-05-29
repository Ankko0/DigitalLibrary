using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DigitalLibrary.DataAccess.Models
{
    public class LibraryEntityDTO : INotifyPropertyChanged
    {
        

        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Code { get; set; }
        public Nullable<int> Pages { get; set; }
        public Nullable<int> Year { get; set; }
        public byte[] Photo { get; set; }
        public string Language { get; set; }

        public string Type { get; set; }
        public string Category { get; set; }

        public static async Task<List<LibraryEntityDTO>> GetAPIAsync(string path)

        {
            List<LibraryEntityDTO> model = null;
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)

            {

                var request = await response.Content.ReadAsStringAsync();
                model = JsonConvert.DeserializeObject<List<LibraryEntityDTO>>(request);


            }

            return model;

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
