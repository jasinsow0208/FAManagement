using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FixedAssetManagement.Models
{
    public class FixedAsset
    {
        public int FixedAssetId { get; set; }
        public string FixedAssetCode { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int Amount { get; set; }
        public DateTime PUrchaseDate { get; set; }
    }
}