using System;

namespace Gameplay.ProgressNotifier
{
    public interface IEndConditionMetNotifier
    {
        public event Action OnEndConditionMet;
    }
}