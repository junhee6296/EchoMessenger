
namespace EchoMessenger

{
    public partial class Echo : Form
    {
        public Echo()
        {
            InitializeComponent();
        }


        private void btnSend_Click(object sender, EventArgs e)
        {
            // 1. TextBox에 입력된 텍스트를 꺼내서 변수에 저장
            string typed_msg;
            typed_msg = txtInput.Text;

            // 1-2 입력 방어: 문자열이 null이거나, 비어있거나, 공백만 있는지 검사
            if (string.IsNullOrWhiteSpace(typed_msg))
            {
                MessageBox.Show("공백문자를 입력할 수 없습니다.", "알림"); // 팝업 추가
                txtInput.Clear();
                txtInput.Focus();
                return; // 함수 종료
            }

            // 2. 가져온 텍스트를 ListBox 항목으로 추가
            listBoxMessages.Items.Add(typed_msg);
            // 3. 입력학 텍스트박스 내용 클리어/커서 포커싱
            txtInput.Clear();
            txtInput.Focus();

        }

        private void Enterkey_Input(object sender, KeyEventArgs e)

        {
            // 누른 키가 Enter 키인지 확인
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                // 버튼 클릭과 같은 효과
                btnSend_Click(sender, e);
            }
        }
    }
}

