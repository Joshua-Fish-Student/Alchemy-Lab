using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNext : MonoBehaviour
{
    public int numLoad;
    void OnTriggerEnter(Collider other){
        SceneManager.LoadScene(numLoad);
    }
}
