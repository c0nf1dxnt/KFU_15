namespace TypographerProject
{
    partial class TypographerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypographerForm));
            tableLayoutPanelForAligningTextBoxes = new TableLayoutPanel();
            inputRichTextBox = new RichTextBox();
            outputRichTextBox = new RichTextBox();
            numberOfSymbolsLabel = new Label();
            copyTextButton = new Button();
            pasteTextButton = new Button();
            tableLayoutPanelForAligningTextBoxes.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelForAligningTextBoxes
            // 
            tableLayoutPanelForAligningTextBoxes.ColumnCount = 2;
            tableLayoutPanelForAligningTextBoxes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelForAligningTextBoxes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelForAligningTextBoxes.Controls.Add(inputRichTextBox, 0, 0);
            tableLayoutPanelForAligningTextBoxes.Controls.Add(outputRichTextBox, 1, 0);
            tableLayoutPanelForAligningTextBoxes.Dock = DockStyle.Top;
            tableLayoutPanelForAligningTextBoxes.Location = new Point(0, 0);
            tableLayoutPanelForAligningTextBoxes.Name = "tableLayoutPanelForAligningTextBoxes";
            tableLayoutPanelForAligningTextBoxes.RowCount = 1;
            tableLayoutPanelForAligningTextBoxes.RowStyles.Add(new RowStyle(SizeType.Percent, 91.13737F));
            tableLayoutPanelForAligningTextBoxes.RowStyles.Add(new RowStyle(SizeType.Percent, 8.862629F));
            tableLayoutPanelForAligningTextBoxes.Size = new Size(1060, 601);
            tableLayoutPanelForAligningTextBoxes.TabIndex = 0;
            // 
            // inputRichTextBox
            // 
            inputRichTextBox.Dock = DockStyle.Fill;
            inputRichTextBox.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inputRichTextBox.Location = new Point(3, 3);
            inputRichTextBox.Name = "inputRichTextBox";
            inputRichTextBox.Size = new Size(524, 595);
            inputRichTextBox.TabIndex = 0;
            inputRichTextBox.Text = "";
            inputRichTextBox.TextChanged += ChangedInputRichTextBox;
            // 
            // outputRichTextBox
            // 
            outputRichTextBox.Dock = DockStyle.Fill;
            outputRichTextBox.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outputRichTextBox.Location = new Point(533, 3);
            outputRichTextBox.Name = "outputRichTextBox";
            outputRichTextBox.ReadOnly = true;
            outputRichTextBox.Size = new Size(524, 595);
            outputRichTextBox.TabIndex = 1;
            outputRichTextBox.Text = "";
            // 
            // numberOfSymbolsLabel
            // 
            numberOfSymbolsLabel.Anchor = AnchorStyles.None;
            numberOfSymbolsLabel.AutoSize = true;
            numberOfSymbolsLabel.Font = new Font("SF Pro Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numberOfSymbolsLabel.Location = new Point(10, 607);
            numberOfSymbolsLabel.Name = "numberOfSymbolsLabel";
            numberOfSymbolsLabel.Size = new Size(203, 23);
            numberOfSymbolsLabel.TabIndex = 2;
            numberOfSymbolsLabel.Text = "Количество символов: ";
            // 
            // copyTextButton
            // 
            copyTextButton.Font = new Font("SF Pro Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            copyTextButton.Location = new Point(901, 638);
            copyTextButton.Name = "copyTextButton";
            copyTextButton.Size = new Size(147, 27);
            copyTextButton.TabIndex = 3;
            copyTextButton.Text = "Скопировать";
            copyTextButton.UseVisualStyleBackColor = true;
            copyTextButton.MouseDown += CopyTextFromOutputRichTextBox;
            // 
            // pasteTextButton
            // 
            pasteTextButton.Font = new Font("SF Pro Display", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pasteTextButton.Location = new Point(8, 642);
            pasteTextButton.Name = "pasteTextButton";
            pasteTextButton.Size = new Size(110, 27);
            pasteTextButton.TabIndex = 4;
            pasteTextButton.Text = "Вставить текст";
            pasteTextButton.UseVisualStyleBackColor = true;
            pasteTextButton.MouseDown += PasteTextIntoInputRichTextBox;
            // 
            // TypographerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 677);
            Controls.Add(pasteTextButton);
            Controls.Add(copyTextButton);
            Controls.Add(tableLayoutPanelForAligningTextBoxes);
            Controls.Add(numberOfSymbolsLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "TypographerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Typographer";
            tableLayoutPanelForAligningTextBoxes.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelForAligningTextBoxes;
        public RichTextBox inputRichTextBox;
        public RichTextBox outputRichTextBox;
        public Label numberOfSymbolsLabel;
        private Button copyTextButton;
        private Button pasteTextButton;
    }
}
