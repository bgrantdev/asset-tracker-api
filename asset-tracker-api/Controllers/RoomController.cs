using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using asset_tracker_api.Models;
using AssetTracker.DTO;

namespace asset_tracker_api.Controllers
{
    //[BasicHttpAuthorize]
    public class RoomController : ApiController
    {
        private RBSAssetTrackerEntities db = new RBSAssetTrackerEntities();

        // GET api/Room/5
        public roomDTO Getroom(int id)
        {
            room room = db.rooms.Single(r => r.id == id);
            if (room == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return room.toDTO();
        }

        // PUT api/Room/5
        public HttpResponseMessage Putroom(int id, room room)
        {
            if (ModelState.IsValid && id == room.id)
            {
                db.rooms.Attach(room);
                db.ObjectStateManager.ChangeObjectState(room, EntityState.Modified);

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // POST api/Room
        public HttpResponseMessage Postroom(room room)
        {
            if (ModelState.IsValid)
            {
                db.rooms.AddObject(room);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, room);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = room.id }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Room/5
        public HttpResponseMessage Deleteroom(int id)
        {
            room room = db.rooms.Single(r => r.id == id);
            if (room == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.rooms.DeleteObject(room);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, room);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}