using System;

namespace Gameplay.ProgressNotifier
{
    public interface IProgressNotifier
    {
        public event Action<int, int> OnSuccessfulProgress;
        public event Action<int, int> OnAnyProgress;
    }
}