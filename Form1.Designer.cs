using System.Reflection.Emit;

namespace GUI_視窗版本XAXB_遊戲
{
   partial class MainForm
{
    // 設計器生成的必需組件變數
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 清理所有使用中的資源。
    /// </summary>
    /// <param name="disposing">如果應該處置受控資源，則為 true；否則為 false。</param>
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
    /// 設計工具所需的方法 - 不要修改
    /// 使用程式碼編輯器修改此方法的內容。
    /// </summary>
    private void InitializeComponent()
    {
        this.label1 = new System.Windows.Forms.Label();
        this.txtUserInput = new System.Windows.Forms.TextBox();
        this.btnGuess = new System.Windows.Forms.Button();
        this.lstResults = new System.Windows.Forms.ListBox();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(88, 57);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(51, 19);
        this.label1.TabIndex = 0;
        this.label1.Text = "label1";
        // 
        // txtUserInput
        // 
        this.txtUserInput.Location = new System.Drawing.Point(88, 101);
        this.txtUserInput.Name = "txtUserInput";
        this.txtUserInput.Size = new System.Drawing.Size(125, 27);
        this.txtUserInput.TabIndex = 1;
        // 
        // btnGuess
        // 
        this.btnGuess.Location = new System.Drawing.Point(88, 150);
        this.btnGuess.Name = "btnGuess";
        this.btnGuess.Size = new System.Drawing.Size(94, 29);
        this.btnGuess.TabIndex = 2;
        this.btnGuess.Text = "Guess";
        this.btnGuess.UseVisualStyleBackColor = true;
        this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
        // 
        // lstResults
        // 
        this.lstResults.FormattingEnabled = true;
        this.lstResults.ItemHeight = 19;
        this.lstResults.Location = new System.Drawing.Point(88, 200);
        this.lstResults.Name = "lstResults";
        this.lstResults.Size = new System.Drawing.Size(300, 213);
        this.lstResults.TabIndex = 3;
        // 
        // MainForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.lstResults);
        this.Controls.Add(this.btnGuess);
        this.Controls.Add(this.txtUserInput);
        this.Controls.Add(this.label1);
        this.Name = "MainForm";
        this.Text = "MainForm";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtUserInput;
    private System.Windows.Forms.Button btnGuess;
    private System.Windows.Forms.ListBox lstResults;
}
}
