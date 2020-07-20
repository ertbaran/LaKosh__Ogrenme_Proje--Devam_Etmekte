    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active_Deaktive : MonoBehaviour
{
    public GameObject[] nesneler;
    bool trfa;
    void Start()
    {
        nesneler[0].SetActive(false);
    }

    public void Aktiflik()
    {
        trfa = !trfa;
        nesneler[0].SetActive(trfa);
    }
}
