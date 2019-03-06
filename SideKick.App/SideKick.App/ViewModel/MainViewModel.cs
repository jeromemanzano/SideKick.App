using SideKick.App.Model.Managers;
using SideKick.App.Model.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Input;
using Xamarin.Forms;

namespace SideKick.App.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private readonly IUserManager _userManager;
        private readonly IAppService _appService;

        private readonly Timer _clockTimer;
        public MainViewModel(IUserManager userManager, IAppService appService)
        {
            _userManager = userManager;
            _appService = appService;
            ExitCommand = new Command(ExitApp);
            MinusOneCommand = new Command(MinusOneHour);
            _clockTimer = new Timer();
            _clockTimer.Interval = 1000;
        }

        public override void InitPage(object parameter = null)
        {
            base.InitPage(parameter);

            Task.Run(async ()=> 
            {
                var userDetails = await _userManager.GetUserAsync();
                Name = userDetails.Name;
                Avatar = userDetails.Avatar;
                RetrieveLocalTime = userDetails.LocalTime;
                TimeDisplay = userDetails.LocalTime;

                _clockTimer.Elapsed += _clockTimer_Elapsed;
                _clockTimer.Enabled = true;
            });
          
        }

        private void _clockTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            TimeDisplay = TimeDisplay.AddSeconds(1);
        }

        private void MinusOneHour()
        {
            TimeDisplay = TimeDisplay.AddHours(-1);
        }

        private void ExitApp()
        {
            _clockTimer.Elapsed -= _clockTimer_Elapsed;
            _clockTimer.Enabled = false;

            _appService.Exit();
        }

        public ICommand MinusOneCommand { get; private set; }
        public ICommand ExitCommand { get; private set; }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { Set(ref _name, value); }
        }

        private string _avatar;
        public string Avatar
        {
            get { return _avatar; }
            set { Set(ref _avatar, value); }
        }

        private DateTime _retrieveLocalTime;
        public DateTime RetrieveLocalTime
        {
            get { return _retrieveLocalTime; }
            set { Set(ref _retrieveLocalTime, value); }
        }

        private DateTime _timeDisplay;
        public DateTime TimeDisplay
        {
            get { return _timeDisplay; }
            set { Set(ref _timeDisplay, value); }
        }
    }
}
