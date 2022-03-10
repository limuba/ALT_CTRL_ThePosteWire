using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlz : MonoBehaviour
{
    private void Sounded()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            FindObjectOfType<AudioManager>().Play("Lefeu");
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            FindObjectOfType<AudioManager>().Play("Lo");
        }
    }
}
