using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using DigitalLibrary.DataAccess.Models;
using Microsoft.Ajax.Utilities;

namespace DigitalLibrary.WebServices.Controllers
{
    public class LibaryEntitiesController : ApiController
    {
        

        // GET: api/LibaryEntities
        public IEnumerable<LibraryEntityDTO> GetLibaryEntity()
        {
            using(LibraryEntities db = new LibraryEntities())
            {
                IEnumerable<LibraryEntityDTO> LibaryEntitys = db.LibaryEntity.Include(x => x.Type).Include(x => x.Category).ToList().Select(b => new LibraryEntityDTO(b));

                return LibaryEntitys;
            }
            
        }

        // GET: api/LibaryEntities/5
        [ResponseType(typeof(LibaryEntity))]
        public IHttpActionResult GetLibaryEntity(int id)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                var LibaryEntity = new LibraryEntityDTO(db.LibaryEntity.Include(x => x.Type).Include(x => x.Category).SingleOrDefault(x=>x.ID == id));

                return Ok(LibaryEntity);
            }
            
        }

        // PUT: api/LibaryEntities/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLibaryEntity(int id, LibaryEntity libaryEntity)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                if (!ModelState.IsValid)
                {
                return BadRequest(ModelState);
                }

                if (id != libaryEntity.ID)
                {
                return BadRequest();
                }

                db.Entry(libaryEntity).State = EntityState.Modified;

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (db.LibaryEntity.Include(x => x.Type).Include(x => x.Category).SingleOrDefault(x => x.ID == id)== null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return StatusCode(HttpStatusCode.NoContent);
             }
        }

        // POST: api/LibaryEntities
        [ResponseType(typeof(LibaryEntity))]
        public IHttpActionResult PostLibaryEntity(LibaryEntity libaryEntity)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }


                db.LibaryEntity.Add(libaryEntity);
                try
                {
                    db.SaveChanges();
                }
                catch(DbUpdateException )
                {
                    StatusCode(HttpStatusCode.Forbidden);
                }


                return CreatedAtRoute("DefaultApi", new { id = libaryEntity.ID }, libaryEntity);
            }
        }
        
        // DELETE: api/LibaryEntities/5
        [ResponseType(typeof(LibaryEntity))]
        public IHttpActionResult DeleteLibaryEntity(int id)
        {
            using (LibraryEntities db = new LibraryEntities())
            {
                LibaryEntity libaryEntity = db.LibaryEntity.Find(id);
                if (libaryEntity == null)
                {
                    return NotFound();
                }

                db.LibaryEntity.Remove(libaryEntity);
                db.SaveChanges();

                return Ok(libaryEntity);
            }
        }

        /*protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LibaryEntityExists(int id)
        {
            return db.LibaryEntity.Count(e => e.ID == id) > 0;
        }*/
    }
}