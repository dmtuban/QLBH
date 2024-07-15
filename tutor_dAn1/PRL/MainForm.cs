namespace PRL
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        //Sự kiện này sẽ add 1 form mới vào trong panel
        private void btn_show_Click(object sender, EventArgs e)
        {
            pn_show.Controls.Clear();
            //B1: Tạo ra 1 đối tượng tương ứng vs form cần add vào
            GenForm gf = new GenForm();
            //B2: Tắt trạng thái TopLevel của form cần add vào
            gf.TopLevel = false;
            pn_show.Controls.Add(gf);
            //Thêm thiết lập cơ bản cho form thêm vào
            gf.FormBorderStyle = FormBorderStyle.None;//kiểu border
            gf.BackColor = Color.Green;//màu nền
            gf.Location = new Point(120, 100); //120, 100 là vị trí trong panel(thành phần chứa nó)
            //120 là k/c pixel tính từ góc trái bên trên sang phía tay phải
            //100 là k/c pixel tính từ góc trái bên trên xuống dưới
            gf.Show();

        }

        private void btn_showTest_Click(object sender, EventArgs e)
        {
            pn_show.Controls.Clear(); //xÓA tất cả các control đang nằm trên panel
            TestForm tf = new TestForm();
            tf.TopLevel = false;
            pn_show.Controls.Add(tf);
            tf.FormBorderStyle = FormBorderStyle.None;
            tf.BackColor = Color.Wheat;
            tf.Show();

        }
    }
}