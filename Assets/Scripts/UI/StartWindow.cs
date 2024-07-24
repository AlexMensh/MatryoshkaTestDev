using CookingPrototype.Controllers;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StartWindow : MonoBehaviour
{
	[SerializeField] private TMP_Text _goalsNumberText;
	[SerializeField] private Button _startButton;

	private bool _isInit = false;

	private void Start() {

		var gc = GameplayController.Instance;
		_goalsNumberText.text = $"{gc.OrdersTarget}";
	}

	public void Show()	{

		if (!_isInit)
			Init();

		gameObject.SetActive(true);
	}

	public void Hide()	{

		gameObject.SetActive(false);
	}

	private void Init()	{

		var gc = GameplayController.Instance;

		_startButton.onClick.AddListener(StartButtonClicked);
		_isInit = true;
	}

	private void StartButtonClicked() {

		var gc = GameplayController.Instance;

		gameObject.SetActive(false);

		gc.StartGame();
		gc.TapBlock.SetActive(false);
	}
}
