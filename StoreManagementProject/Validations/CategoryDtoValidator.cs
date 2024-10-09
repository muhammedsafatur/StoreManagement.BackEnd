using FluentValidation;
using StoreManagementProject.Web.Api.Models.Dtos;

public class CategoryDtoValidator:AbstractValidator<CategoryDto>
{
    public CategoryDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required.")
            .Length(1, 100).WithMessage("Name can't be longer than 100 characters.");

        RuleFor(x => x.Description)
            .NotEmpty().WithMessage("Description is required")
            .Length(1, 100).WithMessage("Description cant be longer than 100 characters or shorter than 1 character");

    }
}
