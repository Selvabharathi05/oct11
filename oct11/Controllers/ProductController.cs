using Microsoft.AspNetCore.Mvc;
using oct11.Models;



namespace oct11.Controllers
{
    public class ProductController : Controller
    {
        private readonly ITransientInterface _transientservice1;
        private readonly ITransientInterface _transientservice2;
        private readonly ITransientInterface _transientservice3;


        public ProductController(ITransientInterface t1, ITransientInterface t2, ITransientInterface t3)
        {

            _transientservice1 = t1;
            _transientservice2 = t2;
            _transientservice1 = t3;


        }



        static List<Product> ProdList = new List<Product>();
        static ProductController()
        {
            ProdList.Add(new Product { Prodid = 1, Prodname = "Goodday", Count = 100, MfgDate = new DateTime(2022, 05, 03) });

            ProdList.Add(new Product { Prodid = 2, Prodname = "Oreo", Count = 200, MfgDate = new DateTime(2022, 06, 21) });
            ProdList.Add(new Product { Prodid = 3, Prodname = "Tiger", Count = 150, MfgDate = new DateTime(2022, 03, 01) });

        }
        public IActionResult Index1()
        {
            return View(ProdList);
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Product model)
        {
            ProdList.Add(model);
            return RedirectToAction("Index");
        }


        public ActionResult Edit(int id)
        {
            Product foundData = ProdList.Find(Product => Product.Prodid == id);


            return View(foundData);
        }


        [HttpPost]
        public ActionResult Edit(int id, Product m)
        {
            Product foundData = ProdList.Find(Product => Product.Prodid == id);
            ProdList.Remove(foundData);
            ProdList.Add(m);
            return RedirectToAction("Index");

        }


        public ActionResult Delete(int id)
        {
            Product foundData = ProdList.Find(Product => Product.Prodid == id);
            return View(foundData);
        }


        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            Product foundData = ProdList.Find(Product => Product.Prodid == id);
            ProdList.Remove(foundData);
            return View(foundData);
        }
    }
}
