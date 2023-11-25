using System.Collections.Generic;
using Zenject;

namespace Client.CharacterSheet
{
    public class ControllerCharacterSheet : BaseController<IModelCharacterSheet, ViewCharacterSheet>
    {
        private readonly List<IController> _subControllers = new();

        protected override void InitInner()
        {
            _subControllers.Add(new ControllerAttributes(Model.Attributes, View.Attributes));
            _subControllers.Add(ControllerFactory.CreateController<ControllerCharacterInfo>(Model.CharacterInfo,
                    View.CharacterInfo));
            _subControllers.Add(new ControllerSkills(Model.Skills, View.Skills));
            _subControllers.Add(new ControllerCharacterStats(Model.CharacterStats, View.Stats));
            _subControllers.Add(new ControllerDisciplines(Model.Disciplines, View.Disciplines));

            foreach (var controller in _subControllers) controller.Init();
        }

        protected override void TerminateInner()
        {
            foreach (var controller in _subControllers) controller.Terminate();

            _subControllers.Clear();
        }
    }
}