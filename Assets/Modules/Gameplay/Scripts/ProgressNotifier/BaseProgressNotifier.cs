using System;
using UnityEngine;
using Zenject;

namespace Gameplay.ProgressNotifier
{
    public class BaseProgressNotifier : MonoBehaviour, IProgressNotifier, IProgressListener
    {
        [Inject]
        public void Construct(IMaxProgressProvider maxProgressProvider)
        {
            _maxProgress = maxProgressProvider.GetMaxProgress();
        }

        public event Action<int, int> OnSuccessfulProgress;
        public event Action<int, int> OnAnyProgress;

        private int _currentSuccessfulProgress;
        private int _currentAnyProgress;
        private int _maxProgress;


        public void NotifyOfProgress(bool successful)
        {
            if (successful) OnSuccessfulProgress.Invoke(++_currentSuccessfulProgress, _maxProgress);
            OnAnyProgress.Invoke(++_currentAnyProgress, _maxProgress);
        }
    }
}