
namespace Jrr_Transport_Management_System
{
    partial class login_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_Form));
            login_Btn = new Button();
            pass_word = new TextBox();
            user_name = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            xlink = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            c_acc_btn = new Button();
            L_acc_link = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // login_Btn
            // 
            resources.ApplyResources(login_Btn, "login_Btn");
            login_Btn.BackColor = Color.DeepSkyBlue;
            login_Btn.ForeColor = SystemColors.ButtonFace;
            login_Btn.Name = "login_Btn";
            login_Btn.UseVisualStyleBackColor = false;
            // 
            // pass_word
            // 
            resources.ApplyResources(pass_word, "pass_word");
            pass_word.Name = "pass_word";
            // 
            // user_name
            // 
            resources.ApplyResources(user_name, "user_name");
            user_name.Name = "user_name";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Name = "label3";
            label3.Click += label3_Click;
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
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(c_acc_btn);
            panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // c_acc_btn
            // 
            c_acc_btn.BackColor = Color.DeepSkyBlue;
            resources.ApplyResources(c_acc_btn, "c_acc_btn");
            c_acc_btn.ForeColor = Color.Transparent;
            c_acc_btn.Name = "c_acc_btn";
            c_acc_btn.UseVisualStyleBackColor = false;
            // 
            // L_acc_link
            // 
            resources.ApplyResources(L_acc_link, "L_acc_link");
            L_acc_link.BackColor = Color.Transparent;
            L_acc_link.LinkColor = Color.Red;
            L_acc_link.Name = "L_acc_link";
            L_acc_link.TabStop = true;
            // 
            // login_Form
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(L_acc_link);
            Controls.Add(xlink);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(user_name);
            Controls.Add(pass_word);
            Controls.Add(login_Btn);
            Controls.Add(panel1);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveBorder;
            FormBorderStyle = FormBorderStyle.None;
            Name = "login_Form";
            WindowState = FormWindowState.Minimized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login_Btn;
        private TextBox pass_word;
        private TextBox user_name;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label xlink;
        private Panel panel1;
        private Button c_acc_btn;
        private PictureBox pictureBox1;
        private LinkLabel L_acc_link;
    }
}
