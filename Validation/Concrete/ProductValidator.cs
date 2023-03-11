using Architecht_TemplateMethodDesignPattern.Models;
using Architecht_TemplateMethodDesignPattern.Validation.Abstract;

namespace Architecht_TemplateMethodDesignPattern.Validation.Concrete
{
    public class ProductValidator : Validator<Product>
    {
        public ProductValidator(Product model) : base(model) { }

        protected override void OnValid()
        {
            if(Data == null)
            {
                IsSuccess = false;
                Results.Add("Ürün eklemek için lütfen zorunlu alanları doldurunuz !");
            }

            // Ürün adı boş geçilemez 
            if (string.IsNullOrWhiteSpace(Data.Name))
            {
                IsSuccess = false;
                Results.Add("Ürün adı boş geçilemez !");
            }

            //ve en az 4 karakter olmalıdır
            if (Data.Name.Length < 4)
            {
                IsSuccess = false;
                Results.Add("Ürün adı en az 4 karakter olmalıdır !");
            }

            // Ürün açıklaması boş geçilemez 
            if (string.IsNullOrWhiteSpace(Data.Description))
            {
                IsSuccess = false;
                Results.Add("Ürün açıklaması boş geçilemez !");
            }
        }
    }
}
