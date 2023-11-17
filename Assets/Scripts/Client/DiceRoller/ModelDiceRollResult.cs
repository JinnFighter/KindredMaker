using System.Collections.Generic;
using Logic.Services;
using Reactivity;

namespace Client.DiceRoller
{
    public class ModelDiceRollResult : IModelDiceRollResult
    {
        public ModelDiceRollResult(IReadOnlyList<RollResult> rollResults, string resultText)
        {
            RollResults = rollResults;
            ResultText = new ReactiveProperty<string>(resultText);
        }

        public IReadOnlyList<RollResult> RollResults { get; }
        public IReactiveProperty<string> ResultText { get; }
    }
}