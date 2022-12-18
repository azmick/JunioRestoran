using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace JunioRestoran
{
    internal class cPersoneller
    {
        #region field
        private int _PersonelId;
        private int _PersonelGorevId;
        private string? _PersonelAd;
        private string? _PersonelSoyad;
        private string? _PersonelParola;
        private string? _PersonelKullaniciAdi;
        private bool _PersonelDurum;
        #endregion
        #region Properties
        public int PersonelId { get { return _PersonelId; } set {
                _PersonelId = value;
            } }
        public int PersonelGorevId { get { return _PersonelGorevId; } set {
                _PersonelGorevId = value;
            } }
        public string? PersonelAd { get {
                return _PersonelAd;
            } set {
                _PersonelAd = value;
            } }
        public string? PersonelSoyad { get {
                return _PersonelSoyad;
            } set {
                _PersonelSoyad = value;
            } }
        public string? PersonelParola { get {
                return _PersonelParola;
            } set {
                _PersonelParola = value;
            } }
        public string? PersonelKullaniciAdi { get {
                return _PersonelKullaniciAdi;
            } set {
                _PersonelKullaniciAdi = value;
            } }
        public bool PersonelDurum
        {
            get
            {
                return _PersonelDurum;
            }
            set
            {
                _PersonelDurum = value;
            }
        }
        #endregion

        cGenel gnl = new cGenel();
        public bool personelEntryControl(string password, int UserId)
        { 
            bool result = false;

            NpgsqlConnection baglantipersoneller = new NpgsqlConnection(gnl.baglanti);
            NpgsqlCommand komut = new NpgsqlCommand("Select * from personel where personelid=@id and parola=@password ", baglantipersoneller);
            komut.Parameters.Add("@id", NpgsqlDbType.Varchar).Value = UserId;
            komut.Parameters.Add("@password", NpgsqlDbType.Varchar).Value = password;

            try
            {
                if (baglantipersoneller.State == ConnectionState.Closed)
                {
                    baglantipersoneller.Open();
                }
                result = Convert.ToBoolean(komut.ExecuteScalar());
            }
            catch (NpgsqlException ex)
            {
                string hata = ex.Message;
                throw;
            }
            return result ;
            
        }
        public void personelGetbyInformation(ComboBox cb)
        {
            cb.Items.Clear();
            NpgsqlConnection baglantipersoneller = new NpgsqlConnection(gnl.baglanti);
            NpgsqlCommand komut = new NpgsqlCommand("Select * from personel", baglantipersoneller);

            if (baglantipersoneller.State == ConnectionState.Closed)
            {
                baglantipersoneller.Open();
            }
            NpgsqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cPersoneller p = new cPersoneller();
                p._PersonelId = Convert.ToInt32(dr["personelid"]);
                p._PersonelGorevId = Convert.ToInt32(dr["gorevid"]);
                p._PersonelAd = Convert.ToString(dr["personelad"]);
                p._PersonelSoyad = Convert.ToString(dr["personelsoyad"]);
                p._PersonelParola = Convert.ToString(dr["parola"]);
                p._PersonelKullaniciAdi = Convert.ToString(dr["kullaniciadi"]);
                p._PersonelDurum = Convert.ToBoolean(dr["personeldurum"]);
                cb.Items.Add(p);
            }
            dr.Close();
            baglantipersoneller.Close();
        }
    }
}
