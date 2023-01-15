using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeName : MonoBehaviour
{
    public string[] Names = { "Portugal", "Espanha", "Franca", "Suica", "Dinamarca", "Eslovenia", "Italia", "Worldwide" };
    public string[] Names2 = { "Portugues", "Espanhol", "Frances", "Sueco", "Dinamarques", "Italiano"};
    public TMPro.TMP_Text country;
    public TMPro.TMP_Text language;
    int i = 0;
    int z = 0;

    public void changeName()
    {
        if (i < Names2.Length)
        {
            country.text = Names[i];
        }else if (i == Names.Length) i = 0;  
        else
        {
            Debug.Log("Can't find the name in the index" + i + " " + Names[i]);
        }
        i++;
    }

    public void changeName2()
    {
        if (z < Names2.Length)
        {
            language.text = Names2[z];
        }else if (z == Names2.Length) z = 0;  
        else
        {
            Debug.Log("Can't find the name in the index" + z + " " + Names2[z]);
        }
        z++;
    }
}
