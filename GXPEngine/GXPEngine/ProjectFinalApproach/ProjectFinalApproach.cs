using System;
using System.Drawing;
using GXPEngine.Core;
using System.Collections.Generic;
using GXPEngine;

public class ProjectFinalApproach : Game
{
	bool isTurned;
	Canvas _background;
	private State _state;
	enum State
	{
		MAIN,
		CHEST,
		ABDOMEN,
		BICEP,
		TRICEP,
		FOREARM,
		SHOULDERS,
		TRAPS,
		HAMSTRINGS,
		CALVES,
		QUADS,
		QUADSINFO,
		MENU,
		LIST,
		BACK,
	}
	public ProjectFinalApproach() : base(1920, 1080, false, false)
	{
		setState(State.MAIN);
	}


	void handleState()
	{
		switch (_state)
		{
			case State.MAIN:
				handleMainState();
				break;

			case State.CHEST:
				handleChestState();
				break;

			case State.QUADS:
				handleQuadsState();
				break;
			case State.QUADSINFO:
				handleQuadsInfo();
				break;
			case State.MENU:
				handleMenu();
				break;
			case State.LIST:
				handleList();
				break;
			case State.ABDOMEN:
				handleAbdomen();
				break;
			case State.BACK:
				handleBack();
				break;
		}
	}
	static void Main()
	{
		new ProjectFinalApproach().Start();
	}
	void Update()
	{
		Controls();
		handleState();
		//pixelColour();
	}

	void Controls()
	{

		//brings to chest
		if (Input.mouseX < 845 && Input.mouseX > 740 && Input.mouseY < 380 && Input.mouseY > 320 && _state != State.LIST && isTurned == false)
		{
			setState(State.CHEST);
		}

		//brings to quads
		if (Input.mouseX < 820 && Input.mouseX > 735 && Input.mouseY < 560 && Input.mouseY > 495 && _state != State.QUADSINFO && _state != State.LIST && isTurned == false)
		{
			setState(State.QUADS);
		}
		//abdomen
		if (Input.mouseX < 820 && Input.mouseX > 735 && Input.mouseY < 560 && Input.mouseY > 495 && _state != State.LIST && isTurned == false)
		{
			setState(State.ABDOMEN);
		}

		if (Input.GetMouseButton(0) && Input.mouseX < 820 && Input.mouseX > 735 && Input.mouseY < 560 && Input.mouseY > 495 && _state != State.LIST && isTurned == false)
		{
			setState(State.QUADSINFO);
		}
		

		if (Input.GetMouseButton(0) && Input.mouseX < 100 && Input.mouseX > 1 && Input.mouseY < 80 && Input.mouseY > 1 && isTurned == false)
		{
			setState(State.MENU);
		}

		if (Input.GetMouseButton(0) && Input.mouseX < 180 && Input.mouseX > 1 && Input.mouseY < 120 && Input.mouseY > 80 && _state == State.MENU && isTurned == false)
		{
			setState(State.LIST);
		}
		if (Input.GetMouseButton(0) && Input.mouseX < 970 && Input.mouseX > 890 && Input.mouseY < 760 && Input.mouseY > 700 && _state != State.LIST && isTurned == false)
		{
			setState(State.BACK);
		}
	}
	void setState(State newState)
	{
		if (_state != newState)
		{
			_state = newState;
		}
	}
	void handleMainState()
	{
		_background = new Canvas("images/startScreen.png");
		//_background.SetOrigin(_background.width / 2, _background.height / 2);
		//_background.SetXY(width / 2, height / 2);
		AddChild(_background);

	}

	void handleChestState()
	{
		_background.Destroy();
		_background = new Canvas("images/chestActive.png");
		AddChild(_background);
	}

	void handleQuadsState()
	{
		_background.Destroy();
		_background = new Canvas("images/quadsActive.png");
		AddChild(_background);
	}

	void handleQuadsInfo()
	{
		_background.Destroy();
		_background = new Canvas("images/quadsInfo.png");
		AddChild(_background);
	}

	void handleMenu()
	{
		_background.Destroy();
		_background = new Canvas("images/menuClicked.png");
		AddChild(_background);
	}

	void handleList()
	{
		_background.Destroy();
		_background = new Canvas("images/exerciseList.png");
		AddChild(_background);
	}

	void handleBack()
	{
		_background.Destroy();
		_background = new Canvas("images/backView.png");
		AddChild(_background);
		isTurned = true;
	}

	void handleAbdomen()
	{
		Console.WriteLine("Abdomen");
	}
}
	/*
	void pixelColour()
	{
		Color color = _background.texture.bitmap.GetPixel(100, 150);
		if(color == Color.Blue)
		{
			_background.Destroy();
			_background = new Canvas("images/exerciseList.png");
			AddChild(_background); 
			_background.InverseTransformPoint(Input.mouseX, Input.mouseY)
		}
		//mySprite <yourCodeMySprite>
		//.texture.bitmap.GetPixel(100, 200);
		//return mySprite;

		//return averageColor
	}
	*/
