using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNamePersist : MonoBehaviour
{
    public static PlayerNamePersist Instance;

    public string playerName;

    private void Awake()
    {
        

        // start of new code
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
