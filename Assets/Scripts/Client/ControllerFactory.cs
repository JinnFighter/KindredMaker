using System;

namespace Client
{
    public class ControllerFactory : IControllerFactory
    {
        public TController CreateController<TController>(IModel model, BaseView view)
            where TController : IBaseController
        {
            var controller = Activator.CreateInstance<TController>();
            controller.Setup(model, view, this);
            return controller;
        }
    }
}