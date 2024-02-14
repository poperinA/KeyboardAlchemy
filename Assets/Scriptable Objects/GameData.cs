using UnityEngine;

[CreateAssetMenu(fileName = "New Game", menuName = "Saved Game")]
public class GameData : ScriptableObject
{
    public string characterName;
    public string creationDate;
}
