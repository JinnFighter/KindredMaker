namespace Client.CharacterSheet
{
    public interface IModelCharacterSheet : IModel
    {
        IModelCharacterInfo CharacterInfo { get; }
        IModelAttributes Attributes { get; }
        IModelSkills Skills { get; }
        IModelCharacterStats CharacterStats { get; }
        IModelDisciplines Disciplines { get; }
    }
}