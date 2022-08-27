using UnityEngine;
using UnityEngine.UI;

namespace Kogane
{
    /// <summary>
    /// Graphic 型の拡張メソッド
    /// </summary>
    public static partial class UIExtensionMethods
    {
        //================================================================================
        // anchoredPosition
        //================================================================================
        public static void ResetAnchoredPosition( this Graphic self )                     => self.rectTransform.ResetAnchoredPosition();
        public static void SetAnchoredPositionX( this  Graphic self, float   x )          => self.rectTransform.SetAnchoredPositionX( x );
        public static void SetAnchoredPositionY( this  Graphic self, float   y )          => self.rectTransform.SetAnchoredPositionY( y );
        public static void SetAnchoredPosition( this   Graphic self, Vector2 v )          => self.rectTransform.SetAnchoredPosition( v );
        public static void SetAnchoredPosition( this   Graphic self, float   x, float y ) => self.rectTransform.SetAnchoredPosition( x, y );
        public static void AddAnchoredPositionX( this  Graphic self, float   x )          => self.rectTransform.AddAnchoredPositionX( x );
        public static void AddAnchoredPositionY( this  Graphic self, float   y )          => self.rectTransform.AddAnchoredPositionY( y );
        public static void AddAnchoredPosition( this   Graphic self, Vector2 v )          => self.rectTransform.AddAnchoredPosition( v );
        public static void AddAnchoredPosition( this   Graphic self, float   x, float y ) => self.rectTransform.AddAnchoredPosition( x, y );

        //================================================================================
        // offsetMax
        //================================================================================
        public static void SetOffsetMaxX( this Graphic self, float   x )          => self.rectTransform.SetOffsetMaxX( x );
        public static void SetOffsetMaxY( this Graphic self, float   y )          => self.rectTransform.SetOffsetMaxY( y );
        public static void SetOffsetMax( this  Graphic self, Vector2 v )          => self.rectTransform.SetOffsetMax( v );
        public static void SetOffsetMax( this  Graphic self, float   x, float y ) => self.rectTransform.SetOffsetMax( x, y );

        //================================================================================
        // offsetMin
        //================================================================================
        public static void SetOffsetMinX( this Graphic self, float   x )          => self.rectTransform.SetOffsetMinX( x );
        public static void SetOffsetMinY( this Graphic self, float   y )          => self.rectTransform.SetOffsetMinY( y );
        public static void SetOffsetMin( this  Graphic self, Vector2 v )          => self.rectTransform.SetOffsetMin( v );
        public static void SetOffsetMin( this  Graphic self, float   x, float y ) => self.rectTransform.SetOffsetMin( x, y );

        //================================================================================
        // anchorMin
        //================================================================================
        public static void SetAnchorMinX( this Graphic self, float   x )          => self.rectTransform.SetAnchorMinX( x );
        public static void SetAnchorMinY( this Graphic self, float   y )          => self.rectTransform.SetAnchorMinY( y );
        public static void SetAnchorMin( this  Graphic self, Vector2 v )          => self.rectTransform.SetAnchorMin( v );
        public static void SetAnchorMin( this  Graphic self, float   x, float y ) => self.rectTransform.SetAnchorMin( x, y );

        //================================================================================
        // anchorMax
        //================================================================================
        public static void SetAnchorMaxX( this Graphic self, float   x )          => self.rectTransform.SetAnchorMaxX( x );
        public static void SetAnchorMaxY( this Graphic self, float   y )          => self.rectTransform.SetAnchorMaxY( y );
        public static void SetAnchorMax( this  Graphic self, Vector2 v )          => self.rectTransform.SetAnchorMax( v );
        public static void SetAnchorMax( this  Graphic self, float   x, float y ) => self.rectTransform.SetAnchorMax( x, y );

        //================================================================================
        // pivot
        //================================================================================
        public static void SetPivotX( this Graphic self, float   x )          => self.rectTransform.SetPivotX( x );
        public static void SetPivotY( this Graphic self, float   y )          => self.rectTransform.SetPivotY( y );
        public static void SetPivot( this  Graphic self, Vector2 v )          => self.rectTransform.SetPivot( v );
        public static void SetPivot( this  Graphic self, float   x, float y ) => self.rectTransform.SetPivot( x, y );

        //================================================================================
        // sizeDelta
        //================================================================================
        public static void SetSizeDeltaX( this Graphic self, float   x )          => self.rectTransform.SetSizeDeltaX( x );
        public static void SetSizeDeltaY( this Graphic self, float   y )          => self.rectTransform.SetSizeDeltaY( y );
        public static void SetSizeDelta( this  Graphic self, Vector2 v )          => self.rectTransform.SetSizeDelta( v );
        public static void SetSizeDelta( this  Graphic self, float   x, float y ) => self.rectTransform.SetSizeDelta( x, y );
        public static void AddSizeDeltaX( this Graphic self, float   x )          => self.rectTransform.AddSizeDeltaX( x );
        public static void AddSizeDeltaY( this Graphic self, float   y )          => self.rectTransform.AddSizeDeltaY( y );
        public static void AddSizeDelta( this  Graphic self, Vector2 v )          => self.rectTransform.AddSizeDelta( v );
        public static void AddSizeDelta( this  Graphic self, float   x, float y ) => self.rectTransform.AddSizeDelta( x, y );

        //================================================================================
        // 関数(static)
        //================================================================================
        /// <summary>
        /// 左端の位置を返します
        /// </summary>
        public static float GetAnchoredPositionLeft( this Graphic self )
        {
            return self.rectTransform.GetAnchoredPositionLeft();
        }

        /// <summary>
        /// 右端の位置を返します
        /// </summary>
        public static float GetAnchoredPositionRight( this Graphic self )
        {
            return self.rectTransform.GetAnchoredPositionRight();
        }

        /// <summary>
        /// 下端の位置を返します
        /// </summary>
        public static float GetAnchoredPositionBottom( this Graphic self )
        {
            return self.rectTransform.GetAnchoredPositionBottom();
        }

        /// <summary>
        /// 上端の位置を返します
        /// </summary>
        public static float GetAnchoredPositionTop( this Graphic self )
        {
            return self.rectTransform.GetAnchoredPositionTop();
        }

        /// <summary>
        /// 端を表す矩形を返します
        /// </summary>
        public static Rect GetAnchoredEdge( this Graphic self )
        {
            return self.rectTransform.GetAnchoredEdge();
        }

        /// <summary>
        /// 透明度を設定します
        /// </summary>
        public static void SetAlpha( this Graphic self, float alpha )
        {
            var color = self.color;
            color.a    = alpha;
            self.color = color;
        }

        /// <summary>
        /// 色を設定します
        /// </summary>
        public static void SetColor( this Graphic self, Color color )
        {
            self.color = color;
        }

        /// <summary>
        /// 色を設定します
        /// </summary>
        public static void SetColor
        (
            this Graphic self,
            float        r,
            float        g,
            float        b,
            float        a
        )
        {
            self.color = new Color( r, g, b, a );
        }

        /// <summary>
        /// 色を設定します
        /// </summary>
        public static void SetColor
        (
            this Graphic self,
            byte         r,
            byte         g,
            byte         b,
            byte         a
        )
        {
            self.color = new Color32( r, g, b, a );
        }

        /// <summary>
        /// 色を設定します
        /// </summary>
        public static void SetColor( this Graphic self, float r, float g, float b )
        {
            self.color = new Color( r, g, b, self.color.a );
        }

        /// <summary>
        /// 色を設定します
        /// </summary>
        public static void SetColor( this Graphic self, byte r, byte g, byte b )
        {
            self.color = new Color32( r, g, b, ( byte )( self.color.a * 255 ) );
        }
    }
}