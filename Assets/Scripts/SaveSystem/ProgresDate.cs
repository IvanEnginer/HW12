[System.Serializable]

public class ProgresDate
{
    public int Coins;
    public int Level;
    public float[] BackgroundColor;
    public bool IsMusicOn;

    public ProgresDate(Progres progres)
    {
        Coins= progres.Coins;
        Level= progres.Level;

        BackgroundColor = new float[3];
        BackgroundColor[0] = progres.BackgroundColor.r;
        BackgroundColor[1] = progres.BackgroundColor.g;
        BackgroundColor[2] = progres.BackgroundColor.b;

        IsMusicOn= progres.IsMusicOn;
    }
}
