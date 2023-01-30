using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndSceneManager : MonoBehaviour
{
    public Text status;

    private void Start()
    {
        status.text = GameSceneManager.winner == "Boat" ? "Das Boot hat gewonnen" : "Die Fische haben gewonnen";
    }


    public void PressRestart()
    {
        SceneManager.LoadScene("StartScene");
    }
}
