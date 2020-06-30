using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Spawn : MonoBehaviour
{
    private static Transform target;

    private int count;

    public void Replay()
    {
        SceneManager.LoadScene("遊戲場景");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
