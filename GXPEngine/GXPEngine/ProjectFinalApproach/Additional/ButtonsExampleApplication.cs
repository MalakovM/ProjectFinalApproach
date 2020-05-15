using GXPEngine;
using GXPEngine.ButtonsExampleApplication;
using System.Drawing;

/// <summary>
/// Application for showcasing usage of the Button class
/// </summary>
public class ButtonsExampleApplication : Game
{
    /// <summary>
    /// Init window and add example buttons
    /// </summary>
    public ButtonsExampleApplication() : base(1280, 720, false)
    {
        // Create example buttons
        var exampleButton1 = new DefaultButton("images/buttons/default.png");
        var exampleButton2 = new DefaultSoundButton("images/buttons/default_sound.png");
        var exampleButton3 = new SoundMirrorButton("images/buttons/sound_mirror.png");
        var exampleButton4 = new OutlineButton("images/buttons/outline.png", Color.Green);
        var exampleButton5 = new DefaultOutlineButton("images/buttons/default_outline.png");

        // Set buttons position
        var gameHalfWidth = game.width * 0.5f;
        var gameHeight = game.height;
        exampleButton1.SetXY(gameHalfWidth, gameHeight / 6);
        exampleButton2.SetXY(gameHalfWidth, gameHeight / 3);
        exampleButton3.SetXY(gameHalfWidth, gameHeight / 2);
        exampleButton4.SetXY(gameHalfWidth, gameHeight * 2 / 3);
        exampleButton5.SetXY(gameHalfWidth, gameHeight * 5 / 6);

        // Add buttons to the Game
        AddChild(exampleButton1);
        AddChild(exampleButton2);
        AddChild(exampleButton3);
        AddChild(exampleButton4);
        AddChild(exampleButton5);
    }

    /// <summary>
    /// Start ButtonsExampleApplication
    /// </summary>
    //static void Main()
    //{
    //    new ButtonsExampleApplication().Start();
    //}
}