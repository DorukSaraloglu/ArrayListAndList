namespace ArrayListAndList
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnColorize = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnButtons = new System.Windows.Forms.Button();
            this.lbxData = new System.Windows.Forms.ListBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnArray = new System.Windows.Forms.Button();
            this.btnArrayList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnColorize
            // 
            this.btnColorize.Location = new System.Drawing.Point(511, 57);
            this.btnColorize.Name = "btnColorize";
            this.btnColorize.Size = new System.Drawing.Size(93, 28);
            this.btnColorize.TabIndex = 13;
            this.btnColorize.Text = "Renklendir";
            this.btnColorize.UseVisualStyleBackColor = true;
            this.btnColorize.Visible = false;
            this.btnColorize.Click += new System.EventHandler(this.btnColorize_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(381, 123);
            this.flowLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(223, 213);
            this.flowLayoutPanel.TabIndex = 12;
            // 
            // btnButtons
            // 
            this.btnButtons.Location = new System.Drawing.Point(381, 57);
            this.btnButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnButtons.Name = "btnButtons";
            this.btnButtons.Size = new System.Drawing.Size(101, 28);
            this.btnButtons.TabIndex = 11;
            this.btnButtons.Text = "Butonlar";
            this.btnButtons.UseVisualStyleBackColor = true;
            this.btnButtons.Click += new System.EventHandler(this.btnButtons_Click);
            // 
            // lbxData
            // 
            this.lbxData.FormattingEnabled = true;
            this.lbxData.ItemHeight = 16;
            this.lbxData.Location = new System.Drawing.Point(34, 123);
            this.lbxData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxData.Name = "lbxData";
            this.lbxData.Size = new System.Drawing.Size(313, 212);
            this.lbxData.TabIndex = 10;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(246, 57);
            this.btnList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(101, 28);
            this.btnList.TabIndex = 9;
            this.btnList.Text = "List ";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnArray
            // 
            this.btnArray.BackColor = System.Drawing.SystemColors.Control;
            this.btnArray.Location = new System.Drawing.Point(34, 57);
            this.btnArray.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnArray.Name = "btnArray";
            this.btnArray.Size = new System.Drawing.Size(75, 28);
            this.btnArray.TabIndex = 8;
            this.btnArray.Text = "Array";
            this.btnArray.UseVisualStyleBackColor = false;
            this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // btnArrayList
            // 
            this.btnArrayList.Location = new System.Drawing.Point(127, 57);
            this.btnArrayList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnArrayList.Name = "btnArrayList";
            this.btnArrayList.Size = new System.Drawing.Size(101, 28);
            this.btnArrayList.TabIndex = 7;
            this.btnArrayList.Text = "Array List ";
            this.btnArrayList.UseVisualStyleBackColor = true;
            this.btnArrayList.Click += new System.EventHandler(this.btnArrayList_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 377);
            this.Controls.Add(this.btnColorize);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.btnButtons);
            this.Controls.Add(this.lbxData);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnArray);
            this.Controls.Add(this.btnArrayList);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnColorize;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btnButtons;
        private System.Windows.Forms.ListBox lbxData;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.Button btnArrayList;
    }
}

