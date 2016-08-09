using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace UniLibs.Localization
{
    public enum LocalizationObjType
    {
        None = 0,
        Text = 1,
        TextMesh = 2,
        Sprite = 3,
        GameObject = 4,
    }

    public class LocalizationManager : MonoBehaviour
    {
        public List<LocalizationObjectBase> m_LocalizationObjList = new List<LocalizationObjectBase>();
    }
}
