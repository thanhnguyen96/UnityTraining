using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadSceneBasicGUI()
    {
        SceneManager.LoadScene("BasicGUI");
    }

    public void LoadSceneTagAndLayer()
    {
        SceneManager.LoadScene("TagAndLayer");
    }

    public void LoadSceneSample()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
