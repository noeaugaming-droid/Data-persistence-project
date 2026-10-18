using TMPro;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public TMP_InputField nameInput;
    public void SavePlayerName()
    {
        DataManager.Instance.playerName = nameInput.text;
    }
}
