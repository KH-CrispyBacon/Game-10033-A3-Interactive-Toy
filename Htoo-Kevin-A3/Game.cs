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
            //Draw.Circle(50, 225, 10);

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


            //If Statements for each key
            //If Players hits the 1-8 key on the keyboard than a whole note will appear on their corrisponding spot

            //Making if statement for F note
            if (Input.IsKeyboardKeyDown(KeyboardKey.One) == true)
            {
                //if 1 key is pressed down then whole note appears and key note turns red
                Draw.SetFillColor(Color.Black);
                Draw.Circle(200, 225, 25);
                Draw.SetFillColor(Color.White);
                Draw.Circle(200, 225, 12);
                Draw.SetFillColor(Color.Red);
                Draw.Rectangle(70, 300, 80, 300);

            }

            // Making if statement for G note

            if (Input.IsKeyboardKeyDown(KeyboardKey.Two) == true)
            {
                //if 1 key is pressed down then whole note appears and key note turns red
                Draw.SetFillColor(Color.Black);
                Draw.Circle(250, 200, 25);
                Draw.SetFillColor(Color.White);
                Draw.Circle(250, 200, 12);
                Draw.SetFillColor(Color.Red);
                Draw.Rectangle(150, 300, 80, 300);

            }

            //Making if statement for A note

            if (Input.IsKeyboardKeyDown(KeyboardKey.Three) == true)
            {
                //if 1 key is pressed down then whole note appears and key note turns red
                Draw.SetFillColor(Color.Black);
                Draw.Circle(300, 175, 25);
                Draw.SetFillColor(Color.White);
                Draw.Circle(300, 175, 12);
                Draw.SetFillColor(Color.Red);
                Draw.Rectangle(240, 300, 80, 300);

            }

            //Making if statement for B note

            if (Input.IsKeyboardKeyDown(KeyboardKey.Four) == true)
            {
                //if 1 key is pressed down then whole note appears and key note turns red
                Draw.SetFillColor(Color.Black);
                Draw.Circle(350, 150, 25);
                Draw.SetFillColor(Color.White);
                Draw.Circle(350, 150, 12);
                Draw.SetFillColor(Color.Red);
                Draw.Rectangle(320, 300, 80, 300);

            }

            //Making if statement for C note

            if (Input.IsKeyboardKeyDown(KeyboardKey.Five) == true)
            {
                //if 1 key is pressed down then whole note appears and key note turns red
                Draw.SetFillColor(Color.Black);
                Draw.Circle(400, 125, 25);
                Draw.SetFillColor(Color.White);
                Draw.Circle(400, 125, 12);
                Draw.SetFillColor(Color.Red);
                Draw.Rectangle(400, 300, 80, 300);

            }

            //making if statement for d note

            if (Input.IsKeyboardKeyDown(KeyboardKey.Six) == true)
            {
                //if 1 key is pressed down then whole note appears and key note turns red
                Draw.SetFillColor(Color.Black);
                Draw.Circle(450, 100, 25);
                Draw.SetFillColor(Color.White);
                Draw.Circle(450, 100, 12);
                Draw.SetFillColor(Color.Red);
                Draw.Rectangle(480, 300, 80, 300);

            }

            //making if statement for e note

            if (Input.IsKeyboardKeyDown(KeyboardKey.Seven) == true)
            {
                //if 1 key is pressed down then whole note appears and key note turns red
                Draw.SetFillColor(Color.Black);
                Draw.Circle(500, 75, 25);
                Draw.SetFillColor(Color.White);
                Draw.Circle(500, 75, 12);
                Draw.SetFillColor(Color.Red);
                Draw.Rectangle(550, 300, 80, 300);

            }

            //making if statement for f note

            if (Input.IsKeyboardKeyDown(KeyboardKey.Eight) == true)
            {
                //if 1 key is pressed down then whole note appears and key note turns red
                Draw.SetFillColor(Color.Black);
                Draw.Circle(550, 50, 25);
                Draw.SetFillColor(Color.White);
                Draw.Circle(550, 50, 12);
                Draw.SetFillColor(Color.Red);
                Draw.Rectangle(630, 300, 80, 300);

            }










        }
    }

}
