using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjActive : MonoBehaviour
{
    public GameObject[] model = new GameObject[2];
    int flag = 0;
    float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > 10)
        {
            time = 0;
            if (flag == 0)
            {
                model[0].SetActive(false);
                model[1].SetActive(true);
                flag = 1;
            }
            else if (flag == 1)
            {
                model[1].SetActive(false);
                model[0].SetActive(true);
                flag = 0;
            }
        }
    }
}
