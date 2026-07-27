using UnityEngine;
using UnityEngine.SceneManagement;
public class HideUI : MonoBehaviour
{
    public GameObject uiPanel;
    public string SceneName;
    public void Hide()
    {
        uiPanel.SetActive(false);
        SceneManager.LoadScene(SceneName);
    }
}