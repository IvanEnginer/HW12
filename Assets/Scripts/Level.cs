using UnityEngine;

[System.Serializable]

public struct Task
{
    public ItemType ItemType;
    public int Number;
    public int Level;
}
public class Level : MonoBehaviour
{
    public int NumberOfBall = 50;
    public int MaxCreatedBallLevel = 1;

    public Task[] Tasks;

    public static Level Instanse;

    private void Awake()
    {
        if(Instanse == null)
        {
            Instanse = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


}
