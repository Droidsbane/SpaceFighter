using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class IStateMenu : IState
{
    private const string PLAY_SCREEN = "PlayScreen";
    void IState.OnSceneLoaded()
    {

    }

    public void OnStateEnter()
    {
        Debug.Log("OnStateEnter Menu");
    }

    public void OnStateExit()
    {
        Debug.Log("OnStateExit Menu");
    }

    void IState.OnStateUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GameManager.Instance.NewGameState(new IStatePlay());
            SceneManager.LoadScene("PlayScreen");
        }
    }

}
