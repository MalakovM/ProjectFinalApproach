using System;
using System.Drawing;
using GXPEngine.Core;
using System.Collections.Generic;
using GXPEngine;
using GXPEngine.ProjectFinalApproach;
using GXPEngine.ProjectFinalApproach.Scenes;
using System.Runtime.ExceptionServices;

public enum State
{
    Main,
    Chest,
    ChestInfo,
    Shoulders,
    ShouldersInfo,
    Quads,
    QuadsInfo,
    Forearms,
    ForearmsInfo,
    Biceps,
    BicepsInfo,
    Abdomen,
    AbdomenInfo,
    Triceps,
    TricepsInfo,
    Traps,
    TrapsInfo,
    Hamstrings,
    HamstringsInfo,
    Calfs,
    CalfsInfo,
    About,
    List
}

public enum Type
{
    Front,
    Back
}

namespace GXPEngine.ProjectFinalApproach
{
    public class MyApp : Game
    {
        private Scene targetScene;

        private AbdomenScene abdomenScene;
        private AbdomenInfoScene abdomenInfoScene;
        private BackScene backScene;
        private BicepsScene bicepsScene;
        private ChestScene chestScene;
        private ForearmsScene forearmsScene;
        private HomeScene homeScene;
        private QuadsScene quadsScene;
        private ShouldersScene shouldersScene;
        private ChestInfoScene chestInfoScene;
        private TricepsScene tricepsScene;
        private TrapsScene trapsScene;
        private HamstringsScene hamstringsScene;
        private CalfsScene calfsScene;
        private AboutScene aboutScene;
        private ListScene listScene;


        public bool turned = true;

        // Singleton
        public static MyApp instance;

        public Type type = Type.Front;

        public MyApp() : base(1920, 1080, false, false)
        {
            MyApp.instance = this;

            abdomenScene = new AbdomenScene();
            abdomenInfoScene = new AbdomenInfoScene();
            backScene = new BackScene();
            bicepsScene = new BicepsScene();
            chestScene = new ChestScene();
            forearmsScene = new ForearmsScene();
            homeScene = new HomeScene();
            quadsScene = new QuadsScene();
            shouldersScene = new ShouldersScene();
            chestInfoScene = new ChestInfoScene();
            tricepsScene = new TricepsScene();
            trapsScene = new TrapsScene();
            hamstringsScene = new HamstringsScene();
            calfsScene = new CalfsScene();
            aboutScene = new AboutScene();
            listScene = new ListScene();

            SetState(State.Main);
        }

        static void Main()
        {
            MyApp myApp = new MyApp();
            myApp.Start();
        }

        public void SetState(State state)
        {
            // Remove scene objects
            if (targetScene != null)
                targetScene.objects.ForEach(each => RemoveChild(each));

            // Set target scene
            if (type == Type.Front)
            {
                switch (state)
                {
                    case State.Main:
                        targetScene = homeScene;
                        break;
                    case State.Chest:
                        targetScene = chestScene;
                        break;
                    case State.Abdomen:
                        targetScene = abdomenScene;
                        break;
                    case State.Biceps:
                        targetScene = bicepsScene;
                        break;
                    case State.Forearms:
                        targetScene = forearmsScene;
                        break;
                    case State.Quads:
                        targetScene = quadsScene;
                        break;
                    case State.Shoulders:
                        targetScene = shouldersScene;
                        break;
                    case State.ChestInfo:
                        targetScene = chestInfoScene;
                        break;
                    case State.AbdomenInfo:
                        targetScene = abdomenInfoScene;
                        break;
                    case State.About:
                        targetScene = aboutScene;
                        break;
                    case State.List:
                        targetScene = listScene;
                        break;
                }
            }

            else if (type == Type.Back)
            {
                switch (state)
                {
                    case State.Main:
                        targetScene = backScene;
                        break;
                    case State.Triceps:
                        targetScene = tricepsScene;
                        break;
                    case State.Traps:
                        targetScene = trapsScene;
                        break;
                    case State.Hamstrings:
                        targetScene = hamstringsScene;
                        break;
                    case State.Calfs:
                        targetScene = calfsScene;
                        break;
                    case State.About:
                        targetScene = aboutScene;
                        break;
                    case State.List:
                        targetScene = listScene;
                        break;
                }
            }


            // Add scene objects
            if (targetScene != null)
                targetScene.objects.ForEach(each => AddChild(each));
        }

        void Update()
        {
            Console.WriteLine(targetScene);
        }
    }
}
