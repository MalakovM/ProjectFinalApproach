using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GXPEngine.ProjectFinalApproach.Scenes
{
    public class HomeScene : Scene
    {
        public HomeScene() : base()
        {
            DropdownMenu menu = new DropdownMenu("images/menuButton.png");
            ColorMapSprite background = new ColorMapSprite("images/startScreen.png", "images/frontColorMap.png");

            objects.Add(background);
            objects.Add(menu);
            SetObjects(objects);
        }
    }
}
