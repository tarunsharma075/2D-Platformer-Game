using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class lobbysencelogic : MonoBehaviour
{
    public Button levelbutton;
    public string level;
    void Start()
    {
        levelbutton.onClick.AddListener(onlick);
    }

private void  onlick() { 

        SceneManager.LoadScene(level);

}
    void Update()
    {
        
    }
}
