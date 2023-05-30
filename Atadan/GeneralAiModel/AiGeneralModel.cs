//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Components.Forms;
//using Microsoft.ML.OnnxRuntime;
//using Microsoft.ML.OnnxRuntime.Tensors;
//using Tensorflow;
//using Image = SixLabors.ImageSharp.Image;
//using ResizeMode = SixLabors.ImageSharp.Processing.ResizeMode;
//using Size = SixLabors.ImageSharp.Size;

//namespace Atadan.GeneralAiModel {
//    public class AiGeneralModel 
//    {
//        public void LoadModel(string imgpath) 
//        {
//            //using(var session = new InferenceSession("path/to/model")) {
//            //    float[] inputdata = PrepareInputData(imgpath);
//            //    var tensor = new DenseTensor<float>(inputdata, session.InputMetadata["0"].Dimensions);

//            //    var names = session.InputMetadata.Values.ToList();
//            //    var name = names.FirstOrDefault();
//            //    var inputs = new List<NamedOnnxValue>
//            //    {

//            //        NamedOnnxValue.CreateFromTensor(name.ToString(),tensor)
//            //    };
//            //    using (var results = session.Run(inputs)) {
//            //        // Process the results
//            //        var outputData = results.First().AsTensor<float>().ToArray();
//            //        // Process and display the output data
//            //    }
//            //}
//            var assembly = Assembly.GetExecutingAssembly();
//            var resource = "Atadan.Assets.model.onnx";
//            var modelPath = "../Assets/model.onnx";
//            var stream = assembly.GetManifestResourceStream(resource);
//            var session = new InferenceSession(stream.ToString());
//            var inputData = PrepareInputData(imgpath);




//            // Create input tensor
//            var inputName = session.InputMetadata.Keys.First();
//            var inputShape = session.InputMetadata[inputName].Dimensions.ToArray();
//            var inputTensor = new DenseTensor<float>(inputShape);
//            var inputSpan = inputTensor.Buffer.Span;
//            var inputDataArray = inputData.ToArray();

//            for (int i = 0; i < inputDataArray.Length; i++) {
//                inputSpan[i] = inputDataArray[i];
//            }

//            var inputs = new List<NamedOnnxValue> { 
//                NamedOnnxValue.CreateFromTensor(inputName, inputTensor),
//            };

//            var res = session.Run(inputs);

//            var outputName = session.OutputMetadata.Keys.First();
//            var outputTensor = res.FirstOrDefault(x=>x.Name == outputName).AsTensor<float>();
//            var outputData = outputTensor.ToArray();

//        }
//        public float[] PrepareInputData(string imagePath) {
//            var inputImage = Image.Load<Rgb24>(imagePath);
//            inputImage.Mutate(x => x.Resize(new ResizeOptions {
//                Size = new Size(224, 224),
//                Mode = ResizeMode.Stretch
//            }));

//            // Convert the preprocessed image to a float array
//            var inputBuffer = new float[1, 224, 224, 3];
//            for (var y = 0; y < 224; y++) {
//                for (var x = 0; x < 224; x++) {
//                    var pixel = inputImage[x, y];
//                    inputBuffer[0, y, x, 0] = pixel.R / 255.0f;
//                    inputBuffer[0, y, x, 1] = pixel.G / 255.0f;
//                    inputBuffer[0, y, x, 2] = pixel.B / 255.0f;
//                }
//            }
//            float[] floatarr = inputBuffer.Cast<float>().ToArray(); 
//            return floatarr;
//        }

//    }
//}
