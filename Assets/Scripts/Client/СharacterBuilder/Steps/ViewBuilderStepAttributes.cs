using System.Collections.Generic;
using Client.Common;
using TMPro;
using UnityEngine;

namespace Client.СharacterBuilder.Steps
{
    public class ViewBuilderStepAttributes : ViewBuilderStep
    {
        [field: SerializeField] public List<TextMeshProUGUI> ListDistributions { get; private set; }
        [field: SerializeField] public List<ViewRoundStat> Attributes { get; private set; }
    }
}