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
    public class AssetController : ApiController
    {
        private RBSAssetTrackerEntities db = new RBSAssetTrackerEntities();


        // GET api/Asset/5
        public assetDTO Getasset(int id)
        {
            asset asset = db.assets.Single(a => a.id == id);
            if (asset == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return asset.toDTO();
        }

        // PUT api/Asset/5
        public HttpResponseMessage Putasset(int id, asset asset)
        {
            if (ModelState.IsValid && id == asset.id)
            {
                db.assets.Attach(asset);
                db.ObjectStateManager.ChangeObjectState(asset, EntityState.Modified);

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

        // POST api/Asset
        public HttpResponseMessage Postasset(asset asset)
        {
            if (ModelState.IsValid)
            {
                db.assets.AddObject(asset);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, asset);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = asset.id }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }

        // DELETE api/Asset/5
        public HttpResponseMessage Deleteasset(int id)
        {
            asset asset = db.assets.Single(a => a.id == id);
            if (asset == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.assets.DeleteObject(asset);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, asset);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}