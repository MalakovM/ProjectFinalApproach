﻿using System.Drawing;

namespace GXPEngine.ButtonsExampleApplication
{
    /// <summary>
    /// Example of a button with default behavior
    /// </summary>
    public class DefaultButton : Button
    {
        /// <summary>
        /// Provide button img path
        /// </summary>
        public DefaultButton(string filePath) : base(filePath)
        {

        }
    }

    /// <summary>
    /// Example of a button with default behavior and sound
    /// </summary>
    public class DefaultSoundButton : Button
    {
        // Button hover sound
        Sound sound = new Sound("sfx/dirt.wav");

        /// <summary>
        /// Provide button img path
        /// </summary>
        public DefaultSoundButton(string filePath) : base(filePath)
        {

        }

        /// <summary>
        /// Execute default hover handling and play sound
        /// </summary>
        protected override void onMouseHover()
        {
            base.onMouseHover();
            sound.Play();
        }
    }

    /// <summary>
    /// Example of a mirrored button with sound
    /// </summary>
    public class SoundMirrorButton : Button
    {
        // Button hover sound
        Sound sound = new Sound("sfx/dirt.wav");

        /// <summary>
        /// Provide button img path
        /// </summary>
        public SoundMirrorButton(string filePath) : base(filePath)
        {

        }

        /// <summary>
        /// Play sound and mirror on Hover
        /// </summary>
        protected override void onMouseHover()
        {
            sound.Play();
            SetScaleXY(-1 , 1);
        }

        /// <summary>
        /// Un-mirror on unhover
        /// </summary>
        protected override void onMouseUnhover()
        {
            SetScaleXY(1 , 1);
        }
    }

    /// <summary>
    /// Example of a button with outline
    /// </summary>
    public class OutlineButton : Button
    {
        private Canvas outline;

        // Width of the outline, default outline color
        private const int OUTLINE_WIDTH = 5;
        private Color outlineColor = Color.Red;

        /// <summary>
        /// Provide button filepath, draw outline
        /// </summary>
        /// /// <param name="filePath"> Button filepath </param>
        public OutlineButton(string filePath) : base(filePath)
        {
            outline = new Canvas(this.width, this.height);
            outline.SetOrigin(width * 0.5f, height * 0.5f);
            outline.graphics.DrawRectangle(new Pen(outlineColor, OUTLINE_WIDTH), 0, 0, outline.width, outline.height);
        }

        /// <summary>
        /// Provide button filepath, set outline color, draw outline
        /// </summary>
        /// <param name="filePath"> Button filepath </param>
        /// <param name="outlineColor"> Color of the outline </param>
        public OutlineButton(string filePath, Color outlineColor) : base(filePath)
        {
            this.outlineColor = outlineColor;
            outline = new Canvas(this.width, this.height);
            outline.SetOrigin(width * 0.5f, height * 0.5f);
            outline.graphics.DrawRectangle(new Pen(outlineColor, OUTLINE_WIDTH), 0, 0, outline.width, outline.height);
        }

        /// <summary>
        /// Add outline to Game on mouse hover
        /// </summary>
        protected override void onMouseHover()
        {
            AddChild(outline);

        }

        /// <summary>
        /// Remove outline from Game on mouse unhover
        /// </summary>
        protected override void onMouseUnhover()
        {
            RemoveChild(outline);
        }
    }

    /// <summary>
    /// Example of a button with default behavior and outline
    /// </summary>
    public class DefaultOutlineButton : Button
    {
        private Canvas outline;

        // Outline width, default outline color
        private const int OUTLINE_WIDTH = 5;
        private Color outlineColor = Color.Red;

        /// <summary>
        /// Provide button filepath, draw outline
        /// </summary>
        /// <param name="filePath"> Button filepath </param>
        public DefaultOutlineButton(string filePath) : base(filePath)
        {
            outline = new Canvas(this.width, this.height);
            outline.SetOrigin(width * 0.5f, height * 0.5f);
            outline.graphics.DrawRectangle(new Pen(outlineColor, OUTLINE_WIDTH), 0, 0, outline.width, outline.height);
        }

        /// <summary>
        /// Provide button filepath, set outline color, draw outline
        /// </summary>
        /// <param name="filePath"> Button filepath </param>
        /// <param name="outlineColor"> Color of the outline </param>
        public DefaultOutlineButton(string filePath, Color outlineColor) : base(filePath)
        {
            this.outlineColor = outlineColor;
            outline = new Canvas(this.width, this.height);
            outline.SetOrigin(width * 0.5f, height * 0.5f);
            outline.graphics.DrawRectangle(new Pen(outlineColor, OUTLINE_WIDTH), 0, 0, outline.width, outline.height);
        }

        /// <summary>
        /// Execute default hover handling and add outline to Game
        /// </summary>
        protected override void onMouseHover()
        {
            base.onMouseHover();
            AddChild(outline);

        }
        /// <summary>
        /// Unhover, remove outline 
        /// </summary>
        protected override void onMouseUnhover()
        {
            base.onMouseUnhover();
            RemoveChild(outline);

        }
    }
}

