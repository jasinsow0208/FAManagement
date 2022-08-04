namespace FixedAssetManagement.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EFFixedAsset : DbContext
    {
        public EFFixedAsset() : base("name=EFFixedAsset")
        {
        }

        public DbSet<FixedAsset> FixedAssets { get; set; }

    }
}
