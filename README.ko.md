[View English Version](README.md)

# Tizen Galaxy Watch Xamarin.Forms 샘플

이 프로젝트는 Xamarin.Forms (C#.NET)를 사용하여 Tizen Galaxy Watch 애플리케이션을 개발하는 데 도움이 되는 다양한 UI 컴포넌트 및 기능의 샘플 구현을 포괄적으로 모아놓은 것입니다. Tizen 웨어러블 플랫폼에서 C# 및 XAML을 사용하여 Tizen 웨어러블 앱을 개발하기 위한 실용적인 가이드 및 참조 역할을 합니다.

## 기능

이 저장소에는 Tizen Galaxy Watch에 맞게 조정된 다양한 Xamarin.Forms 컨트롤 및 레이아웃 사용법을 보여주는 개별 샘플 페이지가 포함되어 있습니다. 각 `.xaml` 파일(해당 `.xaml.cs` 코드 비하인드와 함께)은 별도의 샘플을 나타냅니다.

포함된 샘플 목록은 다음과 같습니다:

*   `AbsoluteLayout1.xaml`: AbsoluteLayout의 기본 사용법을 보여줍니다.
*   `AbsoluteLayoutEx.xaml`: AbsoluteLayout의 확장된 예제를 제공합니다.
*   `ButtonEx.xaml`: 다양한 버튼 구성 및 이벤트 처리를 보여줍니다.
*   `CheckBoxEx.xaml`: CheckBox 사용 예제.
*   `DatePicker.xaml`: DatePicker 컨트롤을 보여줍니다.
*   `EditorEx.xaml`: 여러 줄 텍스트 입력을 위한 Editor 컨트롤 예제.
*   `EntryEx.xaml`: Entry 컨트롤(한 줄 텍스트 입력)의 다양한 구성을 보여줍니다.
*   `FirstPage.xaml`: 초기 탐색 또는 간단한 콘텐츠를 위한 일반 샘플 페이지.
*   `FlexEx.xaml`: 유연한 UI 배열을 위한 FlexLayout을 보여줍니다.
*   `FrameEx.xaml`: 그룹화 및 스타일링을 위한 Frame 컨트롤 사용 예제.
*   `GridEx.xaml`: 구조화된 UI를 위한 Grid 레이아웃의 포괄적인 예제.
*   `ImageEx.xaml`: 이미지 표시 및 조작 방법을 보여줍니다.
*   `MyContentPage1.xaml`: 또 다른 일반 콘텐츠 페이지 샘플.
*   `MyContentView1.xaml`: 사용자 정의 ContentView 생성 및 사용법을 보여줍니다.
*   `PopupEx.xaml`: 팝업 요소 표시 예제.
*   `PromptEx.xaml`: 프롬프트 대화 상자 사용법을 보여줍니다.
*   `RelativeEx.xaml`: 서로 상대적인 요소 위치 지정을 위한 RelativeLayout을 보여줍니다.
*   `ScrollViewHori.xaml`: ScrollView를 사용한 가로 스크롤 예제.
*   `ScrollViewVertical.xaml`: ScrollView를 사용한 세로 스크롤 예제.
*   `SecondPage.xaml`: 또 다른 일반 샘플 페이지.
*   `SliderEx.xaml`: Slider 컨트롤 예제.
*   `SwtichEx.xaml`: Switch 컨트롤을 보여줍니다.
*   `TableViewEx.xaml`: 구조화된 데이터 표시를 위한 TableView 사용 예제.
*   `ThirdPage.xaml`: 또 다른 일반 샘플 페이지.
*   `TimePicker.xaml`: TimePicker 컨트롤을 보여줍니다.

## 필수 구성 요소

이 프로젝트를 빌드하고 실행하려면 다음이 필요합니다:

*   **Visual Studio**: ".NET을 사용한 모바일 개발" 워크로드가 설치되어 있어야 합니다.
*   **Tizen SDK**: Tizen 웨어러블 도구 및 에뮬레이터 이미지를 포함한 Tizen SDK가 설치되어 있는지 확인하십시오.
*   **.NET Core SDK**: .NET 애플리케이션 빌드에 필요합니다.

## 설정 지침

1.  **저장소 복제**: 
    ```bash
    git clone https://github.com/your-repo-link/TizenGalaxyWatchApp.git
    cd TizenGalaxyWatchApp
    ```
    (참고: `https://github.com/your-repo-link/TizenGalaxyWatchApp.git`을 실제 저장소 URL로 바꾸십시오.)

2.  **Visual Studio에서 열기**: 
    Visual Studio에서 `TizenWatchXamlApp1.sln` 파일을 엽니다.

3.  **시작 프로젝트 설정**: 
    솔루션 탐색기에서 `TizenWatchXamlApp1` 프로젝트를 마우스 오른쪽 버튼으로 클릭하고 "시작 프로젝트로 설정"을 선택합니다.

4.  **솔루션 빌드**: 
    NuGet 패키지를 복원하고 코드를 컴파일하려면 전체 솔루션을 빌드하십시오.

5.  **특정 샘플 보기**: 
    특정 샘플을 실행하고 보려면 `App.xaml.cs` 파일을 수정해야 합니다. `TizenWatchXamlApp1/App.xaml.cs`를 열고 `MainPage` 할당을 원하는 샘플 페이지로 변경하십시오.

    예를 들어, `ButtonEx` 샘플을 보려면 다음을 변경하십시오:
    ```csharp
    MainPage = new MainPage();
    ```
    을(를) 다음으로 변경하십시오:
    ```csharp
    MainPage = new ButtonEx();
    ```
    아직 추가되지 않았다면 `using TizenWatchXamlApp1;`을 추가하는 것을 잊지 마십시오.

6.  **배포 및 실행**: 
    Visual Studio 도구 모음에서 Tizen Galaxy Watch 에뮬레이터 또는 연결된 장치를 선택하고 애플리케이션을 실행합니다.

## 프로젝트 구조

*   `TizenWatchXamlApp1/`: 모든 소스 코드를 포함하는 주 프로젝트 디렉토리.
    *   `.xaml` 파일: 각 샘플 페이지의 사용자 인터페이스를 정의합니다.
    *   `.xaml.cs` 파일: XAML 페이지의 코드 비하인드로, 로직 및 이벤트 핸들러를 포함합니다.
    *   `App.xaml` 및 `App.xaml.cs`: 애플리케이션의 진입점 및 주 애플리케이션 클래스.
    *   `MainPage.xaml` 및 `MainPage.xaml.cs`: 기본 자리 표시자 페이지.
    *   `tizen-manifest.xml`: Tizen 애플리케이션 매니페스트 파일로, 애플리케이션 속성 및 권한을 정의합니다.
    *   `TizenWatchXamlApp.csproj`: 프로젝트 파일로, 종속성 및 빌드 설정을 정의합니다.
*   `TizenWatchXamlApp1/asset/img/`: 애플리케이션 내에서 사용되는 이미지 자산(예: `Tizen-logo.png`)을 포함합니다.
*   `bin/` 및 `obj/`: 컴파일된 바이너리 및 중간 빌드 파일을 위한 디렉토리.
*   `.git/`: Git 버전 관리 디렉토리.
*   `.vs/`: Visual Studio 솔루션 파일.

## 라이선스

이 프로젝트는 [LICENSE](LICENSE) 파일에 따라 라이선스가 부여됩니다. 자세한 내용은 `LICENSE` 파일을 참조하십시오.

## 문의

문의 사항이나 피드백이 있으시면 다음으로 연락하십시오:

*   **박재홍** - jaehong1972@gmail.com