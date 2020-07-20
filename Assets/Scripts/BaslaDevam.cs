using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaslaDevam : MonoBehaviour
{
    public GameObject[] yoket;
    public bool basla = false;
    public void Start()
    {
        for (int i = 0; i < yoket.Length; i++)
        {
            yoket[i].SetActive(true);
        }
        if (basla == true)
        {
            Time.timeScale = 1;
        }
    }
    public void Basla()
    {
        for (int i = 0; i < yoket.Length; i++)
        {
            yoket[i].SetActive(false);
        }
        Time.timeScale = 1;
        // StartCoroutine(WaitSome());
    }
    /*
     * private IEnumerator WaitSome() {
        yield return new WaitForSeconds(4f);
    }
    */
    public void Kapat()
    {
        Application.Quit();
    }

}
