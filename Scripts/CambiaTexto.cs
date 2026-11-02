using UnityEngine;
using TMPro;
public class CambiaTexto : MonoBehaviour
{
    public TMP_Text textoUI;
    public void ActualizarTexto()
    {
        textoUI.text = "¡Personaje agarrado!";
    }
}
