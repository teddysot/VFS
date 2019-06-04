using UnityEngine;

public class GameManager : SingletonBehaviour<GameManager>
{
    protected override void SingletonAwake() { }

    public Color[] TeamColors;
}
