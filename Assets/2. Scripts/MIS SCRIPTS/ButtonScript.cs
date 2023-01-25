using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    

    public void DecrementFood()
    {

        if (GameManager.contadorComida <= 0){

            GameManager.contadorComida = 0;
            
            
        }else if (GameManager.contadorComida > 0){

        GameManager.contadorComida--;
        StatsManager.singleton._currentHunger = StatsManager.singleton._currentHunger +20;

        }
        
    }
        public void DecrementDrink()
    {
        GameManager.contadorBebida--;
        if (GameManager.contadorBebida <= 0){

            GameManager.contadorBebida = 0;
            
        }else if (GameManager.contadorBebida > 0){

        GameManager.contadorBebida--;
        StatsManager.singleton._currentThirst = StatsManager.singleton._currentThirst +20;

        }
    }
}
