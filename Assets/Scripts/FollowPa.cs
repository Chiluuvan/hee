using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LeanTween.scale(gameObject, new Vector3(1f, 1, 1f), 1).setEase(LeanTweenType.easeOutElastic);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
