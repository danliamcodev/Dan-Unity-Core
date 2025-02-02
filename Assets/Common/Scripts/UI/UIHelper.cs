using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace SickLab.UI
{
    public static class UIHelper
    {
        public static void AdjustWidthToHeight(RectTransform rectTransform, float ratio)
        {
            Rect rect = rectTransform.rect;
            float width = rect.height * ratio;
            rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, width);
        }

        public static void AdjustHeightToWidth(RectTransform rectTransform, float ratio)
        {
            Rect rect = rectTransform.rect;
            float height = rect.width * ratio;
            rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height);
        }
    }
}

