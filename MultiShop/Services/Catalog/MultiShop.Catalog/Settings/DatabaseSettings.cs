namespace MultiShop.Catalog.Settings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        //public string CategoryColletionName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public string ProductColletionName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public string ProductDetailCollectionName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public string ProductImageCollectionName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public string ConnectionString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public string DatabaseName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CategoryColletionName { get; set; }
        public string ProductColletionName { get; set; }
        public string ProductDetailCollectionName { get; set; }
        public string ProductImageCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
