using System;

namespace Gameplay.GameController
{
    public interface IGameBeginner
    {
        public event Action OnGameBegin;
        public bool IsGameBegun();
    }
}