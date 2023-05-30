using Android.App;
using Android.Content.PM;
using Android.OS;

namespace Atadan;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState) {
        base.OnCreate(savedInstanceState);

        //// Initialize TensorFlow Lite model
        //var assets = Assets;
        //var modelPath = "path/to/your/model.tflite";
        //var tfLiteHelper = new AiModel.AiModel(assets, modelPath);

        //// Perform plant disease prediction
        //var imagePath = "path/to/your/input/image.jpg";
        //var predictedDisease = tfLiteHelper.PredictDisease(imagePath);

        //// Display the results or take appropriate action
        //// ...
    }
}
