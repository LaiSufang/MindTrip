using UnityEngine;

public class TriggerZen : MonoBehaviour
{
    AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // If collide with the player, play music
        if (other.gameObject.CompareTag("Player"))
        {
            audioSource?.Play();

            // reduce stress score
            if (other.gameObject.TryGetComponent<StressScore>(out var stressScore))
            {
                stressScore.ModifyStressScore(-10f);
                Debug.Log("Stress Score: " + stressScore.GetStressScore());
                return;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // If player exits the trigger, stop music
        if (other.gameObject.CompareTag("Player"))
        {
            audioSource?.Stop();
        }
    }
}
