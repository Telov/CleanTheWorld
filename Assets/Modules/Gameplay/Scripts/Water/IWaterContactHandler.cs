using UnityEngine;

namespace Gameplay.Water
{
    public interface IWaterContactHandler
    {
        public void HandleWaterContact(Vector3 position);
    }
}