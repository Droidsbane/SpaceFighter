using UnityEngine;
using UnityEngine.SceneManagement;

public class IStatePlay : IState
{
    private const string START = "Start";
    private const string MENU = "Menu";
    void IState.OnSceneLoaded()
    {

    }

    public void OnStateEnter()
    {
        Debug.Log("OnStateEnter PlayScreen");
    }

    public void OnStateExit()
    {
        Debug.Log("OnStateExit PlayScreen");
    }

    void IState.OnStateUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            GameManager.Instance.NewGameState(new IStateStart());
            SceneManager.LoadScene(START);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GameManager.Instance.NewGameState(new IStatePlay());
            SceneManager.LoadScene("PlayScreen");
        }
    }
}