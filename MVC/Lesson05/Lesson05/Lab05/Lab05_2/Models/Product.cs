using System.ComponentModel.DataAnnotations;

namespace Lab05_2.Models
{
    public class Product
    {
        [Key] public int Id { get; set; }

        [MinLength(6, ErrorMessage = "Nhập ít nhất 6 ký tự!")]
        [MaxLength(150, ErrorMessage = "Nhập nhiều nhất 150 ký tự!")]
        public string Name { get; set; }

        public string Image { get; set; }

        [RegularExpression(@"^\d+$", ErrorMessage = "Giá trị nhập phải là số!")]
        [MinValue(100000, ErrorMessage = "Giá trị ít nhất phải là 1000000")]
        [DataType(DataType.Text)]
        public float Price { get; set; }
        public float SalePrice { get; set; }
        public string Description { get; set; }
    }

    public class MinValueAttribute : ValidationAttribute
    {
        private readonly float _minValue;

        public MinValueAttribute(float minValue)
        {
            _minValue = minValue;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                if (!float.TryParse(value.ToString(), out float price))
                {
                    return new ValidationResult("Định giá không hợp lệ.");
                }

                if (price < _minValue)
                {
                    return new ValidationResult($"Giá ít nhất phải là {_minValue}.");
                }
            }
            return ValidationResult.Success;
        }
    }
}

