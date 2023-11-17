namespace Client.CharacterSheet
{
    public class ControllerCharacterStats : IController
    {
        private readonly IModelCharacterStats _model;
        private readonly ViewCharacterStats _view;

        public ControllerCharacterStats(IModelCharacterStats model, ViewCharacterStats view)
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