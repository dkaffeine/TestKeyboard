using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

[Preserve]
public class KeyPressed : MonoBehaviour
{
    #region Fields
    #region Serialized
    [SerializeField] private Text _keyPressedText;
    #endregion Serialized
    #endregion Fields

    #region Methods
    #region GUI
    void OnGUI()
    {
        Event e = Event.current;
        if (e.isKey && e.keyCode != KeyCode.None)
        {
            _keyPressedText.text = "Detected key code: " + e.keyCode;
            Debug.Log("Detected key code: " + e.keyCode);
        }
    }
    #endregion GUI
    #endregion Methods

}
