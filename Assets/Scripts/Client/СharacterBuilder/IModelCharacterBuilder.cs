using System.Collections.Generic;
using Client.СharacterBuilder.Steps;
using Reactivity;

namespace Client.СharacterBuilder
{
    public interface IModelCharacterBuilder : IModel
    {
        IReactiveProperty<int> CurrentStep { get; }
        List<IModelBuilderStep> Steps { get; }
        void GoToPreviousStep();
        void GoToNextStep();
    }
}