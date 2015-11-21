namespace Lab3_PaulBoyko_PROG1197
{
    partial class Queue
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
            this.txtAddToDo = new System.Windows.Forms.TextBox();
            this.lblToDo = new System.Windows.Forms.Label();
            this.btnAddToDo = new System.Windows.Forms.Button();
            this.lblNext = new System.Windows.Forms.Label();
            this.lblNextOutput = new System.Windows.Forms.Label();
            this.lblTotalToDo = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.lblPriority = new System.Windows.Forms.Label();
            this.ddlPriority = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtAddToDo
            // 
            this.txtAddToDo.Location = new System.Drawing.Point(12, 23);
            this.txtAddToDo.Name = "txtAddToDo";
            this.txtAddToDo.Size = new System.Drawing.Size(306, 20);
            this.txtAddToDo.TabIndex = 0;
            // 
            // lblToDo
            // 
            this.lblToDo.AutoSize = true;
            this.lblToDo.Location = new System.Drawing.Point(13, 4);
            this.lblToDo.Name = "lblToDo";
            this.lblToDo.Size = new System.Drawing.Size(65, 13);
            this.lblToDo.TabIndex = 1;
            this.lblToDo.Text = "New To Do:";
            // 
            // btnAddToDo
            // 
            this.btnAddToDo.Location = new System.Drawing.Point(324, 20);
            this.btnAddToDo.Name = "btnAddToDo";
            this.btnAddToDo.Size = new System.Drawing.Size(75, 23);
            this.btnAddToDo.TabIndex = 2;
            this.btnAddToDo.Text = "Add To Do";
            this.btnAddToDo.UseVisualStyleBackColor = true;
            this.btnAddToDo.Click += new System.EventHandler(this.btnAddToDo_Click);
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Location = new System.Drawing.Point(16, 89);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(65, 13);
            this.lblNext.TabIndex = 3;
            this.lblNext.Text = "Next To Do:";
            // 
            // lblNextOutput
            // 
            this.lblNextOutput.AutoSize = true;
            this.lblNextOutput.Location = new System.Drawing.Point(19, 106);
            this.lblNextOutput.Name = "lblNextOutput";
            this.lblNextOutput.Size = new System.Drawing.Size(0, 13);
            this.lblNextOutput.TabIndex = 4;
            // 
            // lblTotalToDo
            // 
            this.lblTotalToDo.AutoSize = true;
            this.lblTotalToDo.Location = new System.Drawing.Point(19, 148);
            this.lblTotalToDo.Name = "lblTotalToDo";
            this.lblTotalToDo.Size = new System.Drawing.Size(86, 13);
            this.lblTotalToDo.TabIndex = 5;
            this.lblTotalToDo.Text = "Total Still To Do:";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Location = new System.Drawing.Point(22, 165);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(0, 13);
            this.lblTotalCount.TabIndex = 6;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(117, 225);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(180, 23);
            this.btnDone.TabIndex = 7;
            this.btnDone.Text = "To Do Task Complete";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(13, 53);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(67, 13);
            this.lblPriority.TabIndex = 8;
            this.lblPriority.Text = "Priority Level";
            // 
            // ddlPriority
            // 
            this.ddlPriority.FormattingEnabled = true;
            this.ddlPriority.Items.AddRange(new object[] {
            "Critical",
            "High",
            "Normal",
            "Low"});
            this.ddlPriority.Location = new System.Drawing.Point(117, 50);
            this.ddlPriority.Name = "ddlPriority";
            this.ddlPriority.Size = new System.Drawing.Size(121, 21);
            this.ddlPriority.TabIndex = 9;
            // 
            // Queue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 261);
            this.Controls.Add(this.ddlPriority);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.lblTotalToDo);
            this.Controls.Add(this.lblNextOutput);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.btnAddToDo);
            this.Controls.Add(this.lblToDo);
            this.Controls.Add(this.txtAddToDo);
            this.Name = "Queue";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddToDo;
        private System.Windows.Forms.Label lblToDo;
        private System.Windows.Forms.Button btnAddToDo;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label lblNextOutput;
        private System.Windows.Forms.Label lblTotalToDo;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox ddlPriority;
    }
}

