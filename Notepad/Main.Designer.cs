namespace Notepad
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.mnsMain = new System.Windows.Forms.MenuStrip();
            this.mnsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsLineBreak = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsFont = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsAbout = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.mnsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fontDialog1
            // 
            this.fontDialog1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.txtMain);
            this.pnlMain.Controls.Add(this.mnsMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(807, 664);
            this.pnlMain.TabIndex = 2;
            // 
            // txtMain
            // 
            this.txtMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMain.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMain.Location = new System.Drawing.Point(0, 30);
            this.txtMain.Multiline = true;
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(807, 634);
            this.txtMain.TabIndex = 0;
            // 
            // mnsMain
            // 
            this.mnsMain.Font = new System.Drawing.Font("Consolas", 11F);
            this.mnsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsFile,
            this.mnsEdit,
            this.mnsFormat,
            this.mnsHelp});
            this.mnsMain.Location = new System.Drawing.Point(0, 0);
            this.mnsMain.Name = "mnsMain";
            this.mnsMain.Size = new System.Drawing.Size(807, 30);
            this.mnsMain.TabIndex = 1;
            this.mnsMain.Text = "menuStrip1";
            // 
            // mnsFile
            // 
            this.mnsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsNew,
            this.mnsOpen,
            this.mnsSave,
            this.mnsSaveAs,
            this.mnsQuit});
            this.mnsFile.Name = "mnsFile";
            this.mnsFile.Size = new System.Drawing.Size(94, 26);
            this.mnsFile.Text = "&Arquivo";
            // 
            // mnsNew
            // 
            this.mnsNew.Name = "mnsNew";
            this.mnsNew.Size = new System.Drawing.Size(224, 26);
            this.mnsNew.Text = "Novo";
            this.mnsNew.Click += new System.EventHandler(this.mnsNew_Click);
            // 
            // mnsOpen
            // 
            this.mnsOpen.Name = "mnsOpen";
            this.mnsOpen.Size = new System.Drawing.Size(224, 26);
            this.mnsOpen.Text = "Abrir";
            this.mnsOpen.Click += new System.EventHandler(this.mnsOpen_Click);
            // 
            // mnsSave
            // 
            this.mnsSave.Name = "mnsSave";
            this.mnsSave.Size = new System.Drawing.Size(224, 26);
            this.mnsSave.Text = "Salvar";
            // 
            // mnsSaveAs
            // 
            this.mnsSaveAs.Name = "mnsSaveAs";
            this.mnsSaveAs.Size = new System.Drawing.Size(224, 26);
            this.mnsSaveAs.Text = "Salvar Como";
            // 
            // mnsQuit
            // 
            this.mnsQuit.Name = "mnsQuit";
            this.mnsQuit.Size = new System.Drawing.Size(224, 26);
            this.mnsQuit.Text = "Sair";
            // 
            // mnsEdit
            // 
            this.mnsEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsUndo,
            this.mnsCut,
            this.mnsCopy,
            this.mnsPaste,
            this.mnsSelectAll});
            this.mnsEdit.Name = "mnsEdit";
            this.mnsEdit.Size = new System.Drawing.Size(84, 26);
            this.mnsEdit.Text = "&Editar";
            // 
            // mnsUndo
            // 
            this.mnsUndo.Name = "mnsUndo";
            this.mnsUndo.Size = new System.Drawing.Size(224, 26);
            this.mnsUndo.Text = "Desfazer";
            // 
            // mnsCut
            // 
            this.mnsCut.Name = "mnsCut";
            this.mnsCut.Size = new System.Drawing.Size(224, 26);
            this.mnsCut.Text = "Recortar";
            // 
            // mnsCopy
            // 
            this.mnsCopy.Name = "mnsCopy";
            this.mnsCopy.Size = new System.Drawing.Size(224, 26);
            this.mnsCopy.Text = "Copiar";
            // 
            // mnsPaste
            // 
            this.mnsPaste.Name = "mnsPaste";
            this.mnsPaste.Size = new System.Drawing.Size(224, 26);
            this.mnsPaste.Text = "Colar";
            // 
            // mnsSelectAll
            // 
            this.mnsSelectAll.Name = "mnsSelectAll";
            this.mnsSelectAll.Size = new System.Drawing.Size(224, 26);
            this.mnsSelectAll.Text = "Selecionar Tudo";
            // 
            // mnsFormat
            // 
            this.mnsFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsLineBreak,
            this.mnsFont});
            this.mnsFormat.Name = "mnsFormat";
            this.mnsFormat.Size = new System.Drawing.Size(104, 26);
            this.mnsFormat.Text = "&Formatar";
            // 
            // mnsLineBreak
            // 
            this.mnsLineBreak.Name = "mnsLineBreak";
            this.mnsLineBreak.Size = new System.Drawing.Size(224, 26);
            this.mnsLineBreak.Text = "Quebra de Linha";
            // 
            // mnsFont
            // 
            this.mnsFont.Name = "mnsFont";
            this.mnsFont.Size = new System.Drawing.Size(224, 26);
            this.mnsFont.Text = "Fonte";
            // 
            // mnsHelp
            // 
            this.mnsHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsAbout});
            this.mnsHelp.Font = new System.Drawing.Font("Consolas", 11F);
            this.mnsHelp.Name = "mnsHelp";
            this.mnsHelp.Size = new System.Drawing.Size(74, 26);
            this.mnsHelp.Text = "Aj&uda";
            // 
            // mnsAbout
            // 
            this.mnsAbout.Name = "mnsAbout";
            this.mnsAbout.Size = new System.Drawing.Size(224, 26);
            this.mnsAbout.Text = "Sobre";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 664);
            this.Controls.Add(this.pnlMain);
            this.Name = "Main";
            this.Text = "NoteMax";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.mnsMain.ResumeLayout(false);
            this.mnsMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.MenuStrip mnsMain;
        private System.Windows.Forms.ToolStripMenuItem mnsFile;
        private System.Windows.Forms.ToolStripMenuItem mnsNew;
        private System.Windows.Forms.ToolStripMenuItem mnsOpen;
        private System.Windows.Forms.ToolStripMenuItem mnsSave;
        private System.Windows.Forms.ToolStripMenuItem mnsSaveAs;
        private System.Windows.Forms.ToolStripMenuItem mnsQuit;
        private System.Windows.Forms.ToolStripMenuItem mnsEdit;
        private System.Windows.Forms.ToolStripMenuItem mnsUndo;
        private System.Windows.Forms.ToolStripMenuItem mnsCut;
        private System.Windows.Forms.ToolStripMenuItem mnsCopy;
        private System.Windows.Forms.ToolStripMenuItem mnsPaste;
        private System.Windows.Forms.ToolStripMenuItem mnsSelectAll;
        private System.Windows.Forms.ToolStripMenuItem mnsFormat;
        private System.Windows.Forms.ToolStripMenuItem mnsLineBreak;
        private System.Windows.Forms.ToolStripMenuItem mnsFont;
        private System.Windows.Forms.ToolStripMenuItem mnsHelp;
        private System.Windows.Forms.ToolStripMenuItem mnsAbout;
    }
}

