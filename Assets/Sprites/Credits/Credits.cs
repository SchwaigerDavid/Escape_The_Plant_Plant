using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public Animator antimator;
    public Animator legendanimator; 
    public void OpenCredits() {
        antimator.SetBool("Credits",true);
    }
    public void Quit()
    {
        Application.Quit();
    }
   
    public void Play() {
        legendanimator.SetBool("Legend", true);
        SceneManager.LoadScene("Game", LoadSceneMode.Single);

    }
  
}
