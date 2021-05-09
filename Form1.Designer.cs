namespace MusicDiskMaker
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
			this.dsLibrary = new System.Data.DataSet();
			this.table1 = new System.Data.DataTable();
			this.dc1 = new System.Data.DataColumn();
			this.dc2 = new System.Data.DataColumn();
			this.table2 = new System.Data.DataTable();
			this.dataColumn1 = new System.Data.DataColumn();
			this.dataColumn2 = new System.Data.DataColumn();
			this.dataTable1 = new System.Data.DataTable();
			this.dataColumn3 = new System.Data.DataColumn();
			this.dataColumn4 = new System.Data.DataColumn();
			this.dataColumn5 = new System.Data.DataColumn();
			this.dataColumn6 = new System.Data.DataColumn();
			this.dataColumn7 = new System.Data.DataColumn();
			this.dataColumn8 = new System.Data.DataColumn();
			this.dataColumn9 = new System.Data.DataColumn();
			this.dataColumn10 = new System.Data.DataColumn();
			this.dataColumn11 = new System.Data.DataColumn();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.txtTrackList = new System.Windows.Forms.TextBox();
			this.dataColumn12 = new System.Data.DataColumn();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dsLibrary)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
			this.SuspendLayout();
// 
// dsLibrary
// 
			this.dsLibrary.DataSetName = "MusicLibrary";
			this.dsLibrary.Locale = new System.Globalization.CultureInfo("en-US");
			this.dsLibrary.Relations.AddRange(new System.Data.DataRelation[] {
            new System.Data.DataRelation("ArtistsAlbums", "Artists", "Albums", new string[] {
                        "ArtistID"}, new string[] {
                        "ArtistID"}, false),
            new System.Data.DataRelation("AlbumsTracks", "Albums", "Tracks", new string[] {
                        "AlbumID"}, new string[] {
                        "AlbumID"}, false)});
			this.dsLibrary.RemotingFormat = System.Data.SerializationFormat.Xml;
			this.dsLibrary.Tables.AddRange(new System.Data.DataTable[] {
            this.table1,
            this.table2,
            this.dataTable1});
// 
// table1
// 
			this.table1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dc1,
            this.dc2});
			this.table1.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.UniqueConstraint("Constraint1", new string[] {
                        "ArtistID"}, false)});
			this.table1.Locale = new System.Globalization.CultureInfo("en-US");
			this.table1.RemotingFormat = System.Data.SerializationFormat.Xml;
			this.table1.TableName = "Artists";
// 
// dc1
// 
			this.dc1.ColumnName = "ArtistName";
// 
// dc2
// 
			this.dc2.AutoIncrement = true;
			this.dc2.ColumnName = "ArtistID";
			this.dc2.DataType = typeof(int);
// 
// table2
// 
			this.table2.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn11});
			this.table2.Locale = new System.Globalization.CultureInfo("en-US");
			this.table2.RemotingFormat = System.Data.SerializationFormat.Xml;
			this.table2.TableName = "Albums";
// 
// dataColumn1
// 
			this.dataColumn1.ColumnName = "AlbumName";
// 
// dataColumn2
// 
			this.dataColumn2.AutoIncrement = true;
			this.dataColumn2.ColumnName = "AlbumID";
			this.dataColumn2.DataType = typeof(int);
// 
// dataTable1
// 
			this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn12});
			this.dataTable1.Constraints.AddRange(new System.Data.Constraint[] {
            new System.Data.ForeignKeyConstraint("AlbumsTracks", "Albums", new string[] {
                        "AlbumID"}, new string[] {
                        "AlbumID"}, System.Data.AcceptRejectRule.None, System.Data.Rule.Cascade, System.Data.Rule.Cascade),
});
			this.dataTable1.Locale = new System.Globalization.CultureInfo("en-US");
			this.dataTable1.PrimaryKey = new System.Data.DataColumn[] {
        this.dataColumn8,
        this.dataColumn12};
			this.dataTable1.RemotingFormat = System.Data.SerializationFormat.Xml;
			this.dataTable1.TableName = "Tracks";
// 
// dataColumn3
// 
			this.dataColumn3.ColumnName = "TrackName";
// 
// dataColumn4
// 
			this.dataColumn4.ColumnName = "Artist";
// 
// dataColumn5
// 
			this.dataColumn5.ColumnName = "FileName";
// 
// dataColumn6
// 
			this.dataColumn6.ColumnName = "Length";
// 
// dataColumn7
// 
			this.dataColumn7.ColumnName = "FileSize";
			this.dataColumn7.DataType = typeof(long);
// 
// dataColumn8
// 
			this.dataColumn8.ColumnName = "Sequence";
			this.dataColumn8.DataType = typeof(int);
// 
// dataColumn9
// 
			this.dataColumn9.ColumnName = "DiskID";
// 
// dataColumn10
// 
			this.dataColumn10.ColumnName = "AlbumID";
			this.dataColumn10.DataType = typeof(int);
// 
// dataColumn11
// 
			this.dataColumn11.ColumnName = "ArtistID";
			this.dataColumn11.DataType = typeof(int);
// 
// textBox1
// 
			this.textBox1.Location = new System.Drawing.Point(146, 93);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(302, 20);
			this.textBox1.TabIndex = 1;
			this.textBox1.Text = "M:\\";
// 
// txtTrackList
// 
			this.txtTrackList.AutoSize = false;
			this.txtTrackList.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.txtTrackList.Location = new System.Drawing.Point(0, 198);
			this.txtTrackList.MaxLength = 0;
			this.txtTrackList.Multiline = true;
			this.txtTrackList.Name = "txtTrackList";
			this.txtTrackList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtTrackList.Size = new System.Drawing.Size(635, 198);
			this.txtTrackList.TabIndex = 2;
// 
// dataColumn12
// 
			this.dataColumn12.AutoIncrement = true;
			this.dataColumn12.ColumnName = "TrackID";
			this.dataColumn12.DataType = typeof(int);
// 
// button2
// 
			this.button2.Location = new System.Drawing.Point(373, 13);
			this.button2.Name = "button2";
			this.button2.TabIndex = 3;
			this.button2.Text = "button2";
			this.button2.Click += new System.EventHandler(this.button2_Click);
// 
// textBox2
// 
			this.textBox2.Location = new System.Drawing.Point(146, 125);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(302, 20);
			this.textBox2.TabIndex = 4;
			this.textBox2.Text = "L:\\Car\\";
// 
// label1
// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 128);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 14);
			this.label1.TabIndex = 5;
			this.label1.Text = "Root Destination Folder:";
// 
// label2
// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 14);
			this.label2.TabIndex = 6;
			this.label2.Text = "Root Source Folder:";
// 
// Form1
// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(635, 396);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.txtTrackList);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dsLibrary)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Data.DataSet dsLibrary;
		private System.Data.DataTable table1;
		private System.Data.DataColumn dc1;
		private System.Data.DataColumn dc2;
		private System.Data.DataTable table2;
		private System.Data.DataColumn dataColumn1;
		private System.Data.DataColumn dataColumn2;
		private System.Data.DataTable dataTable1;
		private System.Data.DataColumn dataColumn3;
		private System.Data.DataColumn dataColumn4;
		private System.Data.DataColumn dataColumn5;
		private System.Data.DataColumn dataColumn6;
		private System.Data.DataColumn dataColumn7;
		private System.Data.DataColumn dataColumn11;
		private System.Data.DataColumn dataColumn8;
		private System.Data.DataColumn dataColumn9;
		private System.Data.DataColumn dataColumn10;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox txtTrackList;
		private System.Data.DataColumn dataColumn12;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

