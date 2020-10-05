using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadePanel : MonoBehaviour
{

    public void RestartLevel()
    {
        if (Levels.loadNext)
        {
            Levels.Next();
        }
        else
        {
            Levels.Restart();
        }
        Levels.loadNext = false;
    }

    // Update is called once per frame
}
