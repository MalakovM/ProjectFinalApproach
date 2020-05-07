using System;
using System.Drawing;
using GXPEngine;

public class ProjectFinalApproach : Game
{
	Canvas _background;
	Canvas _startMenu;
	private State _state;
	enum State
	{
		MAIN,
		CHEST,
		QUADS,
		QUADSINFO,
		MENU,
		LIST,
	}
	public ProjectFinalApproach():base (1920,1080, false, false)
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
		}
	}
	static void Main() {
		new ProjectFinalApproach().Start ();
	}
	void Update()
	{
		Controls();
		handleState();
	}

	void Controls()
	{

		//brings to chest
		if ( Input.mouseX < 845 && Input.mouseX > 740 && Input.mouseY < 380 && Input.mouseY > 320 && _state != State.LIST)
		{
			setState(State.CHEST);
		}

		//brings to quads
		if (Input.mouseX < 820 && Input.mouseX > 735 && Input.mouseY < 560 && Input.mouseY > 495 && _state != State.QUADSINFO && _state != State.LIST)
		{
			setState(State.QUADS);
		}

		if (Input.GetMouseButton(0) && Input.mouseX < 820 && Input.mouseX > 735 && Input.mouseY < 560 && Input.mouseY > 495 && _state != State.LIST)
		{
			setState(State.QUADSINFO);
		}

		
		if (Input.GetMouseButton(0) && Input.mouseX < 100 && Input.mouseX > 1 && Input.mouseY < 80 && Input.mouseY > 1 )
		{
			setState(State.MENU);
		}

		if (Input.GetMouseButton(0) && Input.mouseX < 180 && Input.mouseX > 1 && Input.mouseY < 120 && Input.mouseY > 80 && _state == State.MENU)
		{
			setState(State.LIST);
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
		_background = new Canvas ("images/chestActive.png");
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
	
}