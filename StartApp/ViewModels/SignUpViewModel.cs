using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StartApp.ViewModels
{
    public class SignUpViewModel
    {
        #region Fields

        string _name = string.Empty;

        string _phoneNumber = string.Empty;

        string _otp = string.Empty;

        bool _isPopUpOpen = false;

        public ICommand CopyOtpCommand { get; }

        #endregion

        public SignUpViewModel()
        {
            CopyOtpCommand = new Command(OTPCopiedTapped);
        }

        #region Properties
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public bool IsPopUpOpen
        {
            get => _isPopUpOpen;
            set
            {
                _isPopUpOpen = value;
                OnPropertyChanged(nameof(IsPopUpOpen));
            }
        }

        public string OTP
        {
            get => _otp;
            set
            {
                _otp = value;
                OnPropertyChanged(nameof(OTP));
            }
        }

        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                _phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        #endregion

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        async void OTPCopiedTapped()
        {
            await Clipboard.SetTextAsync(OTP);
            IsPopUpOpen = false;
        }



    }
}
