using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.CarName).MinimumLength(2);
            //RuleFor(c => c.CarName).Must(StartWithA).WithMessage("Araba isimleri A harfi ile başlamalı");
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.DailyPrice).GreaterThan(200).When(c => c.BrandId == 2);
            RuleFor(c => c.DailyPrice).LessThanOrEqualTo(1200);
;        }

        //private bool StartWithA(string carName)
        //{
        //    return carName.StartsWith("A");
        //}
    }
}
