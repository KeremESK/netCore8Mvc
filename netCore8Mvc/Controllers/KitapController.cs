using Microsoft.AspNetCore.Mvc;
using netCore8Mvc.Models;



namespace NetCoreMVC4.Controllers
{
    public class KitapController : Controller
    {
        public IActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Kitap kitap)
        {

            return Content("yeni urun eklendi");
        }

        public IActionResult Index()
        {
            Kitap kitap = new Kitap();
            kitap.Id = 1;
            kitap.Ad = "Fatih Harbiye";
            kitap.Yazar = "Peyami Sefa";
            kitap.Kategori = "Roman";
            kitap.YayınEvi = "Ötüken Neşriyat";

            Kitap kitap2 = new Kitap();
            kitap2.Id = 2;
            kitap2.Ad = "A'dan Z'ye Siber Guvenlik 2";
            kitap2.Yazar = "A. Polat Can";
            kitap2.Kategori = "Pc";
            kitap2.YayınEvi = "KodLab 2";

            Kitap kitap3 = new Kitap();
            kitap3.Id = 3;
            kitap3.Ad = "A'dan Z'ye Siber Guvenlik 3";
            kitap3.Yazar = "D. Can Polat";
            kitap3.Kategori = "IOS";
            kitap3.YayınEvi = "Kodlab 3";

            List<Kitap> kitaplar = new List<Kitap>();
            kitaplar.Add(kitap);
            kitaplar.Add(kitap2);
            kitaplar.Add(kitap3);

            return View(kitaplar);
        }

    }
}