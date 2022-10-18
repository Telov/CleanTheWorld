namespace MainMenu
{
    public class WindowsManager
    {
        private Window _previousWindow;
        private Window _currentWindow;

        public void SetCurrentWindow(Window window)
        {
            _previousWindow = _currentWindow;
            _currentWindow = window;
        }

        public Window GetCurrentWindow()
        {
            return _currentWindow;
        }

        public Window GetPreviousWindow()
        {
            return _previousWindow;
        }
    }
}