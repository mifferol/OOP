using System;
using System.Data.OleDb;
using System.Data;

namespace WindowsFormsApp1
{
    class DBRequest
    {
        private OleDbConnection DBCon = new OleDbConnection();
    

        public void ConnectTo(string DataSource, string InitialCatalog)
        {      
            DBCon.ConnectionString = "Provider=SQLOLEDB;"+
                                     "Integrated Security=SSPI;"+
                                     "Data Source="+DataSource+";"+
                                     "Initial Catalog="+InitialCatalog+";"+
                                     "User ID=sa; Password=";      
        try       
        {        
            DBCon.Open();
        }       
        catch(Exception e)
        {         
            throw e;       
        }    
    }

        public void Disconnect()
        {
            try 
            { 
                if (DBCon.State == ConnectionState.Open) 
                    DBCon.Close(); 
            } 
            catch { } 
        }

        public string GetTableFields(string TableName)
        {
            if (DBCon.State == ConnectionState.Open){ 
                DataTable CurTable = new DataTable("ConnectedTab");
                OleDbDataAdapter DBAdapt;
                try 
                { 
                    DBAdapt = new OleDbDataAdapter("SELECT * FROM " + TableName, DBCon);
                    DBAdapt.Fill(CurTable); 
                }
                catch (Exception e) 
                { 
                    throw e; 
                } 
                string ResStr = ""; 
                int ColCount = CurTable.Columns.Count; 
                for (int i = 0; i < ColCount; i++) 
                {
                    string StrCon = ", ";
                    if (i == ColCount - 1) 
                        StrCon = ";";
                        ResStr += CurTable.Columns[i].ColumnName + "[" + CurTable.Columns[i].DataType.Name + "]" + StrCon;
                } 
                return ResStr;
            }       
            else return null;
        }

    }
}
