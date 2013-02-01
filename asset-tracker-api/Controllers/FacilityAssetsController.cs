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
        public IEnumerable<facilityAssetDTO> Get(int id)
        {
            List<facilityAssetDTO> asset_list = new List<facilityAssetDTO>();
            foreach (asset aAsset in db.assets.Where(a => a.facility_id == id))
            {
                facilityAssetDTO asset = new facilityAssetDTO();
                asset.id = aAsset.id;
                asset.name = aAsset.name;
                asset.sku = aAsset.sku;
                room asset_room = db.rooms.Single(r => r.id == aAsset.room_id);
                asset.room_name = asset_room.name;
                asset_list.Add(asset);
            }
            return asset_list;
        }
    }
}
