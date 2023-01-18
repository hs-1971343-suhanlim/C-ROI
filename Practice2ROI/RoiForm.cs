using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork3Update
{
    public partial class RoiForm : Form
    {
        public RoiForm()
        {
            InitializeComponent();
        }

        private Rectangle rectRoi;
        private bool isDrag = false;
        private Point startPoint;
        private Image saveImage=null;
        private Image croppedImage=null;
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            string fileName;
            // 파일 경로 선택 후 오픈
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\images\";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
            }
            else return;
            // pictureBox1.Image = Bitmap.FromFile(imgae_File); 차이점은 뭘까?
            pictureBox1.Image = Image.FromFile(fileName);
            saveImage = pictureBox1.Image;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            // 이미지 크기 로딩 기능
            labelX.Text = pictureBox1.Image.Height.ToString() + " pixel";
            labelY.Text = pictureBox1.Image.Width.ToString() + " pixel";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // 만약 이미지를 불러오지 않았다면 경고 후 리턴
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("선택된 이미지가 없습니다.","경고"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            // SaveFileDialog 객체를 활용하여 원하는 경로에 사진 저장 기능
            string fileName;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"C:\CuttingImages\";
            saveFileDialog.Title = "저장경로를 지정하세요";
            saveFileDialog.OverwritePrompt = true; //이름 중복 체크
            saveFileDialog.Filter = "PNG File(*.png)|*.png " +
                "|Bitmap File(*.bmp)|*.bmp |JPEG File(*.jpg)|*.jpg";
            
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
                pictureBox1.Image.Save(fileName);
            }
           
        }

        private void BtnCut_Click(object sender, EventArgs e)
        {
            int x = 0,y = 0,height=0,width=0;
            try
            {
                x = int.Parse(inputX.Text);
                y = int.Parse(inputY.Text);
                height = int.Parse(inputHight.Text);
                width = int.Parse(inputWidth.Text);
            }
            catch(Exception ex)
            {
                inputWidth.Text = inputHight.Text = inputX.Text = inputY.Text = "";
                MessageBox.Show(ex.Message,"입력값 오류",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            croppedImage = Crop(pictureBox1.Image, x, y, width, height);
            pictureBox1.Image = croppedImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            labelX.Text = pictureBox1.Image.Height.ToString() + " pixel";
            labelY.Text = pictureBox1.Image.Width.ToString() + " pixel";
        }
        public static Image Crop(Image image, int x, int y, int width, int height)
        {
            Bitmap cropImage = null;
            if (image != null)
            {
                try
                {
                    cropImage = new Bitmap(image).Clone(
                        new Rectangle(x, y, width, height), System.Drawing.Imaging.PixelFormat.DontCare);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return image;
                }
                return cropImage;
            }
            else
                return image;
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrag = true;
            }

            startPoint = new Point(e.X, e.Y);
            inputX.Text = e.X.ToString();
            inputY.Text = e.Y.ToString();
            inputHight.Text = "";
            inputWidth.Text = "";
            rectRoi = new Rectangle(e.X, e.Y, 0, 0);
            this.Refresh();

        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrag)
            {
                inputWidth.Text = (e.X - startPoint.X).ToString();
                inputHight.Text = (e.Y - startPoint.Y).ToString();
                rectRoi = new Rectangle(rectRoi.Left,rectRoi.Top,
                    Math.Min(e.X-rectRoi.Left,pictureBox1.ClientRectangle.Width-rectRoi.Left),
                    Math.Min(e.Y-rectRoi.Top,pictureBox1.ClientRectangle.Height-rectRoi.Top));
                this.Refresh();
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrag = false;
        }

        private void BtnInit_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = saveImage;
            labelX.Text = pictureBox1.Image.Height.ToString() + " pixel";
            labelY.Text = pictureBox1.Image.Width.ToString() + " pixel";
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            using(Pen pen = new Pen(Color.Red,2))
            {
                e.Graphics.DrawRectangle(pen, rectRoi);
            }
        }

        private void RoiForm_Load(object sender, EventArgs e)
        {
            noticeSub.Text = pictureBox1.Width.ToString() + " x " + pictureBox1.Height.ToString()
                + " 까지 입니다.";
        }
    }
}
