using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float slowness = 10f;
    public GameObject skor;
    public GameObject blood;
    public AudioSource sesKaynak;
    public AudioClip [] sesler;

    public Text puan;
    public Text son_Text;
    public Text rekor_Text;
    float sure;
    float rekor;
    float toplam_puan;
    int rnd;

    void Start()
    {
        if (SceneManager.GetActiveScene().name == "PlayingScene")
        {
            Time.timeScale = 0.1f;
            rnd = Random.Range(1,6);
           sesKaynak.PlayOneShot(sesler[rnd]);
        }
        son_Text.text = (PlayerPrefs.GetFloat("Puan")).ToString("f2");
        rekor_Text.text = (PlayerPrefs.GetFloat("Rekor")).ToString("f2");
    }
    void Update()
    {
        if (sure >= 0.6f && blood.activeSelf == false)
        {
            Time.timeScale = 1;
        }
        sure += Time.deltaTime;

        toplam_puan = sure * 0.5f * Time.deltaTime; //---------
        if (blood.activeSelf == false)
        {
            puan.text = sure.ToString("f2");
        }
        rekor_Text.text = (PlayerPrefs.GetFloat("Rekor")).ToString("f2");
    }
    public void EndGame()
    {
        sesKaynak.PlayOneShot(sesler[0]);
        StartCoroutine(RestartLevel());
    }

    IEnumerator RestartLevel()
    {
        blood.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Time.timeScale = 1f / slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

        PlayerPrefs.SetFloat("Puan", sure);
        if (PlayerPrefs.GetFloat("Puan", sure) > PlayerPrefs.GetFloat("Rekor", rekor))
        {
            rekor = PlayerPrefs.GetFloat("Puan");
            PlayerPrefs.SetFloat("Rekor", rekor);
        }

        yield return new WaitForSeconds(0.5f / slowness);
        sesKaynak.Stop();
        yield return new WaitForSeconds(1.5f / slowness);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;
        SceneManager.LoadScene("MainMenu");
    }
}