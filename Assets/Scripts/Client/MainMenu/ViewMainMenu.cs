using Client.Common;
using UnityEngine;

namespace Client.MainMenu
{
    public class ViewMainMenu : BaseView
    {
        [field: SerializeField] public ButtonLabelled ButtonCreateCharacter { get; private set; }
        [field: SerializeField] public ButtonLabelled ButtonCharacterSheet { get; private set; }
    }
}
