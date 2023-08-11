//*************************************************************************************
//* ��    �ߣ� zouhunter
//* ����ʱ�䣺 2023-05-12 10:06:46
//* ��    ����

//* ************************************************************************************
using UnityEngine;

namespace UFrame.LitUI
{
    public class UIResourceLoader : IUILoader
    {
        public void Load(UIAsyncOperation operation)
        {
            UIView view = null;
            var prefab = Resources.Load<UIView>(operation.info.path);
            if (prefab != null)
            {
                view = Object.Instantiate(prefab);
                view.name = operation.info.name;
            }
            operation.Finish(view);
        }
    }
}