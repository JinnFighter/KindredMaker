namespace Client.CharacterSheet
{
    public class ControllerCharacterSheet : BaseController<IModelCharacterSheet, ViewCharacterSheet>
    {
        protected override void RegisterChildControllers()
        {
            RegisterChildController<ControllerAttributes>(Model.Attributes, View.Attributes);
            RegisterChildController<ControllerCharacterInfo>(Model.CharacterInfo, View.CharacterInfo);
            RegisterChildController<ControllerSkills>(Model.Skills, View.Skills);
            RegisterChildController<ControllerCharacterStats>(Model.CharacterStats, View.Stats);
            RegisterChildController<ControllerDisciplines>(Model.Disciplines, View.Disciplines);
        }
    }
}