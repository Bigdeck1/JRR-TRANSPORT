
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
            acc_Create = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // login_Btn
            // 
            login_Btn.BackColor = Color.DeepSkyBlue;
            resources.ApplyResources(login_Btn, "login_Btn");
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
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Name = "label2";
            // 
            // acc_Create
            // 
            resources.ApplyResources(acc_Create, "acc_Create");
            acc_Create.FlatStyle = FlatStyle.Flat;
            acc_Create.ForeColor = Color.IndianRed;
            acc_Create.Name = "acc_Create";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Name = "label3";
            
            // 
            // login_Form
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(label3);
            Controls.Add(acc_Create);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(user_name);
            Controls.Add(pass_word);
            Controls.Add(login_Btn);
            DoubleBuffered = true;
            ForeColor = SystemColors.ActiveBorder;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "login_Form";
            WindowState = FormWindowState.Maximized;
           
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login_Btn;
        private TextBox pass_word;
        private TextBox user_name;
        private Label label1;
        private Label label2;
        private Label acc_Create;
        private Label label3;
    }
}
