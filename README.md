# DirectX9_Winform_Sample

처음에는 구글에서 하는대로 해도 화면에 윈도우가 뜨질 않았다.

나중에 원인을 찾아보니 App.config 파일에 <startup> -> <startup useLegacyV2RuntimeActivationPolicy="true">이렇게 
바뀌어야 한다는걸 알았다.

MSDN에서는 ".NET Framework 2.0 런타임 정품 인증 정책을 활성화할지 또는 .NET Framework 4 정품 인증 정책을 사용할지 여부를 지정합니다."
라고 써있는데 한마디로 옛날 기술 쓰려면 코드가 있어야 한다는 소리.