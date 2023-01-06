namespace BlazorServer.CommonComponents.Helpers
{
    public class ConfirmDialogHelper
    {
        public event Action<string> OnShow;

        public void Show(string message)
        {
            OnShow?.Invoke(message);
        }

        private Action _onSubmitYes;
        public event Action OnSubmitYes
        {
            remove => _onSubmitYes -= value;
            add
            {
                if (_onSubmitYes != null)
                    _onSubmitYes -= _onSubmitYes;
                _onSubmitYes += value;
            }
        }
        public void SubmitYes()
        {
            if (_onSubmitYes != null)
                _onSubmitYes();
        }
    }
}
