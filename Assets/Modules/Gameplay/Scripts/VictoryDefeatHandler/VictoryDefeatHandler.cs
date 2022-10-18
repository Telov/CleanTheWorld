using Gameplay.ProgressNotifier;
using Zenject;
using UnityEngine;

namespace Gameplay.VictoryDefeatHandler
{
    public class VictoryDefeatHandler : MonoBehaviour
    {
        [Inject]
        public void Construct(IEndConditionMetNotifier endConditionMetNotifier, IVictoryDefeatImplementation victoryDefeatImplementation)
        {
            endConditionMetNotifier.OnEndConditionMet += victoryDefeatImplementation.Launch;
        }
    }
}