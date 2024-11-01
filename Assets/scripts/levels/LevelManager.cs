using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


    public class LevelManager : MonoBehaviour
    {
        private static LevelManager _instance;
        public static LevelManager Instance { get { return _instance; } }
    public string level1;

        private void Awake()
        {
            if (_instance == null)
            {

                _instance = this;
             
            DontDestroyOnLoad(gameObject);
        }
            else
            {
                Destroy(gameObject);

            }

        }


    private void Start()
    {
        if (GetStatus("level 1") == LevelStatus.Locked)
        {
            SetStatus("level 1", LevelStatus.Unlocked);
        }
        if (GetStatus("Staringscence") == LevelStatus.Locked){

            SetStatus("Staringscence", LevelStatus.Unlocked);
        }
    }

    public LevelStatus GetStatus(string Levelname)
    {
        LevelStatus LS= (LevelStatus) PlayerPrefs.GetInt(Levelname, 0);
        return LS;
    }

    public void SetStatus(string Levelname, LevelStatus Levelstatus)
    {

        PlayerPrefs.SetInt(Levelname, (int)Levelstatus);


    }

    public void MarkLevelComplete(string level)
    {
        LevelManager.Instance.SetStatus(SceneManager.GetActiveScene().name, LevelStatus.Completed);
        Scene CurrentScnce = SceneManager.GetActiveScene();
        int Next_Scence_Index = CurrentScnce.buildIndex + 1;
        Scene Next_Scence=  SceneManager.GetSceneByBuildIndex(Next_Scence_Index);
        Instance.SetStatus(Next_Scence.name, LevelStatus.Completed);
        SceneManager.LoadScene(Next_Scence_Index);
    }
    }

