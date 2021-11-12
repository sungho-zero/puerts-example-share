using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private SceneManager sceneManager;
    public void Open(string uiName)
    {
        var panelRes = Resources.Load(uiName) as GameObject;
        panelRes.SetActive(false);
        var panel = Instantiate(panelRes, transform);
        var panelJSBind = panel.GetComponent<UIPanelJSBind>();
        var setupMono = sceneManager.GETJsUI.Invoke(uiName);
        setupMono.Invoke(panelJSBind);
        panel.SetActive(true);
    }
}