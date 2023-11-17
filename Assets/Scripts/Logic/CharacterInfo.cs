namespace Logic
{
    public class CharacterInfo
    {
        public CharacterInfo(string characterName, string sect, EClan clan, string playerName, EPredatorType predatorType, int generation, string chronicleName, string ambition, string desire)
        {
            CharacterName = characterName;
            Sect = sect;
            Clan = clan;
            PlayerName = playerName;
            PredatorType = predatorType;
            Generation = generation;
            ChronicleName = chronicleName;
            Ambition = ambition;
            Desire = desire;
        }

        public string CharacterName { get; }
        public string Sect { get; }
        public EClan Clan { get; }

        public string PlayerName { get; }
        public EPredatorType PredatorType { get; }
        public int Generation { get; }

        public string ChronicleName { get; }
        public string Ambition { get; }
        public string Desire { get; }
    }
}