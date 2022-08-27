using UnityEngine;

namespace Kogane
{
    /// <summary>
    /// RectTransform 型の拡張メソッド
    /// </summary>
    public static partial class UIExtensionMethods
    {
        //================================================================================
        // anchoredPosition
        //================================================================================
        public static void ResetAnchoredPosition( this RectTransform self )                     => self.anchoredPosition = Vector2.zero;
        public static void SetAnchoredPositionX( this  RectTransform self, float   x )          => self.anchoredPosition = new Vector2( x, self.anchoredPosition.y );
        public static void SetAnchoredPositionY( this  RectTransform self, float   y )          => self.anchoredPosition = new Vector2( self.anchoredPosition.x, y );
        public static void SetAnchoredPosition( this   RectTransform self, Vector2 v )          => self.anchoredPosition = v;
        public static void SetAnchoredPosition( this   RectTransform self, float   x, float y ) => self.anchoredPosition = new Vector2( x, y );
        public static void AddAnchoredPositionX( this  RectTransform self, float   x )          => self.anchoredPosition += new Vector2( x, 0 );
        public static void AddAnchoredPositionY( this  RectTransform self, float   y )          => self.anchoredPosition += new Vector2( 0, y );
        public static void AddAnchoredPosition( this   RectTransform self, Vector2 v )          => self.anchoredPosition += v;
        public static void AddAnchoredPosition( this   RectTransform self, float   x, float y ) => self.anchoredPosition += new Vector2( x, y );

        //================================================================================
        // offsetMax
        //================================================================================
        public static void SetOffsetMaxX( this RectTransform self, float   x )          => self.offsetMax = new Vector2( x, self.offsetMax.y );
        public static void SetOffsetMaxY( this RectTransform self, float   y )          => self.offsetMax = new Vector2( self.offsetMax.x, y );
        public static void SetOffsetMax( this  RectTransform self, Vector2 v )          => self.offsetMax = v;
        public static void SetOffsetMax( this  RectTransform self, float   x, float y ) => self.offsetMax = new Vector2( x, y );

        //================================================================================
        // offsetMin
        //================================================================================
        public static void SetOffsetMinX( this RectTransform self, float   x )          => self.offsetMin = new Vector2( x, self.offsetMin.y );
        public static void SetOffsetMinY( this RectTransform self, float   y )          => self.offsetMin = new Vector2( self.offsetMin.x, y );
        public static void SetOffsetMin( this  RectTransform self, Vector2 v )          => self.offsetMin = v;
        public static void SetOffsetMin( this  RectTransform self, float   x, float y ) => self.offsetMin = new Vector2( x, y );

        //================================================================================
        // anchorMin
        //================================================================================
        public static void SetAnchorMinX( this RectTransform self, float   x )          => self.anchorMin = new Vector2( x, self.anchorMin.y );
        public static void SetAnchorMinY( this RectTransform self, float   y )          => self.anchorMin = new Vector2( self.anchorMin.x, y );
        public static void SetAnchorMin( this  RectTransform self, Vector2 v )          => self.anchorMin = v;
        public static void SetAnchorMin( this  RectTransform self, float   x, float y ) => self.anchorMin = new Vector2( x, y );

        //================================================================================
        // anchorMax
        //================================================================================
        public static void SetAnchorMaxX( this RectTransform self, float   x )          => self.anchorMax = new Vector2( x, self.anchorMax.y );
        public static void SetAnchorMaxY( this RectTransform self, float   y )          => self.anchorMax = new Vector2( self.anchorMax.x, y );
        public static void SetAnchorMax( this  RectTransform self, Vector2 v )          => self.anchorMax = v;
        public static void SetAnchorMax( this  RectTransform self, float   x, float y ) => self.anchorMax = new Vector2( x, y );

        //================================================================================
        // pivot
        //================================================================================
        public static void SetPivotX( this RectTransform self, float   x )          => self.pivot = new Vector2( x, self.pivot.y );
        public static void SetPivotY( this RectTransform self, float   y )          => self.pivot = new Vector2( self.pivot.x, y );
        public static void SetPivot( this  RectTransform self, Vector2 v )          => self.pivot = v;
        public static void SetPivot( this  RectTransform self, float   x, float y ) => self.pivot = new Vector2( x, y );

        //================================================================================
        // sizeDelta
        //================================================================================
        public static void SetSizeDeltaX( this RectTransform self, float   x )          => self.sizeDelta = new Vector2( x, self.sizeDelta.y );
        public static void SetSizeDeltaY( this RectTransform self, float   y )          => self.sizeDelta = new Vector2( self.sizeDelta.x, y );
        public static void SetSizeDelta( this  RectTransform self, Vector2 v )          => self.sizeDelta = v;
        public static void SetSizeDelta( this  RectTransform self, float   x, float y ) => self.sizeDelta = new Vector2( x, y );
        public static void AddSizeDeltaX( this RectTransform self, float   x )          => self.sizeDelta += new Vector2( x, 0 );
        public static void AddSizeDeltaY( this RectTransform self, float   y )          => self.sizeDelta += new Vector2( 0, y );
        public static void AddSizeDelta( this  RectTransform self, Vector2 v )          => self.sizeDelta += v;
        public static void AddSizeDelta( this  RectTransform self, float   x, float y ) => self.sizeDelta += new Vector2( x, y );

        //================================================================================
        // 関数(static)
        //================================================================================
        /// <summary>
        /// 左端の位置を返します
        /// </summary>
        public static float GetAnchoredPositionLeft( this RectTransform self )
        {
            return self.anchoredPosition.x - self.sizeDelta.x * self.pivot.x * self.localScale.x;
        }

        /// <summary>
        /// 右端の位置を返します
        /// </summary>
        public static float GetAnchoredPositionRight( this RectTransform self )
        {
            return self.anchoredPosition.x + self.sizeDelta.x * ( 1 - self.pivot.x ) * self.localScale.x;
        }

        /// <summary>
        /// 下端の位置を返します
        /// </summary>
        public static float GetAnchoredPositionBottom( this RectTransform self )
        {
            return self.anchoredPosition.y - self.sizeDelta.y * self.pivot.y * self.localScale.y;
        }

        /// <summary>
        /// 上端の位置を返します
        /// </summary>
        public static float GetAnchoredPositionTop( this RectTransform self )
        {
            return self.anchoredPosition.y + self.sizeDelta.y * ( 1 - self.pivot.y ) * self.localScale.y;
        }

        /// <summary>
        /// 端を表す矩形を返します
        /// </summary>
        public static Rect GetAnchoredEdge( this RectTransform self )
        {
            var rect = new Rect
            {
                xMin = self.GetAnchoredPositionLeft(),
                xMax = self.GetAnchoredPositionRight(),
                yMin = self.GetAnchoredPositionBottom(),
                yMax = self.GetAnchoredPositionTop(),
            };

            return rect;
        }
    }
}