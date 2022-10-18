using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Gameplay.GameController
{
    public class DefaultCutsceneExecuter : ICutsceneExecuter
    {
        private readonly Camera _camera;
        private readonly Transform _endPoint;
        private float _cutsceneDuration;

        public DefaultCutsceneExecuter(Camera camera, Transform endPoint, float cutsceneDuration)
        {
            _camera = camera;
            _endPoint = endPoint;
            _cutsceneDuration = cutsceneDuration;
        }

        public async UniTask ExecuteCutscene()
        {
            Vector3 startPos = _camera.transform.position;

            await MoveCameraTo(_endPoint.position);

            await UniTask.Delay(TimeSpan.FromSeconds(1));

            await MoveCameraTo(startPos);
        }

        private async UniTask MoveCameraTo(Vector3 destination)
        {
            Vector3 startPos = _camera.transform.position;
            float translationLeft = (destination - startPos).magnitude;
            while (translationLeft != 0f)
            {
                Vector3 translateVector = (destination - startPos) * Time.deltaTime / _cutsceneDuration;
                translateVector = Vector3.ClampMagnitude(translateVector, translationLeft);
                _camera.transform.Translate(translateVector, Space.World);
                translationLeft -= translateVector.magnitude;
                await UniTask.Yield(PlayerLoopTiming.Update);
            }
        }
    }
}