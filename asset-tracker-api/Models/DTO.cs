using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssetTracker.DTO
{
    public class facilityDTO
    {
        public Int32 id { get; set; }
        public Int32 address_id { get; set; }
        public String name { get; set; }
        public DateTime add_date { get; set; }
        public Int32 room_count { get; set; }
        public Int32 asset_count { get; set; }
    }

    public class addressDTO
    {
        public Int32 id { get; set; }
        public String line_1 { get; set; }
        public String line_2 { get; set; }
        public String city { get; set; }
        public String state { get; set; }
        public String zip { get; set; }
    }

    public class roomDTO
    {
        public Int32 id { get; set; }
        public Int32 facility_id { get; set; }
        public String name { get; set; }
        public DateTime add_date { get; set; }
    }

    public class assetDTO
    {
        public Int32 id { get; set; }
        public Int32 facility_id { get; set; }
        public Int32 room_id { get; set; }
        public String name { get; set; }
        public String sku { get; set; }
        public String description { get; set; }
        public String add_date { get; set; }
        public String last_scan  { get; set; }
    }
}