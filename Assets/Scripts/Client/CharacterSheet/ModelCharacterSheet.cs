namespace Client.CharacterSheet
{
    public class ModelCharacterSheet : IModelCharacterSheet
    {
        public ModelCharacterSheet()
        {
            CharacterInfo = new ModelCharacterInfo();
            Attributes = new ModelAttributes();
            Skills = new ModelSkills();
            CharacterStats = new ModelCharacterStats();
            Disciplines = new ModelDisciplines();
        }

        public IModelCharacterInfo CharacterInfo { get; }
        public IModelAttributes Attributes { get; }
        public IModelSkills Skills { get; }
        public IModelCharacterStats CharacterStats { get; }
        public IModelDisciplines Disciplines { get; }
    }
}