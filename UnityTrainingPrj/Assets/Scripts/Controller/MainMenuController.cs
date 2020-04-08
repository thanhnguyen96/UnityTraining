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
    public void LoadScenePhysicsCatapult()
    {
        SceneManager.LoadScene("PhysicsCatapult");
    }
    public void LoadSceneSimpleAnimation()
    {
        SceneManager.LoadScene("SimpleAnimation");
    }
    public void LoadSceneSoundExample()
    {
        SceneManager.LoadScene("SoundExample");
    }
}
