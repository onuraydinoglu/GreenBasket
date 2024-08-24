using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GreenBasket.Models;

namespace GreenBasket.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        /*var category = new Category();
        category.CategoryId = 1;
        category.CategoryName = "Dairy, Bread & Eggs";
        category.CategoryImage = "dairy-bread-eggs.jpg";*/

        var categories = new List<Category>(){
            new Category() {CategoryId = 1, CategoryName = "Dairy, Bread & Eggs", CategoryImage ="dairy-bread-eggs.jpg"},
            new Category() {CategoryId = 2, CategoryName = "Snack, Munchie", CategoryImage ="snack-munchies.jpg"},
            new Category() {CategoryId = 3, CategoryName = "Bakery Biscuits", CategoryImage ="bakery-biscuits.jpg"},
            new Category() {CategoryId = 4, CategoryName = "Instant Food", CategoryImage ="instant-food.jpg"},
            new Category() {CategoryId = 5, CategoryName = "Tea, Coffee & Drinks", CategoryImage ="tea-coffee-drinks.jpg"},
            new Category() {CategoryId = 6, CategoryName = "Chicken, Meat & Fish", CategoryImage ="chicken-meat-fish.jpg"},
            new Category() {CategoryId = 7, CategoryName = "Chicken, Meat & Fish", CategoryImage ="chicken-meat-fish.jpg"},
            new Category() {CategoryId = 8, CategoryName = "Cleaning Essentials", CategoryImage ="cleaning-essentials.jpg"},
            new Category() {CategoryId = 9, CategoryName = "Baby Care", CategoryImage ="baby-care.jpg"},
            new Category() {CategoryId = 10, CategoryName = "Pet Care", CategoryImage ="pet-care.jpg"},
            new Category() {CategoryId = 11, CategoryName = "Atta, Rice & Dal", CategoryImage ="atta-rice-dal.jpg"},
            new Category() {CategoryId = 12, CategoryName = "Atta, Rice & Dal", CategoryImage ="atta-rice-dal.jpg"},
        };

        var products = new List<Product>(){
            new Product() {ProductId = 1, ProductName = "Haldiram's Sev Bhujia", ProductImage = "product-img-1.jpg", CategoryName = "Snack, Munchie", ProductPrice = 24},
            new Product() {ProductId = 2, ProductName = "NutriChoice Digestive", ProductImage = "product-img-2.jpg", CategoryName = "Bakery & Biscuits", ProductPrice = 24},
            new Product() {ProductId = 3, ProductName = "Cadbury 5 Star Chocolate", ProductImage = "product-img-3.jpg", CategoryName = "Bakery & Biscuits", ProductPrice = 24},
            new Product() {ProductId = 4, ProductName = "Onion Flavour Potato", ProductImage = "product-img-4.jpg", CategoryName = "Snack, Munchie", ProductPrice = 24},
            new Product() {ProductId = 5, ProductName = "Salted Instant Popcorn", ProductImage = "product-img-5.jpg", CategoryName = "Instant Food", ProductPrice = 24},
            new Product() {ProductId = 6, ProductName = "Blueberry Greek Yogurt", ProductImage = "product-img-6.jpg", CategoryName = "Dairy, Bread & Eggs", ProductPrice = 24},
            new Product() {ProductId = 7, ProductName = "Britannia Cheese Slices", ProductImage = "product-img-7.jpg", CategoryName = "Dairy, Bread & Eggs", ProductPrice = 24},
            new Product() {ProductId = 8, ProductName = "Kellogg's Original Cereals", ProductImage = "product-img-8.jpg", CategoryName = "Instant Food", ProductPrice = 24},
            new Product() {ProductId = 9, ProductName = "Slurrp Millet Chocolate", ProductImage = "product-img-9.jpg", CategoryName = "Snack, Munchie", ProductPrice = 24},
            new Product() {ProductId = 10, ProductName = "Amul Butter - 500 g", ProductImage = "product-img-10.jpg", CategoryName = "Dairy, Bread & Eggs", ProductPrice = 24}
        };

        var viewModel = new HomeViewModel
        {
            Categories = categories,
            Products = products
        };

        return View(viewModel);

    }
}
