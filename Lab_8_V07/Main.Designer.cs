namespace Lab_8_V07
{
    partial class Main
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            textEditingToolStripMenuItem = new ToolStripMenuItem();
            textFormattingToolStripMenuItem = new ToolStripMenuItem();
            FontToolStripMenuItem = new ToolStripMenuItem();
            BackColorToolStripMenuItem = new ToolStripMenuItem();
            textEditingToolStripMenuItem1 = new ToolStripMenuItem();
            myVariantToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            changeSymbolToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            defaultSettingToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            clearTheResultWindowToolStripMenuItem = new ToolStripMenuItem();
            exiteToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(110, 373);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(470, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // button1
            // 
            button1.Location = new Point(295, 504);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Apply";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(248, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(17, 16);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Visible = false;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(248, 59);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(17, 16);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Visible = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(248, 90);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(17, 16);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.Visible = false;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(20, 90);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(100, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "My variant";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(20, 56);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(88, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Fill color";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(20, 26);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(62, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Type";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(89, 85);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(250, 250);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(375, 85);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(250, 250);
            richTextBox2.TabIndex = 5;
            richTextBox2.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { textEditingToolStripMenuItem, exiteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(782, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // textEditingToolStripMenuItem
            // 
            textEditingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { textFormattingToolStripMenuItem, textEditingToolStripMenuItem1, toolStripSeparator1, defaultSettingToolStripMenuItem, toolStripSeparator2, clearTheResultWindowToolStripMenuItem });
            textEditingToolStripMenuItem.Name = "textEditingToolStripMenuItem";
            textEditingToolStripMenuItem.Size = new Size(70, 24);
            textEditingToolStripMenuItem.Text = "Editing";
            // 
            // textFormattingToolStripMenuItem
            // 
            textFormattingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { FontToolStripMenuItem, BackColorToolStripMenuItem });
            textFormattingToolStripMenuItem.Name = "textFormattingToolStripMenuItem";
            textFormattingToolStripMenuItem.Size = new Size(247, 26);
            textFormattingToolStripMenuItem.Text = "Text formatting";
            // 
            // FontToolStripMenuItem
            // 
            FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            FontToolStripMenuItem.Size = new Size(161, 26);
            FontToolStripMenuItem.Text = "Type";
            FontToolStripMenuItem.Click += FontToolStripMenuItem_Click;
            // 
            // BackColorToolStripMenuItem
            // 
            BackColorToolStripMenuItem.Name = "BackColorToolStripMenuItem";
            BackColorToolStripMenuItem.Size = new Size(161, 26);
            BackColorToolStripMenuItem.Text = "Back color";
            BackColorToolStripMenuItem.Click += BackColorToolStripMenuItem_Click;
            // 
            // textEditingToolStripMenuItem1
            // 
            textEditingToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { myVariantToolStripMenuItem, deleteToolStripMenuItem, changeSymbolToolStripMenuItem });
            textEditingToolStripMenuItem1.Name = "textEditingToolStripMenuItem1";
            textEditingToolStripMenuItem1.Size = new Size(247, 26);
            textEditingToolStripMenuItem1.Text = "Text editing";
            // 
            // myVariantToolStripMenuItem
            // 
            myVariantToolStripMenuItem.Name = "myVariantToolStripMenuItem";
            myVariantToolStripMenuItem.Size = new Size(194, 26);
            myVariantToolStripMenuItem.Text = "My Variant";
            myVariantToolStripMenuItem.Click += myVariantToolStripMenuItem_Click;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(194, 26);
            deleteToolStripMenuItem.Text = "Delete symbol";
            // 
            // changeSymbolToolStripMenuItem
            // 
            changeSymbolToolStripMenuItem.Name = "changeSymbolToolStripMenuItem";
            changeSymbolToolStripMenuItem.Size = new Size(194, 26);
            changeSymbolToolStripMenuItem.Text = "Change symbol";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(244, 6);
            // 
            // defaultSettingToolStripMenuItem
            // 
            defaultSettingToolStripMenuItem.Name = "defaultSettingToolStripMenuItem";
            defaultSettingToolStripMenuItem.Size = new Size(247, 26);
            defaultSettingToolStripMenuItem.Text = "Default setting";
            defaultSettingToolStripMenuItem.Click += defaultSettingToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(244, 6);
            // 
            // clearTheResultWindowToolStripMenuItem
            // 
            clearTheResultWindowToolStripMenuItem.Name = "clearTheResultWindowToolStripMenuItem";
            clearTheResultWindowToolStripMenuItem.Size = new Size(247, 26);
            clearTheResultWindowToolStripMenuItem.Text = "Clear the result window";
            clearTheResultWindowToolStripMenuItem.Click += clearTheResultWindowToolStripMenuItem_Click;
            // 
            // exiteToolStripMenuItem
            // 
            exiteToolStripMenuItem.Name = "exiteToolStripMenuItem";
            exiteToolStripMenuItem.Size = new Size(55, 24);
            exiteToolStripMenuItem.Text = "Exite";
            exiteToolStripMenuItem.Click += exiteToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(782, 553);
            Controls.Add(button1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Редагування та оформлення тексту";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem textEditingToolStripMenuItem;
        private ToolStripMenuItem textEditingToolStripMenuItem1;
        private ToolStripMenuItem textFormattingToolStripMenuItem;
        private ToolStripMenuItem exiteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem defaultSettingToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem clearTheResultWindowToolStripMenuItem;
        private ToolStripMenuItem FontToolStripMenuItem;
        private ToolStripMenuItem BackColorToolStripMenuItem;
        private ToolStripMenuItem myVariantToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem changeSymbolToolStripMenuItem;
    }
}
