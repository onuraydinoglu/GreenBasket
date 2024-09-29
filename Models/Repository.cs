namespace GreenBasket.Models
{
    public class Repository
    {
        private static readonly List<Category> _categories = new();
        private static readonly List<SubCategory> _subcategories = new();
        private static readonly List<Product> _products = new();
        private static readonly List<Store> _stores = new();
        private static readonly List<Address> _address = new();

        static Repository()
        {
            _categories = new List<Category>()
            {
                new Category()
                {
                    CategoryId = 1,
                    CategoryName = "Dairy, Bread & Eggs",
                    CategoryImage = "dairy-bread-eggs.jpg",
                    CategoryUrl = "dairy-bread-eggs",
                    CategoryStatus = true
                },
                new Category()
                {
                    CategoryId = 2,
                    CategoryName = "Snack, Munchie",
                    CategoryImage = "snack-munchies.jpg",
                    CategoryUrl = "snack-munchie",
                    CategoryStatus = true
                },
                new Category()
                {
                    CategoryId = 3,
                    CategoryName = "Fruits & Vegetables",
                    CategoryImage = "bakery-biscuits.jpg",
                    CategoryUrl = "fruits-vegetables",
                    CategoryStatus = true
                },
                new Category()
                {
                    CategoryId = 4,
                    CategoryName = "Cold Drinks & Juices",
                    CategoryImage = "instant-food.jpg",
                    CategoryUrl = "cold-drinks-juices",
                    CategoryStatus = false
                },
                new Category()
                {
                    CategoryId = 5,
                    CategoryName = "Breakfast & Instant Food",
                    CategoryImage = "tea-coffee-drinks.jpg",
                    CategoryUrl = "Breakfast-instant-food",
                    CategoryStatus = true
                },
                new Category()
                {
                    CategoryId = 6,
                    CategoryName = "Bakery & Biscuits",
                    CategoryImage = "bakery-biscuits.jpg",
                    CategoryUrl = "bakery-biscuits",
                    CategoryStatus = false
                },
                new Category()
                {
                    CategoryId = 7,
                    CategoryName = "Chicken, Meat & Fish",
                    CategoryImage = "chicken-meat-fish.jpg",
                    CategoryUrl = "chicken-meat-fish",
                    CategoryStatus = true
                }
            };

            _subcategories = new List<SubCategory>()
            {
                new SubCategory() {SubCategoryId = 1, SubCategoryName = "Milk", SubCategoryUrl = "milk", CategoryId = 1 },
                new SubCategory() {SubCategoryId = 2, SubCategoryName = "Milk Drinks", SubCategoryUrl = "milk-drinks", CategoryId = 1 },
                new SubCategory() {SubCategoryId = 3, SubCategoryName = "Eggs", SubCategoryUrl = "eggs", CategoryId = 1 },
                new SubCategory() {SubCategoryId = 4, SubCategoryName = "Bread", SubCategoryUrl = "bread", CategoryId = 1 },
                new SubCategory() {SubCategoryId = 5, SubCategoryName = "Buns & Bakery", SubCategoryUrl = "buns-&-bakery", CategoryId = 1 },
                new SubCategory() {SubCategoryId = 6, SubCategoryName = "Butter & More", SubCategoryUrl = "butter-&-more", CategoryId = 1 },
                new SubCategory() {SubCategoryId = 7, SubCategoryName = "Cheese", SubCategoryUrl = "cheese", CategoryId = 1 },
                new SubCategory() {SubCategoryId = 8, SubCategoryName = "Paneer & Tofu", SubCategoryUrl = "paneer-&-tofu", CategoryId = 1 },
                new SubCategory() {SubCategoryId = 9, SubCategoryName = "Cream & Whitener", SubCategoryUrl = "cream-&-whitener", CategoryId = 1 },
                new SubCategory() {SubCategoryId = 10, SubCategoryName = "Condensed Milk", SubCategoryUrl = "condensed-milk", CategoryId = 1 },
                new SubCategory() {SubCategoryId = 11, SubCategoryName = "Vegan Drinks", SubCategoryUrl = "vegan-drinks", CategoryId = 1 },
                new SubCategory() {SubCategoryId = 12, SubCategoryName = "Chips & Crisps", SubCategoryUrl = "chips-&-crisps", CategoryId = 2 },

                new SubCategory() {SubCategoryId = 13, SubCategoryName = "Nachos", SubCategoryUrl = "nachos", CategoryId = 2 },
                new SubCategory() {SubCategoryId = 14, SubCategoryName = "Popcorn", SubCategoryUrl = "popcorn", CategoryId = 2 },
                new SubCategory() {SubCategoryId = 15, SubCategoryName = "Bhujia & Mixtures", SubCategoryUrl = "bhujia-&-mixtures", CategoryId = 2 },
                new SubCategory() {SubCategoryId = 16, SubCategoryName = "Namkeen Snacks", SubCategoryUrl = "namkeen-snacks", CategoryId = 2 },
                new SubCategory() {SubCategoryId = 17, SubCategoryName = "Healthy Snacks", SubCategoryUrl = "healthy-snacks", CategoryId = 2 },
                new SubCategory() {SubCategoryId = 18, SubCategoryName = "Cakes & Rolls", SubCategoryUrl = "cakes-&-rolls", CategoryId = 2 },
                new SubCategory() {SubCategoryId = 19, SubCategoryName = "Energy Bars", SubCategoryUrl = "energy-bars", CategoryId = 2 },
                new SubCategory() {SubCategoryId = 20, SubCategoryName = "Papad & Fryums", SubCategoryUrl = "papad-&-fryums", CategoryId = 2 },
                new SubCategory() {SubCategoryId = 21, SubCategoryName = "Rusks & Wafers", SubCategoryUrl = "rusks-&-wafers", CategoryId = 2 },

                new SubCategory() {SubCategoryId = 22, SubCategoryName = "Fresh Vegetables", SubCategoryUrl = "fresh-vegetables", CategoryId = 3 },
                new SubCategory() {SubCategoryId = 23, SubCategoryName = "Herbs & Seasonings", SubCategoryUrl = "herbs-&-seasonings", CategoryId = 3 },
                new SubCategory() {SubCategoryId = 24, SubCategoryName = "Fresh Fruits", SubCategoryUrl = "fresh-fruits", CategoryId = 3 },
                new SubCategory() {SubCategoryId = 25, SubCategoryName = "Organic Fruits & Vegetables", SubCategoryUrl = "organic-fruits-&-vegetables", CategoryId = 3 },
                new SubCategory() {SubCategoryId = 26, SubCategoryName = "Cuts & Sprouts", SubCategoryUrl = "cuts-&-sprouts", CategoryId = 3 },
                new SubCategory() {SubCategoryId = 27, SubCategoryName = "Exotic Fruits & Veggies", SubCategoryUrl = "exotic-fruits-&-veggies", CategoryId = 3 },
                new SubCategory() {SubCategoryId = 28, SubCategoryName = "MiFlower Bouquets, Buncheslk", SubCategoryUrl = "miflower-bouquets-buncheslk", CategoryId = 3 },

                new SubCategory() {SubCategoryId = 29, SubCategoryName = "Soft Drinks", SubCategoryUrl = "soft-drinks", CategoryId = 4 },
                new SubCategory() {SubCategoryId = 30, SubCategoryName = "Fruit Juices", SubCategoryUrl = "fruit-juices", CategoryId = 4 },
                new SubCategory() {SubCategoryId = 31, SubCategoryName = "Coldpress", SubCategoryUrl = "coldpress", CategoryId = 4 },
                new SubCategory() {SubCategoryId = 32, SubCategoryName = "Energy Drinks", SubCategoryUrl = "energy-drinks", CategoryId = 4 },
                new SubCategory() {SubCategoryId = 33, SubCategoryName = "Water & Ice Cubes", SubCategoryUrl = "water-&-ice-cubes", CategoryId = 4 },
                new SubCategory() {SubCategoryId = 34, SubCategoryName = "Soda & Mixers", SubCategoryUrl = "soda-&-mixers", CategoryId = 4 },
                new SubCategory() {SubCategoryId = 35, SubCategoryName = "Concentrates & Syrups", SubCategoryUrl = "concentrates-&-syrups", CategoryId = 4 },
                new SubCategory() {SubCategoryId = 36, SubCategoryName = "Detox & Energy Drinks", SubCategoryUrl = "detox-&-energy-drinks", CategoryId = 4 },
                new SubCategory() {SubCategoryId = 37, SubCategoryName = "Juice Collection", SubCategoryUrl = "juice-collection", CategoryId = 4 },

                new SubCategory() {SubCategoryId = 38, SubCategoryName = "Batter", SubCategoryUrl = "batter", CategoryId = 5 },
                new SubCategory() {SubCategoryId = 39, SubCategoryName = "Breakfast Cereal", SubCategoryUrl = "breakfast-cereal", CategoryId = 5 },
                new SubCategory() {SubCategoryId = 40, SubCategoryName = "Noodles, Pasta & Soup", SubCategoryUrl = "noodles-pasta-&-soup", CategoryId = 5 },
                new SubCategory() {SubCategoryId = 41, SubCategoryName = "Frozen Non-Veg Snackss", SubCategoryUrl = "frozen-non-veg-snackss", CategoryId = 5 },
                new SubCategory() {SubCategoryId = 42, SubCategoryName = "Frozen Veg", SubCategoryUrl = "frozen-veg", CategoryId = 5 },
                new SubCategory() {SubCategoryId = 43, SubCategoryName = "Vermicelli", SubCategoryUrl = "vermicelli", CategoryId = 5 },
                new SubCategory() {SubCategoryId = 44, SubCategoryName = "Instant Mixes", SubCategoryUrl = "instant-mixes", CategoryId = 5 },

                new SubCategory() {SubCategoryId = 45, SubCategoryName = "Cookies", SubCategoryUrl = "cookies", CategoryId = 6 },
                new SubCategory() {SubCategoryId = 46, SubCategoryName = "Glucose & Marie", SubCategoryUrl = "glucose-&-marie", CategoryId = 6 },
                new SubCategory() {SubCategoryId = 47, SubCategoryName = "Sweet & Salty", SubCategoryUrl = "sweet-&-salty", CategoryId = 6 },
                new SubCategory() {SubCategoryId = 48, SubCategoryName = "Healthy & Digestive", SubCategoryUrl = "healthy-&-digestive", CategoryId = 6 },
                new SubCategory() {SubCategoryId = 49, SubCategoryName = "Cream Biscuits", SubCategoryUrl = "cream-biscuits", CategoryId = 6 },
                new SubCategory() {SubCategoryId = 50, SubCategoryName = "Rusks & Wafers", SubCategoryUrl = "rusks-&-wafers", CategoryId = 6 },
                new SubCategory() {SubCategoryId = 51, SubCategoryName = "Cakes & Rolls", SubCategoryUrl = "cakes-&-rolls", CategoryId = 6 },
                new SubCategory() {SubCategoryId = 52, SubCategoryName = "Buns & Bakery", SubCategoryUrl = "buns-&-bakery", CategoryId = 6 },

                new SubCategory() {SubCategoryId = 53, SubCategoryName = "Chicken", SubCategoryUrl = "chicken", CategoryId = 7 },
                new SubCategory() {SubCategoryId = 54, SubCategoryName = "Sausage, Salami & Ham", SubCategoryUrl = "sausage-salami-&-ham", CategoryId = 7 },
                new SubCategory() {SubCategoryId = 55, SubCategoryName = "Exotic Meat", SubCategoryUrl = "exotic-meat", CategoryId = 7 },
                new SubCategory() {SubCategoryId = 56, SubCategoryName = "Eggs", SubCategoryUrl = "eggs", CategoryId = 7 },
                new SubCategory() {SubCategoryId = 57, SubCategoryName = "Frozen Non-Veg Snacks", SubCategoryUrl = "frozen-non-veg-snacks", CategoryId = 7 }
            };

            _products = new List<Product>()
            {
                new Product()
                {
                    ProductId = 1,
                    ProductName = "Haldiram's Sev Bhujia",
                    ProductImage = "product-img-1.jpg",
                    CategoryId = 2,
                    ProductPrice = 24,
                    ProductStok = false,
                    ProductIsHome = true,
                    ProductUrl = "haldirams-sev-bhujia",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 2)
                },
                new Product()
                {
                    ProductId = 2,
                    ProductName = "NutriChoice Digestive",
                    ProductImage = "product-img-2.jpg",
                    CategoryId = 6,
                    ProductPrice = 24,
                    ProductStok = true,
                    ProductIsHome = true,
                    ProductUrl = "nutriChoice-digestive",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 6)
                },
                new Product()
                {
                    ProductId = 3,
                    ProductName = "Cadbury 5 Star Chocolate",
                    ProductImage = "product-img-3.jpg",
                    CategoryId = 6,
                    ProductPrice = 24,
                    ProductStok = true,
                    ProductIsHome = true,
                    ProductUrl = "cadbury-5-star-chocolate",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 6)
                },
                new Product()
                {
                    ProductId = 4,
                    ProductName = "Onion Flavour Potato",
                    ProductImage = "product-img-4.jpg",
                    CategoryId = 2,
                    ProductPrice = 24,
                    ProductStok = true,
                    ProductIsHome = true,
                    ProductUrl = "onion-flavour-potato",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 2)
                },
                new Product()
                {
                    ProductId = 5,
                    ProductName = "Salted Instant Popcorn",
                    ProductImage = "product-img-5.jpg",
                    CategoryId = 5,
                    ProductPrice = 24,
                    ProductStok = true,
                    ProductIsHome = true,
                    ProductUrl = "salted-instant-popcorn",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 5)
                },
                new Product()
                {
                    ProductId = 6,
                    ProductName = "Blueberry Greek Yogurt",
                    ProductImage = "product-img-6.jpg",
                    CategoryId = 1,
                    ProductPrice = 24,
                    ProductStok = false,
                    ProductIsHome = true,
                    ProductUrl = "blueberry-greek-yogurt",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 1)
                },
                new Product()
                {
                    ProductId = 7,
                    ProductName = "Britannia Cheese Slices",
                    ProductImage = "product-img-7.jpg",
                    CategoryId = 1,
                    ProductPrice = 24,
                    ProductStok = true,
                    ProductIsHome = true,
                    ProductUrl = "britannia-cheese-slices",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 1)
                },
                new Product()
                {
                    ProductId = 8,
                    ProductName = "Kellogg's Original Cereals",
                    ProductImage = "product-img-8.jpg",
                    CategoryId = 5,
                    ProductPrice = 24,
                    ProductStok = true,
                    ProductIsHome = true,
                    ProductUrl = "kelloggs-original-cereals",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 5)
                },
                new Product()
                {
                    ProductId = 9,
                    ProductName = "Slurrp Millet Chocolate",
                    ProductImage = "product-img-9.jpg",
                    CategoryId = 2,
                    ProductPrice = 24,
                    ProductStok = true,
                    ProductIsHome = true,
                    ProductUrl = "slurrp-millet-chocolate",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 2)
                },
                new Product()
                {
                    ProductId = 10,
                    ProductName = "Amul Butter - 500 g",
                    ProductImage = "product-img-10.jpg",
                    CategoryId = 1,
                    ProductPrice = 24,
                    ProductStok = true,
                    ProductIsHome = true,
                    ProductUrl = "amul-butter",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 1)
                },
                new Product()
                {
                    ProductId = 11,
                    ProductName = "Haldiram's Sev Bhujia",
                    ProductImage = "product-img-1.jpg",
                    CategoryId = 2,
                    ProductPrice = 24,
                    ProductStok = false,
                    ProductIsHome = false,
                    ProductUrl = "haldirams-sev-bhujia",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 2)
                },
                new Product()
                {
                    ProductId = 12,
                    ProductName = "Lay's Classic Potato Chips",
                    ProductImage = "product-img-2.jpg",
                    CategoryId = 2,
                    ProductPrice = 15,
                    ProductStok = true,
                    ProductIsHome = false,
                    ProductUrl = "lays-classic-potato-chips",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 2)
                },
                new Product()
                {
                    ProductId = 13,
                    ProductName = "Ulker Chocolate Wafer",
                    ProductImage = "product-img-3.jpg",
                    CategoryId = 6,
                    ProductPrice = 5,
                    ProductStok = true,
                    ProductIsHome = false,
                    ProductUrl = "ulker-chocolate-wafer",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 6)
                },
                new Product()
                {
                    ProductId = 14,
                    ProductName = "Sütaş Milk 1L",
                    ProductImage = "product-img-4.jpg",
                    CategoryId = 1,
                    ProductPrice = 12,
                    ProductStok = true,
                    ProductIsHome = false,
                    ProductUrl = "sutas-milk-1l",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 1)
                },
                new Product()
                {
                    ProductId = 15,
                    ProductName = "Cappy Mixed Fruit Juice 1L",
                    ProductImage = "product-img-5.jpg",
                    CategoryId = 4,
                    ProductPrice = 8,
                    ProductStok = true,
                    ProductIsHome = false,
                    ProductUrl = "cappy-mixed-fruit-juice-1l",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 4)
                },
                new Product()
                {
                    ProductId = 16,
                    ProductName = "Eti Burçak Biscuit",
                    ProductImage = "product-img-6.jpg",
                    CategoryId = 6,
                    ProductPrice = 6,
                    ProductStok = true,
                    ProductIsHome = false,
                    ProductUrl = "eti-burcak-biscuit",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 6)
                },
                new Product()
                {
                    ProductId = 17,
                    ProductName = "Pınar Olive Bread",
                    ProductImage = "product-img-7.jpg",
                    CategoryId = 6,
                    ProductPrice = 4,
                    ProductStok = true,
                    ProductIsHome = false,
                    ProductUrl = "pinar-olive-bread",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 6)
                },
                new Product()
                {
                    ProductId = 18,
                    ProductName = "Banvit Chicken Breast",
                    ProductImage = "product-img-8.jpg",
                    CategoryId = 7,
                    ProductPrice = 25,
                    ProductStok = true,
                    ProductIsHome = false,
                    ProductUrl = "banvit-chicken-breast",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 7)
                },
                new Product()
                {
                    ProductId = 19,
                    ProductName = "Coca-Cola 1L",
                    ProductImage = "product-img-9.jpg",
                    CategoryId = 4,
                    ProductPrice = 7,
                    ProductStok = true,
                    ProductIsHome = false,
                    ProductUrl = "coca-cola-1l",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 4)
                },
                new Product()
                {
                    ProductId = 20,
                    ProductName = "Pepsi 1L",
                    ProductImage = "product-img-10.jpg",
                    CategoryId = 4,
                    ProductPrice = 7,
                    ProductStok = true,
                    ProductIsHome = false,
                    ProductUrl = "pepsi-1l",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 4)
                },
                new Product()
                {
                    ProductId = 21,
                    ProductName = "Doritos Nacho Cheese",
                    ProductImage = "product-img-11.jpg",
                    CategoryId = 2,
                    ProductPrice = 10,
                    ProductStok = true,
                    ProductIsHome = false,
                    ProductUrl = "doritos-nacho-cheese",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 2)
                },
                new Product()
                {
                    ProductId = 22,
                    ProductName = "Pringles Sour Cream & Onion",
                    ProductImage = "product-img-12.jpg",
                    CategoryId = 2,
                    ProductPrice = 12,
                    ProductStok = true,
                    ProductIsHome = false,
                    ProductUrl = "pringles-sour-cream-onion",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 2)
                },
                new Product()
                {
                    ProductId = 23,
                    ProductName = "Tropicana Orange Juice 1L",
                    ProductImage = "product-img-13.jpg",
                    CategoryId = 4,
                    ProductPrice = 9,
                    ProductStok = true,
                    ProductIsHome = false,
                    ProductUrl = "tropicana-orange-juice-1l",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 4)
                },
                new Product()
                {
                    ProductId = 24,
                    ProductName = "Alpro Almond Milk 1L",
                    ProductImage = "product-img-14.jpg",
                    CategoryId = 1,
                    ProductPrice = 20,
                    ProductStok = true,
                    ProductIsHome = false,
                    ProductUrl = "alpro-almond-milk-1l",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 1)
                },
                new Product()
                {
                    ProductId = 25,
                    ProductName = "Knorr Tomato Soup",
                    ProductImage = "product-img-15.jpg",
                    CategoryId = 5,
                    ProductPrice = 6,
                    ProductStok = true,
                    ProductIsHome = false,
                    ProductUrl = "knorr-tomato-soup",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 5)
                },
                new Product()
                {
                    ProductId = 26,
                    ProductName = "Lipton Ice Tea Lemon 500ml",
                    ProductImage = "product-img-16.jpg",
                    CategoryId = 4,
                    ProductPrice = 5,
                    ProductStok = true,
                    ProductIsHome = false,
                    ProductUrl = "lipton-ice-tea-lemon-500ml",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 4)
                },
                new Product()
                {
                    ProductId = 27,
                    ProductName = "Knorr Chicken Soup",
                    ProductImage = "product-img-17.jpg",
                    CategoryId = 5,
                    ProductPrice = 6,
                    ProductStok = true,
                    ProductIsHome = false,
                    ProductUrl = "knorr-chicken-soup",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 5)
                },
                new Product()
                {
                    ProductId = 28,
                    ProductName = "Fresh Apples",
                    ProductImage = "product-img-18.jpg",
                    CategoryId = 3,
                    ProductPrice = 20,
                    ProductStok = true,
                    ProductIsHome = false,
                    ProductUrl = "fresh-apples",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 3)
                },
                new Product()
                {
                    ProductId = 29,
                    ProductName = "Fresh Bananas",
                    ProductImage = "product-img-19.jpg",
                    CategoryId = 3,
                    ProductPrice = 15,
                    ProductStok = true,
                    ProductIsHome = false,
                    ProductUrl = "fresh-bananas",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 3)
                },
                new Product()
                {
                    ProductId = 30,
                    ProductName = "Knorr Vegetable Soup",
                    ProductImage = "product-img-15.jpg", // Aynı görseli tekrar kullanabilirsiniz
                    CategoryId = 5,
                    ProductPrice = 7,
                    ProductStok = true,
                    ProductIsHome = false,
                    ProductUrl = "knorr-vegetable-soup",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 5)
                },
                new Product()
                {
                    ProductId = 31,
                    ProductName = "Fresh Tomatoes",
                    ProductImage = "product-img-16.jpg", // Aynı görseli tekrar kullanabilirsiniz
                    CategoryId = 3,
                    ProductPrice = 12,
                    ProductStok = true,
                    ProductIsHome = false,
                    ProductUrl = "fresh-tomatoes",
                    Category = _categories.FirstOrDefault(c => c.CategoryId == 3)
                }
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

            _address = new List<Address>()
            {
                new Address()
                {
                    Id = 1,
                    FullName = "Jitu Chauhan",
                    Number = 05459876543,
                    Addres = "4450 North Avenue Oakland",
                    District = "Nebraska",
                    City = "United States",
                    PostalCode = 402-776-1106
                },
                new Address()
                {
                    Id = 2,
                    FullName = "Nitu Chauhan",
                    Number = 05459876543,
                    Addres = "3853 Coal Road Tannersville",
                    District = "Pennsylvania",
                    City = "United States",
                    PostalCode = 402-776-1106
                }
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
        public static Category? GetCategoryByUrl(string url)
        {
            return _categories.FirstOrDefault(p => p.CategoryUrl == url);
        }
        public static Category? GetCategoryById(int id)
        {
            return _categories.SingleOrDefault(x => x.CategoryId == id);
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
        public static Product? GetProductByUrl(string url)
        {
            return _products.FirstOrDefault(p => p.ProductUrl == url);
        }

        public static Product? GetProductById(int id)
        {
            return _products.SingleOrDefault(x => x.ProductId == id);
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