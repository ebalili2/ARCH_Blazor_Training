using FluentValidation;

namespace BlazorServer.DataValidation.CommonControls
{
    public class UserControlModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class UserControlModelValidator: AbstractValidator<UserControlModel>
    {
        public UserControlModelValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
        }
    }
}
