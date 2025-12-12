using System.Collections;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.Diagnostics;
using UnityEngine.SceneManagement;

public class StressScore : MonoBehaviour
{
    float stressIncrement = 10f;
    float stressDecrement = -10f;
    [SerializeField] float stressScore;
    [SerializeField] TMP_Text stressScoreText;
    [SerializeField] ParticleSystem stressParticles;

    // Cache reference to AudioSource component
    AudioSource audioSource;

    // 
    [SerializeField] AudioClip stressReliefSound;
    [SerializeField] AudioClip stressTriggerSound;
    //[SerializeField] AudioClip musicStationClip;
    //[SerializeField] AudioClip zenCircleClip;

    private void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        // If collide on a stress trigerring object, increase stress score
        if (collision.gameObject.CompareTag("StressTrigger"))
        {
            // Increase stress score
            UpdateStressScore(stressIncrement);

            // UI display for stress score
            UpdateScoreUI();


            //TODO: reset collision object to avoid multiple triggers

            // play audio when stress is triggered
            audioSource.PlayOneShot(stressTriggerSound);


        }
        else if (collision.gameObject.CompareTag("StressRelief"))
        {
            // Decrease stress score
            UpdateStressScore(stressDecrement);

            // TODO: Add UI display for stress score
            UpdateScoreUI();

            collision.gameObject.SetActive(false);

            // Play audio when stress is relieved
            audioSource.PlayOneShot(stressReliefSound);
        }
    }

    private void UpdateStressScore(float stress)
    {
        stressScore += stress;
        if (stressScore <= 0f)
        {
            stressScore = 0f;
        }
        else if (stressScore >= 100f)
        {
            stressScore = 100f;
            stressParticles.Play();
            StartCoroutine(LoadLoseScene());
        }

        Debug.Log("Stress Score: " + stressScore);
    }

    private IEnumerator LoadLoseScene()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("LoseScene");
    }

    // add a public method to modify stress score from other scripts
    public void ModifyStressScore(float stressValue) {

        UpdateStressScore(stressValue);
        UpdateScoreUI();
    }

    public float GetStressScore()
    {
        return stressScore;
    }

    private void UpdateScoreUI()
    {
        if (stressScoreText != null)
            stressScoreText.text = stressScore.ToString();
    }
}
