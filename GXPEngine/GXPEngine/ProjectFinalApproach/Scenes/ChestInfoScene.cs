using System;
using System.Collections.Generic;
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
            DropdownMenu menu = new DropdownMenu("images/menuButton.png");
            Sprite background = new Sprite("images/chestInfo.png");
            
            // Add it to objects list
            objects.Add(background);
            objects.Add(menu);
        }
    }
}