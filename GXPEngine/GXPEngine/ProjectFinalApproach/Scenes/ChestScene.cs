using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GXPEngine.ButtonsExampleApplication;

namespace GXPEngine.ProjectFinalApproach.Scenes
{
    class ChestScene : Scene
    {
        public ChestScene() : base()
        {
            // Set scene content
            DropdownMenu menu = new DropdownMenu("images/menuButton.png");
            ColorMapSprite background = new ColorMapSprite("images/chestActive.png", "images/frontColorMap.png");
            ChangeViewButton changeViewButton = new ChangeViewButton("images/changeViewButton.png");
            changeViewButton.SetXY(1000, 600);

            // Add it to objects list
            objects.Add(background);
            objects.Add(menu);
            objects.Add(changeViewButton);
        }
    }
}
