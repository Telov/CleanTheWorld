using UnityEngine;
using Zenject;

namespace Gameplay.VictoryDefeatHandler
{
    public class BaseVictoryDefeatImplementation : IVictoryDefeatImplementation
    {
        public const string BackgroundGoID = nameof(BackgroundGo);

        [Inject]
        public void Construct([Inject(Id = BackgroundGoID)] GameObject backgroundGO)
        {
            BackgroundGo = backgroundGO;
        }

        protected GameObject BackgroundGo;

        public virtual void Launch()
        {
            BackgroundGo.SetActive(true);
        }
    }
}