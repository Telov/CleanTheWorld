using Cysharp.Threading.Tasks;

namespace Gameplay.GameController
{
    public interface ICutsceneExecuter
    {
        public UniTask ExecuteCutscene();
    }
}