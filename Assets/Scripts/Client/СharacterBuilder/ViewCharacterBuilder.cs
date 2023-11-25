using System.Collections.Generic;
using Client.СharacterBuilder.Steps;
using UnityEngine;

namespace Client.СharacterBuilder
{
    public class ViewCharacterBuilder : BaseView
    {
        [field: SerializeField] public List<ViewBuilderStep> Steps { get; private set; }
    }
}