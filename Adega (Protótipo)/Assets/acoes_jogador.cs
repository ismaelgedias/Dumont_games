using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acoes_jogador : MonoBehaviour
{
    public int[] Uva_escolhida;
    public int terreno_escolhido;
    public float dinheiro;
    public GameObject canvas1;
    public bool pertoPilar = false;
    public bool uiAberta;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && pertoPilar && !uiAberta)
        {
            canvas1.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            uiAberta = true;
        }
        else if (Input.GetKeyDown(KeyCode.E) && uiAberta)
        {
            canvas1.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            uiAberta = false;
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Pilar"))
        {
            pertoPilar = true;
        }
    }
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.CompareTag("Pilar"))
        {
            pertoPilar = false;
        }
        canvas1.SetActive(false); 
    }
}

