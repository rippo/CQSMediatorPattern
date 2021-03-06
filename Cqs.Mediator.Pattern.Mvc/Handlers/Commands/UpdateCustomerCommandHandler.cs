﻿using Cqs.Mediator.Pattern.Mvc.ViewModels.Customer;

namespace Cqs.Mediator.Pattern.Mvc.Handlers.Commands
{
    public class UpdateCustomerCommandHandler : ICommandHandler<UpdateCustomerViewModel>
    {
        public virtual void Handle(UpdateCustomerViewModel model)
        {
            //logic here
            model.CustomerId = model.CustomerId; //  + security.CurrentUserId;
        }
    }
}