using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public AudioSource deathSound;
    private bool isDead = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy Body") && !isDead)
        {
            Die();
        }
    }

    void Die()
    {
        isDead = true;
        if (GetComponent<StarterAssets.ThirdPersonController>() != null)
            GetComponent<StarterAssets.ThirdPersonController>().enabled = false;
        var renderer = GetComponentInChildren<SkinnedMeshRenderer>();
        if (renderer != null) renderer.enabled = false;

        Invoke(nameof(ReloadLevel), 1.2f);

        deathSound.Play();
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}