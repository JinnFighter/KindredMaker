using System;
using System.Collections.Generic;
using Client.Common;
using Logic;
using Reactivity;

namespace Client.СharacterBuilder.Steps
{
    public class ModelBuilderStepAttributes : ModelBuilderStep, IModelBuilderStepAttributes
    {
        public ModelBuilderStepAttributes()
        {
            Attributes = new Dictionary<EAttribute, IModelRoundStat>();

            foreach (var obj in Enum.GetValues(typeof(EAttribute)))
            {
                var attribute = (EAttribute)obj;
                Attributes[attribute] = new ModelRoundStat(attribute.ToString());
            }

            PointsDistribution = new Dictionary<int, IReactiveProperty<int>>
            {
                { 1, new ReactiveProperty<int>(1) },
                { 2, new ReactiveProperty<int>(4) },
                { 3, new ReactiveProperty<int>(3) },
                { 4, new ReactiveProperty<int>(1) }
            };
        }

        public Dictionary<EAttribute, IModelRoundStat> Attributes { get; }
        public Dictionary<int, IReactiveProperty<int>> PointsDistribution { get; }
        public void TrySetNewAttributeValue(EAttribute attribute, int value)
        {
            var attributeModel = Attributes[attribute];
            var currentAmount = attributeModel.Amount;
            if (PointsDistribution.TryGetValue(value, out var count))
            {
                //assign new amount to attribute
            }
            attributeModel.SetAmount(value);
        }
    }
}