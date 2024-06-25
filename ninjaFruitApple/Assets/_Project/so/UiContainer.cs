using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Project.UI;

namespace So
{
    [CreateAssetMenu(menuName ="Configuration/UIContainer",
        fileName = "UIContainer")]
    public class UiContainer : ScriptableObject
    {
        [SerializeField] public List<IUBase> _uis;

        public IUBase GetUI(string uiName)
        {
            IUBase result = _uis.Find(ui => ui.name.Contains(uiName));
            return result;
        }
    }
}