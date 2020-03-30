using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Smart_SQLite
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            itemExecute.Enabled = false;
            txtOutput.ForeColor = Color.White;
            txtOutput.BackColor = Color.Black;
            
            //txtOutput.Enabled = false;
           
        }

     
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQLite (*.sqlite3)|*.sqlite3; *.db; *.sqlite";


            bool fileError = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try {
                    globals.dbOpened = true;
                    globals.vFileName = ofd.FileName.ToString();
                    SQLiteConnection connection = new SQLiteConnection("Data Source=" + globals.vFileName.ToString());
                    tts.Text = "Loaded Database " + globals.vFileName;
                    txtOutput.Text = "Loaded Database " + globals.vFileName + "\n";

                    connection.Open();
                    SQLiteCommand cmd = new SQLiteCommand("select * from sqlite_master", connection);
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    TableNames.Items.Clear();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            
                            string name = reader.GetString(reader.GetOrdinal("name"));
                            TableNames.Items.Add(name);
                            acM.AddItem(name);
                        }
                    }
                    SQLiteConnection connectioner = new SQLiteConnection("Data Source=" + globals.vFileName.ToString());
                    connectioner.Open();
                    SQLiteDataAdapter dataadapterSQ = new SQLiteDataAdapter("select * from sqlite_sequence", connectioner);
                    DataSet dSET = new System.Data.DataSet();
                    dataadapterSQ.Fill(dSET, "SQ");
                    sqV.ClearSelection();
                    sqV.DataSource = dSET.Tables[0];

                    sqV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    sqV.AutoResizeColumns();

                    //sqV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    //sqV.AutoResizeRows();
                    txtLA.Text = "Opened: " + globals.vFileName + " Date/Time: " + DateTime.Now.ToString() + "\n";
                }
                catch { }
            }
            
        }


        public void dataFill(String vSQL)
        {
            try
            {
                Console.WriteLine(vSQL);
                Console.WriteLine(globals.vFileName);
                SQLiteConnection connection = new SQLiteConnection("Data Source=" + globals.vFileName.ToString());
                connection.Open();
                SQLiteDataAdapter dataadapter = new SQLiteDataAdapter(vSQL, connection);
                DataSet ds = new System.Data.DataSet();
                dataadapter.Fill(ds, "DV");
                dvGV.ClearSelection();
                dvGV.DataSource = ds.Tables[0];
                dvGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dvGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dvGV.AutoResizeRows();
                dvGV.AutoResizeColumns();
            }
            catch(Exception ex)
            {
                txtOutput.AppendText("Error: " + ex.ToString() + "\n");
            }
            
        }

        private void txtSQL_TextChanged(object sender, EventArgs e)
        {
            if (globals.dbOpened == true)
            {
                itemExecute.Enabled = true;
                int iSelStart = txtSQL.SelectionStart;
                int iSelLength = txtSQL.SelectionLength;

                string tokens = "(auto|double|int|struct|break|else|long|switch|case|enum|register|typedef|char|extern|return|union|const|float|short|unsigned|continue|for|signed|void|default|goto|sizeof|volatile|do|if|static|while|order|by|desc|asc|select|where|like|upper|from)";

                Regex rex = new Regex(tokens);

                MatchCollection mc = rex.Matches(txtSQL.Text);

                int iStart = txtSQL.SelectionStart;

                foreach (Match m in mc)
                {
                    int iStartIndex = m.Index;
                    int iStopIndex = m.Length;

                    txtSQL.Select(iStartIndex, iStopIndex);
                    txtSQL.SelectionColor = Color.Blue;
                    txtSQL.SelectionStart = iStart;
                    txtSQL.SelectionColor = Color.Black;
                }

                txtSQL.SelectionStart = iSelStart;
                txtSQL.SelectionLength = iSelLength;
            }
            else
            {
                MessageBox.Show("You have to open or create a Database before you can execute SQL commands.");
            }
        }

        public void itemExecute_Click(object sender, EventArgs e)
        {
            try
            {
                if (globals.insertmode == true)
                {
                    SQLiteConnection connection = new SQLiteConnection("Data Source=" + globals.vFileName.ToString());


                    connection.Open();
                    SQLiteCommand insertSQL = new SQLiteCommand(txtSQL.Text, connection);
                    
                    DialogResult result = MessageBox.Show("Would you write your Changes?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(result == DialogResult.Yes)
                    {
                        insertSQL.ExecuteNonQuery();
                        connection.Close();
                        txtOutput.AppendText("Written SQL insert command: " + txtSQL.Text);
                        txtSQL.Clear();
                        rbtnInsertMode.Checked = false;
                        dataFill(globals.lastsql);
                        txtLA.AppendText(txtSQL.Text + "\n");

                    }
                    else
                    {
                        txtOutput.AppendText("Changes not written, SQL insert canceled!\n");
                        txtSQL.Clear();
                        rbtnInsertMode.Checked = false;
                    }


               connection.Close();
                }
                else
                {
                    dataFill(txtSQL.Text);
                    globals.lastsql = txtSQL.Text;
                    txtSQL.Clear();
                    txtLA.AppendText(txtSQL.Text + "\n");

                }
            }
            catch (Exception ex)
            {
                txtOutput.AppendText(ex.ToString() + "\n");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TableNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String sql = "select * from " + TableNames.SelectedItems[0].Text;

                txtOutput.AppendText(sql + "\n");
                dataFill(sql);
                sqlTableSchema(TableNames.SelectedItems[0].Text);
                globals.lastsql = sql;
                
            }
            catch { }
        }

        public void sqlTableSchema(string sqlTable)
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=" + globals.vFileName.ToString());


            connection.Open();
            SQLiteCommand cmd = new SQLiteCommand("select sql from sqlite_master where name = '" + sqlTable + "'", connection);
            SQLiteDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string schema = reader.GetString(reader.GetOrdinal("sql"));
                    txtSQLSchema.Text = schema;
                    txtSQLSchemaHighlighting();
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            int iSelStart = txtSQLSchema.SelectionStart;
            int iSelLength = txtSQLSchema.SelectionLength;

            string tokens = "(auto|double|int|struct|break|else|long|switch|case|enum|register|typedef|char|extern|return|union|const|float|short|unsigned|continue|for|signed|void|default|goto|sizeof|volatile|do|if|static|while|order|by|desc|asc|select|where|like|upper|from|CREATE|NUMERIC|NOT|NULL|TEXT|PRIMARY|KEY|AUTOINCREMENT|INTEGER|CREATE|TABLE|create|table)";

            Regex rex = new Regex(tokens);

            MatchCollection mc = rex.Matches(txtSQLSchema.Text);

            int iStart = txtSQLSchema.SelectionStart;

            foreach (Match m in mc)
            {
                int iStartIndex = m.Index;
                int iStopIndex = m.Length;

                txtSQLSchema.Select(iStartIndex, iStopIndex);
                txtSQLSchema.SelectionColor = Color.LightGreen;
                txtSQLSchema.SelectionStart = iStart;
                txtSQLSchema.SelectionColor = Color.White;
            }

            txtSQLSchema.SelectionStart = iSelStart;
            txtSQLSchema.SelectionLength = iSelLength;
        }

        public void txtSQLSchemaHighlighting()
        {
            int iSelStart = txtSQLSchema.SelectionStart;
            int iSelLength = txtSQLSchema.SelectionLength;

            string tokens = "(auto|double|int|struct|break|else|long|switch|case|enum|register|typedef|char|extern|return|union|const|float|short|unsigned|continue|for|signed|void|default|goto|sizeof|volatile|do|if|static|while|order|by|desc|asc|select|where|like|upper|from|CREATE|NUMERIC|NOT|NULL|TEXT|PRIMARY|KEY|AUTOINCREMENT)";

            Regex rex = new Regex(tokens);

            MatchCollection mc = rex.Matches(txtSQLSchema.Text);

            int iStart = txtSQLSchema.SelectionStart;

            foreach (Match m in mc)
            {
                int iStartIndex = m.Index;
                int iStopIndex = m.Length;

                txtSQLSchema.Select(iStartIndex, iStopIndex);
                txtSQLSchema.SelectionColor = Color.Blue;
                txtSQLSchema.SelectionStart = iStart;
                txtSQLSchema.SelectionColor = Color.Black;
            }

            txtSQLSchema.SelectionStart = iSelStart;
            txtSQLSchema.SelectionLength = iSelLength;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ascendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (globals.lastsql != null)
            {
                string sqlCMD = globals.lastsql + " order by ID ASC";
                dataFill(sqlCMD);
                txtOutput.AppendText("Sorted ascending: " + sqlCMD + "\n");
            }
            else
            {
                txtOutput.AppendText("You cant sort. No Table loaded\n");
            }
        }

        private void descendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (globals.lastsql != null)
            {
                string sqlCMD = globals.lastsql + " order by ID DESC";
                dataFill(sqlCMD);
                txtOutput.AppendText("Sorted descending: " + sqlCMD + "\n");

            }
            else
            {
                txtOutput.AppendText("You cant sort. No Table loaded\n");
            }
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (globals.lastsql != null)
            {
                
                dataFill(globals.lastsql);
                txtOutput.AppendText("Reloaded: " + globals.lastsql + "\n");

            }
            else
            {
                txtOutput.AppendText("You cant reload. No Table loaded\n");
            }
        }

        private void rbtnInsertMode_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnInsertMode.Checked = true)
            {
                globals.insertmode = true;
            }
        }

        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dvGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dvGV.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dvGV.ColumnCount);
                            pdfTable.DefaultCell.Padding = 2;
                            pdfTable.WidthPercentage = 10;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
                            pdfTable.DefaultCell.BorderWidth = 1;


                            //Adding Header row
                            foreach (DataGridViewColumn column in dvGV.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));

                                pdfTable.AddCell(cell);
                            }

                            //Adding DataRow
                            foreach (DataGridViewRow row in dvGV.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    try
                                    {
                                        pdfTable.AddCell(cell.Value.ToString());
                                    }
                                    catch { }
                                }
                            }

                            //Exporting to PDF

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Daten wurden Exportiert: " + sfd.FileName.ToString(), "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Keine Daten zum Exportieren!", "Info");
            }
        }

        private void cSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dvGV.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Datei konnte nicht geschrieben werden." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dvGV.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dvGV.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dvGV.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dvGV.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    try
                                    {
                                        outputCsv[i] += dvGV.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                    }
                                    catch { }
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Daten erfolgreich exportiert " + sfd.FileName.ToString(), "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Keine Eintragungen zum Exportieren", "Info");
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info infoW = new Info();
            infoW.Show();
        }
    }

    public class globals
    {
        public static string vFileName = "";
        public static bool dbOpened = false;
        public static string sqlschema = "";
        public static string lastsql;
        public static bool insertmode = false;
    }
}
