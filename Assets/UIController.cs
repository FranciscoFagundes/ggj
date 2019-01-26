using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    public Text woodText;
    public Text waterText;
    public Text gasText;
    public Text rockText;
    public Text goldText;

    public int woodCount;
    public int waterCount;
    public int gasCount;
    public int rockCount;
    public int goldCount;

    
    public Slider fuelBar;
    public float currentFuel;
    public float maxFuel; 

 // Start is called before the first frame update
    void Start()
    {
        woodCount = 10;
        waterCount = 10;
        gasCount = 10;
        rockCount = 10;
        goldCount = 10;

        maxFuel = 20.0f;

        currentFuel = maxFuel;

        fuelBar.value = CalculateFuel();
    }

    // Update is called once per frame
    void Update()
    {
        woodText.text = woodCount.ToString();
        waterText.text = waterCount.ToString();
        gasText.text = gasCount.ToString();
        rockText.text = rockCount.ToString();
        goldText.text = goldCount.ToString();


        if(Input.GetKeyDown(KeyCode.X)) {
            SpendFuel(2);
        }
    }

    void SpendFuel(float fuel) {
        if(currentFuel > 0) {
           currentFuel -= fuel;
           fuelBar.value = CalculateFuel();
        }
        
    }

    float CalculateFuel() {
        return currentFuel / maxFuel ;
    }
}
