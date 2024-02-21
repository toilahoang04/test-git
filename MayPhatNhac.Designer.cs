namespace Songs
{
    partial class MayPhatNhac
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
            pbx_imageSong = new PictureBox();
            btn_startAndPause = new Button();
            gv_listNhac = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pbx_imageSong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gv_listNhac).BeginInit();
            SuspendLayout();
            // 
            // pbx_imageSong
            // 
            pbx_imageSong.Location = new Point(81, 50);
            pbx_imageSong.Name = "pbx_imageSong";
            pbx_imageSong.Size = new Size(260, 213);
            pbx_imageSong.TabIndex = 0;
            pbx_imageSong.TabStop = false;
            // 
            // btn_startAndPause
            // 
            btn_startAndPause.Location = new Point(81, 354);
            btn_startAndPause.Name = "btn_startAndPause";
            btn_startAndPause.Size = new Size(136, 55);
            btn_startAndPause.TabIndex = 1;
            btn_startAndPause.Text = "Start";
            btn_startAndPause.UseVisualStyleBackColor = true;
            btn_startAndPause.Click += btn_startAndPause_Click;
            // 
            // gv_listNhac
            // 
            gv_listNhac.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gv_listNhac.Location = new Point(445, 50);
            gv_listNhac.Name = "gv_listNhac";
            gv_listNhac.RowHeadersWidth = 51;
            gv_listNhac.RowTemplate.Height = 29;
            gv_listNhac.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gv_listNhac.Size = new Size(300, 359);
            gv_listNhac.TabIndex = 2;
            gv_listNhac.CellContentClick += gv_listNhac_CellContentClick;
            // 
            // MayPhatNhac
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gv_listNhac);
            Controls.Add(btn_startAndPause);
            Controls.Add(pbx_imageSong);
            Name = "MayPhatNhac";
            Text = "MayPhatNhac";
            Load += MayPhatNhac_Load;
            ((System.ComponentModel.ISupportInitialize)pbx_imageSong).EndInit();
            ((System.ComponentModel.ISupportInitialize)gv_listNhac).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbx_imageSong;
        private Button btn_startAndPause;
        private DataGridView gv_listNhac;
    }
}