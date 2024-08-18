using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Game", menuName = "ScriptableObj/Game", order = 51)]
public class GameType : ScriptableObject
{
    public string Name;

    public string Description;

    public Sprite Ico;
    public List<Sprite> ScrenShot;
    
}
