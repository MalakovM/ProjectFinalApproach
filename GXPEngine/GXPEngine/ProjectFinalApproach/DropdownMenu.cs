using GXPEngine.ButtonsExampleApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GXPEngine.ProjectFinalApproach
{
    public class DropdownMenu : Button
    {
        Button[] buttons;
        bool droppedDown = false;

        public DropdownMenu(String filePath) : base(filePath)
        {
            // CreateButtons
            var menuButton1 = new DefaultButton("images/default.png");
            var menuButton2 = new DefaultButton("images/default.png");
            var menuButton3 = new DefaultButton("images/default.png");
            var menuButton4 = new DefaultButton("images/default.png");
            // Fill array
            buttons = new Button[] {menuButton1, menuButton2, menuButton3, menuButton4};
            // position buttons
            SetXY(this.width * 0.5f, this.height * 0.5f);
            buttons[0].SetXY(buttons[0].width * 0.5f - this.width * 0.5f, this.height * 1.5f);
            buttons[1].SetXY(buttons[0].width * 0.5f - this.width * 0.5f, this.height * 1.5f + buttons[0].height);
            buttons[2].SetXY(buttons[0].width * 0.5f - this.width * 0.5f, this.height * 1.5f + buttons[0].height * 2);
            buttons[3].SetXY(buttons[0].width * 0.5f - this.width * 0.5f, this.height * 1.5f + buttons[0].height * 3);
        }

        public void DropMenu()
        {
            // AddChild
            for (int i = 0; i < 4; i++)
            {
                AddChild(buttons[i]);
            }
            // flag
            droppedDown = true;
        }

        public void CloseMenu()
        {
            //RemoveChild
            for (int i = 0; i < 4; i++)
            {
                RemoveChild(buttons[i]);
            }
            //flag
            droppedDown = false;
        }

        protected override void onMouseDown()
        {
            if (!droppedDown) DropMenu();
            else
            {
                CloseMenu();
                
            }
        }
    }
}
