using TMPro;
using UnityEngine;

namespace Client.CharacterSheet
{
    public class ViewCharacterInfo : BaseView
    {
        [field: SerializeField] public TextMeshProUGUI TextCharacterName { get; private set; }
        [field: SerializeField] public TextMeshProUGUI TextSect { get; private set; }
        [field: SerializeField] public TextMeshProUGUI TextClan { get; private set; }
        [field: SerializeField] public TextMeshProUGUI TextPlayerName { get; private set; }
        [field: SerializeField] public TextMeshProUGUI TextPredatorType { get; private set; }
        [field: SerializeField] public TextMeshProUGUI TextGeneration { get; private set; }
        [field: SerializeField] public TextMeshProUGUI TextChronicleName { get; private set; }
        [field: SerializeField] public TextMeshProUGUI TextAmbition { get; private set; }
        [field: SerializeField] public TextMeshProUGUI TextDesire { get; private set; }
    }
}