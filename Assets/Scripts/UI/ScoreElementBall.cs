using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreElementBall : ScoreElement
{
    [SerializeField] private TextMeshProUGUI _levelText;
    [SerializeField] private RawImage _ballImage;
    [SerializeField] BallSetings _ballSetings;

    public override void Setup(Task task)
    {
        base.Setup(task);

        int number = (int)Mathf.Pow(2, task.Level + 1);
        _levelText.text = number.ToString();
        _ballImage.color = _ballSetings.BallMatterials[task.Level].color;

        Level = task.Level;
    }
}
