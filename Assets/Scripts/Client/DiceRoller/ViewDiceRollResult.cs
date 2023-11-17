using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Client.DiceRoller
{
    public class ViewDiceRollResult : BaseView
    {
        [field: SerializeField] public List<ViewDiceResult> ImagesDice { get; private set; }
        [field: SerializeField] public TextMeshProUGUI TextResult { get; private set; }
    }
}