using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _coinText;
    [SerializeField] private TextMeshProUGUI _levelText;

    [SerializeField] private Button _startButton;

    [SerializeField] private Image _backgrounImage;
    private void Start()
    {
        _coinText.text = Progres.Instance.Coins.ToString();
        _levelText.text= "Level " + Progres.Instance.Level.ToString();
        _startButton.onClick.AddListener(StartLevel);

        _backgrounImage.color = Progres.Instance.BackgroundColor;
    }

    private void StartLevel()
    {
        SceneManager.LoadScene(Progres.Instance.Level);
    }
}
