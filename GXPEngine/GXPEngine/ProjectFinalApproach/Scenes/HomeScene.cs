﻿using GXPEngine.ButtonsExampleApplication;

namespace GXPEngine.ProjectFinalApproach.Scenes
{
    /// <summary>
    /// Home page scene
    /// </summary>
    public class HomeScene : Scene
    {
        /// <summary>
        /// Set scene content, add it to objects list
        /// </summary>
        public HomeScene() : base()
        {
            // Set scene content
            DropdownMenu menu = new DropdownMenu("images/menuButton.png");
            ColorMapSprite background = new ColorMapSprite("images/startScreen.png", "images/frontColorMap.png");
            ChangeViewButton changeViewButton = new ChangeViewButton("images/changeViewButton.png");
            changeViewButton.SetXY(1000, 600);

            // Add it to objects list
            objects.Add(background);
            objects.Add(menu);
            objects.Add(changeViewButton);
        }
    }
}
