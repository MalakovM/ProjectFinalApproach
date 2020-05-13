using GXPEngine.ButtonsExampleApplication;
using System;

namespace GXPEngine.ProjectFinalApproach
{
    /// <summary>
    /// Dropdown menu class
    /// </summary>
    public class DropdownMenu : Button
    {
        // Array of menu buttons
        Button[] buttons;
        // Flag
        bool droppedDown = false;

        /// <summary>
        /// Provide menu button filepath, create menu buttons, fill the array with buttons, position menu buttons
        /// </summary>
        /// <param name="filePath"></param>
        public DropdownMenu(String filePath) : base(filePath)
        {
            // Create Buttons
            var menuButton1 = new DefaultButton("images/default.png");
            var menuButton2 = new DefaultButton("images/default.png");
            var menuButton3 = new DefaultButton("images/default.png");
            var menuButton4 = new DefaultButton("images/default.png");

            // Fill array
            buttons = new Button[] {menuButton1, menuButton2, menuButton3, menuButton4};

            // Position buttons
            SetXY(this.width * 0.5f, this.height * 0.5f);
            buttons[0].SetXY(buttons[0].width * 0.5f - this.width * 0.5f, this.height * 1.5f);
            buttons[1].SetXY(buttons[0].width * 0.5f - this.width * 0.5f, this.height * 1.5f + buttons[0].height);
            buttons[2].SetXY(buttons[0].width * 0.5f - this.width * 0.5f, this.height * 1.5f + buttons[0].height * 2);
            buttons[3].SetXY(buttons[0].width * 0.5f - this.width * 0.5f, this.height * 1.5f + buttons[0].height * 3);
        }

        /// <summary>
        /// Drop down the menu
        /// </summary>
        public void DropMenu()
        {
            // AddChild array members
            for (int i = 0; i < 4; i++)
            {
                AddChild(buttons[i]);
            }

            // Switch flag
            droppedDown = true;
        }

        /// <summary>
        /// Close the menu
        /// </summary>
        public void CloseMenu()
        {
            // RemoveChild array members
            for (int i = 0; i < 4; i++)
            {
                RemoveChild(buttons[i]);
            }

            // Switch flag
            droppedDown = false;
        }

        /// <summary>
        /// Open/Close menu on left mouse click
        /// </summary>
        protected override void onMouseDown()
        {
            base.onMouseDown();
            if (!droppedDown) DropMenu();
            else
            {
                CloseMenu();
                
            }
        }
    }
}
