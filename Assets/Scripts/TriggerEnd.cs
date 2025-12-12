using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEnd : MonoBehaviour
{
    [SerializeField] ParticleSystem winParticle;


    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // TODO: Load the end scene or display end game message
            //Debug.Log("End of the game reached!");
            //// For now, just reload the current scene
            //int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            //SceneManager.LoadScene(currentSceneIndex);

            winParticle.Play();

            StartCoroutine(LoadWinScene());         
        }
    }

    private IEnumerator LoadWinScene()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("WinScene");
    }
}
