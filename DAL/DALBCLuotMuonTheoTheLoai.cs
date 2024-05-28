using DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALBCLuotMuonTheoTheLoai
    {
        private static DALBCLuotMuonTheoTheLoai instance;

        public static DALBCLuotMuonTheoTheLoai Instance
        {
            get
            {
                if (instance == null) instance = new DALBCLuotMuonTheoTheLoai();
                return instance;
            }
            set => instance = value;
        }

        public List<BCLUOTMUONTHEOTHELOAI> GetAllBaoCao()
        {
            return QLTVDb.Instance.BCLUOTMUONTHEOTHELOAIs.AsNoTracking().ToList();
        }

        public BCLUOTMUONTHEOTHELOAI GetBaoCaoById(int id)
        {
            return QLTVDb.Instance.BCLUOTMUONTHEOTHELOAIs.Find(id);
        }

        public BCLUOTMUONTHEOTHELOAI GetBaoCaoByMa (string ma)
        {
            var res = QLTVDb.Instance.BCLUOTMUONTHEOTHELOAIs.Where(b => b.MaBaoCao == ma).AsNoTracking();
            return (res.Any() ? res.First() : null);
        }

        public List<BCLUOTMUONTHEOTHELOAI> FindBaoCaoByDate(int? thang, int? nam)
        {
            var res = GetAllBaoCao();
            if (thang != null) res = res.Where(b => b.Thang == thang).ToList();
            if (nam != null) res = res.Where(b => b.Nam == nam).ToList();
            return res;
        }
        /// <summary>
        /// Notes: When added BC and its all CT_BCs, you need to call Compute(id) function to compute their values
        /// </summary>
        /// <param name="thang"></param>
        /// <param name="nam"></param>
        /// <returns></returns>
        public int AddBaoCao (int thang, int nam)
        {
            /*            try
                        {


                            var bc = new BCLUOTMUONTHEOTHELOAI
                            {
                                Thang = thang,
                                Nam = nam,
                                TongSoLuotMuon = 0,
                            };
                            QLTVDb.Instance.BCLUOTMUONTHEOTHELOAIs.Add(bc);
                            QLTVDb.Instance.SaveChanges();

                            return bc.id;
                        }*/
            try
            {
                var bc = new BCLUOTMUONTHEOTHELOAI
                {
                    Thang = thang,
                    Nam = nam
                };
                QLTVDb.Instance.BCLUOTMUONTHEOTHELOAIs.Add(bc);
                QLTVDb.Instance.SaveChanges();

                // Now that the BaoCao entity is added to the database, you can access its id
                int newBaoCaoId = bc.id;

                // Compute TongSoLuotMuon using the newly obtained id
                Compute(newBaoCaoId);

                return newBaoCaoId;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return -1;
            }
        }

        /// <summary>
        /// this function will recompute TongSoLuotMuon for BaoCao and TiLe for each CT_BaoCao
        /// </summary>
        /// <param name="id"></param>
        public bool Compute(int id)
        {
            var bc = GetBaoCaoById(id);
            if (bc == null) return false;
            int sum = 0;

            // Compute TongSoLuotMuon
            foreach (var ct in bc.CT_BCLUOTMUONTHEOTHELOAI)
            {
                sum += (int)ct.SoLuotMuon;
            }
            bc.TongSoLuotMuon = sum;

            // Compute TiLe for each CT_BC
            foreach (var ct in bc.CT_BCLUOTMUONTHEOTHELOAI)
            {
                if (sum != 0) ct.TiLe = (decimal)ct.SoLuotMuon / sum;
                else ct.TiLe = 0;
            }
            QLTVDb.Instance.SaveChanges();
            return true;
        }

        /*        public bool DelBaoCao(int id)
                {
                    try
                    {
                        var bc = GetBaoCaoById(id);
                        if (bc == null) return false;

                        QLTVDb.Instance.BCLUOTMUONTHEOTHELOAIs.Remove(bc);
                        QLTVDb.Instance.SaveChanges();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.InnerException.ToString());
                        return false;
                    }
                }*/
        public bool DelBaoCao(int id)
        {
            try
            {
                var bc = GetBaoCaoById(id);
                if (bc == null) return false;

                // Delete related records in the child table first
                var relatedRecords = QLTVDb.Instance.CT_BCLUOTMUONTHEOTHELOAI.Where(ct => ct.idBaoCao == id);
                QLTVDb.Instance.CT_BCLUOTMUONTHEOTHELOAI.RemoveRange(relatedRecords);

                // Then delete the parent record
                QLTVDb.Instance.BCLUOTMUONTHEOTHELOAIs.Remove(bc);
                QLTVDb.Instance.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                return false;
            }
        }

    }
}
