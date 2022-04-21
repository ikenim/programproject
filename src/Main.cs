//LoadAssembly("System.Windows.Forms");
using System.Windows.Forms;
using System;
//LoadAssembly("System.Drawing");
using System.Drawing;
class SnakeApp : System.Windows.Forms.Form
  {
  public SnakeApp()
    {
    Label label;

    ClientSize = new System.Drawing.Size(500,500);

    label = new Label();
    label.Text = "A Mono CSharp REPL Window";
    label.Dock = DockStyle.Fill;
    label.TextAlign = ContentAlignment.MiddleCenter;
    this.Controls.Add(label);
    Text = "Press any key to start.";
  }
  public static void Main(string[] args) {
    Application.Run(new SnakeApp());
  }
  public void DrawImagePointF(PaintEventArgs e)
  {
    Image newImage = Image.FromFile("title.png");

    PointF ulCorner = new PointF(500.0F, 500.0F);

    e.Graphics.DrawImage(newImage, ulCorner);
  }
}
//SnakeApp.Main()
