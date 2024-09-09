class Product{
    public int id { get; set; }
    public string? ProductName { get; set; }
    public string? Quality { get; set; }
}

class Category
{
    public int CatID { get; set; }
    public string? Name { get; set; }
    public List<Product>? Products { get; set; }
    public static List<Category> GetCategories(){
        return new List<Category>(){
            
// Product: SmartHome Hub 3000
// Clothing
// Product: Cozy Comfort Hoodie
// Home & Garden
// Product: Zen Garden Water Fountain
// Beauty & Personal Care
// Product: Radiance Boost Facial Serum
// Toys & Games
// Product: Galactic Explorer STEM Kit
// Sports & Outdoors
// Product: All-Terrain Mountain Bike
// Books & Stationery
// Product: Eco-Friendly Bamboo Notebook
// Food & Beverages
// Product: Artisanal Dark Chocolate Bar
//             new Category(){CatID = 1,Name="", }
        };
    }

}