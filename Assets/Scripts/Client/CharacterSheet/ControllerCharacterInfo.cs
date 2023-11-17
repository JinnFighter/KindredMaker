namespace Client.CharacterSheet
{
    public class ControllerCharacterInfo : IController
    {
        private readonly IModelCharacterInfo _model;
        private readonly ViewCharacterInfo _view;

        public ControllerCharacterInfo(IModelCharacterInfo model, ViewCharacterInfo view)
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