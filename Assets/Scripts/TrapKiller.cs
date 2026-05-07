using UnityEngine;
using UnityEngine.SceneManagement;

public class TrapKiller : MonoBehaviour
{
    public AudioSource deathSound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            deathSound.Play();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
