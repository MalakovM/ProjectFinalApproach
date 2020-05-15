using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using GXPEngine.ButtonsExampleApplication;

namespace GXPEngine.ProjectFinalApproach.Scenes
{
    class AboutScene : Scene
    {
        public AboutScene() : base()
        {
            // Set scene content
            Sprite background = new Sprite("images/background/background.png");
            BodyButton bodyButton = new BodyButton("images/buttons/bodyButton.png");
            bodyButton.SetXY(100, 900);
            DropdownMenu menu = new DropdownMenu("images/buttons/menuButton.png");

            EasyDraw text1 = new EasyDraw(1300, 200);
            EasyDraw text2 = new EasyDraw(1300, 200);
            EasyDraw text3 = new EasyDraw(1300, 200);
            EasyDraw text4 = new EasyDraw(1300, 200);


            text1.TextSize(32);
            text2.TextSize(28);
            Sprite image = new Sprite("images/background/group_photo.jpg");
            text3.TextSize(28);
            text4.TextSize(28);

            image.SetXY(450, 350);

            text1.brush.Color = Color.Black;
            text1.SetXY(300, 200);
            text1.Text("                                                                 Made by Team 22", 1920 / 2 - text1.width, 100);

            text2.brush.Color = Color.Black;
            text2.SetXY(450, 600);
            text2.Text("                                                                   Version 0.1", 1920 / 2 - text1.width, 100);

            text3.brush.Color = Color.Black;
            text3.SetXY(450, 650);
            text3.Text("                                                                     Contact:", 1920 / 2 - text1.width, 100);

            text4.brush.Color = Color.Black;
            text4.SetXY(450, 700);
            text4.Text("                                                          bodybuddy@gmail.com", 1920 / 2 - text1.width, 100);

            ExitButton exitButton = new ExitButton("images/buttons/closeButton.png");
            exitButton.SetXY(1850, 70);
            // Add it to objects list
            objects.Add(background);
            objects.Add(bodyButton);

            objects.Add(text1);
            objects.Add(text2);
            objects.Add(text3);
            objects.Add(text4);
            objects.Add(image);
            objects.Add(exitButton);
            objects.Add(menu);

        }
    }
}