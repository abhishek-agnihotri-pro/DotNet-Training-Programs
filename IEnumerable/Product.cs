class Product
{
    public int ID { get; set; }
    public string? Name { get; set; }
    public decimal? Price { get; set; }

    public override string ToString()
    {
        return $"Product ID : {ID}, Name : {Name}, Price : {Price}";
    }

    public override bool Equals(object? obj)
    {
        Product? product = obj as Product;
        if(product == null) return false;
        if((product.Name == Name) && (product.ID == ID) && (product.Price == Price) ){
            return true;
        }
        else return false;
    }
}