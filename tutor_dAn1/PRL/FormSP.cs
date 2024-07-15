using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL
{
    public partial class FormSP : Form
    {
        public FormSP()
        {
            InitializeComponent();
        }

        private Panel btn_showSP_Click(object sender, EventArgs e)
        {

        }


        //Khi click vào đây sẽ load ra 1 sản phẩm vs các thuộc tính y như form gen
        public void CreatePanelSP(sanPham sp) //Mỗi sản phẩm sẽ đc tạo ra và nằm trong 1 panel, panel này sẽ đc thêm vào tableLayoutPanel
                                              //Phương thức này trả về cả 1 panel
        {
            Panel p = new Panel();p.Size = new Size(616,511);
            PictureBox ptb = new PictureBox();ptb.Size = new Size(285,310);
            ptb.Image = Image.FromFile(sp.ImgUrl);//Gán hình ảnh của picturebox = URL ảnh của sản phẩm
            ptb.Location = new Point(13,22);
            Label lbTen = new Label(); lbTen.Text = "Tên sản phẩm";
            lbTen.Location = new Point(350,34);
            Label lbTenValue = new Label(); lbTenValue.Text = sp.Ten;//Gán tên SP cho label này
            lbTenValue.Location = new Point(350, 84);
            Label lbGia = new Label(); lbGia.Text = "Gía sản phẩm";
            lbGia.Location = new Point(350, 134);
            Label lbGiaValue = new Label(); lbGiaValue.Text = sp.Gia + "";
            lbGiaValue.Location = new Point(350, 184);
            Label lbSL = new Label(); lbSL.Text = "Số lượng tồn";
            lbSL.Location = new Point(350, 234);
            Label lbSLValue = new Label(); lbSLValue.Text = sp.SoLuong + "";
            lbSLValue.Location = new Point(350, 284);
            Label lbMua = new Label(); lbMua.Text = "Số lượng mua";
            lbMua.Location = new Point(350, 334);


        }
    }
    public class sanPham
    {
        public string Ten { get; set; }
        public int Gia { get; set; }
        public int SoLuong { get; set; }
        public string ImgUrl { get; set; }
    }
}
