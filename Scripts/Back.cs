using UnityEngine;
using UnityEngine.SceneManagement;
public class BackToSelection : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void LoadSelectionScene(string scene)
    {
        SceneManager.LoadScene(scene);
            }
}
