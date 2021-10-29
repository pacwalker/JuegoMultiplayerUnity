using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScale : MonoBehaviour
{
    public float increaseSize;
    public float seconds=10;
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(ChangeSize());
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("ChangeSize",seconds);
    }

    void ChangeSize()
    {
        //yield return new WaitForSeconds(seconds);
        transform.localScale += new Vector3(increaseSize, increaseSize, 1) * Time.deltaTime;
    }
}
