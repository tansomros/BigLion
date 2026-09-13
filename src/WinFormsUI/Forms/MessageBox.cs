using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SUTH.HealthCheckup.WinFormsUI.Functions;

namespace SUTH.HealthCheckup.WinFormsUI.Forms
{
    public partial class MessageBox : DevExpress.XtraEditors.XtraForm
    {
        readonly Color _colorHover;
        readonly Color _colorButtonOK;
        Size _normalSize = new Size(510, 300);
        Size _miniSize = new Size(330, 300);
        readonly string _message = "";
        public bool showDetail;
        readonly bool AutoClose;
        public MessageBox(string message, MessageTypes _MessageBoxIcon, bool autoClose)
        {
            InitializeComponent();
            _message = message;
            picSuccess.Visible = false;
            lblMessageDetail.Size = new Size(486, 85);
            lblMessageDetail.Location = new Point(12, 143);
            lblMessageTitle.Text = "";
            switch (_MessageBoxIcon)
            {
                case MessageTypes.Success:
                    picSuccess.Visible = true;
                    picError.Visible = false;
                    lblMessageTitle.Visible = false;

                    _colorButtonOK = Color.MediumSeaGreen;
                    _colorHover = Color.FromArgb(125, 204, 160);

                    lblMessageDetail.Size = new Size(486, 54);
                    lblMessageDetail.Location = new Point(12, 180);
                    this.Size = new Size(299, 300);                                     
                    break;
                case MessageTypes.Info:

                    if (message.Length < 30)
                        modelResize(_miniSize);

                    picError.Visible = true;
                    picError.Image = imageList1.Images["Info.png"];
                    _colorButtonOK = Color.LightSlateGray;
                    _colorHover = Color.FromArgb(164, 175, 187);
                    break;
                case MessageTypes.Warning:

                    if (message.Length < 30)
                        modelResize(_miniSize);
                    else
                    {
                        this.Size = new Size(450, 350);
                        //panel1.Location = new Point(118,380);
                        btOK.Location = new Point(170, 300);
                    }
              
                    picError.Visible = true;
                    picError.Image = imageList1.Images["Warning.png"];

                    _colorButtonOK = Color.FromArgb(255, 193, 7);
                    _colorHover = Color.FromArgb(255, 213, 89);

                    lblMessageTitle.Text = "Warning";
                    lblMessageTitle.ForeColor = _colorButtonOK;
                    lblMessageDetail.Location = new Point(12, 160);
             
                    break;
                case MessageTypes.Error:

                    if (message.Length < 30)
                        modelResize(_miniSize);

                    picError.Visible = true;
                    picError.Image = imageList1.Images["Error.png"];

                    _colorButtonOK = Color.FromArgb(226, 71, 75);
                    _colorHover = Color.FromArgb(235,132,135);

                    lblMessageTitle.Text = "Error";
                    lblMessageTitle.ForeColor = _colorButtonOK;
                    break;
                case MessageTypes.ConfirmDialog:

                    picError.Visible = true;
                    picError.Image = imageList1.Images["ConfirmDialog.png"];

                    //lblMessageTitle.Text = "Warning";
                    //lblMessageTitle.ForeColor = colorButtonOK;

                    lblMessageDetail.Location = new Point(12, 110);

                    lblMessageTitle.Visible = false;
                    btYes.Visible = true;
                    btNo.Visible = true;
                    btCancel.Visible = true;
                    btOK.Visible = false;
                    break;
                //default:
                //    picError.Image = imageList1.Images["Info.png"];
                //    lblMessageTitle.Visible = false;
                //    btYes.Visible = true;
                //    btNo.Visible = true;
                //    btCancel.Visible = true;
                //    btOK.Visible = false;
                //    break;
            }

            btOK.Appearance.BackColor = _colorButtonOK;
            //btOK.Appearance.BorderColor = colorButtonOK;

            //btOK.onHoverState.FillColor = ColorHover;
            //btOK.onHoverState.BorderColor = ColorHover;

            //btOK.OnIdleState.FillColor = colorButtonOK;
            //btOK.OnIdleState.BorderColor = colorButtonOK;

            //btOK.OnPressedState.FillColor = colorButtonOK;
            //btOK.OnPressedState.BorderColor = colorButtonOK;
            AutoClose = autoClose;
        }
        private void modelResize(Size size)
        {
            this.Size = size;
        }

        private void MessageBox_Load(object sender, EventArgs e)
        {
            if (showDetail)
            {
                txtMessageDetail.Texts = "Message : " + _message;
                txtMessageDetail.Visible = !string.IsNullOrEmpty(_message);
                lblMessageDetail.Visible = false;
            }
            else
                lblMessageDetail.Text = _message;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
           // this.Close();
        }

        private void MessageBox_Shown(object sender, EventArgs e)
        {
            var mainForm = GlobalVariables._MAINFORM;
            if (mainForm != null && mainForm.Visible)
            {
                this.Location = new Point(
                    mainForm.Location.X + (mainForm.Width - this.Width) / 2,
                    mainForm.Location.Y + (mainForm.Height - this.Height) / 2
                );
            }
            else
            {
                CenterToScreen();
            }

            if (AutoClose)
            {
                Task.Run(() => Thread.Sleep(1000)).ContinueWith(t =>
                {
                    t.Dispose();
                    this.DialogResult = DialogResult.OK;                   
                });
                
            }
        }
    }
}
