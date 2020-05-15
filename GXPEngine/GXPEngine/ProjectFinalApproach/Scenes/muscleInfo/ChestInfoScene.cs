using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using GXPEngine.ButtonsExampleApplication;

namespace GXPEngine.ProjectFinalApproach.Scenes
{
    class ChestInfoScene : Scene
    {
        public ChestInfoScene() : base()
        {
            // Set scene content
            Sprite background = new Sprite("images/background/background.png");
            BodyButton bodyButton = new BodyButton("images/buttons/bodyButton.png");
            bodyButton.SetXY(100, 900);
            Sprite exercise = new Sprite("images/exercises/Chest.png");
            exercise.SetXY(1920 / 2 - exercise.width / 2, 1080 / 3 + 100);
            DropdownMenu menu = new DropdownMenu("images/buttons/menuButton.png");

            EasyDraw name = new EasyDraw(1300, 200);
            EasyDraw description1 = new EasyDraw(1300, 200);
            EasyDraw description2 = new EasyDraw(1300, 200);
            EasyDraw description3 = new EasyDraw(1300, 200);
            EasyDraw description4 = new EasyDraw(1300, 200);
            EasyDraw description5 = new EasyDraw(1300, 200);
            EasyDraw addText = new EasyDraw(1300, 200);
            EasyDraw exName = new EasyDraw(1300, 200);

            AddtoListButton addtoListButton = new AddtoListButton("images/buttons/addButton.png");
            addtoListButton.SetXY(1300, 800);

            name.TextSize(32);
            description1.TextSize(22);
            description2.TextSize(22);
            description3.TextSize(22);
            description4.TextSize(22);
            addText.TextSize(22);
            description5.TextSize(28);
            exName.TextSize(28);

            name.brush.Color = Color.Black;
            name.SetXY(300, 40);
            name.Text("                                                                     Pectoral muscles", 1920 / 2 - description1.width, 100);

            description1.SetXY(300, 100);
            description1.TextAlign(CenterMode.Min, CenterMode.Min);
            description1.Text("                                          Pectoral muscles are the muscles that connect the front of the human chest with the bones of the ", 1920 / 2 - description1.width, 100);

            description2.SetXY(300, 140);
            description2.TextAlign(CenterMode.Min, CenterMode.Min);
            description2.Text("                                          upper arm and shoulder. Pectoralis major is a thick, fan-shaped muscle, which makes up the bulk", 1920 / 2 - description1.width, 100);

            description3.SetXY(300, 180);
            description3.TextAlign(CenterMode.Min, CenterMode.Min);
            description3.Text("                                          of the chest muscle. It lies under the breast. It serves to flex, extend, and rotate the humerus, ", 1920 / 2 - description1.width, 100);

            description4.SetXY(300, 220);
            description4.TextAlign(CenterMode.Min, CenterMode.Min);
            description4.Text("                                          the long bone of the upper arm.", 1920 / 2 - description1.width, 100);

            description5.brush.Color = Color.Black;
            description5.SetXY(300, 350);
            description5.Text("                                                                              Recomended exercise:", 1920 / 2 - description1.width, 100);

            exName.SetXY(800, 820);
            exName.TextAlign(CenterMode.Min, CenterMode.Min);
            exName.Text("                                         Push-Ups", 1920 / 2 - description1.width, 100);

            addText.SetXY(1340, 680);
            addText.TextAlign(CenterMode.Min, CenterMode.Min);
            addText.Text("                                          Add exercise to the list", 1920 / 2 - description1.width, 100);

            ExitButton exitButton = new ExitButton("images/buttons/closeButton.png");
            exitButton.SetXY(1850, 70);
            // Add it to objects list
            objects.Add(background);
            objects.Add(bodyButton);
            objects.Add(exercise);

            objects.Add(name);
            objects.Add(description1);
            objects.Add(description2);
            objects.Add(description3);
            objects.Add(description4);
            objects.Add(description5);
            objects.Add(addtoListButton);
            objects.Add(addText);
            objects.Add(exName);
            objects.Add(exitButton);


            objects.Add(menu);

        }
    }
}