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

    void changeName()
    {
        if(i < Names.Length)
        {
            country.text = Names[i];
        }     
        else
        {
            Debug.Log("Can't find the name in the index" + i + " " + Names[z]);
        }
        i++;
    }

    void changeName2()
    {
        if (z < Names2.Length)
        {
            language.text = Names2[z];
        }
        else
        {
            Debug.Log("Can't find the name in the index" + z + " " + Names2[z]);
        }
        z++;
    }
}
