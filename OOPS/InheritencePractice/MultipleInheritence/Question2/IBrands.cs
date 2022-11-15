namespace Question1
{
    public interface IBrands
    {
        public string BrandName{get;set;}
        public string ModelName{get;set;}
        void showBrandDetails(string brandName,string modelName);
    }
}