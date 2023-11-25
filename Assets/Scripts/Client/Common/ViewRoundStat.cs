using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Client.Common
{
    public class ViewRoundStat : BaseView
    {
        [field: SerializeField] public TextMeshProUGUI TextName { get; private set; }
        [field: SerializeField] public List<ViewRoundStatSlot> Slots { get; private set; }
    }
}