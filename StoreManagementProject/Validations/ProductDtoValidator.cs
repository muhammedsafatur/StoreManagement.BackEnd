using FluentValidation;
using StoreManagementProject.Web.Api.Models.Dtos;

public class ProductDTOValidator : AbstractValidator<ProductDto>
{
    public ProductDTOValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required.")
            .Length(1, 100).WithMessage("Name can't be longer than 100 characters.");

        RuleFor(x => x.Price)
            .GreaterThan(0).WithMessage("Price must be greater than 0.");

        RuleFor(x => x.Description)
            .NotEmpty().WithMessage("Description is required")
            .Length(1, 100).WithMessage("Description cant be longer than 100 characters or shorter than 1 character");

    }
}
