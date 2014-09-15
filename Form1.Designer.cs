namespace BD_TP1
{
    partial class Compagnie
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
            this.LB_Dept = new System.Windows.Forms.ListBox();
            this.NumEmp = new System.Windows.Forms.Label();
            this.TB_NumEmp = new System.Windows.Forms.TextBox();
            this.TB_Salaire = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Prenom = new System.Windows.Forms.TextBox();
            this.LB_Prenom = new System.Windows.Forms.Label();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.LB_Nom = new System.Windows.Forms.Label();
            this.TB_Total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Suivant = new System.Windows.Forms.Button();
            this.BTN_Preced = new System.Windows.Forms.Button();
            this.BTN_Fin = new System.Windows.Forms.Button();
            this.BTN_Debut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Dept
            // 
            this.LB_Dept.FormattingEnabled = true;
            this.LB_Dept.Location = new System.Drawing.Point(19, 12);
            this.LB_Dept.Name = "LB_Dept";
            this.LB_Dept.Size = new System.Drawing.Size(195, 17);
            this.LB_Dept.TabIndex = 0;
            this.LB_Dept.SelectedIndexChanged += new System.EventHandler(this.LB_Dept_SelectedIndexChanged);
            // 
            // NumEmp
            // 
            this.NumEmp.AutoSize = true;
            this.NumEmp.Location = new System.Drawing.Point(26, 65);
            this.NumEmp.Name = "NumEmp";
            this.NumEmp.Size = new System.Drawing.Size(60, 13);
            this.NumEmp.TabIndex = 1;
            this.NumEmp.Text = "# Employé:";
            // 
            // TB_NumEmp
            // 
            this.TB_NumEmp.Location = new System.Drawing.Point(111, 65);
            this.TB_NumEmp.Name = "TB_NumEmp";
            this.TB_NumEmp.Size = new System.Drawing.Size(102, 20);
            this.TB_NumEmp.TabIndex = 2;
            // 
            // TB_Salaire
            // 
            this.TB_Salaire.Location = new System.Drawing.Point(112, 143);
            this.TB_Salaire.Name = "TB_Salaire";
            this.TB_Salaire.Size = new System.Drawing.Size(102, 20);
            this.TB_Salaire.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Salaire";
            // 
            // TB_Prenom
            // 
            this.TB_Prenom.Location = new System.Drawing.Point(112, 117);
            this.TB_Prenom.Name = "TB_Prenom";
            this.TB_Prenom.Size = new System.Drawing.Size(102, 20);
            this.TB_Prenom.TabIndex = 6;
            // 
            // LB_Prenom
            // 
            this.LB_Prenom.AutoSize = true;
            this.LB_Prenom.Location = new System.Drawing.Point(26, 117);
            this.LB_Prenom.Name = "LB_Prenom";
            this.LB_Prenom.Size = new System.Drawing.Size(46, 13);
            this.LB_Prenom.TabIndex = 5;
            this.LB_Prenom.Text = "Prénom:";
            // 
            // TB_Nom
            // 
            this.TB_Nom.Location = new System.Drawing.Point(111, 91);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.Size = new System.Drawing.Size(102, 20);
            this.TB_Nom.TabIndex = 4;
            // 
            // LB_Nom
            // 
            this.LB_Nom.AutoSize = true;
            this.LB_Nom.Location = new System.Drawing.Point(26, 91);
            this.LB_Nom.Name = "LB_Nom";
            this.LB_Nom.Size = new System.Drawing.Size(32, 13);
            this.LB_Nom.TabIndex = 3;
            this.LB_Nom.Text = "Nom:";
            // 
            // TB_Total
            // 
            this.TB_Total.Location = new System.Drawing.Point(333, 15);
            this.TB_Total.Name = "TB_Total";
            this.TB_Total.Size = new System.Drawing.Size(47, 20);
            this.TB_Total.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nbre total employés:";
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Location = new System.Drawing.Point(292, 68);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(89, 24);
            this.BTN_Ajouter.TabIndex = 13;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.Location = new System.Drawing.Point(292, 98);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(89, 24);
            this.BTN_Supprimer.TabIndex = 14;
            this.BTN_Supprimer.Text = "Supprimer";
            this.BTN_Supprimer.UseVisualStyleBackColor = true;
            this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Location = new System.Drawing.Point(292, 132);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(89, 24);
            this.BTN_Modifier.TabIndex = 15;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // BTN_Suivant
            // 
            this.BTN_Suivant.Location = new System.Drawing.Point(156, 190);
            this.BTN_Suivant.Name = "BTN_Suivant";
            this.BTN_Suivant.Size = new System.Drawing.Size(63, 24);
            this.BTN_Suivant.TabIndex = 11;
            this.BTN_Suivant.Text = "Suivant";
            this.BTN_Suivant.UseVisualStyleBackColor = true;
            this.BTN_Suivant.Click += new System.EventHandler(this.BTN_Suivant_Click);
            // 
            // BTN_Preced
            // 
            this.BTN_Preced.Location = new System.Drawing.Point(82, 190);
            this.BTN_Preced.Name = "BTN_Preced";
            this.BTN_Preced.Size = new System.Drawing.Size(68, 24);
            this.BTN_Preced.TabIndex = 10;
            this.BTN_Preced.Text = "Précédent";
            this.BTN_Preced.UseVisualStyleBackColor = true;
            this.BTN_Preced.Click += new System.EventHandler(this.BTN_Preced_Click);
            // 
            // BTN_Fin
            // 
            this.BTN_Fin.Location = new System.Drawing.Point(225, 190);
            this.BTN_Fin.Name = "BTN_Fin";
            this.BTN_Fin.Size = new System.Drawing.Size(63, 24);
            this.BTN_Fin.TabIndex = 12;
            this.BTN_Fin.Text = "Fin";
            this.BTN_Fin.UseVisualStyleBackColor = true;
            this.BTN_Fin.Click += new System.EventHandler(this.BTN_Fin_Click);
            // 
            // BTN_Debut
            // 
            this.BTN_Debut.Location = new System.Drawing.Point(13, 190);
            this.BTN_Debut.Name = "BTN_Debut";
            this.BTN_Debut.Size = new System.Drawing.Size(63, 24);
            this.BTN_Debut.TabIndex = 9;
            this.BTN_Debut.Text = "Début";
            this.BTN_Debut.UseVisualStyleBackColor = true;
            this.BTN_Debut.Click += new System.EventHandler(this.BTN_Debut_Click);
            // 
            // Compagnie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 226);
            this.Controls.Add(this.BTN_Debut);
            this.Controls.Add(this.BTN_Fin);
            this.Controls.Add(this.BTN_Preced);
            this.Controls.Add(this.BTN_Suivant);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_Supprimer);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Total);
            this.Controls.Add(this.TB_Nom);
            this.Controls.Add(this.LB_Nom);
            this.Controls.Add(this.TB_Prenom);
            this.Controls.Add(this.LB_Prenom);
            this.Controls.Add(this.TB_Salaire);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_NumEmp);
            this.Controls.Add(this.NumEmp);
            this.Controls.Add(this.LB_Dept);
            this.Name = "Compagnie";
            this.Text = "Employés par département";
            this.Load += new System.EventHandler(this.Compagnie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Dept;
        private System.Windows.Forms.Label NumEmp;
        private System.Windows.Forms.TextBox TB_NumEmp;
        private System.Windows.Forms.TextBox TB_Salaire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Prenom;
        private System.Windows.Forms.Label LB_Prenom;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.Label LB_Nom;
        private System.Windows.Forms.TextBox TB_Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Suivant;
        private System.Windows.Forms.Button BTN_Preced;
        private System.Windows.Forms.Button BTN_Fin;
        private System.Windows.Forms.Button BTN_Debut;
    }
}

