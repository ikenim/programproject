using System;
using System.Drawing;
using System.Windows;

public class Snake {
  private void ImageExampleForm_Paint(object sender, PaintEventArgs e) {
    Image newImage = Image.fromFile("segment.png");

    PointF ulCorner = new PointF(100.0, 100.0);

    e.Graphics.DrawImage(newImage, ulCorner);
  }
}