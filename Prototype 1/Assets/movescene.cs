using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movescene : MonoBehaviour
{
    public void loadPlane(){
        SceneManager.LoadScene("planescene");
    }

    public void LoadCar()
    {
        Debug.Log("hi");
        SceneManager.LoadScene("carscene");
    }
    
}
