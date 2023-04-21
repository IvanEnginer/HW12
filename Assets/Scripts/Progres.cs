using UnityEngine;

public class Progres : MonoBehaviour
{
    public int Coins;
    public int Level;
    public Color BackgroundColor;
    public bool IsMusicOn;

    public static Progres Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        Load();
    }

    public void SetLevel(int level)
    {
        Level = level;
        Save();
    }

    public void AddCoins(int value)
    {
        Coins += value;
        Save();
    }

    [ContextMenu("DeliteFile")]
    public void DeliteFile()
    {
        SaveSystem.DeleteFile();
    }

    [ContextMenu("Save")]
    public void Save()
    {
        SaveSystem.Save(this);
    }

    [ContextMenu("Load")]
    public void Load()
    {
        ProgresDate progresDate = SaveSystem.Load();
        if(progresDate != null)
        {
            Coins = progresDate.Coins;
            Level = progresDate.Level;

            Color color = new Color();
            color.r = progresDate.BackgroundColor[0];
            color.g = progresDate.BackgroundColor[1];
            color.b = progresDate.BackgroundColor[2];
            BackgroundColor = color;

            IsMusicOn = progresDate.IsMusicOn;
        }
        else
        {
            Coins=0;
            Level=1;
            BackgroundColor = Color.blue * 0.5f;
            IsMusicOn = true;
        }

    }
}
