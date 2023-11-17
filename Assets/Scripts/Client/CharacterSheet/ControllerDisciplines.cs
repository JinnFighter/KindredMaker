namespace Client.CharacterSheet
{
    public class ControllerDisciplines : IController
    {
        private readonly IModelDisciplines _model;
        private readonly ViewDisciplines _view;

        public ControllerDisciplines(IModelDisciplines model, ViewDisciplines view)
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