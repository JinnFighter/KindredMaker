using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Client.Common
{
    public class ButtonLabelled : MonoBehaviour
    {
        [field: SerializeField] public Button Button { get; private set; }
        [field: SerializeField] public TextMeshProUGUI Label { get; private set; }
    }
}