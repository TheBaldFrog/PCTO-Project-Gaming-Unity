using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr1 : MonoBehaviour
{
    public int i = 0;
    public int j = 0;
    // Start is called before the first frame update
    void Start()
    {
        i++;
        Debug.Log(i);
    }

    // Update is called once per frame
    void Update()
    {
        /*i++;
        // Debug.Log(i);
        j++;
        Debug.Log(j);*/
    }

    private void FixedUpdate()
    {
        j++;
        Debug.Log("fixed" + j);
    }
}
