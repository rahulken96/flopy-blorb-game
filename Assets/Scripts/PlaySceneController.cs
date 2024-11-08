using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaySceneController : MonoBehaviour
{
    public AudioSource playAudio;
    public float delayBeforeStart = 1f; // Waktu jeda dalam detik

    public void playGame()
    {
        StartCoroutine(startPlayAudio());
    }

    private IEnumerator startPlayAudio()
    {
        playAudio.Play(); // Memainkan audio
        yield return new WaitForSeconds(delayBeforeStart); // Menunggu selama 'delayBeforeStart' detik
        SceneManager.LoadSceneAsync(1); // Memuat scene berikutnya setelah jeda
    }
}
