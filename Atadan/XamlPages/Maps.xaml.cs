using Microsoft.Maui.Maps;
using Map = Microsoft.Maui.Controls.Maps.Map;
namespace Atadan.XamlPages;

public partial class Maps : ContentPage
{
    public Maps()
	{
		InitializeComponent();
        mappy.Pins.Add(new Microsoft.Maui.Controls.Maps.Pin {
            Label = "Çankaya Üniversitesi",
            Location = new Location(39.81876203124682, 32.56120159697087)
        });
        mappy.Pins.Add(new Microsoft.Maui.Controls.Maps.Pin {
            Label = "Agroset Tarım Market",
            Location = new Location(39.961467862835335, 32.78085881342035)
        });
        mappy.Pins.Add(new Microsoft.Maui.Controls.Maps.Pin {
            Label = "Kurt Tarım ve Bahçe İlaçları",
            Location = new Location(39.97100323200796, 32.724943336694416)
        });
        mappy.Pins.Add(new Microsoft.Maui.Controls.Maps.Pin {
            Label = "Yıldız Tarım ilaçları",
            Location = new Location(39.94277674612372, 32.85793859523074)
        });
        mappy.Pins.Add(new Microsoft.Maui.Controls.Maps.Pin {
            Label = "Tarım Derman Ticaret",
            Location = new Location(39.94085592145026, 32.85836901168583)
        });
        mappy.Pins.Add(new Microsoft.Maui.Controls.Maps.Pin {
            Label = "Lena Tarım Ürünleri Üretim",
            Location = new Location(39.79882655694597, 32.43479489047646)
        });
        mappy.Pins.Add(new Microsoft.Maui.Controls.Maps.Pin {
            Label = "VAPCO TARIM İLAÇ ÜRETİM PAZARLAMA",
            Location = new Location(39.86856980232223, 32.64596105782057)
        });
        mappy.Pins.Add(new Microsoft.Maui.Controls.Maps.Pin {
            Label = "Berkay Peyzaj Zirai Ilac",
            Location = new Location(39.898602911232764, 32.70089269688408)
        });
    }

}