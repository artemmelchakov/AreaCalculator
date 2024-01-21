using System.ComponentModel.DataAnnotations;

namespace Figures
{
    /// <summary>
    /// Абстрактный класс, от которого наследуются геометрические фигуры.
    /// </summary>
    public abstract class Figure : IValidatableObject
    {
        /// <summary>
        /// Корректно ли состояние и параметры фигуры.
        /// </summary>
        public bool IsValid => Validator.TryValidateObject(this, new ValidationContext(this), null);
        public abstract IEnumerable<ValidationResult> Validate(ValidationContext validationContext);
    }
}
