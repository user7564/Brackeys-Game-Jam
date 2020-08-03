using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    private bool Menu_Active = false;
    public GameObject Ui;
    // Start is called before the first frame update
    void Start()
    {
        Ui.gameObject.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Menu_Active == false)
            {
                pause();
            }

            else
            {
                resume();
            }
        }
    }
    public void pause()
    {
        Menu_Active = true;
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Ui.gameObject.SetActive(true);
    }

    public void resume()
    {
        Menu_Active = false;
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Ui.gameObject.SetActive(false);
    }

    public void exit()
    {
        SceneManager.LoadScene("Main_Menu");
    }
}
