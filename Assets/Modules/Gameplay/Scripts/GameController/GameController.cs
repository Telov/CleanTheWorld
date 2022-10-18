using System;
using UnityEngine;
using Zenject;

namespace Gameplay.GameController
{
    public class GameController : IGameBeginner, IInitializable
    {
        public event Action OnGameBegin;
        private ICutsceneExecuter _cutsceneExecuter;
        private readonly Texture2D _cursorTexture;
        private bool _gameBegun;

        public GameController(Texture2D CursorTexture, ICutsceneExecuter cutsceneExecuter)
        {
            _cutsceneExecuter = cutsceneExecuter;
            _cursorTexture = CursorTexture;
        }

        public bool IsGameBegun()
        {
            return _gameBegun;
        }


        public async void Initialize()
        {
            Cursor.SetCursor(_cursorTexture, new Vector2(0, _cursorTexture.height - 1), CursorMode.ForceSoftware);
            await _cutsceneExecuter.ExecuteCutscene();
            BeginGame();
        }

        private void BeginGame()
        {
            OnGameBegin.Invoke();
            _gameBegun = true;
        }
    }
}