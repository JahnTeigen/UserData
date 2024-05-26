namespace UserData
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnRegister = new Button();
            txtbUsername = new TextBox();
            txtbPassword = new TextBox();
            splitContainer1 = new SplitContainer();
            chbReqAdmin = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblRegistration = new Label();
            txtbSurname = new TextBox();
            form1BindingSource = new BindingSource(components);
            form1BindingSource1 = new BindingSource(components);
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource1).BeginInit();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.ActiveCaption;
            btnRegister.Location = new Point(12, 307);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(175, 34);
            btnRegister.TabIndex = 0;
            btnRegister.Text = "Register User";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtbUsername
            // 
            txtbUsername.Location = new Point(12, 74);
            txtbUsername.Name = "txtbUsername";
            txtbUsername.Size = new Size(175, 23);
            txtbUsername.TabIndex = 1;
            txtbUsername.TextChanged += txtbUsername_TextChanged;
            // 
            // txtbPassword
            // 
            txtbPassword.Location = new Point(12, 161);
            txtbPassword.Name = "txtbPassword";
            txtbPassword.Size = new Size(175, 23);
            txtbPassword.TabIndex = 1;
            txtbPassword.TextChanged += txtbPassword_TextChanged;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(chbReqAdmin);
            splitContainer1.Panel1.Controls.Add(txtbUsername);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(lblRegistration);
            splitContainer1.Panel1.Controls.Add(btnRegister);
            splitContainer1.Panel1.Controls.Add(txtbSurname);
            splitContainer1.Panel1.Controls.Add(txtbPassword);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            splitContainer1.Size = new Size(601, 354);
            splitContainer1.SplitterDistance = 200;
            splitContainer1.TabIndex = 2;
            // 
            // chbReqAdmin
            // 
            chbReqAdmin.AutoSize = true;
            chbReqAdmin.Location = new Point(12, 282);
            chbReqAdmin.Name = "chbReqAdmin";
            chbReqAdmin.Size = new Size(166, 19);
            chbReqAdmin.TabIndex = 4;
            chbReqAdmin.Text = "Request admin permission";
            chbReqAdmin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 143);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 100);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 3;
            label2.Text = "Surname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 3;
            label1.Text = "First name";
            // 
            // lblRegistration
            // 
            lblRegistration.AutoSize = true;
            lblRegistration.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRegistration.Location = new Point(12, 13);
            lblRegistration.Name = "lblRegistration";
            lblRegistration.Size = new Size(175, 37);
            lblRegistration.TabIndex = 2;
            lblRegistration.Text = "Registration";
            lblRegistration.Click += label1_Click;
            // 
            // txtbSurname
            // 
            txtbSurname.Location = new Point(12, 118);
            txtbSurname.Name = "txtbSurname";
            txtbSurname.Size = new Size(175, 23);
            txtbSurname.TabIndex = 1;
            txtbSurname.TextChanged += txtbPassword_TextChanged;
            // 
            // form1BindingSource
            // 
            form1BindingSource.DataSource = typeof(Form1);
            // 
            // form1BindingSource1
            // 
            form1BindingSource1.DataSource = typeof(Form1);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 378);
            Controls.Add(splitContainer1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(641, 417);
            MinimumSize = new Size(641, 417);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)form1BindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegister;
        private TextBox txtbUsername;
        private TextBox txtbPassword;
        private SplitContainer splitContainer1;
        private Label lblRegistration;
        private TextBox txtbSurname;
        private Label label2;
        private Label label1;
        private Label label3;
        private BindingSource form1BindingSource;
        private BindingSource form1BindingSource1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripProgressBar ts_PrgBar;
        private CheckBox chbReqAdmin;
        private OpenFileDialog openFileDialog1;
    }
}
