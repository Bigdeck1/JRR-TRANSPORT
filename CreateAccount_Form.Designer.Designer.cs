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
            L_acc_link = new LinkLabel();
            label4 = new Label();
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
            // L_acc_link
            // 
            resources.ApplyResources(L_acc_link, "L_acc_link");
            L_acc_link.BackColor = Color.Transparent;
            L_acc_link.LinkColor = Color.Red;
            L_acc_link.Name = "L_acc_link";
            L_acc_link.TabStop = true;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.BackColor = Color.Transparent;
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Name = "label4";
            // 
            // CreateAccount_Form
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(label4);
            Controls.Add(L_acc_link);
            Controls.Add(C_acc_btn);
            Controls.Add(C_pass_word);
            Controls.Add(C_user_name);
            Controls.Add(label3);
            Controls.Add(C_password);
            Controls.Add(C_username);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "CreateAccount_Form";
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
        private LinkLabel L_acc_link;
        private Label label4;
    }
}
