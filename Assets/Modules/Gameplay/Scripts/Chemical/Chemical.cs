using System;
using Gameplay.GameController;
using Gameplay.ProgressNotifier;
using UnityEngine;
using UnityEngine.EventSystems;
using Zenject;

namespace Gameplay.Chemical
{
    public class Chemical : MonoBehaviour, IPointerDownHandler
    {
        [Inject]
        public void Construct(IGameBeginner gameBeginner, IProgressListener progressListener)
        {
            _gameBeginner = gameBeginner;
            _progressListener = progressListener;
        }

        private IGameBeginner _gameBeginner;
        private IProgressListener _progressListener;
        
        public void OnPointerDown(PointerEventData eventData)
        {
            if (_gameBeginner.IsGameBegun()) DestroyThisChemical();
        }

        private void DestroyThisChemical()
        {
            Destroy(gameObject);
            _progressListener.NotifyOfProgress(true);
        }
    }
}