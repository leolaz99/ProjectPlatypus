using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Intro : MonoBehaviour
{
    [SerializeField]
    private Image _blackPanel;
    [SerializeField]
    private GameObject _blackObject;
    [SerializeField]
    private GameObject introContinueButton;
    [SerializeField]
    private TextMeshProUGUI text;
    [SerializeField]
    private GameObject textObject;

    public void RemoveBlackPanel()
    {
        FadeOut();
        introContinueButton.SetActive(false);
        Invoke("BlackPanelDisappears", 1f);
    }
    private void BlackPanelDisappears()
    {
        //attiva il gameobject del pannello nero
        _blackObject.SetActive(false);
        textObject.SetActive(false);
    }
    private void FadeOut()
    {
        //cambia l'alpha del pannello nero a 0(totalmente trasparente) in X secondi(secondo paramentro)
        _blackPanel.CrossFadeAlpha(0, 1f, false);
        text.CrossFadeAlpha(0, 1f, false);
    }
}
