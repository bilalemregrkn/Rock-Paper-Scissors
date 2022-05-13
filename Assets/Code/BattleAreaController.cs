using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum ResultState
{
	Draw, Win, Lose
}

public class BattleAreaController : MonoBehaviour
{
	[SerializeField] private Image playerImage;
	[SerializeField] private Image enemyImage;
	[SerializeField] private TextMeshProUGUI resultText;

	public void Populate(Sprite player, Sprite enemy, ResultState state)
	{
		gameObject.SetActive(true);
		playerImage.sprite = player;
		enemyImage.sprite = enemy;
		resultText.SetText(state.ToString());
	}
}