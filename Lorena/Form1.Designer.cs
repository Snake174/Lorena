namespace Lorena
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
    protected override void Dispose( bool disposing )
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose( disposing );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      this.salonTree = new System.Windows.Forms.TreeView();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.dep = new System.Windows.Forms.Label();
      this.discount = new System.Windows.Forms.Label();
      this.name = new System.Windows.Forms.Label();
      this.description = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.button1 = new System.Windows.Forms.Button();
      this.price = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // salonTree
      // 
      this.salonTree.Location = new System.Drawing.Point( 12, 12 );
      this.salonTree.Name = "salonTree";
      this.salonTree.Size = new System.Drawing.Size( 275, 223 );
      this.salonTree.TabIndex = 0;
      this.salonTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler( this.salonTree_AfterSelect );
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add( this.dep );
      this.groupBox1.Controls.Add( this.discount );
      this.groupBox1.Controls.Add( this.name );
      this.groupBox1.Controls.Add( this.description );
      this.groupBox1.Controls.Add( this.label4 );
      this.groupBox1.Controls.Add( this.label3 );
      this.groupBox1.Controls.Add( this.label2 );
      this.groupBox1.Controls.Add( this.label1 );
      this.groupBox1.Location = new System.Drawing.Point( 293, 12 );
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size( 338, 223 );
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Информация";
      // 
      // dep
      // 
      this.dep.AutoSize = true;
      this.dep.Location = new System.Drawing.Point( 108, 85 );
      this.dep.Name = "dep";
      this.dep.Size = new System.Drawing.Size( 0, 13 );
      this.dep.TabIndex = 7;
      // 
      // discount
      // 
      this.discount.AutoSize = true;
      this.discount.Location = new System.Drawing.Point( 108, 56 );
      this.discount.Name = "discount";
      this.discount.Size = new System.Drawing.Size( 0, 13 );
      this.discount.TabIndex = 6;
      // 
      // name
      // 
      this.name.AutoSize = true;
      this.name.Location = new System.Drawing.Point( 108, 27 );
      this.name.Name = "name";
      this.name.Size = new System.Drawing.Size( 0, 13 );
      this.name.TabIndex = 5;
      // 
      // description
      // 
      this.description.Location = new System.Drawing.Point( 9, 128 );
      this.description.Multiline = true;
      this.description.Name = "description";
      this.description.ReadOnly = true;
      this.description.Size = new System.Drawing.Size( 323, 89 );
      this.description.TabIndex = 4;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)) );
      this.label4.Location = new System.Drawing.Point( 6, 112 );
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size( 65, 13 );
      this.label4.TabIndex = 3;
      this.label4.Text = "Описание";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)) );
      this.label3.Location = new System.Drawing.Point( 6, 85 );
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size( 86, 13 );
      this.label3.TabIndex = 2;
      this.label3.Text = "Зависимость";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)) );
      this.label2.Location = new System.Drawing.Point( 6, 56 );
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size( 50, 13 );
      this.label2.TabIndex = 1;
      this.label2.Text = "Скидка";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)) );
      this.label1.Location = new System.Drawing.Point( 6, 27 );
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size( 65, 13 );
      this.label1.TabIndex = 0;
      this.label1.Text = "Название";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add( this.dataGridView1 );
      this.groupBox2.Controls.Add( this.button1 );
      this.groupBox2.Controls.Add( this.price );
      this.groupBox2.Controls.Add( this.label5 );
      this.groupBox2.Location = new System.Drawing.Point( 12, 241 );
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size( 619, 245 );
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Расчёт стоимости";
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AllowUserToOrderColumns = true;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)) );
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridView1.Columns.AddRange( new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3} );
      this.dataGridView1.Location = new System.Drawing.Point( 9, 52 );
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      this.dataGridView1.ShowEditingIcon = false;
      this.dataGridView1.Size = new System.Drawing.Size( 604, 187 );
      this.dataGridView1.TabIndex = 3;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point( 538, 23 );
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size( 75, 23 );
      this.button1.TabIndex = 2;
      this.button1.Text = "Расчитать";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler( this.button1_Click );
      // 
      // price
      // 
      this.price.Location = new System.Drawing.Point( 49, 23 );
      this.price.Name = "price";
      this.price.Size = new System.Drawing.Size( 483, 20 );
      this.price.TabIndex = 1;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font( "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)) );
      this.label5.Location = new System.Drawing.Point( 6, 26 );
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size( 37, 13 );
      this.label5.TabIndex = 0;
      this.label5.Text = "Цена";
      // 
      // Column1
      // 
      this.Column1.HeaderText = "Выбор";
      this.Column1.Name = "Column1";
      this.Column1.ReadOnly = true;
      // 
      // Column2
      // 
      this.Column2.HeaderText = "Цена";
      this.Column2.Name = "Column2";
      this.Column2.ReadOnly = true;
      // 
      // Column3
      // 
      this.Column3.HeaderText = "Результат";
      this.Column3.Name = "Column3";
      this.Column3.ReadOnly = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size( 639, 498 );
      this.Controls.Add( this.groupBox2 );
      this.Controls.Add( this.groupBox1 );
      this.Controls.Add( this.salonTree );
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Lorena";
      this.Load += new System.EventHandler( this.Form1_Load );
      this.groupBox1.ResumeLayout( false );
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout( false );
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout( false );

    }

    #endregion

    private System.Windows.Forms.TreeView salonTree;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox description;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label dep;
    private System.Windows.Forms.Label discount;
    private System.Windows.Forms.Label name;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox price;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
  }
}

