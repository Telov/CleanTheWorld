using UnityEngine;

namespace Gameplay.Water
{
    public class Water : MonoBehaviour
    {
        private void OnTriggerEnter(Collider collider)
        {
            if (Physics.Raycast(collider.transform.position,
                    Vector3.down,
                    out RaycastHit hit,
                    1000f,
                    1 << LayerMask.NameToLayer("Water")))
            {
                collider.GetComponent<IWaterContactHandler>()?.HandleWaterContact(hit.point);
            }
        }
    }
}