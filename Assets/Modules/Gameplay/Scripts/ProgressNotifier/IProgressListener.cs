namespace Gameplay.ProgressNotifier
{
    public interface IProgressListener
    {
        public void NotifyOfProgress(bool successful);
    }
}