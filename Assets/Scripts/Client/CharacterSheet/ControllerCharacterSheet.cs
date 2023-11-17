using System.Collections.Generic;

namespace Client.CharacterSheet
{
    public class ControllerCharacterSheet : IController
    {
        private readonly IModelCharacterSheet _model;

        private readonly List<IController> _subControllers = new();
        private readonly ViewCharacterSheet _view;

        public ControllerCharacterSheet(IModelCharacterSheet model, ViewCharacterSheet view)
        {
            _model = model;
            _view = view;
        }

        public void Init()
        {
            _subControllers.Add(new ControllerAttributes(_model.Attributes, _view.Attributes));
            _subControllers.Add(new ControllerCharacterInfo(_model.CharacterInfo, _view.CharacterInfo));
            _subControllers.Add(new ControllerSkills(_model.Skills, _view.Skills));
            _subControllers.Add(new ControllerCharacterStats(_model.CharacterStats, _view.Stats));
            _subControllers.Add(new ControllerDisciplines(_model.Disciplines, _view.Disciplines));

            foreach (var controller in _subControllers) controller.Init();
        }

        public void Terminate()
        {
            foreach (var controller in _subControllers) controller.Terminate();

            _subControllers.Clear();
        }
    }
}