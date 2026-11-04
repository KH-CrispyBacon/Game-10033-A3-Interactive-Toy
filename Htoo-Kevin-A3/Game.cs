// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Piano Music Sheet");
            Window.SetSize(800, 600);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            //Clear background to offwhite color
            Window.ClearBackground(240);

            //Making the music sheet
            Draw.SetLineColor(Color.Black);
            Draw.SetLineSize(3);
            Draw.Line(0, 0, 800, 0);
            Draw.Line(0, 0, 0, 250);
            Draw.Line(800, 0, 800, 250);
            Draw.Line(0, 250, 800, 250);
            Draw.Line(0, 50, 800, 50);
            Draw.Line(0, 100, 800, 100);
            Draw.Line(0, 150, 800, 150);
            Draw.Line(0, 200, 800, 200);

            //Making the treble clef
            Draw.SetLineSize(5);
            Draw.SetLineColor(Color.Black);
            Draw.Line(60, 160, 60, 130);
            Draw.Line(60, 130, 125, 130);
            Draw.Line(125, 130, 125, 175);
            Draw.Line(125, 175, 25, 175);
            Draw.Line(25, 175, 25, 125);
            Draw.Line(25, 125, 125, 80);
            Draw.Line(125, 80, 125, 25);
            Draw.Line(125, 25, 75, 25);
            Draw.Line(75, 25, 75, 225);
            Draw.Line(75, 225, 50, 225);
            Draw.Circle(50, 225, 10);

            //Making the piano outline
            Draw.SetLineColor(Color.Black);
            Draw.SetFillColor(Color.Black);
            Draw.Rectangle(0, 250, 800, 50);
            Draw.Rectangle(0, 300, 70, 300);
            Draw.Rectangle(700, 300, 100, 300);

            //Making the piano white keys
            Draw.SetLineColor(Color.Black);
            Draw.SetFillColor(Color.White);
            Draw.SetLineSize(1);
            Draw.Rectangle(70, 300, 80, 300);
            Draw.Rectangle(150, 300, 80, 300);
            Draw.Rectangle(230, 300, 80, 300);
            Draw.Rectangle(310, 300, 80, 300);
            Draw.Rectangle(390, 300, 80, 300);
            Draw.Rectangle(470, 300, 80, 300);
            Draw.Rectangle(550, 300, 80, 300);
            Draw.Rectangle(630, 300, 80, 300);

            //Making the piano black keys
            Draw.SetFillColor(Color.Black);
            Draw.SetLineColor(Color.Black);
            Draw.Rectangle(130, 300, 40, 150);
            Draw.Rectangle(220, 300, 40, 150);
            Draw.Rectangle(310, 300, 40, 150);
            Draw.Rectangle(450, 300, 40, 150);
            Draw.Rectangle(540, 300, 40, 150);
            Draw.Rectangle(680, 300, 40, 150);


           





           

            
            



            


            
           
            
        }
    }

}
