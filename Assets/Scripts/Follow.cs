using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
  public  Transform tar;
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.followDamp(transform, tar, LeanProp.localY, 1.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
