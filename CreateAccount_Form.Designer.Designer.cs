namespace Jrr_Transport_Management_System
{
    partial class CreateAccount_Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount_Form));
            C_username = new Label();
            C_password = new Label();
            label3 = new Label();
            C_user_name = new TextBox();
            C_pass_word = new TextBox();
            C_acc_btn = new Button();
            label4 = new Label();
            xlink = new Label();
            l_btn = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // C_username
            // 
            resources.ApplyResources(C_username, "C_username");
            C_username.BackColor = Color.Transparent;
            C_username.Name = "C_username";
            // 
            // C_password
            // 
            resources.ApplyResources(C_password, "C_password");
            C_password.BackColor = Color.Transparent;
            C_password.Name = "C_password";
            C_password.Click += C_password_Click;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.Transparent;
            label3.Name = "label3";
            // 
            // C_user_name
            // 
            resources.ApplyResources(C_user_name, "C_user_name");
            C_user_name.Name = "C_user_name";
            // 
            // C_pass_word
            // 
            resources.ApplyResources(C_pass_word, "C_pass_word");
            C_pass_word.Name = "C_pass_word";
            // 
            // C_acc_btn
            // 
            resources.ApplyResources(C_acc_btn, "C_acc_btn");
            C_acc_btn.BackColor = Color.DeepSkyBlue;
            C_acc_btn.ForeColor = SystemColors.ButtonFace;
            C_acc_btn.Name = "C_acc_btn";
            C_acc_btn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Name = "label4";
            // 
            // xlink
            // 
            resources.ApplyResources(xlink, "xlink");
            xlink.BackColor = Color.Transparent;
            xlink.ForeColor = Color.Red;
            xlink.Name = "xlink";
            // 
            // l_btn
            // 
            l_btn.BackColor = Color.DeepSkyBlue;
            resources.ApplyResources(l_btn, "l_btn");
            l_btn.ForeColor = SystemColors.ControlText;
            l_btn.Name = "l_btn";
            l_btn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(l_btn);
            panel1.Name = "panel1";
            // 
            // CreateAccount_Form
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel1);
            Controls.Add(xlink);
            Controls.Add(label4);
            Controls.Add(C_acc_btn);
            Controls.Add(C_pass_word);
            Controls.Add(C_user_name);
            Controls.Add(label3);
            Controls.Add(C_password);
            Controls.Add(C_username);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateAccount_Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label C_username;
        private Label C_password;
        private Label label3;
        private TextBox C_user_name;
        private TextBox C_pass_word;
        private Button C_acc_btn;
        private Label label4;
        private Label xlink;
        private Button l_btn;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}
