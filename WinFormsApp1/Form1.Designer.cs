namespace WinFormsApp1
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            LOGIN = new Button();
            USUARIO = new TextBox();
            SENHA = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // LOGIN
            // 
            LOGIN.Location = new Point(397, 281);
            LOGIN.Name = "LOGIN";
            LOGIN.Size = new Size(151, 54);
            LOGIN.TabIndex = 0;
            LOGIN.Text = "LOGIN";
            LOGIN.UseVisualStyleBackColor = true;
            LOGIN.Click += LOGIN_Click;
            // 
            // USUARIO
            // 
            USUARIO.Location = new Point(400, 120);
            USUARIO.Name = "USUARIO";
            USUARIO.Size = new Size(150, 27);
            USUARIO.TabIndex = 3;
            USUARIO.TextChanged += textBox1_TextChanged;
            // 
            // SENHA
            // 
            SENHA.Location = new Point(397, 200);
            SENHA.Name = "SENHA";
            SENHA.Size = new Size(151, 27);
            SENHA.TabIndex = 4;
            SENHA.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(444, 87);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 5;
            label1.Text = "LOGIN";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(444, 165);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 6;
            label2.Text = "SENHA";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(958, 485);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SENHA);
            Controls.Add(USUARIO);
            Controls.Add(LOGIN);
            Name = "Form1";
            Text = "TELA 1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Button LOGIN;
        private TextBox USUARIO;
        private TextBox SENHA;
        private Label label1;
        protected Label label2;
    }
}
