namespace Calculator.Winforms;

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
        lblFirst = new Label();
        txtFirst = new TextBox();
        lblSecond = new Label();
        txtSecond = new TextBox();
        btnAdd = new Button();
        btnSubtract = new Button();
        btnMultiply = new Button();
        btnDivide = new Button();
        lblResult = new Label();
        SuspendLayout();
        // 
        // lblFirst
        // 
        lblFirst.AutoSize = true;
        lblFirst.Location = new Point(20, 20);
        lblFirst.Name = "lblFirst";
        lblFirst.Size = new Size(85, 15);
        lblFirst.TabIndex = 0;
        lblFirst.Text = "First number";
        // 
        // txtFirst
        // 
        txtFirst.Location = new Point(130, 17);
        txtFirst.Name = "txtFirst";
        txtFirst.Size = new Size(190, 23);
        txtFirst.TabIndex = 1;
        // 
        // lblSecond
        // 
        lblSecond.AutoSize = true;
        lblSecond.Location = new Point(20, 55);
        lblSecond.Name = "lblSecond";
        lblSecond.Size = new Size(98, 15);
        lblSecond.TabIndex = 2;
        lblSecond.Text = "Second number";
        // 
        // txtSecond
        // 
        txtSecond.Location = new Point(130, 52);
        txtSecond.Name = "txtSecond";
        txtSecond.Size = new Size(190, 23);
        txtSecond.TabIndex = 3;
        // 
        // btnAdd
        // 
        btnAdd.Font = new Font("Segoe UI", 12F);
        btnAdd.Location = new Point(20, 95);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(70, 40);
        btnAdd.TabIndex = 4;
        btnAdd.Tag = "+";
        btnAdd.Text = "+";
        btnAdd.UseVisualStyleBackColor = true;
        btnAdd.Click += OperatorButton_Click;
        // 
        // btnSubtract
        // 
        btnSubtract.Font = new Font("Segoe UI", 12F);
        btnSubtract.Location = new Point(97, 95);
        btnSubtract.Name = "btnSubtract";
        btnSubtract.Size = new Size(70, 40);
        btnSubtract.TabIndex = 5;
        btnSubtract.Tag = "-";
        btnSubtract.Text = "-";
        btnSubtract.UseVisualStyleBackColor = true;
        btnSubtract.Click += OperatorButton_Click;
        // 
        // btnMultiply
        // 
        btnMultiply.Font = new Font("Segoe UI", 12F);
        btnMultiply.Location = new Point(174, 95);
        btnMultiply.Name = "btnMultiply";
        btnMultiply.Size = new Size(70, 40);
        btnMultiply.TabIndex = 6;
        btnMultiply.Tag = "*";
        btnMultiply.Text = "×";
        btnMultiply.UseVisualStyleBackColor = true;
        btnMultiply.Click += OperatorButton_Click;
        // 
        // btnDivide
        // 
        btnDivide.Font = new Font("Segoe UI", 12F);
        btnDivide.Location = new Point(251, 95);
        btnDivide.Name = "btnDivide";
        btnDivide.Size = new Size(70, 40);
        btnDivide.TabIndex = 7;
        btnDivide.Tag = "/";
        btnDivide.Text = "÷";
        btnDivide.UseVisualStyleBackColor = true;
        btnDivide.Click += OperatorButton_Click;
        // 
        // lblResult
        // 
        lblResult.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblResult.Location = new Point(20, 150);
        lblResult.Name = "lblResult";
        lblResult.Size = new Size(301, 35);
        lblResult.TabIndex = 8;
        lblResult.Text = "Result";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(344, 205);
        Controls.Add(lblFirst);
        Controls.Add(txtFirst);
        Controls.Add(lblSecond);
        Controls.Add(txtSecond);
        Controls.Add(btnAdd);
        Controls.Add(btnSubtract);
        Controls.Add(btnMultiply);
        Controls.Add(btnDivide);
        Controls.Add(lblResult);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "WinCalc";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblFirst;
    private TextBox txtFirst;
    private Label lblSecond;
    private TextBox txtSecond;
    private Button btnAdd;
    private Button btnSubtract;
    private Button btnMultiply;
    private Button btnDivide;
    private Label lblResult;
}
