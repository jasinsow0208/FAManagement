using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using FixedAssetManagement.Models;


namespace FixedAssetManagement.Controllers
{
    [EnableCors(origins: "http://jasinsowandi-001-site5.btempurl.com", headers: "*", methods: "*")]
    public class ValuesController : ApiController
    {
        EFFixedAsset db = new EFFixedAsset();

        // GET api/values
        public List<FixedAsset> Get()
        {
            List<FixedAsset> fixedAssets = db.FixedAssets.OrderBy(x=>x.FixedAssetCode).ToList();
            List<FixedAsset> fa = new List<FixedAsset>();
            foreach (FixedAsset rw in fixedAssets)
            {
                FixedAsset far = new FixedAsset();
                far.Amount = rw.Amount;
                far.Description = rw.Description;
                far.Location = rw.Location;
                far.PUrchaseDate = DateTime.Parse(rw.PUrchaseDate.ToShortDateString());
                far.FixedAssetCode = rw.FixedAssetCode;
                far.FixedAssetId = rw.FixedAssetId;

                fa.Add(far);
            }

            return fa;
        }

        // GET api/values/5
        public FixedAsset Get(int id)
        {
            FixedAsset fa = db.FixedAssets.Find(id);
            fa.PUrchaseDate = DateTime.Parse(fa.PUrchaseDate.ToShortDateString());
            return fa;
        }

        // POST api/values
        public void Post(string FixedAssetCode, string Description, string Location, string Amount, string PurchaseDate)
        {
            FixedAsset fa = new FixedAsset();
            fa.Amount = int.Parse(Amount);
            fa.FixedAssetCode = FixedAssetCode;
            fa.Description = Description;
            fa.Location = Location;
            fa.PUrchaseDate = DateTime.Parse(PurchaseDate);

            db.FixedAssets.Add(fa);
            db.SaveChanges();
        }

        // POST for update
        public void Post(int id, string FixedAssetCode, string Description, string Location, string Amount, string PurchaseDate)
        {
            FixedAsset fa = db.FixedAssets.Find(id);
            fa.FixedAssetCode = FixedAssetCode;
            fa.Description = Description;
            fa.Location = Location;
            fa.Amount = int.Parse(Amount);
            fa.PUrchaseDate = DateTime.Parse(PurchaseDate);

            db.Entry(fa).State = EntityState.Modified;
            db.SaveChanges();
        }

        //POST for Delete
        public void Post(int id)
        {
            FixedAsset fa = db.FixedAssets.Find(id);
            db.Entry(fa).State = EntityState.Deleted;
            db.SaveChanges();
        }

        // PUT api/values/5
        public void Put(int id, string FixedAssetCode, string Description, string Location, string Amount, string PurchaseDate)
        {
            FixedAsset fa = db.FixedAssets.Find(id);
            fa.FixedAssetCode = FixedAssetCode;
            fa.Description = Description;
            fa.Location = Location;
            fa.Amount = int.Parse(Amount);
            fa.PUrchaseDate = DateTime.Parse(PurchaseDate);

            db.Entry(fa).State = EntityState.Modified;
            db.SaveChanges();
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            FixedAsset fa = db.FixedAssets.Find(id);
            db.Entry(fa).State = EntityState.Deleted;
            db.SaveChanges();
        }
    }
}
