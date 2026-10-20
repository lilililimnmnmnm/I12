# I12 — WPF UI Component

## 프로젝트 목적

- DevExpress, Infragistics 등 상용 UI 라이브러리 사용 시 버전 이슈와 라이선스 비용은 항상 발생합니다. 개발환경 세팅에 대한 부담을 줄이고, 보안 이슈 등에 의한 버전 변경에 유연하게 대응함을 목표로 합니다.
- 복잡한 폴더 구조는 리소스 관리 부담이 증가 시키고, 여러개로 쪼개진 리소스 관계 파악이 힘듭니다. 차라리 하나의 컴포넌트가 하나의 단일 .cs 파일을 가지도록 설계하고, 검색 기능을 활용하는 것이 낫습니다.
- 별도의 이미지 파일 없이 단일 .cs 파일로 아이콘을 관리합니다.
- 입력 컨트롤과 설명용 라벨을 하나의 컴포넌트로 통합하여 XAML 코드의 중복을 줄이고 가독성을 높입니다.

## UI 컴포넌트 제공

현대적인 디자인을 지향하는 WPF UI 컴포넌트를 제공합니다.

| Control | Description |
|---|---|
| `I12Button1` | 버튼 |
| `I12IconButton1` | 아이콘 버튼 |
| `I12DatePicker1` | 날짜 선택기 |
| `I12Calender1` | 달력 |
| `I12TabControl1` | 탭 컨트롤 |
| `I12TextBox1` | 텍스트 박스 |
| `I12TreeView1` | 트리 뷰 |
| `I12MessageManager` | 메시지 매니저 |

### XAML 예시

기존 방식에서는 입력 컨트롤과 라벨을 별도로 배치해야 합니다.

```xml
<StackPanel>
    <TextBlock Text="날짜입력"/>
    <DatePicker/>
</StackPanel>
```

아래와 같이 라벨과 입력 컨트롤을 하나로 구성할 수 있습니다.

```xml
<StackPanel>
    <i12:I12DatePicker1 TitleText="날짜입력"/>
</StackPanel>
```

## WPF Drawing 코드기반 아이콘 제공

- 16px, 24px, 32px 사이즈의 아이콘을 제공합니다.
- Box, Calendar, Contrast, Confirm, Convert, Directory, FilterCancel, Image, Information, Login, Password, Patient, Reset, Setting, Skip, Tag, User, Warning, Wait, History, ZoomIn, ZoomOut

## HLSL 셰이더 효과

- Add Effect: 포토샵의 더하기 효과
- Negative Effect: 색상 반전 효과
- Overlay Effect: 포토샵의 오버레이 효과

## 빌드가 확인된 버전

- .NET 8.0
- .NET 9.0
- .NET 10.0

## 실행화면

![실행화면](./Image/image1.png)

### 예제화면1

![예제화면1](./Image/image2.png)

### 예제화면2

![예제화면2](./Image/image3.png)

### 예제화면3

![예제화면3](./Image/image4.png)