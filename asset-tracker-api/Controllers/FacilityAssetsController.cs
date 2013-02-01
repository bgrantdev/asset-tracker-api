using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using asset_tracker_api.Models;
using AssetTracker.DTO;

namespace asset_tracker_api.Controllers
{
    //[BasicHttpAuthorize]
    public class FacilityAssetsController : ApiController
    {
        private RBSAssetTrackerEntities db = new RBSAssetTrackerEntities();

        // GET api/FacilityAssets/5
        public IEnumerable<assetDTO> Get(int id)
        {
            List<assetDTO> asset_list = new List<assetDTO>();
            foreach (asset aAsset in db.assets.Where(a => a.facility_id == id))
            {
                asset_list.Add(aAsset.toDTO());
            }
            return asset_list;
        }
    }
}
