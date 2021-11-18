using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{
    [SerializeField] private Button Button;   
    
    void Start()
    {
        Button btn = Button.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }   
    void TaskOnClick()
    {
        SceneManager.LoadScene("Level1");
    }
}