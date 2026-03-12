using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject optionsPanel;

    public void StartGame()
    {
        Debug.Log("Game Bắt Đầu!");
    }

    public void OpenOptions()
    {
        if(optionsPanel != null) optionsPanel.SetActive(true);
    }

    public void CloseOptions()
    {
        if(optionsPanel != null) optionsPanel.SetActive(false);
    }

    public void ExitGame()
    {
        Debug.Log("Thoát Game!");
        Application.Quit();
    }
}