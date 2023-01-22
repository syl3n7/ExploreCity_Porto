using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeName : MonoBehaviour
{
    public string[] Names = { "Portugal", "Espanha", "França", "Suiça", "Dinamarca", "Eslovénia", "Itália", "Worldwide"};
    public string[] Names2 = { "Português", "Español", "François", "Svenska", "Danks", "Italiano" };
    public TMPro.TMP_Text country, language, country2;
    int i = 0;
    int z = 0;

    public void changeName(int x)
    {
		if (i >= 0 && i < Names.Length)
        {
            country.text = Names[i];
			country2.text = Names[i];
			i = i + (x);
			if(i == Names.Length) i = 0;
			if(i == -1) i = 0;
        }
    }

    public void changeName2(int x)
    {
        if (z < Names2.Length)
        {
            language.text = Names2[z];        
			z = z + (x);
 			if (z == Names2.Length) z = 0;
			if (z == -1) z = 0;
        }
		
    }
}
