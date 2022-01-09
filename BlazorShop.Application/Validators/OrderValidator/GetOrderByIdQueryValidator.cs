﻿namespace BlazorShop.Application.Validators.OrderValidator
{
    public class GetOrderByIdQueryValidator : AbstractValidator<GetOrderByIdQuery>
    {
        public GetOrderByIdQueryValidator()
        {
            RuleFor(v => v.Id).GreaterThan(0);
        }
    }
}
