using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void LoadS(string scenename)
    
    {
        SceneManager.LoadScene(scenename);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
