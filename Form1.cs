// Révision ADO.net
// Par Isabelle Angrignon et Simon Bouchard 
// Fait le 2014-02
// But Réviser les notions de base d'une application ADO.net


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace BD_TP1
{
    public partial class Compagnie : Form
    {
        private OracleConnection conn = new OracleConnection();
        private DataSet monDataSet = new DataSet();
        OracleDataReader OraReadCIE;
        private string SqlDep = "SELECT nomDept FROM Departements order by nomDept";    // Utiliser pour le data reader de la LB.
        private string AllDep = "List_Dep";                                             // Titre de la table DataSet
        
                                                                  

        public Compagnie()
        {
            InitializeComponent();
        }

        private void Compagnie_Load(object sender, EventArgs e)
        {
            Connection();
            ListerDepartement();
            DataSetCreator();
        }

        // Établie la connection
        private void Connection()
        {
            try
            {
                string Dsource = "(DESCRIPTION="
                + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
                + "(HOST=205.237.244.251)(PORT=1521)))"
                + "(CONNECT_DATA=(SERVICE_NAME=ORCL)))";

                String ChaineConnexion = "Data Source=" + Dsource
                + ";User Id = angrigno; Password = oracle1";
                conn.ConnectionString = ChaineConnexion;

                conn.Open();

                MessageBox.Show(conn.State.ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void DataSetCreator()
        {
            

            try
            {
                //Relatif a l'item selectionner de la List Box.
                string SQLDataSet = "SELECT * From Employes WHERE CodeDept =" +         
                " (Select CodeDept From Departements Where NomDept = '" + LB_Dept.SelectedItem.ToString() + "')";  
                OracleDataAdapter Oraliste = new OracleDataAdapter(SQLDataSet, conn);

                if (monDataSet.Tables.Contains(AllDep))
                {
                    monDataSet.Tables[AllDep].Clear();
                }
                Oraliste.Fill(monDataSet, AllDep);
                Oraliste.Dispose();

                BindingSource maSource = new BindingSource(monDataSet, AllDep);
                Clear();
                MAJ_Champs();
            }
            catch (Exception se) { MessageBox.Show(se.Message.ToString()); }

        }

        private void MAJ_Champs()
        {
            TB_Nom.DataBindings.Add("Text", monDataSet, AllDep + ".NomEmp");
            TB_NumEmp.DataBindings.Add("Text", monDataSet, AllDep + ".NumEmp");
            TB_Prenom.DataBindings.Add("Text", monDataSet, AllDep + ".PrenomEmp");
            TB_Salaire.DataBindings.Add("Text", monDataSet, AllDep + ".SalaireEmp");
        }

        // Clear les text box ET les DataBindings du DataSet
        private void Clear()
        {
            TB_Nom.Clear();
            TB_NumEmp.Clear();
            TB_Prenom.Clear();
            TB_Salaire.Clear();

            TB_Nom.DataBindings.Clear();
            TB_NumEmp.DataBindings.Clear();
            TB_Prenom.DataBindings.Clear();
            TB_Salaire.DataBindings.Clear();
        }

        // Remplie la ListBox avec les noms de départements.

        private void ListerDepartement()
        {
            try
            {
                LB_Dept.Items.Clear();
                OracleCommand CMD = new OracleCommand(SqlDep, conn);
                CMD.CommandType = CommandType.Text;
                OraReadCIE = CMD.ExecuteReader();
                while (OraReadCIE.Read())
                {
                    LB_Dept.Items.Add(OraReadCIE.GetString(0));
                }
                LB_Dept.SelectedItem = LB_Dept.Items[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        
        // Affiche le nombre d'employes pour le departement selectionner dans le list box 
        private void AfficherTotal()
        {
            try
            {
                // Utilise un Data reader !!! Le nom dept sert a récupérer le total.
                string SQL1 = "Select count(E.NumEmp) AS NombreEmp , NomDept From Employes E Inner Join Departements D ON"+
                    " E.CodeDept = D.CodeDept Group by E.CodeDept , NomDept HAVING NomDept = '"+ LB_Dept.SelectedItem.ToString()
                 +"'";
                OracleCommand CMD = new OracleCommand(SQL1, conn);
                CMD.CommandType = CommandType.Text;
                OraReadCIE = CMD.ExecuteReader();
                bool Zero = true;
                while (OraReadCIE.Read()) 
                {
                    string Total = OraReadCIE.GetValue(0).ToString();
                    TB_Total.Text = Total;
                    Zero = false;

                }
                if (Zero)
                {
                    TB_Total.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void LB_Dept_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherTotal();
            DataSetCreator();
        }

        // met au debut du data set
        private void BTN_Debut_Click(object sender, EventArgs e)
        {
            try
            {
                this.BindingContext[monDataSet, AllDep].Position = 0;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        // met a la fin du data set
        private void BTN_Fin_Click(object sender, EventArgs e)
        {
            try
            {
                this.BindingContext[monDataSet, AllDep].Position =
                this.BindingContext[monDataSet, AllDep].Count - 1;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        // fait un précédent 
        private void BTN_Preced_Click(object sender, EventArgs e)
        {
            try
            {
                --this.BindingContext[monDataSet, AllDep].Position;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        // fait un suivant
        private void BTN_Suivant_Click(object sender, EventArgs e)
        {
            try
            {
                ++this.BindingContext[monDataSet, AllDep].Position;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }

        // fait un ajout. 
        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                
                // Codept n'étant pas null il faut faire une sous-requête pour aller le chercher dans le ListBox
                // La modification du numero d'employé de peut pas être fait de facon manuelle. On utilise la séquence.
                string sqlAdd = "INSERT INTO Employes VALUES (NumYe.NextVal,:NOMEMP,:PRENOM,:SALAIRE,NULL,"+
                    " (SELECT CodeDept FROM Departements WHERE NomDept = '"+LB_Dept.SelectedItem.ToString() +"'), NULL)";
                
                OracleParameter oParamNomEmp = new OracleParameter(":NOMEMP", OracleDbType.Varchar2, 40);
                OracleParameter oParamPrenom = new OracleParameter(":PRENOM", OracleDbType.Varchar2, 40);
                OracleParameter oParamSalaire = new OracleParameter(":SALAIRE", OracleDbType.Int32, 8);
               
                oParamNomEmp.Value = TB_Nom.Text;
                oParamPrenom.Value = TB_Prenom.Text;
                oParamSalaire.Value = int.Parse(TB_Salaire.Text);

                OracleCommand orComm = new OracleCommand(sqlAdd, conn);
           
                orComm.Parameters.Add(oParamNomEmp);
                orComm.Parameters.Add(oParamPrenom);
                orComm.Parameters.Add(oParamSalaire);
                orComm.ExecuteNonQuery();
               

                DataSetCreator();
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            AfficherTotal();
        }

        // Supprime un employé
        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer cet enregistrement?", "Attention", MessageBoxButtons.YesNo) == 
                    System.Windows.Forms.DialogResult.Yes)
                {
                    string Nom = TB_Prenom.Text +" " +TB_Nom.Text;
                    string sqlDelete = "DELETE FROM Employes WHERE NumEmp = :NUMEMP";//requete supprime

                    OracleParameter oParamNomDiv = new OracleParameter(":NUMEMP", OracleDbType.Int32, 5);
                    oParamNomDiv.Value = TB_NumEmp.Text;

                    OracleCommand orComm = new OracleCommand(sqlDelete, conn);
                    orComm.Parameters.Add(oParamNomDiv);
                    int res = orComm.ExecuteNonQuery();

                    DataSetCreator();
                    if (res > 0)
                    {
                        MessageBox.Show("L'employé " + Nom + " a été supprimé");
                    }
                    else
                    {
                        MessageBox.Show("Aucune entrée");
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
            AfficherTotal();
        }

        // Met a jour uniquement le salaire !!! 
        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlUpdate = "UPDATE Employes SET SalaireEmp = :SALAIRE WHERE NumEmp = :NUMEMP";


                OracleParameter oParamSalaire = new OracleParameter(":SALAIRE", OracleDbType.Int32, 8);
                OracleParameter oParamNumEmp = new OracleParameter(":NUMEMP", OracleDbType.Int32, 5);

                oParamSalaire.Value = int.Parse(TB_Salaire.Text);
                oParamNumEmp.Value = int.Parse(TB_NumEmp.Text);

                OracleCommand orComm = new OracleCommand(sqlUpdate, conn);
                orComm.Parameters.Add(oParamSalaire);
                orComm.Parameters.Add(oParamNumEmp);
                orComm.ExecuteNonQuery();
               

                DataSetCreator();
            }
            catch (OracleException ex) { MessageBox.Show(ex.Message); }
        }
       
        


    }
}
