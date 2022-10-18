using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Gameplay.HoldingStructure
{
    public class JointDoor : MonoBehaviour, IDoor
    {
        [SerializeField] private float openingDuration;
        [SerializeField] private Transform joint;
        [SerializeField] private Transform movingEnd;
        [SerializeField] private Transform endDestination;

        public async void Open()
        {
            var jointPos = joint.position;
            float initialLeftRotationAngle = Vector3.Angle(movingEnd.position - jointPos, endDestination.position - jointPos);
            float whichSide = 
                Quaternion.FromToRotation(movingEnd.position - jointPos, endDestination.position - jointPos).eulerAngles.z > 180f ? -1f : 1f;
            float leftRotationAngle = initialLeftRotationAngle;
            while (leftRotationAngle > 0f)
            {
                float rotationAngle =
                    Mathf.Clamp(leftRotationAngle, 0f, initialLeftRotationAngle / openingDuration * Time.deltaTime);
                leftRotationAngle -= rotationAngle;
                transform.RotateAround(jointPos, Vector3.forward, rotationAngle * whichSide);
                await UniTask.Yield(PlayerLoopTiming.Update);
            }
        }
    }
}