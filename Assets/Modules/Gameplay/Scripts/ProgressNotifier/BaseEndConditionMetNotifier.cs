using System;
using UnityEngine;
using Zenject;

namespace Gameplay.ProgressNotifier
{
    public class BaseEndConditionMetNotifier : IEndConditionMetNotifier
    {
        [Inject]
        public BaseEndConditionMetNotifier(IProgressNotifier progressNotifier)
        {
            progressNotifier.OnAnyProgress += CheckEndGameCondition;
        }

        public event Action OnEndConditionMet;

        private void CheckEndGameCondition(int currentAnyProgress, int maxProgress)
        {
            Debug.Log(currentAnyProgress);
            if (currentAnyProgress == maxProgress)
            {
                OnEndConditionMet.Invoke();
            }
        }
    }
}