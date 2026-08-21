# UnityOkey

Unity UI에서 키보드, 마우스, 게임패드 입력을 이미지로 표시하는 스프라이트와 `ScriptableObject` 풀 패키지입니다.

## 설치

Unity Package Manager의 `Add package from git URL...`에 다음 주소를 입력합니다.

```text
https://github.com/oojjrs/unity_okey.git?path=/Packages/src
```

## 구성

| 구성 요소 | 종류 | 용도 |
| --- | --- | --- |
| `MyKeyPool` | `ScriptableObject` | 입력 열거형 또는 키 경로를 `Sprite`로 변환 |
| `MyKeyPoolKeyboard`, `MyKeyPoolMouse`, `MyKeyPoolGamepad` | `ScriptableObject` | 장치별 스프라이트 매핑 보관 |
| `MyInput` | 열거형 모음 | 키보드, 마우스, PlayStation, Xbox 입력 식별자 제공 |
| `MyKeyPool.asset`, `MyKeyPoolSymbol.asset` | 기본 풀 에셋 | 일반 키 이미지 또는 긴 키용 심볼 이미지 세트 제공 |
| `Okey.spriteatlasv2`, `Runtime/Sprites` | 이미지 에셋 | 패키지 기본 스프라이트와 아틀라스 제공 |

## 사용

```csharp
Sprite escape = keyPool.GetSprite(MyInput.Keyboard.Escape);
Sprite leftMouse = keyPool.GetSprite(MyInput.Mouse.LeftButton);
Sprite fromPath = keyPool.GetSprite("/Keyboard/escape");
```

## 제약

- Unity `6000.0` 이상을 사용합니다.
- `GetSprite(string)`은 패키지가 지원하는 Input System 형식의 키 경로를 받으며, 알 수 없는 경로에는 풀에 설정된 오류 스프라이트를 반환합니다.

## 문서

- [패키지 상세 문서](Packages/src/Documentation~/com.oojjrs.okey.md)

