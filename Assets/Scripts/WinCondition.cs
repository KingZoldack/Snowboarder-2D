using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    [SerializeField] float _reloadDelay;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Invoke("LoadIntro", _reloadDelay);
        }
    }

    void LoadIntro()
    {
        SceneManager.LoadScene(0);
    }
}
