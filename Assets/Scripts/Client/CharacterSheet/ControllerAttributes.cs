namespace Client.CharacterSheet
{
    public class ControllerAttributes : IController
    {
        private readonly IModelAttributes _model;
        private readonly ViewAttributes _view;

        public ControllerAttributes(IModelAttributes model, ViewAttributes view)
        {
            _model = model;
            _view = view;
        }

        public void Init()
        {
        }

        public void Terminate()
        {
        }
    }
}