# DirectX9_Winform_Sample

처음에는 구글에서 하는대로 해도 화면에 윈도우가 뜨질 않았다.

나중에 원인을 찾아보니 App.config 파일에 `<startup> -> <startup useLegacyV2RuntimeActivationPolicy="true">` 이렇게 
바뀌어야 한다는걸 알았다.

MSDN에서는 ".NET Framework 2.0 런타임 정품 인증 정책을 활성화할지 또는 .NET Framework 4 정품 인증 정책을 사용할지 여부를 지정합니다."
라고 써있는데 한마디로 옛날 기술 쓰려면 코드가 있어야 한다는 소리.

Windows10 환경에서 Visual Studio 2015으로 DirectX쓰려니 이런 사단이 난듯....

비주얼 스튜디오가 다이렉트X 세팅이 안되어 있다면 아래화면과 같이 처리되어야 함
![ScreenShot1] (https://cloud.githubusercontent.com/assets/12135142/20792434/0a3f0a2a-b805-11e6-8731-8420e4a3af87.PNG)


빌드할때 LoaderLock관련 에러가 난다면 아래화면과 같이 처리
![ScreenShot2] (https://cloud.githubusercontent.com/assets/12135142/20793150/fc9dad0a-b808-11e6-985f-2fc50f9ba31a.png)
![ScreenShot0] (https://cloud.githubusercontent.com/assets/12135142/20792433/07d1fc66-b805-11e6-8728-241ba2701dad.png)
