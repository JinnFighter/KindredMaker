using System;
using System.Collections.Generic;
using Random = UnityEngine.Random;

namespace Logic.Services
{
    public class DiceRollerService : IDiceRollerService
    {
        public IEnumerable<RollResult> RollDices(int totalCount, int hungerDiceCount = 0)
        {
            if (totalCount <= 0) throw new Exception("Attempted to throw negative or 0 amount of dice");

            if (hungerDiceCount < 0) throw new Exception("Hunger dice count is less than zero");

            if (hungerDiceCount > totalCount) throw new Exception("Hunger dice count is greater than total dice count");

            var result = new List<RollResult>();

            var hungerDiceRemaining = hungerDiceCount;
            for (var i = 0; i < totalCount; i++)
            {
                var countRes = Random.Range(1, 11);
                var isHungerDice = hungerDiceRemaining > 0;
                var rollResult = new RollResult
                {
                    Result = countRes,
                    IsHunger = isHungerDice
                };

                result.Add(rollResult);
                if (isHungerDice) hungerDiceRemaining -= 1;
            }

            return result;
        }
    }
}