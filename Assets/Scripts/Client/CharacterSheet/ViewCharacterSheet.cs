using UnityEngine;

namespace Client.CharacterSheet
{
    public class ViewCharacterSheet : BaseView
    {
        [field: SerializeField] public ViewCharacterInfo CharacterInfo { get; private set; }
        [field: SerializeField] public ViewAttributes Attributes { get; private set; }
        [field: SerializeField] public ViewSkills Skills { get; private set; }
        [field: SerializeField] public ViewCharacterStats Stats { get; private set; }
        [field: SerializeField] public ViewDisciplines Disciplines { get; private set; }
    }
}