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

namespace asset_tracker_api.Controllers
{
    public class AddressController : ApiController
    {
        private RBSAssetTrackerEntities db = new RBSAssetTrackerEntities();

        // GET api/Address
        public IEnumerable<address> Getaddresses()
        {
            return db.addresses.AsEnumerable();
        }

        // GET api/Address/5
        public address Getaddress(int id)
        {
            address address = db.addresses.Single(a => a.id == id);
            if (address == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return address;
        }

        // PUT api/Address/5
        public HttpResponseMessage Putaddress(int id, address address)
        {
            if (ModelState.IsValid && id == address.id)
            {
                db.addresses.Attach(address);
                db.ObjectStateManager.ChangeObjectState(address, EntityState.Modified);

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

        // POST api/Address
        public HttpResponseMessage Postaddress(address address)
        {
            if (ModelState.IsValid)
            {
                db.addresses.AddObject(address);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, address);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = address.id }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Address/5
        public HttpResponseMessage Deleteaddress(int id)
        {
            address address = db.addresses.Single(a => a.id == id);
            if (address == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.addresses.DeleteObject(address);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, address);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}