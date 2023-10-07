﻿namespace ImageProcessorLib
{
    public static class OperationImage
    {
        /// <summary>
        /// Draw the supplied image according to the parameters.
        /// </summary>
        public static ImageProcessor WithImage(this ImageProcessor imageProcessor, Image image, int x, int y, float opacity = 1.0f)
        {
            imageProcessor.AddOperation(ctx => ctx.DrawImage(image, new Point(x, y), opacity));
            return imageProcessor;
        }
    }
}
