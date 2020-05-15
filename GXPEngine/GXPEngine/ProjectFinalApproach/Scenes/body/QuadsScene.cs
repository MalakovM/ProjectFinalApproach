using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GXPEngine.ButtonsExampleApplication;

namespace GXPEngine.ProjectFinalApproach.Scenes
{
    class QuadsScene : Scene
    {
        public QuadsScene() : base()
        {
            // Set scene content
            Sprite background = new Sprite("images/background/background.png");
            DropdownMenu menu = new DropdownMenu("images/buttons/menuButton.png");
            ColorMapSprite body = new ColorMapSprite("images/body/body_front_quads.png", "images/body/frontColorMap.png");
            ChangeViewButton changeViewButton = new ChangeViewButton("images/buttons/button_180.png");
            changeViewButton.SetXY(110, 940);
            ExitButton exitButton = new ExitButton("images/buttons/closeButton.png");
            exitButton.SetXY(1850, 70);

            // Add it to objects list
            objects.Add(background);
            objects.Add(body);
            objects.Add(menu);
            objects.Add(changeViewButton);
            objects.Add(exitButton);
        }
    }
}
