using System.Collections.Generic;
using Logic.Services;
using Reactivity;

namespace Client.DiceRoller
{
    public interface IModelDiceRollResult : IModel
    {
        IReadOnlyList<RollResult> RollResults { get; }
        IReactiveProperty<string> ResultText { get; }
    }
}