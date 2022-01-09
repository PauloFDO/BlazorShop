﻿namespace BlazorShop.Application.Validators.AppRoleValidator
{
    public class DeleteRoleCommandValidator : AbstractValidator<DeleteRoleCommand>
    {
        public DeleteRoleCommandValidator()
        {
            RuleFor(v => v.Id).GreaterThan(0);
        }
    }
}
