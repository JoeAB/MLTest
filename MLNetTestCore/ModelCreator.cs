using System;
using System.IO;
using System.Linq;


namespace MLNetTestCore
{ 
    public static class ModelCreator
    {
        public static void Run(String imagePath)
        {
            ClassifyCatOrDog(imagePath);
        }

        public static void ClassifyCatOrDog(String imagePath)
        {
            //Load sample data
            var imageBytes = File.ReadAllBytes(imagePath);
            Cat_dog.ModelInput sampleData = new Cat_dog.ModelInput()
            {
                ImageSource = imageBytes,
            };

            //Load model and predict output
            var result = Cat_dog.Predict(sampleData);
            Console.WriteLine($"Image: {Path.GetFileName(imagePath)} predicted as: {result.PredictedLabel} with score: {result.Score.Max()} ");

        }
    }
}
