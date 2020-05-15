using GXPEngine.ProjectFinalApproach.Scenes;
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

		//EasyDraw _text;

		Dictionary<int, State> lookupMap = new Dictionary<int, State>();
		Dictionary<int, State> lookupInfoMap = new Dictionary<int, State>();

		public ColorMapSprite(String spriteFilePath, String mapFilePath) : base(spriteFilePath)
		{
			realImage = new Sprite(spriteFilePath);
			lookupImage = new Sprite(mapFilePath);

			AddChild(realImage);
			AddChild(lookupImage);

			//setup lookup image, toggle with space
			lookupImage.alpha = 0.5f;
			lookupImage.visible = false;
			
			//_text = new EasyDraw(250, 25);
			//_text.TextAlign(CenterMode.Min, CenterMode.Min);
			//AddChild(_text);

			//create lookup map for all your values		
			//eye dropper in photoshop, right click, copy color hex code, and add 0x in front

			//front
			lookupMap[0xff0000] = State.Chest;
			lookupMap[0x00ff00] = State.Abdomen;
			lookupMap[0x0000ff] = State.Biceps;
			lookupMap[0x00ffff] = State.Forearms;
			lookupMap[0xffff00] = State.Quads;
			lookupMap[0xff00ff] = State.Shoulders;

			//back
			lookupMap[0x9600ff] = State.Triceps;
			lookupMap[0xff9000] = State.Traps;
			lookupMap[0x00a2ff] = State.Hamstrings;
			lookupMap[0x00ff96] = State.Calfs;

			//info
			lookupInfoMap[0xff0000] = State.ChestInfo;
			lookupInfoMap[0x00ff00] = State.AbdomenInfo;
			lookupInfoMap[0x0000ff] = State.BicepsInfo;
			lookupInfoMap[0x00ffff] = State.ForearmsInfo;
			lookupInfoMap[0xffff00] = State.QuadsInfo;
			lookupInfoMap[0xff00ff] = State.ShouldersInfo;
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

				//_text.Clear(Color.Black);
				if (lookupMap.ContainsKey(lookupColor))
				{
					//_text.Text("Info:" + lookupMap[lookupColor].ToString(), 0, 0);
					MyApp.instance.SetState(lookupMap[lookupColor]);

					if (Input.GetMouseButtonUp(0) && lookupInfoMap.ContainsKey(lookupColor))
						MyApp.instance.SetState(lookupInfoMap[lookupColor]);
				}
				else
					MyApp.instance.SetState(State.Main);
			}
		}

	}
}

