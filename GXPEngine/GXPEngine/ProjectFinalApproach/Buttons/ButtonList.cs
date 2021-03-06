﻿using System.Drawing;
using System.Runtime.InteropServices;

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
    /// Example of a button with default behavior and sound
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
        //
        private const int OUTLINE_WIDTH = 5;
        private Canvas outline;
        private Color outlineColor = Color.Red;

        public OutlineButton(string filePath) : base(filePath)
        {
            outline = new Canvas(this.width, this.height);
            outline.SetOrigin(width * 0.5f, height * 0.5f);
            outline.graphics.DrawRectangle(new Pen(outlineColor, OUTLINE_WIDTH), 0, 0, outline.width, outline.height);
        }
        public OutlineButton(string filePath, Color outlineColor) : base(filePath)
        {
            this.outlineColor = outlineColor;
            outline = new Canvas(this.width, this.height);
            outline.SetOrigin(width * 0.5f, height * 0.5f);
            outline.graphics.DrawRectangle(new Pen(outlineColor, OUTLINE_WIDTH), 0, 0, outline.width, outline.height);
        }

        protected override void onMouseHover()
        {
            AddChild(outline);

        }

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
        private const int OUTLINE_WIDTH = 5;
        private Canvas outline;
        private Color outlineColor = Color.Red;

        public DefaultOutlineButton(string filePath) : base(filePath)
        {
            outline = new Canvas(this.width, this.height);
            outline.SetOrigin(width * 0.5f, height * 0.5f);
            outline.graphics.DrawRectangle(new Pen(outlineColor, OUTLINE_WIDTH), 0, 0, outline.width, outline.height);
        }
        public DefaultOutlineButton(string filePath, Color outlineColor) : base(filePath)
        {
            this.outlineColor = outlineColor;
            outline = new Canvas(this.width, this.height);
            outline.SetOrigin(width * 0.5f, height * 0.5f);
            outline.graphics.DrawRectangle(new Pen(outlineColor, OUTLINE_WIDTH), 0, 0, outline.width, outline.height);
        }

        protected override void onMouseHover()
        {
            base.onMouseHover();
            AddChild(outline);

        }

        protected override void onMouseUnhover()
        {
            base.onMouseUnhover();
            RemoveChild(outline);

        }
    }
}

