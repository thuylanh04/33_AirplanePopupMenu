using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // <== thêm dòng này để load scene

public class GameManager : MonoBehaviour
{
    public GameObject popupCanvas; 
    public TMP_Text titleText;
    public TMP_Text messageText;

    void Start()
    {
        popupCanvas.SetActive(false);
    }

    public void ShowPopup()
    {
        popupCanvas.SetActive(true);
        titleText.text = "Level Complete!";
        messageText.text = "Your airplane has reached the wall.";
    }

    // ⚡ Hàm bấm nút Continue
    public void NextScene()
    {
        int nextIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextIndex);
        }
        else
        {
            Debug.Log("No next scene found!");
        }
    }

    // 🔄 Hàm bấm nút Restart
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
