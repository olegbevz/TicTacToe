namespace TicTacToe.Android
{
    using System;

    using TicTacToe.Interfaces;

    using global::Android.Content.Res;
    using global::Android.Graphics;

    using Color = TicTacToe.Interfaces.Color;

    public class AndroidGraphics : IGraphics
    {
        private Canvas canvas;

        private Resources resources;

        public AndroidGraphics(Canvas canvas, Resources resources)
        {
            this.canvas = canvas;

            this.resources = resources;
        }

        public void DrawBitmap()
        {
            var options = new BitmapFactory.Options { InJustDecodeBounds = true };

            var bitmap = BitmapFactory.DecodeResource(resources, Resource.Drawable.Background, options);

            using (var paint = new Paint())
            {
                canvas.DrawBitmap(bitmap, 0, 0, paint);
            }
        }

        public void DrawEllipse(MonoPen pen, int x, int y, int width, int height)
        {
            var drawingColor = this.GetColor(pen.Color); 

            using (var paint = new Paint())
            {
                paint.SetARGB(drawingColor.A, drawingColor.R, drawingColor.G, drawingColor.B);
                paint.SetStyle(Paint.Style.Stroke);
                paint.StrokeWidth = pen.Width;

                canvas.DrawOval(new RectF(x, y, x + width, y + height), paint);
            }
        }

        public void DrawLine(MonoPen pen, int x1, int y1, int x2, int y2)
        {
            var drawingColor = this.GetColor(pen.Color);

            using (var paint = new Paint())
            {
                paint.SetARGB(drawingColor.A, drawingColor.R, drawingColor.G, drawingColor.B);
                paint.SetStyle(Paint.Style.Stroke);
                paint.StrokeWidth = pen.Width;

                paint.StrokeJoin = Paint.Join.Round;
                paint.StrokeCap = Paint.Cap.Round;
                paint.StrokeMiter = (float)0.5;

                canvas.DrawLine(x1, y1, x2, y2, paint);
            }
        }

        public void DrawRectangle(MonoPen pen, int x, int y, int width, int height)
        {
            var drawingColor = this.GetColor(pen.Color);
            
            using (var paint = new Paint())
            {
                paint.SetARGB(drawingColor.A, drawingColor.R, drawingColor.G, drawingColor.B);
                paint.SetStyle(Paint.Style.Stroke);
                paint.StrokeWidth = pen.Width;

                this.canvas.DrawRect(new RectF(x, y, x + width, y + height), paint);
            }
        }

        public System.Drawing.Color GetColor(Color color)
        {
            switch (color)
            {
                case Color.Black:
                    return System.Drawing.Color.Black;
                case Color.Red:
                    return System.Drawing.Color.Red;
                case Color.White:
                    return System.Drawing.Color.White;
                case Color.Blue:
                    return System.Drawing.Color.Blue;
                case Color.Gray:
                    return System.Drawing.Color.LightGray;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}