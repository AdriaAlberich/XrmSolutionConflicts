namespace XrmSolutionConflicts
{
    partial class SolutionConflictsControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolutionConflictsControl));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbLoadSolutions = new System.Windows.Forms.ToolStripButton();
            this.tssSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.cmbSolutions = new System.Windows.Forms.ComboBox();
            this.lblSolution = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grdConflicts = new System.Windows.Forms.DataGridView();
            this.componentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.componentType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conflictSolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConflicts)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLoadSolutions,
            this.tssSeparator1,
            this.tsbClose});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(820, 25);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbLoadSolutions
            // 
            this.tsbLoadSolutions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbLoadSolutions.Name = "tsbLoadSolutions";
            this.tsbLoadSolutions.Size = new System.Drawing.Size(89, 22);
            this.tsbLoadSolutions.Text = "Load Solutions";
            this.tsbLoadSolutions.Click += new System.EventHandler(this.tsbLoadSolutions_Click);
            // 
            // tssSeparator1
            // 
            this.tssSeparator1.Name = "tssSeparator1";
            this.tssSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(40, 22);
            this.tsbClose.Text = "Close";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // cmbSolutions
            // 
            this.cmbSolutions.FormattingEnabled = true;
            this.cmbSolutions.Location = new System.Drawing.Point(6, 39);
            this.cmbSolutions.Name = "cmbSolutions";
            this.cmbSolutions.Size = new System.Drawing.Size(358, 21);
            this.cmbSolutions.TabIndex = 7;
            // 
            // lblSolution
            // 
            this.lblSolution.AutoSize = true;
            this.lblSolution.Location = new System.Drawing.Point(3, 25);
            this.lblSolution.Name = "lblSolution";
            this.lblSolution.Size = new System.Drawing.Size(85, 13);
            this.lblSolution.TabIndex = 8;
            this.lblSolution.Text = "Select a solution";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(370, 38);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(107, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search for conflicts";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // grdConflicts
            // 
            this.grdConflicts.AllowUserToAddRows = false;
            this.grdConflicts.AllowUserToDeleteRows = false;
            this.grdConflicts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConflicts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.componentName,
            this.componentType,
            this.conflictSolution});
            this.grdConflicts.Location = new System.Drawing.Point(6, 66);
            this.grdConflicts.Name = "grdConflicts";
            this.grdConflicts.ReadOnly = true;
            this.grdConflicts.Size = new System.Drawing.Size(811, 479);
            this.grdConflicts.TabIndex = 10;
            // 
            // componentName
            // 
            this.componentName.HeaderText = "Component";
            this.componentName.Name = "componentName";
            this.componentName.ReadOnly = true;
            this.componentName.Width = 400;
            // 
            // componentType
            // 
            this.componentType.HeaderText = "Component Type";
            this.componentType.Name = "componentType";
            this.componentType.ReadOnly = true;
            this.componentType.Width = 150;
            // 
            // conflictSolution
            // 
            this.conflictSolution.HeaderText = "Conflict Solution";
            this.conflictSolution.Name = "conflictSolution";
            this.conflictSolution.ReadOnly = true;
            this.conflictSolution.Width = 150;
            // 
            // SolutionConflictsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdConflicts);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSolution);
            this.Controls.Add(this.cmbSolutions);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "SolutionConflictsControl";
            this.PluginIcon = ((System.Drawing.Icon)(resources.GetObject("$this.PluginIcon")));
            this.Size = new System.Drawing.Size(820, 548);
            this.TabIcon = global::SolutionConflicts.Properties.Resources.iconsmall;
            this.OnCloseTool += new System.EventHandler(this.SolutionConflicts_OnCloseTool);
            this.Load += new System.EventHandler(this.SolutionConflicts_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConflicts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripButton tsbLoadSolutions;
        private System.Windows.Forms.ToolStripSeparator tssSeparator1;
        private System.Windows.Forms.ComboBox cmbSolutions;
        private System.Windows.Forms.Label lblSolution;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView grdConflicts;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn componentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn conflictSolution;
    }
}
