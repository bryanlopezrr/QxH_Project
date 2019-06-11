using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
using Couchbase.Configuration.Client;
using Couchbase.Authentication;
using Couchbase.N1QL;

namespace cbase1
{
    class Startup
    {
        OracleConnection oc = new OracleConnection();
        public Startup()
        {
            
        }

        //Create Oracle connection
        internal OracleConnection GetOracleConnect()
        {
            try
            {
                OracleConnectionStringBuilder cb = new OracleConnectionStringBuilder();
                cb.DataSource = ConfigurationManager.AppSettings["DataSource"];
                cb.LoadBalancing = true;
                cb.Pooling = true;
                cb.UserID = "npm2admin";
                cb.Password = "npm2.321";
                oc.ConnectionString = cb.ConnectionString;
                return oc;
            }
            catch (OracleException ex)
            {
                throw ex;
            }
        }

        //Create Couchbase connection
        internal Couchbase.Cluster GetCouchBaseConnect()
        {
         
            var cluster = new Couchbase.Cluster(new ClientConfiguration
            {
                Servers = new List<Uri> { new Uri("http://172.21.254.119:8091") }
            });
            var authenticator = new PasswordAuthenticator("DBAUser", "ILikeSQL!");
            cluster.Authenticate(authenticator);
            return cluster;

        }
    }
}
