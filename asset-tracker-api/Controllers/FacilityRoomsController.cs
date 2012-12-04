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
    public class FacilityRoomsController : ApiController
    {
        private RBSAssetTrackerEntities db = new RBSAssetTrackerEntities();

        // GET api/facilityrooms/5
        public IEnumerable<roomDTO> Get(int id)
        {
            List<roomDTO> room_list = new List<roomDTO>();
            foreach (room aRoom in db.rooms.Where(r => r.facility_id == id))
            {
                room_list.Add(aRoom.toDTO());
            }
            return room_list;
        }
    }
}
