# (C# 코딩) 에코 메신저
## 개요
- C# 프로그래밍 학습
- 1줄 소개: 사용자 키보드 입력을 받아서 처리하는 프로그램
- 사용한 플랫폼:
  - C#, .NET Windows Forms, Visual Studio, GitHub
- 사용한 컨트롤:
  - Label, TextBox, ListBox, Button
- 사용한 기술과 구현한 기능:
  - Visual Studio를 이용하여 UI 디자인
  - string 클래스를 이용한 사용자 입력 데이터 처리
  - DateTime 클래스를 이용한 현재시간 정보 구하기
  - MessageBox 기능 이용한 알림 및 경고
  - focus, clear 기능을 통한 커서 고정 및 메시지 삭제
  - keycode 코드를 통한 키바인딩 
  - Count 기능을 통한 갯수 세기 


## 실행 화면 (과제1)
- 과제1 코드의 실행 스크린샷

![과제1 실행화면](img/1.png)

- 과제 내용
	- label, textbox, listbox, button을 가독성이 좋은 변수로 정의하고 추가합니다.
	- typed_msg 변수를 정의하여 txtInput의 텍스트를 listBoxMessages에 item 으로 add 합니다
	- 이후 txtInput을 clear합니다.
- 구현 내용과 기능 설명
  	- 입력창 메시지 입력 후 전송을 누르면 입력한 내용이 리스트박스에 들어가짐
  	- 전송 버튼을 누른 후 리스트 박스 내용을 삭제하기
	- 내용이 리스트박스보다 길어지면 오른쪽에 스크롤바가 생김

- ## 실행 화면 (과제2)
- 과제2 코드의 실행 스크린샷

![과제2 실행화면](img/2.png)

- 과제 내용
	- 메시지를 전송하고 나면 txtInput에 마우스를 focus합니다.
	- Enterkey_Input 함수를 만들어 e.KeyCode의 enter 키가 입력된 경우 btnSend_Click(1단계함수)를 실행합니다.
	- IsNullOrWhiteSpace 상태를 감지하여 true일 경우 경고 MessageBox를 보내고 clear,focus 후 return하여 초기화합니다.
- 구현 내용과 기능 설명
	- 전송 버튼을 누른 후 커서를 메시지 입력 박스 위로 자동으로 이동시킴
   	- 엔터 버튼을 눌러도 메시지가 전송이 됨
   	- 공백만 있는 상태에서 전송 버튼을 누르면 알림 팝업과 함께 메시지가 전송되지 않음

- ## 실행 화면 (과제3)
- 과제3 코드의 실행 스크린샷

![과제3 실행화면](img/3.png)

- 과제 내용
	- time 변수를 DateTime.Now.ToString("HH:mm:ss") 형식으로 정의하여 displaymsg 변수에 $"[{time}] {typed_msg}" 형식으로 listbox 메시지에 추가합니다.
	- listbox의 item 수를 count 하여 하단 label에 추가합니다.
	- Trim 기능을 사용하여 txtInput의 앞 뒤 공백을 잘라냅니다.
- 구현 내용과 기능 설명
	- 메시지를 보내면 [시간] [메시지] 형식으로 표시가 됨
	- 메시지 갯수 출력 코드를 추가함
	- 문단의 처음, 끝 부분 공백을 자동으로 삭제함

- ## 실행 화면 (과제4)
- 과제4 코드의 실행 스크린샷

![과제4 실행화면](img/4.png)

- 과제 내용
	- 전체삭제의 경우 버튼을 누르면 listbox 내의 모든 item을 clear하고 label의 메시지를 0개로 수정합니다
	- 선택삭제의 경우 SelectedIndex가 -1인지를 판별하여 텍스트 선택 유무를 파악하고 맞다면 RemoveAt으로 제거 후 label을 다시 불러와 업데이트합니다
	- txtInput.Text.Length를 판별하여 50보다 많다면 전송을 거절하고 사유 MessageBox를 출력합니다
- 구현 내용과 기능 설명
	- 삭제할 메시지를 클릭하고 선택삭제 버튼을 누르면 그 메시지가 삭제됨
 	- 전체삭제 버튼을 누르면 리스트 박스 내 모든 메시지가 삭제됨
  	- 선택/전체 삭제를 했을 때 메시지의 갯수가 삭제된 메시지를 포함하지 않음
  	- 아무것도 선택을 하지 않고 선택 삭제 버튼을 누르면 알림 팝업으로 삭제할 메시지를 선택하라고 정보를 보냄
  	- 50자보다 많이 입력하면 경고 팝업과 함께 메시지가 전송되지 않음
