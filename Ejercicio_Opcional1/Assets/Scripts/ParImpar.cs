using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParImpar: MonoBehaviour
{
    public int num = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Return)) //El cuadro de texto nos dej�r� escribir hasta darle a enter
        {
            num = int.Parse(GetComponent<InputField>().text); //el numero que hayamos introducido lo convertir� en un int, ya que es solo texto que hemos introducido
            EsParImpar(num); //comprobar� si es par o impar y nos lo indicar� por pantalla
        }
        
    }

    public void EsParImpar(int num)
    {
        if (num % 2 == 0) //si al dividir entre 2 tiene residuo 0
        {
            Debug.Log($"El n�mero {num} es par"); //es un num par
        }
        else //En caso de no tenga rsesiduo 0
        {
            Debug.Log($"El n�mero {num} es impar"); //es impar
        }
    }
}
