namespace GestionCompte
{
    partial class fm_items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_items));
            this.panel_items = new System.Windows.Forms.Panel();
            this.sBT_valider = new Siticone.UI.WinForms.SiticoneButton();
            this.sTB_title = new Siticone.UI.WinForms.SiticoneLabel();
            this.sCB_exit = new Siticone.UI.WinForms.SiticoneControlBox();
            this.sTB_email = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneDragControl = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.sLB_formules = new Siticone.UI.WinForms.SiticoneLabel();
            this.sLB_potions = new Siticone.UI.WinForms.SiticoneLabel();
            this.sLB_estBanni = new Siticone.UI.WinForms.SiticoneLabel();
            this.sLB_email = new Siticone.UI.WinForms.SiticoneLabel();
            this.sLB_motDePasse = new Siticone.UI.WinForms.SiticoneLabel();
            this.sLB_nomCompte = new Siticone.UI.WinForms.SiticoneLabel();
            this.sTB_nomCompte = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.sTB_motDePasse = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.sCB_isBanned = new Siticone.UI.WinForms.SiticoneCheckBox();
            this.sTB_potionChance = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.sTB_formules = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.panel_items.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_items
            // 
            this.panel_items.Controls.Add(this.sBT_valider);
            this.panel_items.Controls.Add(this.sTB_title);
            this.panel_items.Controls.Add(this.sCB_exit);
            this.panel_items.Controls.Add(this.sTB_email);
            this.panel_items.Location = new System.Drawing.Point(-1, 0);
            this.panel_items.MinimumSize = new System.Drawing.Size(256, 406);
            this.panel_items.Name = "panel_items";
            this.panel_items.Size = new System.Drawing.Size(256, 406);
            this.panel_items.TabIndex = 13;
            // 
            // sBT_valider
            // 
            this.sBT_valider.CheckedState.Parent = this.sBT_valider;
            this.sBT_valider.CustomImages.Parent = this.sBT_valider;
            this.sBT_valider.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sBT_valider.ForeColor = System.Drawing.Color.White;
            this.sBT_valider.HoveredState.Parent = this.sBT_valider;
            this.sBT_valider.Location = new System.Drawing.Point(90, 360);
            this.sBT_valider.Name = "sBT_valider";
            this.sBT_valider.ShadowDecoration.Parent = this.sBT_valider;
            this.sBT_valider.Size = new System.Drawing.Size(75, 37);
            this.sBT_valider.TabIndex = 16;
            this.sBT_valider.Text = "Valider";
            this.sBT_valider.Click += new System.EventHandler(this.sBT_valider_Click);
            // 
            // sTB_title
            // 
            this.sTB_title.AutoSize = false;
            this.sTB_title.BackColor = System.Drawing.Color.Transparent;
            this.sTB_title.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.sTB_title.Location = new System.Drawing.Point(13, 12);
            this.sTB_title.Name = "sTB_title";
            this.sTB_title.Size = new System.Drawing.Size(169, 24);
            this.sTB_title.TabIndex = 14;
            this.sTB_title.Text = "Ajouter/modifier un compte";
            this.sTB_title.Click += new System.EventHandler(this.sTB_title_Click);
            // 
            // sCB_exit
            // 
            this.sCB_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sCB_exit.BorderRadius = 10;
            this.sCB_exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.sCB_exit.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.sCB_exit.HoveredState.IconColor = System.Drawing.Color.White;
            this.sCB_exit.HoveredState.Parent = this.sCB_exit;
            this.sCB_exit.IconColor = System.Drawing.Color.White;
            this.sCB_exit.Location = new System.Drawing.Point(205, 7);
            this.sCB_exit.Name = "sCB_exit";
            this.sCB_exit.ShadowDecoration.Parent = this.sCB_exit;
            this.sCB_exit.Size = new System.Drawing.Size(45, 29);
            this.sCB_exit.TabIndex = 15;
            // 
            // sTB_email
            // 
            this.sTB_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sTB_email.DefaultText = "";
            this.sTB_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sTB_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sTB_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sTB_email.DisabledState.Parent = this.sTB_email;
            this.sTB_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sTB_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sTB_email.FocusedState.Parent = this.sTB_email;
            this.sTB_email.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sTB_email.HoveredState.Parent = this.sTB_email;
            this.sTB_email.Location = new System.Drawing.Point(83, 168);
            this.sTB_email.Name = "sTB_email";
            this.sTB_email.PasswordChar = '\0';
            this.sTB_email.PlaceholderText = "";
            this.sTB_email.SelectedText = "";
            this.sTB_email.ShadowDecoration.Parent = this.sTB_email;
            this.sTB_email.Size = new System.Drawing.Size(150, 30);
            this.sTB_email.TabIndex = 25;
            // 
            // siticoneDragControl
            // 
            this.siticoneDragControl.TargetControl = this.panel_items;
            // 
            // sLB_formules
            // 
            this.sLB_formules.AutoSize = false;
            this.sLB_formules.BackColor = System.Drawing.Color.Transparent;
            this.sLB_formules.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sLB_formules.Location = new System.Drawing.Point(16, 322);
            this.sLB_formules.Name = "sLB_formules";
            this.sLB_formules.Size = new System.Drawing.Size(112, 23);
            this.sLB_formules.TabIndex = 17;
            this.sLB_formules.Text = "Formule du maitre";
            // 
            // sLB_potions
            // 
            this.sLB_potions.AutoSize = false;
            this.sLB_potions.BackColor = System.Drawing.Color.Transparent;
            this.sLB_potions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sLB_potions.Location = new System.Drawing.Point(16, 264);
            this.sLB_potions.Name = "sLB_potions";
            this.sLB_potions.Size = new System.Drawing.Size(112, 23);
            this.sLB_potions.TabIndex = 18;
            this.sLB_potions.Text = "Potion de chance";
            // 
            // sLB_estBanni
            // 
            this.sLB_estBanni.AutoSize = false;
            this.sLB_estBanni.BackColor = System.Drawing.Color.Transparent;
            this.sLB_estBanni.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sLB_estBanni.Location = new System.Drawing.Point(16, 213);
            this.sLB_estBanni.Name = "sLB_estBanni";
            this.sLB_estBanni.Size = new System.Drawing.Size(75, 23);
            this.sLB_estBanni.TabIndex = 19;
            this.sLB_estBanni.Text = "Est banni";
            // 
            // sLB_email
            // 
            this.sLB_email.AutoSize = false;
            this.sLB_email.BackColor = System.Drawing.Color.Transparent;
            this.sLB_email.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sLB_email.Location = new System.Drawing.Point(16, 156);
            this.sLB_email.Name = "sLB_email";
            this.sLB_email.Size = new System.Drawing.Size(47, 23);
            this.sLB_email.TabIndex = 20;
            this.sLB_email.Text = "Email";
            // 
            // sLB_motDePasse
            // 
            this.sLB_motDePasse.AutoSize = false;
            this.sLB_motDePasse.BackColor = System.Drawing.Color.Transparent;
            this.sLB_motDePasse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sLB_motDePasse.Location = new System.Drawing.Point(16, 103);
            this.sLB_motDePasse.Name = "sLB_motDePasse";
            this.sLB_motDePasse.Size = new System.Drawing.Size(101, 23);
            this.sLB_motDePasse.TabIndex = 21;
            this.sLB_motDePasse.Text = "Mot de passe";
            // 
            // sLB_nomCompte
            // 
            this.sLB_nomCompte.AutoSize = false;
            this.sLB_nomCompte.BackColor = System.Drawing.Color.Transparent;
            this.sLB_nomCompte.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.sLB_nomCompte.Location = new System.Drawing.Point(16, 44);
            this.sLB_nomCompte.Name = "sLB_nomCompte";
            this.sLB_nomCompte.Size = new System.Drawing.Size(101, 23);
            this.sLB_nomCompte.TabIndex = 22;
            this.sLB_nomCompte.Text = "Nom de compte";
            // 
            // sTB_nomCompte
            // 
            this.sTB_nomCompte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sTB_nomCompte.DefaultText = "";
            this.sTB_nomCompte.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sTB_nomCompte.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sTB_nomCompte.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sTB_nomCompte.DisabledState.Parent = this.sTB_nomCompte;
            this.sTB_nomCompte.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sTB_nomCompte.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sTB_nomCompte.FocusedState.Parent = this.sTB_nomCompte;
            this.sTB_nomCompte.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sTB_nomCompte.HoveredState.Parent = this.sTB_nomCompte;
            this.sTB_nomCompte.Location = new System.Drawing.Point(122, 56);
            this.sTB_nomCompte.Name = "sTB_nomCompte";
            this.sTB_nomCompte.PasswordChar = '\0';
            this.sTB_nomCompte.PlaceholderText = "";
            this.sTB_nomCompte.SelectedText = "";
            this.sTB_nomCompte.ShadowDecoration.Parent = this.sTB_nomCompte;
            this.sTB_nomCompte.Size = new System.Drawing.Size(110, 30);
            this.sTB_nomCompte.TabIndex = 23;
            // 
            // sTB_motDePasse
            // 
            this.sTB_motDePasse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sTB_motDePasse.DefaultText = "";
            this.sTB_motDePasse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sTB_motDePasse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sTB_motDePasse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sTB_motDePasse.DisabledState.Parent = this.sTB_motDePasse;
            this.sTB_motDePasse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sTB_motDePasse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sTB_motDePasse.FocusedState.Parent = this.sTB_motDePasse;
            this.sTB_motDePasse.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sTB_motDePasse.HoveredState.Parent = this.sTB_motDePasse;
            this.sTB_motDePasse.Location = new System.Drawing.Point(122, 116);
            this.sTB_motDePasse.Name = "sTB_motDePasse";
            this.sTB_motDePasse.PasswordChar = '\0';
            this.sTB_motDePasse.PlaceholderText = "";
            this.sTB_motDePasse.SelectedText = "";
            this.sTB_motDePasse.ShadowDecoration.Parent = this.sTB_motDePasse;
            this.sTB_motDePasse.Size = new System.Drawing.Size(110, 30);
            this.sTB_motDePasse.TabIndex = 24;
            // 
            // sCB_isBanned
            // 
            this.sCB_isBanned.AutoSize = true;
            this.sCB_isBanned.BackColor = System.Drawing.SystemColors.Control;
            this.sCB_isBanned.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sCB_isBanned.CheckedState.BorderRadius = 2;
            this.sCB_isBanned.CheckedState.BorderThickness = 0;
            this.sCB_isBanned.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sCB_isBanned.CheckMarkColor = System.Drawing.Color.Black;
            this.sCB_isBanned.ForeColor = System.Drawing.Color.Black;
            this.sCB_isBanned.Location = new System.Drawing.Point(113, 222);
            this.sCB_isBanned.Name = "sCB_isBanned";
            this.sCB_isBanned.Size = new System.Drawing.Size(15, 14);
            this.sCB_isBanned.TabIndex = 26;
            this.sCB_isBanned.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.sCB_isBanned.UncheckedState.BorderRadius = 2;
            this.sCB_isBanned.UncheckedState.BorderThickness = 0;
            this.sCB_isBanned.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.sCB_isBanned.UseVisualStyleBackColor = false;
            // 
            // sTB_potionChance
            // 
            this.sTB_potionChance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sTB_potionChance.DefaultText = "";
            this.sTB_potionChance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sTB_potionChance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sTB_potionChance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sTB_potionChance.DisabledState.Parent = this.sTB_potionChance;
            this.sTB_potionChance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sTB_potionChance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sTB_potionChance.FocusedState.Parent = this.sTB_potionChance;
            this.sTB_potionChance.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sTB_potionChance.HoveredState.Parent = this.sTB_potionChance;
            this.sTB_potionChance.Location = new System.Drawing.Point(134, 276);
            this.sTB_potionChance.Name = "sTB_potionChance";
            this.sTB_potionChance.PasswordChar = '\0';
            this.sTB_potionChance.PlaceholderText = "";
            this.sTB_potionChance.SelectedText = "";
            this.sTB_potionChance.ShadowDecoration.Parent = this.sTB_potionChance;
            this.sTB_potionChance.Size = new System.Drawing.Size(110, 30);
            this.sTB_potionChance.TabIndex = 27;
            // 
            // sTB_formules
            // 
            this.sTB_formules.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sTB_formules.DefaultText = "";
            this.sTB_formules.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sTB_formules.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sTB_formules.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sTB_formules.DisabledState.Parent = this.sTB_formules;
            this.sTB_formules.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sTB_formules.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sTB_formules.FocusedState.Parent = this.sTB_formules;
            this.sTB_formules.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sTB_formules.HoveredState.Parent = this.sTB_formules;
            this.sTB_formules.Location = new System.Drawing.Point(134, 325);
            this.sTB_formules.Name = "sTB_formules";
            this.sTB_formules.PasswordChar = '\0';
            this.sTB_formules.PlaceholderText = "";
            this.sTB_formules.SelectedText = "";
            this.sTB_formules.ShadowDecoration.Parent = this.sTB_formules;
            this.sTB_formules.Size = new System.Drawing.Size(110, 30);
            this.sTB_formules.TabIndex = 28;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.sTB_title;
            // 
            // fm_items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 406);
            this.Controls.Add(this.sTB_formules);
            this.Controls.Add(this.sTB_potionChance);
            this.Controls.Add(this.sCB_isBanned);
            this.Controls.Add(this.sTB_motDePasse);
            this.Controls.Add(this.sTB_nomCompte);
            this.Controls.Add(this.sLB_nomCompte);
            this.Controls.Add(this.sLB_motDePasse);
            this.Controls.Add(this.sLB_email);
            this.Controls.Add(this.sLB_estBanni);
            this.Controls.Add(this.sLB_potions);
            this.Controls.Add(this.sLB_formules);
            this.Controls.Add(this.panel_items);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(256, 406);
            this.Name = "fm_items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter/modifier un compte";
            this.Load += new System.EventHandler(this.fm_items_Load);
            this.panel_items.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel panel_items;
        private Siticone.UI.WinForms.SiticoneControlBox sCB_exit;
        private Siticone.UI.WinForms.SiticoneLabel sTB_title;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl;
        private Siticone.UI.WinForms.SiticoneButton sBT_valider;
        private Siticone.UI.WinForms.SiticoneLabel sLB_formules;
        private Siticone.UI.WinForms.SiticoneLabel sLB_potions;
        private Siticone.UI.WinForms.SiticoneLabel sLB_estBanni;
        private Siticone.UI.WinForms.SiticoneLabel sLB_email;
        private Siticone.UI.WinForms.SiticoneLabel sLB_motDePasse;
        private Siticone.UI.WinForms.SiticoneLabel sLB_nomCompte;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox sTB_nomCompte;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox sTB_motDePasse;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox sTB_email;
        private Siticone.UI.WinForms.SiticoneCheckBox sCB_isBanned;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox sTB_potionChance;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox sTB_formules;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
    }
}