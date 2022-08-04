using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseConditioin : MonoBehaviour
{
    [SerializeField] float _reloadDelay;

    [SerializeField] ParticleSystem _loseParticles;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            Invoke("LoadIntro", _reloadDelay);
            _loseParticles.Play();
        }
    }

    void LoadIntro()
    {
        SceneManager.LoadScene(0);
    }
}
