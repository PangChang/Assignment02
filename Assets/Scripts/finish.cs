using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
    public void FinishGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
