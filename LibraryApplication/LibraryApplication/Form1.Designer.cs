namespace LibraryApplication
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magazinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMagazinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMagazineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchMagazineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musicItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMusicItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMusicItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchMusicItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showVideoItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVideoItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchVideoItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.booksToolStripMenuItem,
            this.magazinesToolStripMenuItem,
            this.musicItemsToolStripMenuItem,
            this.videoItemsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.showAllItemsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // showAllItemsToolStripMenuItem
            // 
            this.showAllItemsToolStripMenuItem.Name = "showAllItemsToolStripMenuItem";
            this.showAllItemsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showAllItemsToolStripMenuItem.Text = "Show All Items";
            this.showAllItemsToolStripMenuItem.Click += new System.EventHandler(this.showAllItemsToolStripMenuItem_Click);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllBooksToolStripMenuItem,
            this.addBookToolStripMenuItem,
            this.searchBookToolStripMenuItem});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // showAllBooksToolStripMenuItem
            // 
            this.showAllBooksToolStripMenuItem.Name = "showAllBooksToolStripMenuItem";
            this.showAllBooksToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.showAllBooksToolStripMenuItem.Text = "Show Books";
            this.showAllBooksToolStripMenuItem.Click += new System.EventHandler(this.showAllBooksToolStripMenuItem_Click);
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.addBookToolStripMenuItem.Text = "Add Book";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // searchBookToolStripMenuItem
            // 
            this.searchBookToolStripMenuItem.Name = "searchBookToolStripMenuItem";
            this.searchBookToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.searchBookToolStripMenuItem.Text = "Search Book";
            this.searchBookToolStripMenuItem.Click += new System.EventHandler(this.searchBookToolStripMenuItem_Click);
            // 
            // magazinesToolStripMenuItem
            // 
            this.magazinesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMagazinesToolStripMenuItem,
            this.addMagazineToolStripMenuItem,
            this.searchMagazineToolStripMenuItem});
            this.magazinesToolStripMenuItem.Name = "magazinesToolStripMenuItem";
            this.magazinesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.magazinesToolStripMenuItem.Text = "Magazines";
            // 
            // showMagazinesToolStripMenuItem
            // 
            this.showMagazinesToolStripMenuItem.Name = "showMagazinesToolStripMenuItem";
            this.showMagazinesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.showMagazinesToolStripMenuItem.Text = "Show Magazines";
            this.showMagazinesToolStripMenuItem.Click += new System.EventHandler(this.showMagazinesToolStripMenuItem_Click);
            // 
            // addMagazineToolStripMenuItem
            // 
            this.addMagazineToolStripMenuItem.Name = "addMagazineToolStripMenuItem";
            this.addMagazineToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.addMagazineToolStripMenuItem.Text = "Add Magazine";
            this.addMagazineToolStripMenuItem.Click += new System.EventHandler(this.addMagazineToolStripMenuItem_Click);
            // 
            // searchMagazineToolStripMenuItem
            // 
            this.searchMagazineToolStripMenuItem.Name = "searchMagazineToolStripMenuItem";
            this.searchMagazineToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.searchMagazineToolStripMenuItem.Text = "Search Magazine";
            this.searchMagazineToolStripMenuItem.Click += new System.EventHandler(this.searchMagazineToolStripMenuItem_Click);
            // 
            // musicItemsToolStripMenuItem
            // 
            this.musicItemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMusicItemsToolStripMenuItem,
            this.addMusicItemToolStripMenuItem,
            this.searchMusicItemToolStripMenuItem});
            this.musicItemsToolStripMenuItem.Name = "musicItemsToolStripMenuItem";
            this.musicItemsToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.musicItemsToolStripMenuItem.Text = "Music Items";
            // 
            // showMusicItemsToolStripMenuItem
            // 
            this.showMusicItemsToolStripMenuItem.Name = "showMusicItemsToolStripMenuItem";
            this.showMusicItemsToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.showMusicItemsToolStripMenuItem.Text = "Show Music Items";
            this.showMusicItemsToolStripMenuItem.Click += new System.EventHandler(this.showMusicItemsToolStripMenuItem_Click);
            // 
            // addMusicItemToolStripMenuItem
            // 
            this.addMusicItemToolStripMenuItem.Name = "addMusicItemToolStripMenuItem";
            this.addMusicItemToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.addMusicItemToolStripMenuItem.Text = "Add Music Item";
            this.addMusicItemToolStripMenuItem.Click += new System.EventHandler(this.addMusicItemToolStripMenuItem_Click);
            // 
            // searchMusicItemToolStripMenuItem
            // 
            this.searchMusicItemToolStripMenuItem.Name = "searchMusicItemToolStripMenuItem";
            this.searchMusicItemToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.searchMusicItemToolStripMenuItem.Text = "Search Music Item";
            this.searchMusicItemToolStripMenuItem.Click += new System.EventHandler(this.searchMusicItemToolStripMenuItem_Click);
            // 
            // videoItemsToolStripMenuItem
            // 
            this.videoItemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showVideoItemsToolStripMenuItem,
            this.addVideoItemToolStripMenuItem,
            this.searchVideoItemToolStripMenuItem});
            this.videoItemsToolStripMenuItem.Name = "videoItemsToolStripMenuItem";
            this.videoItemsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.videoItemsToolStripMenuItem.Text = "Video Items";
            // 
            // showVideoItemsToolStripMenuItem
            // 
            this.showVideoItemsToolStripMenuItem.Name = "showVideoItemsToolStripMenuItem";
            this.showVideoItemsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.showVideoItemsToolStripMenuItem.Text = "Show Video Items";
            this.showVideoItemsToolStripMenuItem.Click += new System.EventHandler(this.showVideoItemsToolStripMenuItem_Click);
            // 
            // addVideoItemToolStripMenuItem
            // 
            this.addVideoItemToolStripMenuItem.Name = "addVideoItemToolStripMenuItem";
            this.addVideoItemToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.addVideoItemToolStripMenuItem.Text = "Add Video Item";
            this.addVideoItemToolStripMenuItem.Click += new System.EventHandler(this.addVideoItemToolStripMenuItem_Click);
            // 
            // searchVideoItemToolStripMenuItem
            // 
            this.searchVideoItemToolStripMenuItem.Name = "searchVideoItemToolStripMenuItem";
            this.searchVideoItemToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.searchVideoItemToolStripMenuItem.Text = "Search Video Item";
            this.searchVideoItemToolStripMenuItem.Click += new System.EventHandler(this.searchVideoItemToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 650);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Library";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magazinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musicItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMagazinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMagazineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchMagazineToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMusicItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMusicItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchMusicItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showVideoItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVideoItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchVideoItemToolStripMenuItem;
    }
}

