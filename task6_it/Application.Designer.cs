namespace task6_it
{
    partial class Application
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.openbtn = new System.Windows.Forms.Button();
            this.pathInp = new System.Windows.Forms.TextBox();
            this.loadbtn = new System.Windows.Forms.Button();
            this.dropdown = new System.Windows.Forms.ComboBox();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.methodListBox = new System.Windows.Forms.ListBox();
            this.executeMethod = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.numericInput = new System.Windows.Forms.NumericUpDown();
            this.textInput = new System.Windows.Forms.TextBox();
            this.createObj = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericInput)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.28436F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.71564F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.outputTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.97737F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.02263F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1123, 707);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.openbtn, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pathInp, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.loadbtn, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.dropdown, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 467F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(333, 616);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // openbtn
            // 
            this.openbtn.Location = new System.Drawing.Point(3, 3);
            this.openbtn.Name = "openbtn";
            this.openbtn.Size = new System.Drawing.Size(327, 38);
            this.openbtn.TabIndex = 1;
            this.openbtn.Text = "Open";
            this.openbtn.UseVisualStyleBackColor = true;
            this.openbtn.Click += new System.EventHandler(this.openbtn_Click);
            // 
            // pathInp
            // 
            this.pathInp.Location = new System.Drawing.Point(3, 53);
            this.pathInp.Name = "pathInp";
            this.pathInp.Size = new System.Drawing.Size(327, 31);
            this.pathInp.TabIndex = 2;
            // 
            // loadbtn
            // 
            this.loadbtn.Location = new System.Drawing.Point(3, 132);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(327, 34);
            this.loadbtn.TabIndex = 3;
            this.loadbtn.Text = "Load";
            this.loadbtn.UseVisualStyleBackColor = true;
            this.loadbtn.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // dropdown
            // 
            this.dropdown.FormattingEnabled = true;
            this.dropdown.Location = new System.Drawing.Point(3, 89);
            this.dropdown.Name = "dropdown";
            this.dropdown.Size = new System.Drawing.Size(327, 33);
            this.dropdown.TabIndex = 0;
            this.dropdown.SelectedIndexChanged += new System.EventHandler(this.dropdown_SelectedIndexChanged);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputTextBox.Location = new System.Drawing.Point(342, 3);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(497, 616);
            this.outputTextBox.TabIndex = 2;
            this.outputTextBox.Text = "";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.methodListBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.executeMethod, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(845, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.01948F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.980519F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(275, 616);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // methodListBox
            // 
            this.methodListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.methodListBox.FormattingEnabled = true;
            this.methodListBox.ItemHeight = 25;
            this.methodListBox.Location = new System.Drawing.Point(3, 3);
            this.methodListBox.Name = "methodListBox";
            this.methodListBox.Size = new System.Drawing.Size(269, 567);
            this.methodListBox.TabIndex = 1;
            // 
            // executeMethod
            // 
            this.executeMethod.Location = new System.Drawing.Point(3, 576);
            this.executeMethod.Name = "executeMethod";
            this.executeMethod.Size = new System.Drawing.Size(269, 34);
            this.executeMethod.TabIndex = 2;
            this.executeMethod.Text = "Execute";
            this.executeMethod.UseVisualStyleBackColor = true;
            this.executeMethod.Click += new System.EventHandler(this.executeMethod_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.numericInput, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.textInput, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.createObj, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(342, 625);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(497, 79);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // numericInput
            // 
            this.numericInput.Location = new System.Drawing.Point(251, 3);
            this.numericInput.Name = "numericInput";
            this.numericInput.Size = new System.Drawing.Size(243, 31);
            this.numericInput.TabIndex = 0;
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(3, 3);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(242, 31);
            this.textInput.TabIndex = 1;
            // 
            // createObj
            // 
            this.createObj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createObj.Location = new System.Drawing.Point(251, 42);
            this.createObj.Name = "createObj";
            this.createObj.Size = new System.Drawing.Size(243, 34);
            this.createObj.TabIndex = 2;
            this.createObj.Text = "Create";
            this.createObj.UseVisualStyleBackColor = true;
            this.createObj.Click += new System.EventHandler(this.createObj_Click);
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 707);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Application";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox dropdown;
        private Button openbtn;
        private TextBox pathInp;
        private Button loadbtn;
        private ListBox methodListBox;
        private RichTextBox outputTextBox;
        private TableLayoutPanel tableLayoutPanel3;
        private Button executeMethod;
        private TableLayoutPanel tableLayoutPanel4;
        private NumericUpDown numericInput;
        private TextBox textInput;
        private Button createObj;
    }
}