using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButtonLogic : MonoBehaviour
{


    public  Button LobbyButton;
    [SerializeField] private GameObject _lobby;
    [SerializeField] private GameObject _playbutton;
   

   public  void Awake()
    {
        LobbyButton = gameObject.GetComponent<Button>();

    }

    public void Start()
    {
        LobbyButton.onClick.AddListener(OnClick);
    }
    void OnClick()
    {
        Debug.Log("button clicked");
        SoundManager.Instance.Play(SoundManager.sounds.ButtonClick);
        _lobby.SetActive(true);
        _playbutton.SetActive(false);
    }

}
