
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SideKick.App.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
    {
        private StackLayout _landscapeStack;
        private Label _userName;
        private Label _retrieveDate;
        private double _width;
        private double _height;

        public MainPage ()
		{
			InitializeComponent ();
            CreateViews();
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (_width == width || _height == height)
            {
                return;
            }

            _width = width;
            _height = height;

            if (Width > Height)
            {
                TopLayout.Orientation = StackOrientation.Horizontal;
                _userName.HorizontalOptions = LayoutOptions.Start;
                _retrieveDate.HorizontalOptions = LayoutOptions.Start;
                RemoveView(_userName, TopLayout);
                RemoveView(_retrieveDate, TopLayout);
                AddView(_userName, _landscapeStack);
                AddView(_retrieveDate, _landscapeStack);
                AddView(_landscapeStack, TopLayout);
            }
            else
            {
                TopLayout.Orientation = StackOrientation.Vertical;
                _userName.HorizontalOptions = LayoutOptions.Center;
                _retrieveDate.HorizontalOptions = LayoutOptions.Center;
                RemoveView(_userName, _landscapeStack);
                RemoveView(_retrieveDate, _landscapeStack);
                AddView(_userName, TopLayout);
                AddView(_retrieveDate, TopLayout);
                RemoveView(_landscapeStack, TopLayout);
            }
        }

        private void RemoveView(Xamarin.Forms.View view, StackLayout layout)
        {
            if (layout.Children.Contains(view))
            {
                layout.Children.Remove(view);
            }
        }

        private void AddView(Xamarin.Forms.View view, StackLayout layout)
        {
            if (!layout.Children.Contains(view))
            {
                layout.Children.Add(view);
            }
        }

        private void CreateViews()
        {
            _landscapeStack = new StackLayout();
            _userName = new Label()
            {
                FontAttributes = FontAttributes.Bold,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                TextColor = Color.White,
            };

            _retrieveDate = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                TextColor = Color.White,
            };

            _userName.SetBinding(Label.TextProperty, new Binding("Name"));
            _retrieveDate.SetBinding(Label.TextProperty, new Binding("RetrieveLocalTime", stringFormat: "{0:HH:mm}"));
        }
    }
}