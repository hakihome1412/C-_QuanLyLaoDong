using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entities;

namespace BLL
{
    public class PhongBanBLL
    {
        QLLaoDongDataContext db;

        public PhongBanBLL()
        {
            db = new QLLaoDongDataContext();
        }

        public List<ePhongBan> getAllPhongBan()
        {
            List<PhongBan> list = db.PhongBans.ToList();
            List<ePhongBan> eList = new List<ePhongBan>();

            foreach (PhongBan item in list)
            {
                ePhongBan e = new ePhongBan(item.idPhongBan,item.tenPhongBan);
                eList.Add(e);
            }

            return eList;
        }

        public ePhongBan getPhongBanById(string id)
        {
            PhongBan aa = db.PhongBans.Where(p => p.idPhongBan == id).SingleOrDefault();

            ePhongBan a = new ePhongBan(aa.idPhongBan, aa.tenPhongBan);

            return a;
        }
    }
}
