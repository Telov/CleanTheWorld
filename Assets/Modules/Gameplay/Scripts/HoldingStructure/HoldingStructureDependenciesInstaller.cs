using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace Gameplay.HoldingStructure
{
    public class HoldingStructureDependenciesInstaller : MonoInstaller
    {
        [SerializeField] private List<JointDoor> Doors;

        public override void InstallBindings()
        {
            Container.Bind<List<IDoor>>().FromInstance(new List<IDoor>(Doors)).AsSingle();
            Container.Bind<ISpawner>().To<BaseSpawner>().AsSingle();
        }
    }
}
