# OOJJRS' Key Sprite

`com.oojjrs.okey`는 Unity에서 키보드, 마우스, 게임패드 입력을 UI 이미지로 표시하기 위한 스프라이트와 프리팹을 제공하는 패키지입니다.

## 설치

Unity Package Manager의 `Add package from git URL...`에서 다음 주소를 추가합니다.

```text
https://github.com/oojjrs/unity_okey.git?path=/Packages/src
```

## 구조

- `Runtime/Scripts`: 입력 표시용 런타임 스크립트와 asmdef
- `Runtime/Sprites`: 키보드, 마우스, 게임패드 스프라이트
- `Runtime/Prefabs`: 입력 표시용 `MyKeyPool` ScriptableObject 에셋
- `Runtime/Atlas`: 스프라이트 아틀라스

## 사용

`MyKeyPool` 에셋을 참조한 뒤 `GetSprite`를 호출해 입력에 맞는 스프라이트를 가져옵니다.

```csharp
Sprite escape = keyPool.GetSprite(MyInput.Keyboard.Escape);
Sprite leftMouse = keyPool.GetSprite(MyInput.Mouse.LeftButton);
Sprite southButton = keyPool.GetSprite(MyInput.Controller.Default.ButtonSouth);
Sprite fromPath = keyPool.GetSprite("/Keyboard/escape");
```

문자열 키는 Unity Input System에서 사용하는 키 경로를 기준으로 처리합니다. 알 수 없는 키는 오류 스프라이트를 반환하고, 플랫폼별로 직접 대응하기 어려운 일부 입력은 null 표시용 스프라이트를 반환합니다.

패키지에 포함된 스프라이트와 `MyKeyPool` 에셋은 기본 이미지 세트입니다. 프로젝트에 맞는 버튼 이미지가 필요하면 `MyKeyPool`, `MyKeyPoolKeyboard`, `MyKeyPoolMouse`, `MyKeyPoolGamepad` ScriptableObject를 따로 만들어 별도 애셋팩처럼 구성해 사용할 수 있습니다.

## 1.2.2 변경 사항

- 마우스 입력 스프라이트를 다시 정리해 버튼, 이동, 휠 입력 이미지의 시각 품질을 맞췄습니다.
- 게임패드 입력 스프라이트를 Xbox와 PlayStation 계열로 분리해 어깨 버튼, 트리거, 얼굴 버튼, 스틱, 방향 패드 이미지가 플랫폼별 형태를 유지하도록 정리했습니다.
- 런타임 배포에는 필요 없는 원본 PSD 파일을 제거하고 패키지에는 실제 사용하는 PNG 스프라이트와 Unity 메타 정보만 남겼습니다.

## 1.2.0 변경 사항

- 패키지 내용을 `Packages/src/Runtime` 아래로 정리해 git URL의 `path=/Packages/src` 방식으로 바로 설치할 수 있게 했습니다.
- `MyKeyPool`과 키보드, 마우스, 게임패드 풀을 프리팹에서 ScriptableObject 에셋으로 전환해 기본 이미지 세트와 사용자 정의 이미지 세트를 분리해 구성할 수 있게 했습니다.

테스트용 씬과 개발 확인용 에셋은 패키지에 포함하지 않고 프로젝트의 `Assets` 아래에 둡니다.

