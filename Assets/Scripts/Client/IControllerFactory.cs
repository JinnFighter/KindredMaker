namespace Client
{
    public interface IControllerFactory
    {
        TController CreateController<TController>(IModel model, BaseView view) where TController : IBaseController;
    }
}