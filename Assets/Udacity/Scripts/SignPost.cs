using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SignPost : MonoBehaviour
{

    public Text toTransform;
    private int coinGoalCount = 10;
    private int coinCurrentCount = 0;
    
    public void Start()
    {
        toTransform.text = "You Win";
    }

    public void Update()
    {
        toTransform.text = "You Win\nCoins: "+coinCurrentCount+"/"+coinGoalCount;
    }

	public void ResetScene() 
	{        
        // Reset the scene when the user clicks the sign post
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void IncrementCoinCount()
    {
        coinCurrentCount++;
    }
}