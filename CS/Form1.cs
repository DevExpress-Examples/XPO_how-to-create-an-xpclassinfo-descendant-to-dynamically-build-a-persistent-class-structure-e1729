using System;
using System.Data;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DynamicDataTable {
    public partial class Form1 : Form {
        private readonly string connectionString = "Data Source=(local);Initial Catalog=Northwind;Integrated Security=True";
        private SqlConnection connection;
        private MSSqlConnectionProvider connectionProvider;
        private Session workSession;
        private Dictionary<string, DynamicDataTableClassInfo> dynamicClasses;
        public Form1() {
            InitializeComponent();
            Init();
        }
        protected void Init() {
            connection = new SqlConnection(connectionString);
            connectionProvider = new MSSqlConnectionProvider(connection, AutoCreateOption.None);
            IDataLayer dal = new SimpleDataLayer(connectionProvider);
            workSession = new Session(dal);
            string[] tablesList = connectionProvider.GetStorageTablesList();
            dynamicClasses = new Dictionary<string, DynamicDataTableClassInfo>(tablesList.Length);
            cmbTables.Properties.Items.AddRange(tablesList);
            cmbTables.SelectedIndexChanged += delegate(object sender, EventArgs args) {
                FillGrid(cmbTables.Text);
            };
        }
        protected void FillGrid(string tableName) {
            grdTableBrowser.DataSource = null;
            gridView1.OptionsBehavior.Editable = false;
            gridView1.Columns.Clear();
            SqlDataAdapter adapter = new SqlDataAdapter(string.Format("SELECT * FROM [{0}]", tableName), connection);
            DataTable dataTable = new DataTable(tableName);
            adapter.FillSchema(dataTable, SchemaType.Source);
            DynamicDataTableClassInfo dataTableClassInfo;
            if (!dynamicClasses.TryGetValue(tableName, out dataTableClassInfo)) {
                dynamicClasses.Add(tableName, new DynamicDataTableClassInfo(workSession.Dictionary, dataTable));
            }
            XPServerCollectionSource dataSource = new XPServerCollectionSource(workSession, dynamicClasses[tableName]);
            grdTableBrowser.DataSource = dataSource;
            //grdTableBrowser.ServerMode = true;
            grdTableBrowser.ForceInitialize();
        }
    }
}