namespace GXPEngine.ButtonsExampleApplication
{
    /// <summary>
    /// Scalable button abstract class, that handles following events:
    /// - onMouseHover
    /// - onMouseUnhover
    /// - onMouseDown
    /// - onMouseUp
    /// </summary>
    public abstract class Button : Sprite
    {
        // Flag
        private bool hovered = false;
        // Scales intencity of the default button hover effect
        private float hoverScale = 0.99f;
        /// <summary>
        /// Button constructor
        /// </summary>
        /// <param name="filePath"> Filepath to button img file </param>
        public Button(string filePath) : base(filePath)
        {
            // Reset origin to image center
            SetOrigin(width * 0.5f, height * 0.5f);
        }

        #region Virtual functions

        /// <summary>
        /// Called when mouse is hovered over the button
        /// </summary>
        protected virtual void onMouseHover()
        {
            // Scale button down
            SetScaleXY(hoverScale, hoverScale);
        }

        /// <summary>
        /// Called when mouse is unhovered from the button
        /// </summary>
        protected virtual void onMouseUnhover()
        {
            // Scale button up
            SetScaleXY(1, 1);
        }

        /// <summary>
        /// Called when left mouse button is pressed down while mouse is hovered over the button
        /// </summary>
        protected virtual void onMouseDown()
        {
        }

        /// <summary>
        /// Called when left mouse button is released while mouse is hovered over the button
        /// </summary>
        protected virtual void onMouseUp()
        {
        }

        #endregion Virtual functions

        /// <summary>
        /// Handle button events on update
        /// </summary>
        public void Update()
        {
            // Check if mouse is over the button
            var hit = HitTestPoint(Input.mouseX, Input.mouseY);
            
            // Handle hover
            if (hit && !hovered)
            {
                onMouseHover();
                hovered = true;
            }

            // Handle unhover
            else if (!hit && hovered)
            {
                onMouseUnhover();
                hovered = false;
            }

            // Handle left mouse button down
            if (hovered && Input.GetMouseButtonDown(0))
                onMouseDown();

            // Handle left mouse button up
            else if (hovered && Input.GetMouseButtonUp(0))
                onMouseUp();
        }
    }
}
