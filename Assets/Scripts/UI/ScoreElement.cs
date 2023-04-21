using System.Collections;
using TMPro;
using UnityEngine;

public class ScoreElement : MonoBehaviour
{
    public ItemType ItemType;
    public int CurrentScore;
    public Transform IconTransform;
    public int Level;
    public GameObject FlyingIconPrefab;

    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private AnimationCurve _scaleCurve;

    [ContextMenu("AddOne")]

    public void AddOne()
    {
        CurrentScore--;

        if(CurrentScore < 0)
        {
            CurrentScore = 0;
        }

        _text.text = CurrentScore.ToString();

        StartCoroutine(AddAnimation());
        //ScoreMeneger.Instance.CheckWin();
    }

    public virtual void Setup(Task task)
    {
        CurrentScore = task.Number;
        _text.text = task.Number.ToString();
    }

    IEnumerator AddAnimation()
    {
        for(float t = 0; t <1f; t += Time.deltaTime * 1.8f)
        {
            float scale = _scaleCurve.Evaluate(t);
            IconTransform.localScale = Vector3.one * scale;
            yield return null;
        }

        IconTransform.localScale = Vector3.one;
    }
}
