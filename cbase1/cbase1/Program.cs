using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using Dapper;

namespace cbase1
{
    class Program
    {
        
        static void Main(string[] args)

        {
            List<RtrItemAggModel> rtrData = new List<RtrItemAggModel>();
            OracleConnection oc = new OracleConnection();
            Startup s = new Startup();
            oc = s.GetOracleConnect();
            try
            {
                oc.Open();
                using (var _bucket = s.GetCouchBaseConnect().OpenBucket("RT_ITEM_AGG"))
                {
                    Couchbase.Document<RtrItemAggModel> doc = new Couchbase.Document<RtrItemAggModel>();
                    OracleCommand cmd = oc.CreateCommand();
                    

                    rtrData = oc.Query<RtrItemAggModel>("select * from npm2admin.vu_rtr_item_agg").ToList();
                    foreach (RtrItemAggModel rowdata in rtrData)
                    {
                        
                        doc.Id = rowdata.DocId;
                        doc.Content = rowdata;
                        var result = _bucket.Upsert(doc);
                        

                        try
                        {
                            cmd.CommandText = "DELETE FROM NPM2ADMIN.BATCH_DATA ba WHERE ba.key.key1 = '" + rowdata.AggRowId+"'";
                            cmd.CommandType = System.Data.CommandType.Text;
                            var i = cmd.ExecuteNonQuery();
                        }
                        catch(OracleException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        
                    }

                    oc.Close();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }           
          
        }
       
    }
}
