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
    public class RoomAssetsController : ApiController
    {
        private RBSAssetTrackerEntities db = new RBSAssetTrackerEntities();

        // GET api/roomassets/5
        public IEnumerable<assetDTO> Get(int id)
        {
            List<assetDTO> asset_list = new List<assetDTO>();
            foreach (asset aAsset in db.assets.Where(a => a.room_id == id))
            {
                asset_list.Add(aAsset.toDTO());
            }
            return asset_list;
        }
    }
}
