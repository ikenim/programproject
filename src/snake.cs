using System;
using System.Drawing;
using System.Windows;

class Snake {
  private void ImageExampleForm_Paint(object sender, PaintEventArgs e) {
    Image newImage = Image.fromFile("segment.png");

    PointF ulCorner = new PointF(100.0F, 100.0F);

    e.Graphics.DrawImage(newImage, ulCorner);
  }
}
