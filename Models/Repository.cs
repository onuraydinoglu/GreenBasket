namespace GreenBasket.Models
{
    public class Repository
    {
        private static readonly List<Category> _categories = new();
        private static readonly List<SubCategory> _subcategories = new();
        private static readonly List<Product> _products = new();
        private static readonly List<Store> _stores = new();

        static Repository()
        {
            _categories = new List<Category>()
            {
                new Category() {CategoryId = 1, CategoryName = "Dairy, Bread & Eggs", CategoryImage ="dairy-bread-eggs.jpg", CategoryUrl="dairy-bread-eggs"},
                new Category() {CategoryId = 2, CategoryName = "Snack, Munchie", CategoryImage ="snack-munchies.jpg", CategoryUrl="snack-munchie"},
                new Category() {CategoryId = 3, CategoryName = "Fruits & Vegetables", CategoryImage ="bakery-biscuits.jpg", CategoryUrl="fruits-vegetables"},
                new Category() {CategoryId = 4, CategoryName = "Cold Drinks & Juices", CategoryImage ="instant-food.jpg", CategoryUrl="cold-drinks-juices"},
                new Category() {CategoryId = 5, CategoryName = "Breakfast & Instant Food", CategoryImage ="tea-coffee-drinks.jpg", CategoryUrl="Breakfast-instant-food"},
                new Category() {CategoryId = 6, CategoryName = "Bakery & Biscuits", CategoryImage ="bakery-biscuits.jpg", CategoryUrl="bakery-biscuits"},
                new Category() {CategoryId = 7, CategoryName = "Chicken, Meat & Fish", CategoryImage ="chicken-meat-fish.jpg", CategoryUrl="chicken-meat-fish"}
            };

            _subcategories = new List<SubCategory>()
            {
                new SubCategory() {SubCategoryId = 1, SubCategoryName = "Milk", CategoryId = 1 },
                new SubCategory() {SubCategoryId = 2, SubCategoryName = "Milk Drinks", CategoryId = 1 },
                new SubCategory() {SubCategoryId = 3, SubCategoryName = "Eggs", CategoryId = 1 },
                new SubCategory() {SubCategoryId = 4, SubCategoryName = "Bread", CategoryId = 1 },
                new SubCategory() {SubCategoryId = 5, SubCategoryName = "Buns & Bakery", CategoryId = 1 },
                new SubCategory() {SubCategoryId = 6, SubCategoryName = "Butter & More", CategoryId = 1 },
                new SubCategory() {SubCategoryId = 7, SubCategoryName = "Cheese", CategoryId = 1 },
                new SubCategory() {SubCategoryId = 8, SubCategoryName = "Paneer & Tofu", CategoryId = 1 },
                new SubCategory() {SubCategoryId = 9, SubCategoryName = "Cream & Whitener", CategoryId = 1 },
                new SubCategory() {SubCategoryId = 10, SubCategoryName = "Condensed Milk", CategoryId = 1 },
                new SubCategory() {SubCategoryId = 11, SubCategoryName = "Vegan Drinks", CategoryId = 1 },

                new SubCategory() {SubCategoryId = 12, SubCategoryName = "Chips & Crisps", CategoryId = 2 },
                new SubCategory() {SubCategoryId = 13, SubCategoryName = "Nachos", CategoryId = 2 },
                new SubCategory() {SubCategoryId = 14, SubCategoryName = "Popcorn", CategoryId = 2 },
                new SubCategory() {SubCategoryId = 15, SubCategoryName = "Bhujia & Mixtures", CategoryId = 2 },
                new SubCategory() {SubCategoryId = 16, SubCategoryName = "Namkeen Snacks", CategoryId = 2 },
                new SubCategory() {SubCategoryId = 17, SubCategoryName = "Healthy Snacks", CategoryId = 2 },
                new SubCategory() {SubCategoryId = 18, SubCategoryName = "Cakes & Rolls", CategoryId = 2 },
                new SubCategory() {SubCategoryId = 19, SubCategoryName = "Energy Bars", CategoryId = 2 },
                new SubCategory() {SubCategoryId = 20, SubCategoryName = "Papad & Fryums", CategoryId = 2 },
                new SubCategory() {SubCategoryId = 21, SubCategoryName = "Rusks & Wafers", CategoryId = 2 },

                new SubCategory() {SubCategoryId = 22, SubCategoryName = "Fresh Vegetables", CategoryId = 3 },
                new SubCategory() {SubCategoryId = 23, SubCategoryName = "Herbs & Seasonings", CategoryId = 3 },
                new SubCategory() {SubCategoryId = 24, SubCategoryName = "Fresh Fruits", CategoryId = 3 },
                new SubCategory() {SubCategoryId = 25, SubCategoryName = "Organic Fruits & Vegetables", CategoryId = 3 },
                new SubCategory() {SubCategoryId = 26, SubCategoryName = "Cuts & Sprouts", CategoryId = 3 },
                new SubCategory() {SubCategoryId = 27, SubCategoryName = "Exotic Fruits & Veggies", CategoryId = 3 },
                new SubCategory() {SubCategoryId = 28, SubCategoryName = "MiFlower Bouquets, Buncheslk", CategoryId = 3 },

                new SubCategory() {SubCategoryId = 29, SubCategoryName = "Soft Drinks", CategoryId = 4 },
                new SubCategory() {SubCategoryId = 30, SubCategoryName = "Fruit Juices", CategoryId = 4 },
                new SubCategory() {SubCategoryId = 31, SubCategoryName = "Coldpress", CategoryId = 4 },
                new SubCategory() {SubCategoryId = 32, SubCategoryName = "Energy Drinks", CategoryId = 4 },
                new SubCategory() {SubCategoryId = 33, SubCategoryName = "Water & Ice Cubes", CategoryId = 4 },
                new SubCategory() {SubCategoryId = 34, SubCategoryName = "Soda & Mixers", CategoryId = 4 },
                new SubCategory() {SubCategoryId = 35, SubCategoryName = "Concentrates & Syrups", CategoryId = 4 },
                new SubCategory() {SubCategoryId = 36, SubCategoryName = "Detox & Energy Drinks", CategoryId = 4 },
                new SubCategory() {SubCategoryId = 37, SubCategoryName = "Juice Collection", CategoryId = 4 },

                new SubCategory() {SubCategoryId = 38, SubCategoryName = "Batter", CategoryId = 5 },
                new SubCategory() {SubCategoryId = 39, SubCategoryName = "Breakfast Cereal", CategoryId = 5 },
                new SubCategory() {SubCategoryId = 40, SubCategoryName = "Noodles, Pasta & Soup", CategoryId = 5 },
                new SubCategory() {SubCategoryId = 41, SubCategoryName = "Frozen Non-Veg Snackss", CategoryId = 5 },
                new SubCategory() {SubCategoryId = 42, SubCategoryName = "Frozen Veg", CategoryId = 5 },
                new SubCategory() {SubCategoryId = 43, SubCategoryName = "Vermicelli", CategoryId = 5 },
                new SubCategory() {SubCategoryId = 44, SubCategoryName = "Instant Mixes", CategoryId = 5 },

                new SubCategory() {SubCategoryId = 45, SubCategoryName = "Cookies", CategoryId = 6 },
                new SubCategory() {SubCategoryId = 46, SubCategoryName = "Glucose & Marie", CategoryId = 6 },
                new SubCategory() {SubCategoryId = 47, SubCategoryName = "Sweet & Salty", CategoryId = 6 },
                new SubCategory() {SubCategoryId = 48, SubCategoryName = "Healthy & Digestive", CategoryId = 6 },
                new SubCategory() {SubCategoryId = 49, SubCategoryName = "Cream Biscuits", CategoryId = 6 },
                new SubCategory() {SubCategoryId = 50, SubCategoryName = "Rusks & Wafers", CategoryId = 6 },
                new SubCategory() {SubCategoryId = 51, SubCategoryName = "Cakes & Rolls", CategoryId = 6 },
                new SubCategory() {SubCategoryId = 52, SubCategoryName = "Buns & Bakery", CategoryId = 6 },

                new SubCategory() {SubCategoryId = 53, SubCategoryName = "Chicken", CategoryId = 7 },
                new SubCategory() {SubCategoryId = 54, SubCategoryName = "Sausage, Salami & Ham", CategoryId = 7 },
                new SubCategory() {SubCategoryId = 55, SubCategoryName = "Exotic Meat", CategoryId = 7 },
                new SubCategory() {SubCategoryId = 56, SubCategoryName = "Eggs", CategoryId = 7 },
                new SubCategory() {SubCategoryId = 57, SubCategoryName = "Frozen Non-Veg Snacks", CategoryId = 7 }
            };

            _products = new List<Product>()
            {
                new Product() {ProductId = 1, ProductName = "Haldiram's Sev Bhujia", ProductImage = "product-img-1.jpg", CategoryId = 2, ProductPrice = 24, ProductUrl="haldirams-sev-bhujia",
                Category = _categories.FirstOrDefault(c => c.CategoryId == 1)
                },
                new Product() {ProductId = 2, ProductName = "NutriChoice Digestive", ProductImage = "product-img-2.jpg", CategoryId = 6, ProductPrice = 24, ProductUrl="nutriChoice-digestive",
                Category = _categories.FirstOrDefault(c => c.CategoryId == 6)},
                new Product() {ProductId = 3, ProductName = "Cadbury 5 Star Chocolate", ProductImage = "product-img-3.jpg", CategoryId = 6, ProductPrice = 24, ProductUrl="cadbury-5-star-chocolate",
                Category = _categories.FirstOrDefault(c => c.CategoryId == 6)},
                new Product() {ProductId = 4, ProductName = "Onion Flavour Potato", ProductImage = "product-img-4.jpg", CategoryId = 2, ProductPrice = 24, ProductUrl="onion-flavour-potato",
                Category = _categories.FirstOrDefault(c => c.CategoryId == 2)},
                new Product() {ProductId = 5, ProductName = "Salted Instant Popcorn", ProductImage = "product-img-5.jpg", CategoryId = 5, ProductPrice = 24, ProductUrl="salted-instant-popcorn",
                Category = _categories.FirstOrDefault(c => c.CategoryId == 5)},
                new Product() {ProductId = 6, ProductName = "Blueberry Greek Yogurt", ProductImage = "product-img-6.jpg", CategoryId = 1, ProductPrice = 24, ProductUrl="blueberry-greek-yogurt",
                Category = _categories.FirstOrDefault(c => c.CategoryId == 1)},
                new Product() {ProductId = 7, ProductName = "Britannia Cheese Slices", ProductImage = "product-img-7.jpg", CategoryId = 1, ProductPrice = 24, ProductUrl="britannia-cheese-slices",
                Category = _categories.FirstOrDefault(c => c.CategoryId == 1)},
                new Product() {ProductId = 8, ProductName = "Kellogg's Original Cereals", ProductImage = "product-img-8.jpg", CategoryId = 5, ProductPrice = 24, ProductUrl="kelloggs-original-cereals",
                Category = _categories.FirstOrDefault(c => c.CategoryId == 5)},
                new Product() {ProductId = 9, ProductName = "Slurrp Millet Chocolate", ProductImage = "product-img-9.jpg", CategoryId = 2, ProductPrice = 24, ProductUrl="slurrp-millet-chocolate",
                Category = _categories.FirstOrDefault(c => c.CategoryId == 2)},
                new Product() {ProductId = 10, ProductName = "Amul Butter - 500 g", ProductImage = "product-img-10.jpg", CategoryId = 1, ProductPrice = 24, ProductUrl="amul-butter",
                Category = _categories.FirstOrDefault(c => c.CategoryId == 1)}
            };

            _stores = new List<Store>()
            {
                new Store() {StoreId = 1, StoreName ="E-Grocery"},
                new Store() {StoreId = 2, StoreName ="DealShare"},
                new Store() {StoreId = 3, StoreName ="DMart"},
                new Store() {StoreId = 4, StoreName ="Blinkit"},
                new Store() {StoreId = 5, StoreName ="BigBasket"},
                new Store() {StoreId = 6, StoreName ="StoreFront"},
                new Store() {StoreId = 7, StoreName ="Spencers"},
                new Store() {StoreId = 8, StoreName ="Online Grocery"}
            };
        }

        /*Category*/
        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }
        public static Category? GetByUrl(string url)
        {
            return _categories.FirstOrDefault(p => p.CategoryUrl == url);
        }

        /*SubCategory*/
        public static List<SubCategory> SubCategories
        {
            get
            {
                return _subcategories;
            }
        }

        /*Product*/
        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }
        public static Product? GetById(string url)
        {
            return _products.FirstOrDefault(p => p.ProductUrl == url);
        }


        /*Store*/
        public static List<Store> Stores
        {
            get
            {
                return _stores;
            }
        }
    }
}