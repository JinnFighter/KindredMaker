using System.Collections.Generic;
using Client.Common;
using Logic;
using Reactivity;

namespace Client.СharacterBuilder.Steps
{
    public interface IModelBuilderStepAttributes : IModelBuilderStep
    {
        Dictionary<EAttribute, IModelRoundStat> Attributes { get; }
        Dictionary<int, IReactiveProperty<int>> PointsDistribution { get; }

        void TrySetNewAttributeValue(EAttribute attribute, int value);
    }
}