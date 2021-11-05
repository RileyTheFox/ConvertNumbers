namespace ConvertNumbersApp
{
    partial class Form1
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
            this.generateNewButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.questionsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.q6Check = new System.Windows.Forms.Label();
            this.q5Check = new System.Windows.Forms.Label();
            this.q4Check = new System.Windows.Forms.Label();
            this.q3Check = new System.Windows.Forms.Label();
            this.q2Check = new System.Windows.Forms.Label();
            this.q1Answer = new System.Windows.Forms.TextBox();
            this.q1Label = new System.Windows.Forms.Label();
            this.q1Text = new System.Windows.Forms.TextBox();
            this.q2Label = new System.Windows.Forms.Label();
            this.q2Text = new System.Windows.Forms.TextBox();
            this.q2Answer = new System.Windows.Forms.TextBox();
            this.q3Label = new System.Windows.Forms.Label();
            this.q3Text = new System.Windows.Forms.TextBox();
            this.q3Answer = new System.Windows.Forms.TextBox();
            this.q5Label = new System.Windows.Forms.Label();
            this.q4Label = new System.Windows.Forms.Label();
            this.q6Label = new System.Windows.Forms.Label();
            this.q4Answer = new System.Windows.Forms.TextBox();
            this.q4Text = new System.Windows.Forms.TextBox();
            this.q5Text = new System.Windows.Forms.TextBox();
            this.q6Text = new System.Windows.Forms.TextBox();
            this.q5Answer = new System.Windows.Forms.TextBox();
            this.q6Answer = new System.Windows.Forms.TextBox();
            this.q1Check = new System.Windows.Forms.Label();
            this.questionsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // generateNewButton
            // 
            this.generateNewButton.AutoSize = true;
            this.generateNewButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.generateNewButton.Location = new System.Drawing.Point(24, 23);
            this.generateNewButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.generateNewButton.Name = "generateNewButton";
            this.generateNewButton.Size = new System.Drawing.Size(159, 35);
            this.generateNewButton.TabIndex = 1;
            this.generateNewButton.Text = "Generate New";
            this.generateNewButton.UseVisualStyleBackColor = false;
            this.generateNewButton.Click += new System.EventHandler(this.generateNewButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.submitButton.Location = new System.Drawing.Point(1033, 528);
            this.submitButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.submitButton.Name = "submitButton";
            this.submitButton.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.submitButton.Size = new System.Drawing.Size(138, 44);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // questionsPanel
            // 
            this.questionsPanel.AutoSize = true;
            this.questionsPanel.ColumnCount = 4;
            this.questionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.questionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.questionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.questionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.questionsPanel.Controls.Add(this.q6Check, 3, 5);
            this.questionsPanel.Controls.Add(this.q5Check, 3, 4);
            this.questionsPanel.Controls.Add(this.q4Check, 3, 3);
            this.questionsPanel.Controls.Add(this.q3Check, 3, 2);
            this.questionsPanel.Controls.Add(this.q2Check, 3, 1);
            this.questionsPanel.Controls.Add(this.q1Answer, 2, 0);
            this.questionsPanel.Controls.Add(this.q1Label, 0, 0);
            this.questionsPanel.Controls.Add(this.q1Text, 1, 0);
            this.questionsPanel.Controls.Add(this.q2Label, 0, 1);
            this.questionsPanel.Controls.Add(this.q2Text, 1, 1);
            this.questionsPanel.Controls.Add(this.q2Answer, 2, 1);
            this.questionsPanel.Controls.Add(this.q3Label, 0, 2);
            this.questionsPanel.Controls.Add(this.q3Text, 1, 2);
            this.questionsPanel.Controls.Add(this.q3Answer, 2, 2);
            this.questionsPanel.Controls.Add(this.q5Label, 0, 4);
            this.questionsPanel.Controls.Add(this.q4Label, 0, 3);
            this.questionsPanel.Controls.Add(this.q6Label, 0, 5);
            this.questionsPanel.Controls.Add(this.q4Answer, 2, 3);
            this.questionsPanel.Controls.Add(this.q4Text, 1, 3);
            this.questionsPanel.Controls.Add(this.q5Text, 1, 4);
            this.questionsPanel.Controls.Add(this.q6Text, 1, 5);
            this.questionsPanel.Controls.Add(this.q5Answer, 2, 4);
            this.questionsPanel.Controls.Add(this.q6Answer, 2, 5);
            this.questionsPanel.Controls.Add(this.q1Check, 3, 0);
            this.questionsPanel.Location = new System.Drawing.Point(24, 79);
            this.questionsPanel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.questionsPanel.Name = "questionsPanel";
            this.questionsPanel.RowCount = 6;
            this.questionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.questionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.questionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.questionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.questionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.questionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.questionsPanel.Size = new System.Drawing.Size(1147, 433);
            this.questionsPanel.TabIndex = 2;
            // 
            // q6Check
            // 
            this.q6Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q6Check.ForeColor = System.Drawing.Color.Green;
            this.q6Check.Location = new System.Drawing.Point(964, 385);
            this.q6Check.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.q6Check.Name = "q6Check";
            this.q6Check.Size = new System.Drawing.Size(122, 44);
            this.q6Check.TabIndex = 29;
            this.q6Check.Text = "🗸";
            // 
            // q5Check
            // 
            this.q5Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q5Check.ForeColor = System.Drawing.Color.Green;
            this.q5Check.Location = new System.Drawing.Point(964, 308);
            this.q5Check.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.q5Check.Name = "q5Check";
            this.q5Check.Size = new System.Drawing.Size(122, 44);
            this.q5Check.TabIndex = 28;
            this.q5Check.Text = "🗸";
            // 
            // q4Check
            // 
            this.q4Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q4Check.ForeColor = System.Drawing.Color.Green;
            this.q4Check.Location = new System.Drawing.Point(964, 231);
            this.q4Check.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.q4Check.Name = "q4Check";
            this.q4Check.Size = new System.Drawing.Size(122, 44);
            this.q4Check.TabIndex = 27;
            this.q4Check.Text = "🗸";
            // 
            // q3Check
            // 
            this.q3Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q3Check.ForeColor = System.Drawing.Color.Green;
            this.q3Check.Location = new System.Drawing.Point(964, 154);
            this.q3Check.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.q3Check.Name = "q3Check";
            this.q3Check.Size = new System.Drawing.Size(122, 44);
            this.q3Check.TabIndex = 26;
            this.q3Check.Text = "🗸";
            // 
            // q2Check
            // 
            this.q2Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2Check.ForeColor = System.Drawing.Color.Green;
            this.q2Check.Location = new System.Drawing.Point(964, 77);
            this.q2Check.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.q2Check.Name = "q2Check";
            this.q2Check.Size = new System.Drawing.Size(122, 44);
            this.q2Check.TabIndex = 25;
            this.q2Check.Text = "🗸";
            // 
            // q1Answer
            // 
            this.q1Answer.Location = new System.Drawing.Point(484, 6);
            this.q1Answer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.q1Answer.Name = "q1Answer";
            this.q1Answer.Size = new System.Drawing.Size(468, 31);
            this.q1Answer.TabIndex = 2;
            // 
            // q1Label
            // 
            this.q1Label.Location = new System.Drawing.Point(6, 0);
            this.q1Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.q1Label.Name = "q1Label";
            this.q1Label.Size = new System.Drawing.Size(230, 44);
            this.q1Label.TabIndex = 0;
            this.q1Label.Text = "Denary -> Binary";
            this.q1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q1Text
            // 
            this.q1Text.Location = new System.Drawing.Point(248, 6);
            this.q1Text.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.q1Text.Name = "q1Text";
            this.q1Text.ReadOnly = true;
            this.q1Text.Size = new System.Drawing.Size(224, 31);
            this.q1Text.TabIndex = 1;
            this.q1Text.Text = "75";
            this.q1Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // q2Label
            // 
            this.q2Label.Location = new System.Drawing.Point(6, 77);
            this.q2Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.q2Label.Name = "q2Label";
            this.q2Label.Size = new System.Drawing.Size(230, 44);
            this.q2Label.TabIndex = 3;
            this.q2Label.Text = "Unset";
            this.q2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q2Text
            // 
            this.q2Text.Location = new System.Drawing.Point(248, 83);
            this.q2Text.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.q2Text.Name = "q2Text";
            this.q2Text.ReadOnly = true;
            this.q2Text.Size = new System.Drawing.Size(224, 31);
            this.q2Text.TabIndex = 4;
            this.q2Text.Text = "Question";
            this.q2Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // q2Answer
            // 
            this.q2Answer.Location = new System.Drawing.Point(484, 83);
            this.q2Answer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.q2Answer.Name = "q2Answer";
            this.q2Answer.Size = new System.Drawing.Size(468, 31);
            this.q2Answer.TabIndex = 5;
            // 
            // q3Label
            // 
            this.q3Label.Location = new System.Drawing.Point(6, 154);
            this.q3Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.q3Label.Name = "q3Label";
            this.q3Label.Size = new System.Drawing.Size(230, 44);
            this.q3Label.TabIndex = 6;
            this.q3Label.Text = "Unset";
            this.q3Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q3Text
            // 
            this.q3Text.Location = new System.Drawing.Point(248, 160);
            this.q3Text.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.q3Text.Name = "q3Text";
            this.q3Text.ReadOnly = true;
            this.q3Text.Size = new System.Drawing.Size(224, 31);
            this.q3Text.TabIndex = 7;
            this.q3Text.Text = "Question";
            this.q3Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // q3Answer
            // 
            this.q3Answer.Location = new System.Drawing.Point(484, 160);
            this.q3Answer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.q3Answer.Name = "q3Answer";
            this.q3Answer.Size = new System.Drawing.Size(468, 31);
            this.q3Answer.TabIndex = 8;
            // 
            // q5Label
            // 
            this.q5Label.Location = new System.Drawing.Point(6, 308);
            this.q5Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.q5Label.Name = "q5Label";
            this.q5Label.Size = new System.Drawing.Size(230, 44);
            this.q5Label.TabIndex = 12;
            this.q5Label.Text = "Unset";
            this.q5Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q4Label
            // 
            this.q4Label.Location = new System.Drawing.Point(6, 231);
            this.q4Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.q4Label.Name = "q4Label";
            this.q4Label.Size = new System.Drawing.Size(230, 44);
            this.q4Label.TabIndex = 9;
            this.q4Label.Text = "Unset";
            this.q4Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q6Label
            // 
            this.q6Label.Location = new System.Drawing.Point(6, 385);
            this.q6Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.q6Label.Name = "q6Label";
            this.q6Label.Size = new System.Drawing.Size(230, 44);
            this.q6Label.TabIndex = 15;
            this.q6Label.Text = "Unset";
            this.q6Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // q4Answer
            // 
            this.q4Answer.Location = new System.Drawing.Point(484, 237);
            this.q4Answer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.q4Answer.Name = "q4Answer";
            this.q4Answer.Size = new System.Drawing.Size(468, 31);
            this.q4Answer.TabIndex = 14;
            // 
            // q4Text
            // 
            this.q4Text.Location = new System.Drawing.Point(248, 237);
            this.q4Text.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.q4Text.Name = "q4Text";
            this.q4Text.ReadOnly = true;
            this.q4Text.Size = new System.Drawing.Size(224, 31);
            this.q4Text.TabIndex = 10;
            this.q4Text.Text = "Question";
            this.q4Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // q5Text
            // 
            this.q5Text.Location = new System.Drawing.Point(248, 314);
            this.q5Text.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.q5Text.Name = "q5Text";
            this.q5Text.ReadOnly = true;
            this.q5Text.Size = new System.Drawing.Size(224, 31);
            this.q5Text.TabIndex = 13;
            this.q5Text.Text = "Question";
            this.q5Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // q6Text
            // 
            this.q6Text.Location = new System.Drawing.Point(248, 391);
            this.q6Text.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.q6Text.Name = "q6Text";
            this.q6Text.ReadOnly = true;
            this.q6Text.Size = new System.Drawing.Size(224, 31);
            this.q6Text.TabIndex = 16;
            this.q6Text.Text = "Question";
            this.q6Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // q5Answer
            // 
            this.q5Answer.Location = new System.Drawing.Point(484, 314);
            this.q5Answer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.q5Answer.Name = "q5Answer";
            this.q5Answer.Size = new System.Drawing.Size(468, 31);
            this.q5Answer.TabIndex = 17;
            // 
            // q6Answer
            // 
            this.q6Answer.Location = new System.Drawing.Point(484, 391);
            this.q6Answer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.q6Answer.Name = "q6Answer";
            this.q6Answer.Size = new System.Drawing.Size(468, 31);
            this.q6Answer.TabIndex = 11;
            // 
            // q1Check
            // 
            this.q1Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1Check.ForeColor = System.Drawing.Color.Green;
            this.q1Check.Location = new System.Drawing.Point(964, 0);
            this.q1Check.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.q1Check.Name = "q1Check";
            this.q1Check.Size = new System.Drawing.Size(122, 44);
            this.q1Check.TabIndex = 24;
            this.q1Check.Text = "🗸";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 587);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.questionsPanel);
            this.Controls.Add(this.generateNewButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.questionsPanel.ResumeLayout(false);
            this.questionsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label q1Check;
        private System.Windows.Forms.Label q2Check;
        private System.Windows.Forms.Label q3Check;
        private System.Windows.Forms.Label q4Check;
        private System.Windows.Forms.Label q5Check;
        private System.Windows.Forms.Label q6Check;

        private System.Windows.Forms.Label q1Label;
        private System.Windows.Forms.TextBox q1Text;
        private System.Windows.Forms.TextBox q1Answer;

        private System.Windows.Forms.Label q2Label;
        private System.Windows.Forms.TextBox q2Text;
        private System.Windows.Forms.TextBox q2Answer;

        private System.Windows.Forms.Label q3Label;
        private System.Windows.Forms.TextBox q3Text;
        private System.Windows.Forms.TextBox q3Answer;

        private System.Windows.Forms.Label q4Label;
        private System.Windows.Forms.TextBox q4Text;

        private System.Windows.Forms.Label q5Label;
        private System.Windows.Forms.TextBox q5Text;
        private System.Windows.Forms.TextBox q6Answer;

        private System.Windows.Forms.Label q6Label;
        private System.Windows.Forms.TextBox q6Text;
        private System.Windows.Forms.TextBox q4Answer;
        private System.Windows.Forms.TextBox q5Answer;
        
        private System.Windows.Forms.TableLayoutPanel questionsPanel;

        private System.Windows.Forms.Button submitButton;

        private System.Windows.Forms.Button generateNewButton;
        #endregion
    }
}