using Foodbuffet.RealPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace Foodbuffet.RealPortal.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Menu()
        {
            List<MenuViewModel> products = new List<MenuViewModel>();

            MenuViewModel product1 = new MenuViewModel();
            product1.ImagePath = "../images/chimmi-makis-main-image-foodbuffet-x-webflow-template.jpg";
            product1.Price = "$99.9";
            product1.ProductName = "Chimmi Makis";
            product1.Description = "Lorem ipsupm dolor sit amet, conse ctetur adipisicing elit, sed do eiumthgtipsupm dolor sit amet conse";

            products.Add(product1);


            MenuViewModel product2 = new MenuViewModel();
            product2.ImagePath = "../images/migiri-sushi-main-image-foodbuffet-x-webflow-template.jpg";
            product2.Price = "$10.99";
            product2.ProductName = "Migiri Sushi";
            product2.Description = "Lorem ipsupm dolor sit amet, conse ctetur adipisicing elit, sed do eiumthgtipsupm dolor sit amet conse";

            products.Add(product2);


            MenuViewModel product3 = new MenuViewModel();
            product3.ImagePath = "../images/migiri-sushi-main-image-foodbuffet-x-webflow-template.jpg";
            product3.Price = "$11.99";
            product3.ProductName = "Togarashi Makis";
            product3.Description = "Lorem ipsupm dolor sit amet, conse ctetur adipisicing elit, sed do eiumthgtipsupm dolor sit amet conse";

            products.Add(product3);


            MenuViewModel product4 = new MenuViewModel();
            product4.ImagePath = "../images/salmon-roll-main-image-foodbuffet-x-webflow-template.jpg";
            product4.Price = "$12.99";
            product4.ProductName = "Salmon Roll";
            product4.Description = "Lorem ipsupm dolor sit amet, conse ctetur adipisicing elit, sed do eiumthgtipsupm dolor sit amet conse";

            products.Add(product4);


            MenuViewModel product5 = new MenuViewModel();
            product5.ImagePath = "../images/tuna-poke-bowl-main-image-foodbuffet-x-webflow-template.jpg";
            product5.Price = "$10.99";
            product5.ProductName = "Tuna Poke Bowl";
            product5.Description = "Lorem ipsupm dolor sit amet, conse ctetur adipisicing elit, sed do eiumthgtipsupm dolor sit amet conse";

            products.Add(product5);


            MenuViewModel product6 = new MenuViewModel();
            product6.ImagePath = "../images/sardine-stew-main-image-foodbuffet-x-webflow-template.jpg";
            product6.Price = "$12.99";
            product6.ProductName = "Sardine Stew";
            product6.Description = "Lorem ipsupm dolor sit amet, conse ctetur adipisicing elit, sed do eiumthgtipsupm dolor sit amet conse";

            products.Add(product6);


            MenuViewModel product7 = new MenuViewModel();
            product7.ImagePath = "../images/vegetarian-ramen-main-image-foodbuffet-x-webflow-template.jpg";
            product7.Price = "$11.99";
            product7.ProductName = "Vegetarian Ramen";
            product7.Description = "Lorem ipsupm dolor sit amet, conse ctetur adipisicing elit, sed do eiumthgtipsupm dolor sit amet conse";

            products.Add(product7);


            MenuViewModel product8 = new MenuViewModel();
            product8.ImagePath = "../images/vegetarian-soup-main-image-foodbuffet-x-webflow-template.jpg";
            product8.Price = "$11.99";
            product8.ProductName = "Vegetarian Soup";
            product8.Description = "Lorem ipsupm dolor sit amet, conse ctetur adipisicing elit, sed do eiumthgtipsupm dolor sit amet conse";

            products.Add(product8);

            return View(products);
        }
    }
}
