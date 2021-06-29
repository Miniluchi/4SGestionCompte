namespace GestionCompte
{
    partial class FormGestion
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
            this.components = new System.ComponentModel.Container();
            Siticone.UI.AnimatorNS.Animation animation2 = new Siticone.UI.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestion));
            this.lv_comptes = new System.Windows.Forms.ListView();
            this.ch_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_isbanned = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_potionchance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_formule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.siticoneDragControl = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneTransition = new Siticone.UI.WinForms.SiticoneTransition();
            this.sCB_minimize = new Siticone.UI.WinForms.SiticoneControlBox();
            this.sLB_FormName = new Siticone.UI.WinForms.SiticoneLabel();
            this.sCB_exit = new Siticone.UI.WinForms.SiticoneControlBox();
            this.sGB_ajouterModifier = new Siticone.UI.WinForms.SiticoneGradientCircleButton();
            this.sGB_supprimer = new Siticone.UI.WinForms.SiticoneGradientCircleButton();
            this.SuspendLayout();
            // 
            // lv_comptes
            // 
            this.lv_comptes.AllowColumnReorder = true;
            this.lv_comptes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_comptes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_name,
            this.ch_password,
            this.ch_email,
            this.ch_isbanned,
            this.ch_potionchance,
            this.ch_formule});
            this.siticoneTransition.SetDecoration(this.lv_comptes, Siticone.UI.AnimatorNS.DecorationType.None);
            this.lv_comptes.FullRowSelect = true;
            this.lv_comptes.GridLines = true;
            this.lv_comptes.HideSelection = false;
            this.lv_comptes.Location = new System.Drawing.Point(12, 38);
            this.lv_comptes.MultiSelect = false;
            this.lv_comptes.Name = "lv_comptes";
            this.lv_comptes.ShowItemToolTips = true;
            this.lv_comptes.Size = new System.Drawing.Size(756, 395);
            this.lv_comptes.TabIndex = 0;
            this.lv_comptes.UseCompatibleStateImageBehavior = false;
            this.lv_comptes.View = System.Windows.Forms.View.Details;
            this.lv_comptes.DoubleClick += new System.EventHandler(this.lv_comptes_DoubleClick);
            // 
            // ch_name
            // 
            this.ch_name.Text = "Nom de compte";
            this.ch_name.Width = 120;
            // 
            // ch_password
            // 
            this.ch_password.Text = "Mot de passe";
            this.ch_password.Width = 150;
            // 
            // ch_email
            // 
            this.ch_email.Text = "Adresse mail";
            this.ch_email.Width = 150;
            // 
            // ch_isbanned
            // 
            this.ch_isbanned.Text = "Est banni";
            this.ch_isbanned.Width = 120;
            // 
            // ch_potionchance
            // 
            this.ch_potionchance.Text = "Potion de chance";
            this.ch_potionchance.Width = 100;
            // 
            // ch_formule
            // 
            this.ch_formule.Text = "Formule du maitre";
            this.ch_formule.Width = 100;
            // 
            // siticoneDragControl
            // 
            this.siticoneDragControl.TargetControl = this;
            // 
            // siticoneTransition
            // 
            this.siticoneTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.siticoneTransition.DefaultAnimation = animation2;
            // 
            // sCB_minimize
            // 
            this.sCB_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sCB_minimize.BorderRadius = 10;
            this.sCB_minimize.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneTransition.SetDecoration(this.sCB_minimize, Siticone.UI.AnimatorNS.DecorationType.None);
            this.sCB_minimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.sCB_minimize.HoveredState.Parent = this.sCB_minimize;
            this.sCB_minimize.IconColor = System.Drawing.Color.White;
            this.sCB_minimize.Location = new System.Drawing.Point(672, 3);
            this.sCB_minimize.Name = "sCB_minimize";
            this.sCB_minimize.ShadowDecoration.Parent = this.sCB_minimize;
            this.sCB_minimize.Size = new System.Drawing.Size(45, 29);
            this.sCB_minimize.TabIndex = 4;
            // 
            // sLB_FormName
            // 
            this.sLB_FormName.AutoSize = false;
            this.sLB_FormName.BackColor = System.Drawing.Color.Transparent;
            this.siticoneTransition.SetDecoration(this.sLB_FormName, Siticone.UI.AnimatorNS.DecorationType.None);
            this.sLB_FormName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sLB_FormName.Location = new System.Drawing.Point(13, 13);
            this.sLB_FormName.Name = "sLB_FormName";
            this.sLB_FormName.Size = new System.Drawing.Size(146, 19);
            this.sLB_FormName.TabIndex = 5;
            this.sLB_FormName.Text = "Gestion de compte";
            // 
            // sCB_exit
            // 
            this.sCB_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sCB_exit.BorderRadius = 10;
            this.siticoneTransition.SetDecoration(this.sCB_exit, Siticone.UI.AnimatorNS.DecorationType.None);
            this.sCB_exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.sCB_exit.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.sCB_exit.HoveredState.IconColor = System.Drawing.Color.White;
            this.sCB_exit.HoveredState.Parent = this.sCB_exit;
            this.sCB_exit.IconColor = System.Drawing.Color.White;
            this.sCB_exit.Location = new System.Drawing.Point(723, 3);
            this.sCB_exit.Name = "sCB_exit";
            this.sCB_exit.ShadowDecoration.Parent = this.sCB_exit;
            this.sCB_exit.Size = new System.Drawing.Size(45, 29);
            this.sCB_exit.TabIndex = 6;
            // 
            // sGB_ajouterModifier
            // 
            this.sGB_ajouterModifier.CheckedState.Parent = this.sGB_ajouterModifier;
            this.sGB_ajouterModifier.CustomImages.Parent = this.sGB_ajouterModifier;
            this.siticoneTransition.SetDecoration(this.sGB_ajouterModifier, Siticone.UI.AnimatorNS.DecorationType.None);
            this.sGB_ajouterModifier.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.sGB_ajouterModifier.ForeColor = System.Drawing.Color.White;
            this.sGB_ajouterModifier.HoveredState.Parent = this.sGB_ajouterModifier;
            this.sGB_ajouterModifier.Location = new System.Drawing.Point(13, 439);
            this.sGB_ajouterModifier.Name = "sGB_ajouterModifier";
            this.sGB_ajouterModifier.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.sGB_ajouterModifier.ShadowDecoration.Parent = this.sGB_ajouterModifier;
            this.sGB_ajouterModifier.Size = new System.Drawing.Size(35, 35);
            this.sGB_ajouterModifier.TabIndex = 7;
            this.sGB_ajouterModifier.Text = "+";
            this.sGB_ajouterModifier.Tile = false;
            this.sGB_ajouterModifier.Click += new System.EventHandler(this.sGB_ajouterModifier_Click);
            // 
            // sGB_supprimer
            // 
            this.sGB_supprimer.CheckedState.Parent = this.sGB_supprimer;
            this.sGB_supprimer.CustomImages.Parent = this.sGB_supprimer;
            this.siticoneTransition.SetDecoration(this.sGB_supprimer, Siticone.UI.AnimatorNS.DecorationType.None);
            this.sGB_supprimer.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.sGB_supprimer.ForeColor = System.Drawing.Color.White;
            this.sGB_supprimer.HoveredState.Parent = this.sGB_supprimer;
            this.sGB_supprimer.Location = new System.Drawing.Point(54, 439);
            this.sGB_supprimer.Name = "sGB_supprimer";
            this.sGB_supprimer.ShadowDecoration.Mode = Siticone.UI.WinForms.Enums.ShadowMode.Circle;
            this.sGB_supprimer.ShadowDecoration.Parent = this.sGB_supprimer;
            this.sGB_supprimer.Size = new System.Drawing.Size(35, 35);
            this.sGB_supprimer.TabIndex = 8;
            this.sGB_supprimer.Text = "-";
            this.sGB_supprimer.Tile = false;
            this.sGB_supprimer.Click += new System.EventHandler(this.sGB_supprimer_Click);
            // 
            // FormGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 486);
            this.Controls.Add(this.sGB_supprimer);
            this.Controls.Add(this.sGB_ajouterModifier);
            this.Controls.Add(this.sCB_exit);
            this.Controls.Add(this.sLB_FormName);
            this.Controls.Add(this.sCB_minimize);
            this.Controls.Add(this.lv_comptes);
            this.siticoneTransition.SetDecoration(this, Siticone.UI.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(780, 475);
            this.Name = "FormGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de compte";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGestion_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader ch_name;
        private System.Windows.Forms.ColumnHeader ch_password;
        private System.Windows.Forms.ColumnHeader ch_isbanned;
        private System.Windows.Forms.ColumnHeader ch_potionchance;
        private System.Windows.Forms.ColumnHeader ch_formule;
        private System.Windows.Forms.ColumnHeader ch_email;
        public System.Windows.Forms.ListView lv_comptes;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;
        private Siticone.UI.WinForms.SiticoneTransition siticoneTransition;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl;
        private Siticone.UI.WinForms.SiticoneControlBox sCB_minimize;
        private Siticone.UI.WinForms.SiticoneLabel sLB_FormName;
        private Siticone.UI.WinForms.SiticoneControlBox sCB_exit;
        private Siticone.UI.WinForms.SiticoneGradientCircleButton sGB_ajouterModifier;
        private Siticone.UI.WinForms.SiticoneGradientCircleButton sGB_supprimer;
    }
}

