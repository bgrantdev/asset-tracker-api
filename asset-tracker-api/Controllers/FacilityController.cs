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
using System.Security.Principal;

namespace asset_tracker_api.Controllers
{
    [BasicHttpAuthorize]
    public class FacilityController : ApiController
    {
        private RBSAssetTrackerEntities db = new RBSAssetTrackerEntities();
        
        // GET api/Facility
        
        public IEnumerable<facilityDTO> Getfacilities()
        {
            List<facilityDTO> facility_list = new List<facilityDTO>();
            foreach (facility aFacility in db.facilities)
            {
                facility_list.Add(aFacility.toDTO());
            }
            return facility_list;
        }

        // GET api/Facility/5
        public facilityDTO Getfacility(int id)
        {
            facility facility = db.facilities.Single(f => f.id == id);
            if (facility == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return facility.toDTO();
        }

        // PUT api/Facility/5
        public HttpResponseMessage Putfacility(int id, facility facility)
        {
            if (ModelState.IsValid && id == facility.id)
            {
                db.facilities.Attach(facility);
                db.ObjectStateManager.ChangeObjectState(facility, EntityState.Modified);

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

        // POST api/Facility
        public HttpResponseMessage Postfacility(facility facility)
        {
            if (ModelState.IsValid)
            {
                db.facilities.AddObject(facility);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, facility);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = facility.id }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Facility/5
        public HttpResponseMessage Deletefacility(int id)
        {
            facility facility = db.facilities.Single(f => f.id == id);
            if (facility == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.facilities.DeleteObject(facility);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, facility);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}