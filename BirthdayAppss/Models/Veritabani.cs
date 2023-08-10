using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace BirthdayAppss.Models
{
    public static class Veritabani
    {
        private static Dictionary<string, DavetiyeModel> _liste;
        static Veritabani()
        {
            _liste = new Dictionary<string, DavetiyeModel>();
            _liste.Add("Kubilay", new DavetiyeModel
            {
                Ad = "Hasan",
                Eposta = "hasan@gmail.com",
                KatilmaDurumu = false
            });
            _liste.Add("Şeyma", new DavetiyeModel
            {
                Ad = "Şeyma",
                Eposta = "şeyma@gmail.com",
                KatilmaDurumu = true
            });
            _liste.Add("Esma", new DavetiyeModel
            {
                Ad = "Esma",
                Eposta = "Esma@gmail.com",
                KatilmaDurumu = true
            });
            _liste.Add("Elif", new DavetiyeModel
            {
                Ad = "Elif",
                Eposta = "Elif@gmail.com",
                KatilmaDurumu = true
            });
        }
        public static void Add(DavetiyeModel model)
        {
            string key = model.Ad.ToLower();
            if(_liste.ContainsKey(key))
            {
                _liste[key] = model;
            }
            else
            {
                _liste.Add(key, model);
            }
        }
        public static IEnumerable<DavetiyeModel>Liste
        {
            get { return _liste.Values; }
        }
    }
}