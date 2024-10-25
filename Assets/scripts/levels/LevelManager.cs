using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;


    public class LevelManager : MonoBehaviour
    {
        private static LevelManager insatance;
        public static LevelManager Instance { get { return insatance; } }
    public string level1;

        private void Awake()
        {
            if (insatance == null)
            {

                insatance = this;
             
            DontDestroyOnLoad(gameObject);
        }
            else
            {
                Destroy(gameObject);

            }

        }


    private void Start()
    {
        if (getstatus("level 1") == LevelStatus.locked)
        {
            setstatus("level 1", LevelStatus.unlocked);
        }
        if (getstatus("Staringscence") == LevelStatus.locked){

            setstatus("Staringscence", LevelStatus.unlocked);
        }
    }

    public LevelStatus getstatus(string Levelname)
    {
        LevelStatus LS= (LevelStatus) PlayerPrefs.GetInt(Levelname, 0);
        return LS;
    }

    public void setstatus(string Levelname, LevelStatus Levelstatus)
    {

        PlayerPrefs.SetInt(Levelname, (int)Levelstatus);


    }

    public void MarkLevelComplete(string level)
    {
        LevelManager.Instance.setstatus(SceneManager.GetActiveScene().name, LevelStatus.completed);
        Scene CurrentScnce = SceneManager.GetActiveScene();
        int Next_Scence_Index = CurrentScnce.buildIndex + 1;
        Scene Next_Scence=  SceneManager.GetSceneByBuildIndex(Next_Scence_Index);
        Instance.setstatus(Next_Scence.name, LevelStatus.completed);
        SceneManager.LoadScene(Next_Scence_Index);
    }
    }

