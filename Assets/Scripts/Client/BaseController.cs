using Reactivity;

namespace Client
{
    public class BaseController<TModel, TView> : IBaseController where TModel : IModel where TView : BaseView
    {
        protected readonly SubscriptionAggregator SubscriptionAggregator = new();

        protected TModel Model { get; private set; }
        protected TView View { get; private set; }
        
        protected IControllerFactory ControllerFactory { get; private set; }

        public void Init()
        {
            InitInner();
        }

        public void Terminate()
        {
            SubscriptionAggregator.Unsubscribe();
            TerminateInner();
        }

        public void Setup(IModel model, BaseView view, IControllerFactory controllerFactory)
        {
            Model = (TModel)model;
            View = (TView)view;
            ControllerFactory = controllerFactory;
        }

        protected virtual void InitInner()
        {
        }

        protected virtual void TerminateInner()
        {
        }
    }
}