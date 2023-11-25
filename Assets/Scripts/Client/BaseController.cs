using System.Collections.Generic;
using Reactivity;

namespace Client
{
    public class BaseController<TModel, TView> : IBaseController where TModel : IModel where TView : BaseView
    {
        private readonly List<IController> _childControllers = new();
        protected readonly SubscriptionAggregator SubscriptionAggregator = new();

        protected TModel Model { get; private set; }
        protected TView View { get; private set; }

        private IControllerFactory ControllerFactory { get; set; }

        public void Init()
        {
            InitInner();

            RegisterChildControllers();
            foreach (var childController in _childControllers) childController.Init();
        }

        public void Terminate()
        {
            SubscriptionAggregator.Unsubscribe();
            foreach (var childController in _childControllers) childController.Terminate();

            _childControllers.Clear();
            TerminateInner();
        }

        public void Setup(IModel model, BaseView view, IControllerFactory controllerFactory)
        {
            Model = (TModel) model;
            View = (TView) view;
            ControllerFactory = controllerFactory;
        }

        protected void RegisterChildController<TController>(IModel model, BaseView view)
            where TController : IBaseController
        {
            _childControllers.Add(ControllerFactory.CreateController<TController>(model, view));
        }

        protected virtual void InitInner()
        {
        }

        protected virtual void TerminateInner()
        {
        }

        protected virtual void RegisterChildControllers()
        {
        }
    }
}