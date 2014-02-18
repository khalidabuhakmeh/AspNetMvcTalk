using System;
using System.Web.Mvc;
using FluentValidation;
using FluentValidation.Mvc;

namespace AspNetMvcTalk.Web.App_Start
{
    public static class ValidationConfig
    {
        public static void Setup()
        {
            var factory = new DependencyResolverValidatorFactory();
            ModelValidatorProviders.Providers.Add(new FluentValidationModelValidatorProvider(factory));
            DataAnnotationsModelValidatorProvider.AddImplicitRequiredAttributeForValueTypes = false;
        }

        public class DependencyResolverValidatorFactory : ValidatorFactoryBase
        {
            public override IValidator CreateInstance(Type validatorType)
            {
                return DependencyResolver.Current.GetService(validatorType) as IValidator;
            }
        }
    }

}