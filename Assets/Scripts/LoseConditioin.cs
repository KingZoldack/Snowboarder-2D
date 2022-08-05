using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseConditioin : MonoBehaviour
{
    [SerializeField] float _reloadDelay;

    [SerializeField] ParticleSystem _loseParticles;

    PlayerController _playerController;

    private void Awake()
    {
        if (_playerController == null)
        {
            _playerController = GetComponent<PlayerController>();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            _loseParticles.Play();
            _playerController.DisableControls();
            Invoke("LoadIntro", _reloadDelay);
        }
    }

    void LoadIntro()
    {
        SceneManager.LoadScene(0);
    }
}
