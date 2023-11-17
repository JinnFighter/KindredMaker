using Logic;
using Reactivity;

namespace Client.CharacterSheet
{
    public class ModelCharacterInfo : IModelCharacterInfo
    {
        public ModelCharacterInfo(CharacterInfo characterInfo)
        {
            CharacterName = new ReactiveProperty<string>(characterInfo.CharacterName);
            Sect = new ReactiveProperty<string>(characterInfo.Sect);
            Clan = new ReactiveProperty<string>(characterInfo.Clan.ToString());
            PlayerName = new ReactiveProperty<string>(characterInfo.PlayerName);
            PredatorType = new ReactiveProperty<string>(characterInfo.PredatorType.ToString());
            Generation = new ReactiveProperty<int>(characterInfo.Generation);
            ChronicleName = new ReactiveProperty<string>(characterInfo.ChronicleName);
            Ambition = new ReactiveProperty<string>(characterInfo.Ambition);
            Desire = new ReactiveProperty<string>(characterInfo.Desire);
        }

        public IReactiveProperty<string> CharacterName { get; }
        public IReactiveProperty<string> Sect { get; }
        public IReactiveProperty<string> Clan { get; }
        public IReactiveProperty<string> PlayerName { get; }
        public IReactiveProperty<string> PredatorType { get; }
        public IReactiveProperty<int> Generation { get; }
        public IReactiveProperty<string> ChronicleName { get; }
        public IReactiveProperty<string> Ambition { get; }
        public IReactiveProperty<string> Desire { get; }
    }
}