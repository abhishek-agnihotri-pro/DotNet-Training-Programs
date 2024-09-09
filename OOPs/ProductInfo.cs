class ProductInfo
{
    public int ProductID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Date ManufacturingDate { get; set; }
    public Date ExpiryDate { get; set; }

    public ProductInfo(int productID, string name, string desc, Date manufacturingDate, Date expiryDate)
    {
        ProductID = productID;
        Name = name;
        Description = desc;
        ManufacturingDate = manufacturingDate;
        ExpiryDate = expiryDate;
    }

    public override string ToString()
    {
        return $"Product ID : {ProductID}, Name : {Name}, Description : {Description}, Manufacturing Date : {ManufacturingDate}, Expiry Date : {ExpiryDate}";
    }
}