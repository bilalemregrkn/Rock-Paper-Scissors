using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
	public static GameManager Instance { get; private set; }

	private ElementController _player;
	private ElementController _enemy;

	[SerializeField] BattleAreaController battleArea;

	[SerializeField] private List<ElementController> listElement;
	[SerializeField] private List<ButtonController> listButton;

	private void Awake()
	{
		Instance = this;
	}

	public void SelectElement(ElementController controller)
	{
		_player = controller;
	}

	public void RandomEnemy()
	{
		var index = Random.Range(0, listElement.Count);
		_enemy = listElement[index];
	}

	private void Start()
	{
		for (int i = 0; i < listButton.Count; i++)
		{
			var button = listButton[i];
			var element = listElement[i];
			button.Populate(element);
		}
	}

	public void Battle()
	{
		var currentState = ResultState.Draw;
		var contains = _player.WeakTypes.Contains(_enemy.MyType);
		currentState = contains ? ResultState.Lose : ResultState.Win;

		if (_player.MyType == _enemy.MyType)
			currentState = ResultState.Draw;

		battleArea.Populate(_player.MySprite, _enemy.MySprite, currentState);
	}
}