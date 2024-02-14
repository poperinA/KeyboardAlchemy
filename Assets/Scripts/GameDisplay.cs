using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameDisplay : MonoBehaviour
{
    public GameData game;

    public TextMeshProUGUI CharacterName;
    public TextMeshProUGUI CreationDate;

    void Start()
    {
        CharacterName.text = game.characterName;
        CreationDate.text = game.creationDate;
    }

}
