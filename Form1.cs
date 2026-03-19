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

            // 2. 가져온 텍스트를 ListBox 항목으로 추가
            listBoxMessages.Items.Add(typed_msg);

            // 3. 입력학 텍스트박스 내용 클리어
            txtInput.Clear();
        }
    }
}
