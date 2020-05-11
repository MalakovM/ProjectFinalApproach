using System;
using System.Drawing;
using GXPEngine.Core;
using System.Collections.Generic;
using GXPEngine;
using GXPEngine.ProjectFinalApproach;
using GXPEngine.ProjectFinalApproach.Scenes;

namespace GXPEngine.ProjectFinalApproach
{
    public class MyApp : Game
    {
        Scene targetScene;

        HomeScene homeScene;

        public MyApp() : base(1920, 1080, false, false)
        {
            homeScene = new HomeScene();
            SetTargetSceneByName("home");
        }

        static void Main()
        {
            new MyApp().Start();
        }
        void Update()
        {
            if (targetScene != null)
            {
                DrawScene();
            }
            //if (Input.GetMouseButton(0))
            //{
            //	mousePressed();
            //}

        }
        //void mousePressed()
        //{
        //	if (targetScene != null)
        //	{
        //		targetScene.HandleClick(new Vector2(mouseX, mouseY));
        //	}

        //	if (targetScene != menuScene && targetScene != loseScene && targetScene != keypadScene && targetScene != codeScene && targetScene != openBoxScene && targetScene != introScene)
        //	{
        //		inventoryScene.HandleClick(new Vector2(mouseX, mouseY));
        //		clock1.HandleClick();
        //		targetScene.HandleTimeClick();
        //	}
        //}
        public void SetTargetSceneByName(String name)
        {
            switch (name)
            {
                case "home":
                    targetScene = homeScene;
                    break;
            }
        }
        public void DrawScene()
        {
            if (targetScene.objects == null)
                return;
            for (int i = 0; i < targetScene.objects.Count; i++)
            {
                if (targetScene.objects[i] != null)
                {
                    AddChild(targetScene.objects[i]);
                }
            }
        }
    }
}
