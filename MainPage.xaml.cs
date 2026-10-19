namespace mobilna
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
            int rozmiarZm = 0;
        string[] tab = ["Dzień dobry", "Good morning", "Buenos dias"];

        int i = 0;
        public void OnValueChanged(Object sender, EventArgs e)
        {
            rozmiarZm = (int)suwak.Value;
            rozmiar.Text = "Rozmiar: " + rozmiarZm.ToString();
            napisCytatu.FontSize = rozmiarZm;
        }

        public void Clicked(object sender, EventArgs e)
        {
            if(i < 2)
            { 
                i++;
            }
            else
            {
                i = 0;
            }
                napisCytatu.Text = tab[i];
        }
    }

}
