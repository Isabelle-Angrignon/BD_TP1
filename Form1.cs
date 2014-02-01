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
        private string SqlDep = "SELECT nomDept FROM Departements order by nomDept";
        private string AllDep = "List_Dep";

        public Compagnie()
        {
            InitializeComponent();
        }

        private void Compagnie_Load(object sender, EventArgs e)
        {
            Connection();
            Lister_Dept();
        }

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

        private void Lister_Dept()
        {
            LB_Dept.Items.Clear();
            //Clear();

            try
            {
                OracleDataAdapter Oraliste = new OracleDataAdapter(SqlDep, conn);

                if (monDataSet.Tables.Contains(AllDep))
                {
                    monDataSet.Tables[AllDep].Clear();
                }
                Oraliste.Fill(monDataSet, AllDep);
                Oraliste.Dispose();

                BindingSource maSource = new BindingSource(monDataSet, AllDep);
            }
            catch (Exception se) { MessageBox.Show(se.Message.ToString()); }

            ListerDepartement();
        }

        private void ListerDepartement()
        {
            try
            {

                OracleCommand CMD = new OracleCommand(SqlDep, conn);
                CMD.CommandType = CommandType.Text;
                OraReadCIE = CMD.ExecuteReader();
                while (OraReadCIE.Read())
                {
                    LB_Dept.Items.Add(OraReadCIE.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void AfficherTotal()
        {
            try
            {
                SQL1 = "Select Count(NumEmp) From Employes Group by codedept
                OracleCommand CMD = new OracleCommand(SqlDep, conn);
                CMD.CommandType = CommandType.Text;
                OraReadCIE = CMD.ExecuteReader();
                while (OraReadCIE.Read())
                {
                    LB_Dept.Items.Add(OraReadCIE.GetString(0));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
       
        


    }
}
