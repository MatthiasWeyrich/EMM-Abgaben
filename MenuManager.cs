using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject Menu;
    private bool isPaused = false;

    private void Start()
    {
        Menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        bool toggleMenu = Input.GetKeyDown(KeyCode.Escape);
        if (toggleMenu)
        {
            isPaused = !isPaused;
            if (isPaused)
            {
                Pause();   
            }
            else
            {
                Return();
            }
        }
        
    }

    public void Return()
    {
        Time.timeScale = 1f;
        Menu.SetActive(false);
    }

    void Pause()
    {
        Time.timeScale = 0f;
        Menu.SetActive(true);
    }

    public void Restart()
    {
        Time.timeScale = 1f;        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
