using Reactivity;

namespace Client.CharacterSheet
{
    public interface IModelCharacterInfo : IModel
    {
        IReactiveProperty<string> CharacterName { get; }
        IReactiveProperty<string> Sect { get; }
        IReactiveProperty<string> Clan { get; }

        IReactiveProperty<string> PlayerName { get; }
        IReactiveProperty<string> PredatorType { get; }
        IReactiveProperty<int> Generation { get; }

        IReactiveProperty<string> ChronicleName { get; }
        IReactiveProperty<string> Ambition { get; }
        IReactiveProperty<string> Desire { get; }
    }
}