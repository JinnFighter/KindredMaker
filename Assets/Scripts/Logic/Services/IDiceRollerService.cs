using System.Collections.Generic;

namespace Logic.Services
{
    public interface IDiceRollerService
    {
        IEnumerable<RollResult> RollDices(int totalCount, int hungerDiceCount = 0);
    }
}