using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tensorflow.Framework.Models;
using Tensorflow;
using Xamarin.TensorFlow.Lite;
using Java.Nio;
using static Android.Graphics.ColorSpace;
using Image = SixLabors.ImageSharp.Image;
using Size = SixLabors.ImageSharp.Size;
using ResizeMode = SixLabors.ImageSharp.Processing.ResizeMode;
using Android.Content.Res;
using Android.OS;

namespace Atadan.AiModel {
    //public class AiModel 
    //{
    //    private Interpreter _interpreter;
    //    public AiModel(AssetManager assets, string modelPath) {
    //        // Load the TensorFlow Lite model
    //        var options = new Interpreter.Options();
    //        _interpreter = new Interpreter((Java.IO.File)modelPath); 
    //    }
        

    //    //public void PredictDisease() {
    //    //    var imagePath = "path/to/your/input/image.jpg";
    //    //    var inputImage = Image.Load<Rgb24>(imagePath);
    //    //    inputImage.Mutate(x => x.Resize(new ResizeOptions {
    //    //        Size = new Size(224, 224),
    //    //        Mode = ResizeMode.Stretch
    //    //    }));

    //    //    // Convert the preprocessed image to a float array
    //    //    var inputBuffer = new float[1, 224, 224, 3];
    //    //    for (var y = 0; y < 224; y++) {
    //    //        for (var x = 0; x < 224; x++) {
    //    //            var pixel = inputImage[x, y];
    //    //            inputBuffer[0, y, x, 0] = pixel.R / 255.0f;
    //    //            inputBuffer[0, y, x, 1] = pixel.G / 255.0f;
    //    //            inputBuffer[0, y, x, 2] = pixel.B / 255.0f;
    //    //        }
    //    //    }
    //    //}


    //    public string PredictDisease(string imagePath) {
    //        // Preprocess input image


    //        // Perform inference
    //        // ...

    //        // Process predictions
    //        // ...

    //        return "";
    //        // Return predicted disease
    //        // ...
    //    }

    //    private void PreprocessInputImage(string imagePath) {
    //        // Implement image preprocessing logic (e.g., resizing, normalization)
    //        // ...
    //        var inputImage = Image.Load<Rgb24>(imagePath);
    //        inputImage.Mutate(x => x.Resize(new ResizeOptions {
    //            Size = new Size(224, 224),
    //            Mode = ResizeMode.Stretch
    //        }));

    //        // Convert the preprocessed image to a float array
    //        var inputBuffer = new float[1, 224, 224, 3];
    //        for (var y = 0; y < 224; y++) {
    //            for (var x = 0; x < 224; x++) {
    //                var pixel = inputImage[x, y];
    //                inputBuffer[0, y, x, 0] = pixel.R / 255.0f;
    //                inputBuffer[0, y, x, 1] = pixel.G / 255.0f;
    //                inputBuffer[0, y, x, 2] = pixel.B / 255.0f;
    //            }
    //        }
    //    }

    //    private void PerformInference() {
    //        // Invoke the TensorFlow Lite interpreter and obtain the predictions
    //        // ...
    //    }



    //}
}
