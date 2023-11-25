namespace Client
{
    public interface IBaseController : IController
    {
        void Setup(IModel model, BaseView view, IControllerFactory controllerFactory);
    }
}