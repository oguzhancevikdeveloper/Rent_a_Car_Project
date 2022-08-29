using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
  public class BrandValidator : AbstractValidator<Brand>
  {
    public BrandValidator()
    {
      RuleFor(b => b.Name).MaximumLength(5);
      RuleFor(b => b.Name).NotEmpty();
      //RuleFor(b => b.Name).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");
    }

    private bool StartWithA(string arg)
    {
      return arg.StartsWith("A");
    }
  }
}
