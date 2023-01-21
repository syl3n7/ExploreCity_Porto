using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class namesGen : MonoBehaviour
{
    string[] nomes = new []{"Olá", "Olé"};
    TMP_Text[] gameObjects = new TMP_Text[0];
    private int i = 0;
    void Start()
    {
        gameObjects = gameObject.GetComponents<TMPro.TMP_Text>();
        PopulateNames();
    }
    public void PopulateNames() {
        foreach (var gO in gameObjects)
        {
            gO.text = nomes[i];
            i++;
        }
    }
    
    void Update()
    {
        // add if someone adds a name to the name list, it automagically clones the \
        // gameobject to be used as the name background / button, and it fills the textbox with the correct value 
    }
}
