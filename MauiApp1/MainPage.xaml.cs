namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()

        {

            InitializeComponent();

            // DateTime dt = new DateTime(2024, 1, 2); 

            DateTime dt = DateTime.Now;

            dpDate1.Date = dt;



        }



        private void onDateSelected(object sender, EventArgs e)

        {

         

        }

        private void onSwitchToggled(object sender, EventArgs e)

        {

    
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DateTime data = dpDate.Date;
            DateTime data2 = dpDate1.Date;
            Output.Text ="Wylot: "+data.ToString("yyyy/MM/dd")+" Przylot: "+data2.ToString("yyyy/MM/dd")+" Pasażerowie: "+Passengers.Text+" Miejsce Odlotu: "+Wylot.Text+" Miesjce Przylotu: "+Przylot.Text;
        }
    }
}
