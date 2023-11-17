namespace Client.CharacterSheet
{
    public class ControllerSkills : IController
    {
        private readonly IModelSkills _model;
        private readonly ViewSkills _view;

        public ControllerSkills(IModelSkills model, ViewSkills view)
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