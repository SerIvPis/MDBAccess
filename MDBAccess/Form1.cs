using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryMDB;
using LibraryMDB.MDBDataSetTableAdapters;

namespace MDBAccess
{
    //Перечесление используемых таблиц
    enum tableEnum
    {
        Projs,
        Registry,
        ECO_CONT,
        ECO_ATTR
    }

    public partial class Form1 : Form
    {
       
        // Словарь вида таблица > datatable, dataAdapter
        private Dictionary<tableEnum, Tuple< object, object>> AdapterTableDictionary =
                new Dictionary<tableEnum, Tuple<object, object>>
                {
                    { tableEnum.Registry, Tuple.Create((object)new MDBDataSet.REGISTRYDataTable( ),
                                                        (object ) new REGISTRYTableAdapter( )) },
                    { tableEnum.Projs, Tuple.Create((object)new MDBDataSet.PROJSDataTable( ),
                                                        (object ) new PROJSTableAdapter( )) },
                    { tableEnum.ECO_CONT, Tuple.Create((object)new MDBDataSet.ECO_CONTDataTable( ),
                                                        (object ) new ECO_CONTTableAdapter( )) },
                    { tableEnum.ECO_ATTR, Tuple.Create((object)new MDBDataSet.ECO_ATTRDataTable( ),
                                                        (object ) new ECO_ATTRTableAdapter( )) }

                };
    
        public Form1( )
        {
            InitializeComponent( );
            InitComboBox( );
        }

        /// <summary>
        /// Заполнить combobox названиями таблиц
        /// </summary>
        private void InitComboBox( )
        {
            foreach (var item in AdapterTableDictionary.Select( p => p.Key ))
            {
                comboBoxSelectTable.Items.Add( item );
            }
            comboBoxSelectTable.SelectedIndex = 0;
        }

        private void button1_Click( object sender, EventArgs e )
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog( ))
            {
                openFileDialog.InitialDirectory = "d:\\";
                openFileDialog.Filter = "MDB files (*.mdb)|*.mdb|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog( ) == DialogResult.OK)
                {
                    //Get the path of specified file
                    textBoxPathDB.Text = openFileDialog.FileName;
                }
            }
        }

        private void comboBoxSelectTable_SelectionChangeCommitted( object sender, EventArgs e )
        {
           
        }

        private void buttonViewTable_Click( object sender, EventArgs e )
        {

        }

        private void buttonRegistry_Click( object sender, EventArgs e )
        {
            MDBDataSet.REGISTRYDataTable table = (MDBDataSet.REGISTRYDataTable)AdapterTableDictionary[ tableEnum.Registry ].Item1;
            REGISTRYTableAdapter dAdapter = (REGISTRYTableAdapter)AdapterTableDictionary[ tableEnum.Registry ].Item2;
            dAdapter.Fill( table );
            dataGridView1.DataSource = table;
        }

        private void buttonProjs_Click( object sender, EventArgs e )
        {
            MDBDataSet.PROJSDataTable table = (MDBDataSet.PROJSDataTable)AdapterTableDictionary[ tableEnum.Projs ].Item1;
            PROJSTableAdapter dAdapter = (PROJSTableAdapter)AdapterTableDictionary[ tableEnum.Projs ].Item2;
            dAdapter.Fill( table );
            dataGridView1.DataSource = table;
        }

        private void buttonECO_ATTR_Click( object sender, EventArgs e )
        {
            MDBDataSet.ECO_ATTRDataTable table = (MDBDataSet.ECO_ATTRDataTable)AdapterTableDictionary[ tableEnum.ECO_ATTR ].Item1;
            ECO_ATTRTableAdapter dAdapter = (ECO_ATTRTableAdapter)AdapterTableDictionary[ tableEnum.ECO_ATTR ].Item2;
            dAdapter.Fill( table );
            dataGridView1.DataSource = table;
        }

        private void buttonECO_Cont_Click( object sender, EventArgs e )
        {
            MDBDataSet.ECO_CONTDataTable table = (MDBDataSet.ECO_CONTDataTable)AdapterTableDictionary[ tableEnum.ECO_CONT ].Item1;
            ECO_CONTTableAdapter dAdapter = (ECO_CONTTableAdapter)AdapterTableDictionary[ tableEnum.ECO_CONT ].Item2;
            dAdapter.Fill( table );
            dataGridView1.DataSource = table;
        }

        private void button3_Click( object sender, EventArgs e )
        {

        }

        private void button5_Click( object sender, EventArgs e )
        {

        }
    }
}
