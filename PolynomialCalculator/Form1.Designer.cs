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
        menuStrip1 = new MenuStrip();
        historyToolStripMenuItem = new ToolStripMenuItem();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // PolynomialInput
        // 
        PolynomialInput.Location = new Point(369, 99);
        PolynomialInput.Margin = new Padding(3, 4, 3, 4);
        PolynomialInput.Name = "PolynomialInput";
        PolynomialInput.Size = new Size(442, 27);
        PolynomialInput.TabIndex = 0;
        // 
        // CalculateButton
        // 
        CalculateButton.Location = new Point(857, 97);
        CalculateButton.Margin = new Padding(3, 4, 3, 4);
        CalculateButton.Name = "CalculateButton";
        CalculateButton.Size = new Size(86, 31);
        CalculateButton.TabIndex = 1;
        CalculateButton.Text = "Calculate";
        CalculateButton.UseVisualStyleBackColor = true;
        CalculateButton.Click += CalculateButton_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(186, 196);
        label1.Name = "label1";
        label1.Size = new Size(109, 37);
        label1.TabIndex = 2;
        label1.Text = "Answer:";
        label1.Click += label1_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(389, 196);
        label2.Name = "label2";
        label2.Size = new Size(0, 20);
        label2.TabIndex = 3;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(291, 196);
        textBox1.Margin = new Padding(3, 4, 3, 4);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.ReadOnly = true;
        textBox1.Size = new Size(651, 47);
        textBox1.TabIndex = 4;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
        label3.Location = new Point(482, 41);
        label3.Name = "label3";
        label3.Size = new Size(210, 26);
        label3.TabIndex = 5;
        label3.Text = "Write Polynomial";
        // 
        // menuStrip1
        // 
        menuStrip1.ImageScalingSize = new Size(20, 20);
        menuStrip1.Items.AddRange(new ToolStripItem[] { historyToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(1161, 28);
        menuStrip1.TabIndex = 6;
        menuStrip1.Text = "menuStrip1";
        // 
        // historyToolStripMenuItem
        // 
        historyToolStripMenuItem.Name = "historyToolStripMenuItem";
        historyToolStripMenuItem.Size = new Size(70, 24);
        historyToolStripMenuItem.Text = "History";
        historyToolStripMenuItem.Click += historyToolStripMenuItem_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1161, 753);
        Controls.Add(label3);
        Controls.Add(textBox1);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(CalculateButton);
        Controls.Add(PolynomialInput);
        Controls.Add(menuStrip1);
        MainMenuStrip = menuStrip1;
        Margin = new Padding(3, 4, 3, 4);
        Name = "Form1";
        Text = "Polynomial Calculator";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
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
    private MenuStrip menuStrip1;
    private ToolStripMenuItem historyToolStripMenuItem;
}