using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{
    public string sceneName = "nextScene";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}