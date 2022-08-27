# Kogane UI Extension Methods

UI 関連の拡張メソッド

## Button

```cs
var button = GetComponent<Button>();

void OnClick()
{
}

// onClick イベントを上書き
button.onClick.SetListener( OnClick );

// onClick.AddListener の省略表記
button.onClick.Add( OnClick );

// onClick.RemoveListener の省略表記
button.onClick.Remove( OnClick );

// onClick.SetListener の省略表記
button.onClick.Set( OnClick );
```

## Graphic

```cs
var graphic = GetComponent<Graphic>();

// anchoredPosition をリセット
graphic.ResetAnchoredPosition();

// anchoredPosition を設定
graphic.SetAnchoredPositionX( 1 );
graphic.SetAnchoredPositionY( 1 );
graphic.SetAnchoredPosition( Vector2.one );
graphic.SetAnchoredPosition( 1, 1 );

// anchoredPosition を加算
graphic.AddAnchoredPositionX( 1 );
graphic.AddAnchoredPositionY( 1 );
graphic.AddAnchoredPosition( Vector2.one );
graphic.AddAnchoredPosition( 1, 1 );

// offsetMax を設定
graphic.SetOffsetMaxX( 1 );
graphic.SetOffsetMaxY( 1 );
graphic.SetOffsetMax( Vector2.one );
graphic.SetOffsetMax( 1, 1 );

// offsetMin を設定
graphic.SetOffsetMinX( 1 );
graphic.SetOffsetMinY( 1 );
graphic.SetOffsetMin( Vector2.one );
graphic.SetOffsetMin( 1, 1 );

// anchorMin を設定
graphic.SetAnchorMinX( 1 );
graphic.SetAnchorMinY( 1 );
graphic.SetAnchorMin( Vector2.one );
graphic.SetAnchorMin( 1, 1 );

// anchorMax を設定
graphic.SetAnchorMaxX( 1 );
graphic.SetAnchorMaxY( 1 );
graphic.SetAnchorMax( Vector2.one );
graphic.SetAnchorMax( 1, 1 );

// pivot を設定
graphic.SetPivotX( 1 );
graphic.SetPivotY( 1 );
graphic.SetPivot( Vector2.one );
graphic.SetPivot( 1, 1 );

// sizeDelta を設定
graphic.SetSizeDeltaX( 1 );
graphic.SetSizeDeltaY( 1 );
graphic.SetSizeDelta( Vector2.one );
graphic.SetSizeDelta( 1, 1 );

// sizeDelta を加算
graphic.AddSizeDeltaX( 1 );
graphic.AddSizeDeltaY( 1 );
graphic.AddSizeDelta( Vector2.one );
graphic.AddSizeDelta( 1, 1 );

// 端の位置を取得
var left   = graphic.GetAnchoredPositionLeft();
var right  = graphic.GetAnchoredPositionRight();
var top    = graphic.GetAnchoredPositionTop();
var bottom = graphic.GetAnchoredPositionBottom();
var edge   = graphic.GetAnchoredEdge();

// 透明度を設定
graphic.SetAlpha( 0 );

// 色を設定
graphic.SetColor( Color.white );
graphic.SetColor( 1f, 1f, 1f, 1f );
graphic.SetColor( 255, 255, 255, 255 );
graphic.SetColor( 1f, 1f, 1f );
graphic.SetColor( 255, 255, 255 );
```

## Image

```cs
var image  = GetComponent<Image>();
var sprite = Resources.Load<Sprite>( "" );

// image.sprite = sprite; と同様
image.SetSprite( sprite );

// null じゃなければ SetSprite
image.SetSpriteIfNotNull( sprite );

// スプライト設定後に SetNativeSize 呼び出し
image.SetSpriteAndSnap( sprite );

// null じゃなければ SetSpriteAndSnap
image.SetSpriteAndSnapIfNotNull( sprite );

// スプライト設定後に
// スプライトが null かどうかでゲームオブジェクトのアクティブ設定
image.SetSpriteAndActive( sprite );

// null じゃなければ SetSpriteAndActive
image.SetSpriteAndActiveIfNotNull( sprite );

// スプライト設定後にスプライトが null かどうかで enabled 設定
image.SetSpriteAndEnabled( sprite );

// null じゃなければ SetSpriteAndEnabled
image.SetSpriteAndEnabledIfNotNull( sprite );

// image.fillAmount = 0.5; と同様
image.SetFillAmount( 0.5f );

// null じゃなければ SetFillAmount
image.SetFillAmountIfNotNull( 0.5f );

// 指定された数値から fillAmount を計算して設定
image.SetFillAmount( 25, 100 );

// null じゃなければ SetFillAmount
image.SetFillAmountIfNotNull( 25, 100 );
```

## InputField

```cs
var inputField = GetComponent<InputField>();

void OnEndEdit( string s )
{
}

// onEndEdit イベントを上書き
inputField.onEndEdit.SetListener( OnEndEdit );

// onEndEdit.AddListener の省略表記
inputField.onEndEdit.Add( OnEndEdit );

// onEndEdit.RemoveListener の省略表記
inputField.onEndEdit.Remove( OnEndEdit );

// onEndEdit.SetListener の省略表記
inputField.onEndEdit.Set( OnEndEdit );

void OnChange( string s )
{
}

// onValueChanged イベントを上書き
inputField.onValueChanged.SetListener( OnChange );

// onValueChanged.AddListener の省略表記
inputField.onValueChanged.Add( OnChange );

// onValueChanged.RemoveListener の省略表記
inputField.onValueChanged.Remove( OnChange );

// onValueChanged.SetListener の省略表記
inputField.onValueChanged.Set( OnChange );
```

## RawImage

```cs
var rawImage = GetComponent<RawImage>();
var texture  = Resources.Load<Texture>( "" );

// rawImage.texture = texture; と同様
rawImage.SetTexture( texture );

// null じゃなければ SetTexture
rawImage.SetTextureIfNotNull( texture );

// テクスチャ設定後に SetNativeSize 呼び出し
rawImage.SetTextureAndSnap( texture );

// null じゃなければ SetTextureAndSnap
rawImage.SetTextureAndSnapIfNotNull( texture );

// テクスチャ設定後に
// テクスチャが null かどうかでゲームオブジェクトのアクティブ設定
rawImage.SetTextureAndActive( texture );

// null じゃなければ SetTextureAndActiveIfNotNull
rawImage.SetTextureAndActiveIfNotNull( texture );

// テクスチャ設定後にテクスチャが null かどうかで enabled 設定
rawImage.SetTextureAndEnabled( texture );

// null じゃなければ SetTextureAndEnabled
rawImage.SetTextureAndEnabledIfNotNull( texture );

// UV を取得
var uvRectX      = rawImage.GetUvRectX();
var uvRectY      = rawImage.GetUvRectY();
var uvRectWidht  = rawImage.GetUvRectWidth();
var uvRectHeight = rawImage.GetUvRectHeight();

// UV を設定
rawImage.SetUvRectX( 0 );
rawImage.SetUvRectY( 0 );
rawImage.SetUvRectWidth( 0 );
rawImage.SetUvRectHeight( 0 );
```

## RectTransform

```cs
var rectTransform = GetComponent<RectTransform>();

// anchoredPosition をリセット
rectTransform.ResetAnchoredPosition();

// anchoredPosition を設定
rectTransform.SetAnchoredPositionX( 1 );
rectTransform.SetAnchoredPositionY( 1 );
rectTransform.SetAnchoredPosition( Vector2.one );
rectTransform.SetAnchoredPosition( 1, 1 );

// anchoredPosition を加算
rectTransform.AddAnchoredPositionX( 1 );
rectTransform.AddAnchoredPositionY( 1 );
rectTransform.AddAnchoredPosition( Vector2.one );
rectTransform.AddAnchoredPosition( 1, 1 );

// offsetMax を設定
rectTransform.SetOffsetMaxX( 1 );
rectTransform.SetOffsetMaxY( 1 );
rectTransform.SetOffsetMax( Vector2.one );
rectTransform.SetOffsetMax( 1, 1 );

// offsetMin を設定
rectTransform.SetOffsetMinX( 1 );
rectTransform.SetOffsetMinY( 1 );
rectTransform.SetOffsetMin( Vector2.one );
rectTransform.SetOffsetMin( 1, 1 );

// anchorMin を設定
rectTransform.SetAnchorMinX( 1 );
rectTransform.SetAnchorMinY( 1 );
rectTransform.SetAnchorMin( Vector2.one );
rectTransform.SetAnchorMin( 1, 1 );

// anchorMax を設定
rectTransform.SetAnchorMaxX( 1 );
rectTransform.SetAnchorMaxY( 1 );
rectTransform.SetAnchorMax( Vector2.one );
rectTransform.SetAnchorMax( 1, 1 );

// pivot を設定
rectTransform.SetPivotX( 1 );
rectTransform.SetPivotY( 1 );
rectTransform.SetPivot( Vector2.one );
rectTransform.SetPivot( 1, 1 );

// sizeDelta を設定
rectTransform.SetSizeDeltaX( 1 );
rectTransform.SetSizeDeltaY( 1 );
rectTransform.SetSizeDelta( Vector2.one );
rectTransform.SetSizeDelta( 1, 1 );

// sizeDelta を加算
rectTransform.AddSizeDeltaX( 1 );
rectTransform.AddSizeDeltaY( 1 );
rectTransform.AddSizeDelta( Vector2.one );
rectTransform.AddSizeDelta( 1, 1 );

// 端の位置を取得
var left   = rectTransform.GetAnchoredPositionLeft();
var right  = rectTransform.GetAnchoredPositionRight();
var top    = rectTransform.GetAnchoredPositionTop();
var bottom = rectTransform.GetAnchoredPositionBottom();
var edge   = rectTransform.GetAnchoredEdge();
```

## ScrollRect

```cs
// スクロール座標を上端にリセットします
m_scrollRect.ResetScrollPositionToTop();

// スクロール座標を下端にリセットします
m_scrollRect.ResetScrollPositionToBottom();

// スクロール座標を左端にリセットします
m_scrollRect.ResetScrollPositionToLeft();

// スクロール座標を右端にリセットします
m_scrollRect.ResetScrollPositionToRight();
```

## Slider

```cs
var slider = GetComponent<Slider>();

void OnChange( float f )
{
}

// onValueChanged イベントを上書き
slider.onValueChanged.SetListener( OnChange );

// onValueChanged.AddListener の省略表記
slider.onValueChanged.Add( OnChange );

// onValueChanged.RemoveListener の省略表記
slider.onValueChanged.Remove( OnChange );

// onValueChanged.SetListener の省略表記
slider.onValueChanged.Set( OnChange );
```

## TMP_InputField

```cs
var tmpInputField = GetComponent<TMP_InputField>();

void OnEndEdit( string s )
{
}

// onEndEdit イベントを上書き
tmpInputField.onEndEdit.SetListener( OnEndEdit );

// onEndEdit.AddListener の省略表記
tmpInputField.onEndEdit.Add( OnEndEdit );

// onEndEdit.RemoveListener の省略表記
tmpInputField.onEndEdit.Remove( OnEndEdit );

// onEndEdit.SetListener の省略表記
tmpInputField.onEndEdit.Set( OnEndEdit );

void OnChange( string s )
{
}

// onValueChanged イベントを上書き
tmpInputField.onValueChanged.SetListener( OnChange );

// onValueChanged.AddListener の省略表記
tmpInputField.onValueChanged.Add( OnChange );

// onValueChanged.RemoveListener の省略表記
tmpInputField.onValueChanged.Remove( OnChange );

// onValueChanged.SetListener の省略表記
tmpInputField.onValueChanged.Set( OnChange );

void OnSelect( string s )
{
}

// onSelect イベントを上書き
tmpInputField.onSelect.SetListener( OnSelect );

// onSelect.AddListener の省略表記
tmpInputField.onSelect.Add( OnSelect );

// onSelect.RemoveListener の省略表記
tmpInputField.onSelect.Remove( OnSelect );

// onSelect.SetListener の省略表記
tmpInputField.onSelect.Set( OnSelect );

void OnTextSelection( string s, int i1, int i2 )
{
}

// onTextSelection イベントを上書き
tmpInputField.onTextSelection.SetListener( OnTextSelection );

// onTextSelection.AddListener の省略表記
tmpInputField.onTextSelection.Add( OnTextSelection );

// onTextSelection.RemoveListener の省略表記
tmpInputField.onTextSelection.Remove( OnTextSelection );

// onTextSelection.SetListener の省略表記
tmpInputField.onTextSelection.Set( OnTextSelection );

void OnTouchScreenKeyboardStatusChanged( TouchScreenKeyboard.Status status )
{
}

// onTouchScreenKeyboardStatusChanged イベントを上書き
tmpInputField.onTouchScreenKeyboardStatusChanged.SetListener( OnTouchScreenKeyboardStatusChanged );

// onTouchScreenKeyboardStatusChanged.AddListener の省略表記
tmpInputField.onTouchScreenKeyboardStatusChanged.Add( OnTouchScreenKeyboardStatusChanged );

// onTouchScreenKeyboardStatusChanged.RemoveListener の省略表記
tmpInputField.onTouchScreenKeyboardStatusChanged.Remove( OnTouchScreenKeyboardStatusChanged );

// onTouchScreenKeyboardStatusChanged.SetListener の省略表記
tmpInputField.onTouchScreenKeyboardStatusChanged.Set( OnTouchScreenKeyboardStatusChanged );
```
