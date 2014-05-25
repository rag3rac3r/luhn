namespace Luhn
{
    partial class LuhnFrm
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
            this.tabLuhn = new System.Windows.Forms.TabControl();
            this.tabLuhnVal = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.lblValRes = new System.Windows.Forms.Label();
            this.tabLuhnGen = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.boxBase = new System.Windows.Forms.TextBox();
            this.boxResult = new System.Windows.Forms.TextBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.tabLuhn.SuspendLayout();
            this.tabLuhnVal.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabLuhnGen.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabLuhn
            // 
            this.tabLuhn.Controls.Add(this.tabLuhnVal);
            this.tabLuhn.Controls.Add(this.tabLuhnGen);
            this.tabLuhn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabLuhn.Location = new System.Drawing.Point(0, 0);
            this.tabLuhn.Name = "tabLuhn";
            this.tabLuhn.SelectedIndex = 0;
            this.tabLuhn.Size = new System.Drawing.Size(354, 175);
            this.tabLuhn.TabIndex = 0;
            // 
            // tabLuhnVal
            // 
            this.tabLuhnVal.Controls.Add(this.tableLayoutPanel1);
            this.tabLuhnVal.Location = new System.Drawing.Point(4, 22);
            this.tabLuhnVal.Name = "tabLuhnVal";
            this.tabLuhnVal.Padding = new System.Windows.Forms.Padding(3);
            this.tabLuhnVal.Size = new System.Drawing.Size(346, 149);
            this.tabLuhnVal.TabIndex = 0;
            this.tabLuhnVal.Text = "Validate";
            this.tabLuhnVal.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtVal, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblValRes, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(332, 125);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(128, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Validate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtVal
            // 
            this.txtVal.AcceptsReturn = true;
            this.txtVal.Location = new System.Drawing.Point(3, 3);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(326, 20);
            this.txtVal.TabIndex = 0;
            // 
            // lblValRes
            // 
            this.lblValRes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblValRes.Location = new System.Drawing.Point(3, 50);
            this.lblValRes.Name = "lblValRes";
            this.lblValRes.Size = new System.Drawing.Size(326, 23);
            this.lblValRes.TabIndex = 2;
            this.lblValRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabLuhnGen
            // 
            this.tabLuhnGen.Controls.Add(this.tableLayoutPanel2);
            this.tabLuhnGen.Location = new System.Drawing.Point(4, 22);
            this.tabLuhnGen.Name = "tabLuhnGen";
            this.tabLuhnGen.Padding = new System.Windows.Forms.Padding(3);
            this.tabLuhnGen.Size = new System.Drawing.Size(346, 149);
            this.tabLuhnGen.TabIndex = 1;
            this.tabLuhnGen.Text = "Generate";
            this.tabLuhnGen.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.boxBase, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.boxResult, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnGen, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(332, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // boxBase
            // 
            this.boxBase.Location = new System.Drawing.Point(3, 3);
            this.boxBase.Name = "boxBase";
            this.boxBase.Size = new System.Drawing.Size(326, 20);
            this.boxBase.TabIndex = 0;
            this.boxBase.Enter += new System.EventHandler(this.btnGen_Click);
            // 
            // boxResult
            // 
            this.boxResult.Location = new System.Drawing.Point(3, 36);
            this.boxResult.Name = "boxResult";
            this.boxResult.Size = new System.Drawing.Size(326, 20);
            this.boxResult.TabIndex = 1;
            // 
            // btnGen
            // 
            this.btnGen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnGen.Location = new System.Drawing.Point(128, 69);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 2;
            this.btnGen.Text = "Generate";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // LuhnFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 175);
            this.Controls.Add(this.tabLuhn);
            this.Name = "LuhnFrm";
            this.Text = "Luhn";
            this.tabLuhn.ResumeLayout(false);
            this.tabLuhnVal.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabLuhnGen.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabLuhn;
        private System.Windows.Forms.TabPage tabLuhnVal;
        private System.Windows.Forms.TabPage tabLuhnGen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblValRes;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox boxBase;
        private System.Windows.Forms.TextBox boxResult;
        private System.Windows.Forms.Button btnGen;
    }
}

