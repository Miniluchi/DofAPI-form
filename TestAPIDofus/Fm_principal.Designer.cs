namespace TestAPIDofus
{
    partial class Fm_principal
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_id = new System.Windows.Forms.TextBox();
            this.bt_Valider = new System.Windows.Forms.Button();
            this.cb_Type = new System.Windows.Forms.ComboBox();
            this.tb_Txt = new System.Windows.Forms.TextBox();
            this.lb_1 = new System.Windows.Forms.Label();
            this.lb_2 = new System.Windows.Forms.Label();
            this.lb_4 = new System.Windows.Forms.Label();
            this.lb_3 = new System.Windows.Forms.Label();
            this.lb_5 = new System.Windows.Forms.Label();
            this.wv_img = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.wv_img)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(168, 11);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(175, 22);
            this.tb_id.TabIndex = 1;
            // 
            // bt_Valider
            // 
            this.bt_Valider.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Valider.Location = new System.Drawing.Point(359, 11);
            this.bt_Valider.Name = "bt_Valider";
            this.bt_Valider.Size = new System.Drawing.Size(79, 22);
            this.bt_Valider.TabIndex = 2;
            this.bt_Valider.Text = "Valider";
            this.bt_Valider.UseVisualStyleBackColor = true;
            this.bt_Valider.Click += new System.EventHandler(this.bt_Valider_Click);
            // 
            // cb_Type
            // 
            this.cb_Type.DropDownHeight = 110;
            this.cb_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Type.DropDownWidth = 120;
            this.cb_Type.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Type.FormattingEnabled = true;
            this.cb_Type.IntegralHeight = false;
            this.cb_Type.ItemHeight = 14;
            this.cb_Type.Items.AddRange(new object[] {
            "classes",
            "consumables",
            "equipments",
            "harnesses",
            "havenbags",
            "idols",
            "monsters",
            "mounts",
            "pets",
            "professions",
            "resources",
            "sets",
            "weapons"});
            this.cb_Type.Location = new System.Drawing.Point(12, 10);
            this.cb_Type.Name = "cb_Type";
            this.cb_Type.Size = new System.Drawing.Size(138, 22);
            this.cb_Type.TabIndex = 6;
            this.cb_Type.TabStop = false;
            // 
            // tb_Txt
            // 
            this.tb_Txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Txt.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Txt.Location = new System.Drawing.Point(12, 38);
            this.tb_Txt.Multiline = true;
            this.tb_Txt.Name = "tb_Txt";
            this.tb_Txt.ReadOnly = true;
            this.tb_Txt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_Txt.Size = new System.Drawing.Size(781, 611);
            this.tb_Txt.TabIndex = 3;
            this.tb_Txt.TabStop = false;
            this.tb_Txt.WordWrap = false;
            // 
            // lb_1
            // 
            this.lb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_1.Location = new System.Drawing.Point(799, 326);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(363, 23);
            this.lb_1.TabIndex = 9;
            this.lb_1.Text = "label1";
            // 
            // lb_2
            // 
            this.lb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_2.Location = new System.Drawing.Point(799, 349);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(363, 23);
            this.lb_2.TabIndex = 10;
            this.lb_2.Text = "label2";
            // 
            // lb_4
            // 
            this.lb_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_4.Location = new System.Drawing.Point(799, 395);
            this.lb_4.Name = "lb_4";
            this.lb_4.Size = new System.Drawing.Size(363, 23);
            this.lb_4.TabIndex = 12;
            this.lb_4.Text = "label4";
            // 
            // lb_3
            // 
            this.lb_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_3.Location = new System.Drawing.Point(799, 372);
            this.lb_3.Name = "lb_3";
            this.lb_3.Size = new System.Drawing.Size(363, 23);
            this.lb_3.TabIndex = 11;
            this.lb_3.Text = "label3";
            // 
            // lb_5
            // 
            this.lb_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_5.Location = new System.Drawing.Point(799, 418);
            this.lb_5.Name = "lb_5";
            this.lb_5.Size = new System.Drawing.Size(363, 155);
            this.lb_5.TabIndex = 13;
            this.lb_5.Text = "label5";
            // 
            // wv_img
            // 
            this.wv_img.CreationProperties = null;
            this.wv_img.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wv_img.Location = new System.Drawing.Point(799, 38);
            this.wv_img.Name = "wv_img";
            this.wv_img.Size = new System.Drawing.Size(363, 268);
            this.wv_img.TabIndex = 15;
            this.wv_img.ZoomFactor = 1D;
            // 
            // Fm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 661);
            this.Controls.Add(this.wv_img);
            this.Controls.Add(this.lb_5);
            this.Controls.Add(this.lb_4);
            this.Controls.Add(this.lb_3);
            this.Controls.Add(this.lb_2);
            this.Controls.Add(this.lb_1);
            this.Controls.Add(this.tb_Txt);
            this.Controls.Add(this.cb_Type);
            this.Controls.Add(this.bt_Valider);
            this.Controls.Add(this.tb_id);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1190, 700);
            this.Name = "Fm_principal";
            this.Text = "API Dofus";
            this.Load += new System.EventHandler(this.Fm_principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wv_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Button bt_Valider;
        private System.Windows.Forms.ComboBox cb_Type;
        private System.Windows.Forms.TextBox tb_Txt;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.Label lb_2;
        private System.Windows.Forms.Label lb_4;
        private System.Windows.Forms.Label lb_3;
        private System.Windows.Forms.Label lb_5;
        private Microsoft.Web.WebView2.WinForms.WebView2 wv_img;
    }
}

