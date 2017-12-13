namespace JasonMellingerAssignment05
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.citiesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.citiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.citiesDataSet = new JasonMellingerAssignment05.CitiesDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.citiesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.citiesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lowestPop = new System.Windows.Forms.Button();
            this.lowestText = new System.Windows.Forms.TextBox();
            this.highestText = new System.Windows.Forms.TextBox();
            this.highestPop = new System.Windows.Forms.Button();
            this.avgText = new System.Windows.Forms.TextBox();
            this.avgPop = new System.Windows.Forms.Button();
            this.totalText = new System.Windows.Forms.TextBox();
            this.totalPop = new System.Windows.Forms.Button();
            this.citiesTableAdapter = new JasonMellingerAssignment05.CitiesDataSetTableAdapters.CitiesTableAdapter();
            this.tableAdapterManager = new JasonMellingerAssignment05.CitiesDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingNavigator)).BeginInit();
            this.citiesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // citiesBindingNavigator
            // 
            this.citiesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.citiesBindingNavigator.BindingSource = this.citiesBindingSource;
            this.citiesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.citiesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.citiesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.citiesBindingNavigatorSaveItem});
            this.citiesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.citiesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.citiesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.citiesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.citiesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.citiesBindingNavigator.Name = "citiesBindingNavigator";
            this.citiesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.citiesBindingNavigator.Size = new System.Drawing.Size(788, 25);
            this.citiesBindingNavigator.TabIndex = 0;
            this.citiesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // citiesBindingSource
            // 
            this.citiesBindingSource.DataMember = "Cities";
            this.citiesBindingSource.DataSource = this.citiesDataSet;
            // 
            // citiesDataSet
            // 
            this.citiesDataSet.DataSetName = "CitiesDataSet";
            this.citiesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // citiesBindingNavigatorSaveItem
            // 
            this.citiesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.citiesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("citiesBindingNavigatorSaveItem.Image")));
            this.citiesBindingNavigatorSaveItem.Name = "citiesBindingNavigatorSaveItem";
            this.citiesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.citiesBindingNavigatorSaveItem.Text = "Save Data";
            this.citiesBindingNavigatorSaveItem.Click += new System.EventHandler(this.citiesBindingNavigatorSaveItem_Click);
            // 
            // citiesDataGridView
            // 
            this.citiesDataGridView.AutoGenerateColumns = false;
            this.citiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.citiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.citiesDataGridView.DataSource = this.citiesBindingSource;
            this.citiesDataGridView.Location = new System.Drawing.Point(12, 28);
            this.citiesDataGridView.Name = "citiesDataGridView";
            this.citiesDataGridView.Size = new System.Drawing.Size(256, 220);
            this.citiesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CityName";
            this.dataGridViewTextBoxColumn1.HeaderText = "CityName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Population";
            this.dataGridViewTextBoxColumn2.HeaderText = "Population";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "To sort cities by population or name click on the \r\nheader of the respective colu" +
    "mn, click again to sort \r\nthe other direction.";
            // 
            // lowestPop
            // 
            this.lowestPop.Location = new System.Drawing.Point(296, 213);
            this.lowestPop.Name = "lowestPop";
            this.lowestPop.Size = new System.Drawing.Size(75, 35);
            this.lowestPop.TabIndex = 5;
            this.lowestPop.Text = "Lowest Population";
            this.lowestPop.UseVisualStyleBackColor = true;
            this.lowestPop.Click += new System.EventHandler(this.lowestPop_Click);
            // 
            // lowestText
            // 
            this.lowestText.Location = new System.Drawing.Point(406, 221);
            this.lowestText.Name = "lowestText";
            this.lowestText.ReadOnly = true;
            this.lowestText.Size = new System.Drawing.Size(100, 20);
            this.lowestText.TabIndex = 9;
            // 
            // highestText
            // 
            this.highestText.Location = new System.Drawing.Point(406, 159);
            this.highestText.Name = "highestText";
            this.highestText.ReadOnly = true;
            this.highestText.Size = new System.Drawing.Size(100, 20);
            this.highestText.TabIndex = 8;
            // 
            // highestPop
            // 
            this.highestPop.Location = new System.Drawing.Point(296, 151);
            this.highestPop.Name = "highestPop";
            this.highestPop.Size = new System.Drawing.Size(75, 35);
            this.highestPop.TabIndex = 4;
            this.highestPop.Text = "Highest Population";
            this.highestPop.UseVisualStyleBackColor = true;
            this.highestPop.Click += new System.EventHandler(this.highestPop_Click);
            // 
            // avgText
            // 
            this.avgText.Location = new System.Drawing.Point(406, 95);
            this.avgText.Name = "avgText";
            this.avgText.ReadOnly = true;
            this.avgText.Size = new System.Drawing.Size(100, 20);
            this.avgText.TabIndex = 7;
            // 
            // avgPop
            // 
            this.avgPop.Location = new System.Drawing.Point(296, 87);
            this.avgPop.Name = "avgPop";
            this.avgPop.Size = new System.Drawing.Size(75, 35);
            this.avgPop.TabIndex = 3;
            this.avgPop.Text = "Average Population";
            this.avgPop.UseVisualStyleBackColor = true;
            this.avgPop.Click += new System.EventHandler(this.avgPop_Click);
            // 
            // totalText
            // 
            this.totalText.Location = new System.Drawing.Point(406, 36);
            this.totalText.Name = "totalText";
            this.totalText.ReadOnly = true;
            this.totalText.Size = new System.Drawing.Size(100, 20);
            this.totalText.TabIndex = 6;
            // 
            // totalPop
            // 
            this.totalPop.Location = new System.Drawing.Point(296, 28);
            this.totalPop.Name = "totalPop";
            this.totalPop.Size = new System.Drawing.Size(75, 35);
            this.totalPop.TabIndex = 2;
            this.totalPop.Text = "Total Population";
            this.totalPop.UseVisualStyleBackColor = true;
            this.totalPop.Click += new System.EventHandler(this.totalPop_Click);
            // 
            // citiesTableAdapter
            // 
            this.citiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CitiesTableAdapter = this.citiesTableAdapter;
            this.tableAdapterManager.UpdateOrder = JasonMellingerAssignment05.CitiesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Clear Population Calculations";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(562, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 81);
            this.button2.TabIndex = 12;
            this.button2.Text = "Who\'s A Faggot";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(667, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 356);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lowestText);
            this.Controls.Add(this.highestText);
            this.Controls.Add(this.avgText);
            this.Controls.Add(this.totalText);
            this.Controls.Add(this.lowestPop);
            this.Controls.Add(this.highestPop);
            this.Controls.Add(this.avgPop);
            this.Controls.Add(this.totalPop);
            this.Controls.Add(this.citiesDataGridView);
            this.Controls.Add(this.citiesBindingNavigator);
            this.Name = "Form1";
            this.Text = "City Population";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingNavigator)).EndInit();
            this.citiesBindingNavigator.ResumeLayout(false);
            this.citiesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.citiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.citiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CitiesDataSet citiesDataSet;
        private System.Windows.Forms.BindingSource citiesBindingSource;
        private CitiesDataSetTableAdapters.CitiesTableAdapter citiesTableAdapter;
        private CitiesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator citiesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton citiesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView citiesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lowestPop;
        private System.Windows.Forms.TextBox lowestText;
        private System.Windows.Forms.TextBox highestText;
        private System.Windows.Forms.Button highestPop;
        private System.Windows.Forms.TextBox avgText;
        private System.Windows.Forms.Button avgPop;
        private System.Windows.Forms.TextBox totalText;
        private System.Windows.Forms.Button totalPop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

