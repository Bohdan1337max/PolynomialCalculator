namespace PolynomialCalculator;

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
        PolynomialInput = new TextBox();
        CalculateButton = new Button();
        label1 = new Label();
        label2 = new Label();
        textBox1 = new TextBox();
        label3 = new Label();
        SuspendLayout();
        // 
        // PolynomialInput
        // 
        PolynomialInput.Location = new Point(297, 73);
        PolynomialInput.Name = "PolynomialInput";
        PolynomialInput.Size = new Size(387, 23);
        PolynomialInput.TabIndex = 0;
        // 
        // CalculateButton
        // 
        CalculateButton.Location = new Point(740, 73);
        CalculateButton.Name = "CalculateButton";
        CalculateButton.Size = new Size(75, 23);
        CalculateButton.TabIndex = 1;
        CalculateButton.Text = "Calculate";
        CalculateButton.UseVisualStyleBackColor = true;
        CalculateButton.Click += CalculateButton_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(166, 158);
        label1.Name = "label1";
        label1.Size = new Size(78, 25);
        label1.TabIndex = 2;
        label1.Text = "Answer:";
        label1.Click += label1_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(340, 147);
        label2.Name = "label2";
        label2.Size = new Size(0, 15);
        label2.TabIndex = 3;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(255, 147);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.ReadOnly = true;
        textBox1.Size = new Size(570, 36);
        textBox1.TabIndex = 4;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label3.Location = new Point(405, 37);
        label3.Name = "label3";
        label3.Size = new Size(170, 20);
        label3.TabIndex = 5;
        label3.Text = "Write Polynomial";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1016, 565);
        Controls.Add(label3);
        Controls.Add(textBox1);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(CalculateButton);
        Controls.Add(PolynomialInput);
        Name = "Form1";
        Text = "Polynomial Calculator";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox PolynomialInput;
    private Button CalculateButton;
    private Label label1;
    private Label label2;
    private TextBox textBox1;
    private Label label3;
}