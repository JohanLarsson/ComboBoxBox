namespace ComboBoxBox
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    public class TypeItem : INotifyPropertyChanged
    {
        private bool isSelecteded;

        public TypeItem(string text)
        {
            this.Text = text;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Text { get; }

        public bool IsSelecteded
        {
            get => this.isSelecteded;

            set
            {
                if (value == this.isSelecteded)
                {
                    return;
                }

                this.isSelecteded = value;
                this.OnPropertyChanged();
            }
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
