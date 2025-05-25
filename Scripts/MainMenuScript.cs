using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript :
MonoBehaviour

{
    public static string SB = "";
    public GameObject[] imageTargets;
    public void startapp()
    {
        SceneManager.LoadScene("selectionscene");
    }
    public void exitapp()
    {
        Application.Quit();
    }

    public void LoadARScene(string button)
    {
        SB = button;

        SceneManager.LoadScene("ARscene");
    }
    void Start()
    {
        foreach (GameObject target in imageTargets)
        {
            target.SetActive(false);
        }
        foreach (GameObject target in imageTargets)
        {
            if (target.name == SB)
            {
                target.SetActive(true);
                Debug.Log("Activated target: " + SB);
                break;
            }
        }
    }



}
