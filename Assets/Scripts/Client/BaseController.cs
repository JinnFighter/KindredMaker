using Reactivity;

namespace Client
{
    public class BaseController<TModel, TView> : IController where TModel : IModel where TView : BaseView
    {
        protected readonly SubscriptionAggregator SubscriptionAggregator = new();

        public BaseController(TModel model, TView view)
        {
            Model = model;
            View = view;
        }

        protected TModel Model { get; }
        protected TView View { get; }

        public void Init()
        {
            InitInner();
        }

        public void Terminate()
        {
            SubscriptionAggregator.Unsubscribe();
            TerminateInner();
        }

        protected virtual void InitInner()
        {
        }

        protected virtual void TerminateInner()
        {
        }
    }
}