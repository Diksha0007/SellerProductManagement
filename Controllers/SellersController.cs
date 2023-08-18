using Microsoft.AspNetCore.Mvc;
using SellerProductManagement.Models;
using ShoppingHub.Data;
using ShoppingHub.Models;
using static SellerProductManagement.Models.WishListItems;

namespace ShoppingHub.Controllers
{
    public class SellersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private const string StaticUserName = "Diksha123";
        private const string StaticUserPassword = "Password";
        public SellersController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Dashboard()
        {

            
            var List = _context.Product.ToList();


            return View(List);
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Login(Login Logins)
        {
            if (Logins.Username == StaticUserName && Logins.Password == StaticUserPassword)
            {
                return RedirectToAction("Dashboard");
            }
            else
            {
                var ErrorMessage = "Invalid Username Or Password";
            }
            return View();

        }
        [HttpGet]
        public IActionResult Register()
        {
            
            return View();

        }
        [HttpPost]
        public IActionResult Register(Seller sellers)
        {
            if (sellers.Password == sellers.ConfirmPassword)
            {
                _context.Sellers.Add(sellers);
            }
            
            _context.SaveChanges();
            return RedirectToAction("Dashboard");

        }


       


            [HttpGet]
        public IActionResult Create()
        {

            return View();

        }
        [HttpPost]
        public ActionResult Create(Product Product)
        {
            //try
            //{
            //    var AddData = new Product
            //    {
            //        ProductName = p,
            //        Description = d,


            //    };

            _context.Product.Add(Product);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");

            //}
            //catch (Exception ex)
            //{


            //    return Json(new { Status = "Error", Message = ex.Message });

            //}
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var E = _context.Product.Find(id);

            return View(E);

        }

        [HttpPost]
        public IActionResult Edit(Product p)
        {
            _context.Product.Update(p);
            _context.SaveChanges();
            return RedirectToAction("DashBoard");

        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var E = _context.Product.Find(id);

            return View(E);

        }
        [HttpPost]
        public IActionResult Delete(Product p)
        {
            _context.Product.Update(p);
            _context.SaveChanges();
            return RedirectToAction("DashBoard");

        }
        [HttpGet]
        public IActionResult WishList()
        {
            

            return View();

        }
  

            [HttpPost]
            public IActionResult AddToWishlist(int productId)
            {
                
                var userId = "user123";

              
                var existingItem = _context.WishlistItems
                    .FirstOrDefault(item => item.UserId == userId && item.ProductId == productId);

                if (existingItem == null)
                {
                    var wishlistItem = new WishlistItem
                    {
                        UserId = userId,
                        ProductId = productId
                    };

                    _context.WishlistItems.Add(wishlistItem);
                    _context.SaveChanges();
                }

                return Json(new { success = true });
            }
        }










    }

