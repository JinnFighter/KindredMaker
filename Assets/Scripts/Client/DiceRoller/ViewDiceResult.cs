using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Client.DiceRoller
{
    public class ViewDiceResult : BaseView
    {
        [field: SerializeField] public Image ImageDiceType { get; private set; }
        [field: SerializeField] public TextMeshProUGUI TextDiceRoll { get; private set; }
    }
}