# CaptureScreenshot
Continuously Capture Screenshot in Unity

## Main Camera 셋팅

* Clear Flags를 Solid Color로 변경
* 찍고 싶은 Culling Mask 설정

## Screen Shot Controller 컴포넌트 추가

* **Folder Name** : 스크린샷을 저장할 폴더명
* **How Many** : 스크린샷을 연속으로 몇 장 찍을 것인가.
* **Time Scale** : time 스케일 1 기준, 몇으로 조정 할 것인가 ⇒ 값이 낮을 수록 부드럽게 찍힘

## Usage

* 위 설명처럼 카메라 설정을 한다.
* 새로운 오브젝트를 만들거나 또는 기존에 있는 오브젝트에 `ScreenShotController`컴포넌트를 추가한다.
* 설정값을 입력하고, Editor에서 PlayMode로 플레이한다.
* 원하는 타이밍에 `Spacebar`를 누르면 Screen Capture가 시작된다.

## Demo

회전하는 큐브로 스크린샷을 테스트 해볼 수 있다.
