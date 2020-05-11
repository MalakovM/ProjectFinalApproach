using System;
using System.Collections.Generic;
using System.Drawing;

namespace GXPEngine.ProjectFinalApproach
{
    public class ColorMapSprite : Sprite
	{
		//static void Main()
		//{
		//	new ColorMap().Start();
		//}

		Sprite realImage;
		Sprite lookupImage;

		EasyDraw _text;

		Dictionary<int, string> lookupMap = new Dictionary<int, string>();

		public ColorMapSprite(String spriteFilePath, String mapFilePath) : base(spriteFilePath)
		{
			realImage = new Sprite(spriteFilePath);
			lookupImage = new Sprite(mapFilePath);

			AddChild(realImage);
			AddChild(lookupImage);

			//setup lookup image, toggle with space
			lookupImage.alpha = 0.5f;
			lookupImage.visible = false;

			_text = new EasyDraw(250, 25);
			_text.TextAlign(CenterMode.Min, CenterMode.Min);
			AddChild(_text);

			//create lookup map for all your values		
			//eye dropper in photoshop, right click, copy color hex code, and add 0x in front
			lookupMap[0xff0000] = "Chest";
			lookupMap[0x00ff00] = "Abdomen";
			lookupMap[0x0000ff] = "Biceps";
			lookupMap[0x00ffff] = "Forearms";
			lookupMap[0xffff00] = "Quads";
			lookupMap[0xff00ff] = "Shoulders";

		}


		void Update()
		{
			if (Input.GetKeyDown(Key.SPACE)) lookupImage.visible = !lookupImage.visible;

			//get the bitmap from the sprite
			Bitmap bitmap = lookupImage.texture.bitmap;
			//check if mouse is within bitmap bounds
			if (Input.mouseX >= 0 && Input.mouseX < bitmap.Width && Input.mouseY >= 0 && Input.mouseY < bitmap.Height)
			{
				//get pixel
				Color c = bitmap.GetPixel(Input.mouseX, Input.mouseY);
				//convert to usable value by removing the alpha value
				int lookupColor = c.ToArgb() & 0xffffff;

				_text.Clear(Color.Black);
				if (lookupMap.ContainsKey(lookupColor))
				{
					_text.Text("Info:" + lookupMap[lookupColor], 0, 0);
				}
			}
		}


	}


}

