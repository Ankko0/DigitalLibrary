using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalLibrary.DataAccess.Models
{
    public class LibraryEntityDTO
    {
        public LibraryEntityDTO(LibaryEntity entity)
        {
            this.ID = entity.ID;
            this.Name = entity.Name;
            this.Author = entity.Author;
            this.Code = entity.Code;
            this.Pages = entity.Pages;
            this.Year = entity.Year;
            this.Photo = entity.Photo;
            this.Language = entity.Language;
            this.Type = entity.Type.ToString();
            this.Category = entity.Category.ToString();
        }

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
    }
}
