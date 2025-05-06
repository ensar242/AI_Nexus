using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AILinks : MonoBehaviour
{
    public string mapsURL = ""; // x ai linkini buraya giriceksin unityde

    public void OpenMap()
    {
        Application.OpenURL(mapsURL);
    }
}
