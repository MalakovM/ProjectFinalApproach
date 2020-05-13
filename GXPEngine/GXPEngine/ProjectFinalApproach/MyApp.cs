using System;
using System.Drawing;
using GXPEngine.Core;
using System.Collections.Generic;
using GXPEngine;
using GXPEngine.ProjectFinalApproach;
using GXPEngine.ProjectFinalApproach.Scenes;
using System.Runtime.ExceptionServices;

namespace GXPEngine.ProjectFinalApproach
{
     public class MyApp : Game
    {
        Scene targetScene;
        static Scene mainScene;
        
        HomeScene homeScene;
        ChestScene chestScene;
        BackScene backScene;
        ChestInfoScene chestInfoScene;

        public static String state = "Main";
        public static bool turned = false;


        public MyApp() : base(1920, 1080, false, false)
        {
            homeScene = new HomeScene();
            chestScene = new ChestScene();
            backScene = new BackScene();
            chestInfoScene = new ChestInfoScene();
            mainScene = homeScene;
            targetScene = mainScene;
        }

        static void Main()
        {
            MyApp myApp = new MyApp();
            myApp.Start();
        }
        void Update()
        {
            if (targetScene != null)
            {
                HandleState();
                DrawScene();
                //Console.WriteLine("State - " + state);
                Console.WriteLine("targetScene - " + targetScene);
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

        public void CleanScene()
        {
            if (targetScene.objects == null)
                return;
            for (int i = 0; i < targetScene.objects.Count; i++)
            {
                if (targetScene.objects[i] != null)
                {
                    RemoveChild(targetScene.objects[i]);
                }
            }
        }

        public void HandleState()
        {
            switch (state)
            {
                case "Main":
                    if (!turned)
                    {
                        CleanScene();
                        targetScene = homeScene;
                    }
                    else
                    {
                        CleanScene();
                        targetScene = backScene;
                    }
                    break;
                case "Chest":
                    CleanScene();
                    targetScene = chestScene;
                    break;
                case "Abdomen":
                    //CleanScene();
                    //targetScene = abdomenScene;
                    break;
                case "Biceps":
                    //CleanScene();
                    //targetScene = bicepsScene;
                    break;
                case "Forearms":
                    //CleanScene();
                    //targetScene = foreamsScene;
                    break;
                case "Quads":
                    //CleanScene();
                    // targetScene = quadsScene;
                    break;
                case "Shoulders":
                    //CleanScene();
                    //targetScene = shouldersScene;
                    break;
                case "ChestInfo":
                    CleanScene();
                    targetScene = chestInfoScene;
                    break;
            }

        }
    }
}
