using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Data;
using ENTITY;


namespace DAL
{
    public class DebtCollectorRepository
    {
        private OracleConnection Connection;
        IList<debtCollector> debtCollectors = new List<debtCollector>();
        public DebtCollectorRepository(OracleConnection connection)
        {
            Connection = connection;
        }

        public debtCollector Map(OracleDataReader reader)
        {
            var collector = new debtCollector();
            collector.ID = (string)reader["ID"];
            collector.FirstName = (string)reader["FirstName"];
            collector.SecondName = (string)reader["SecondName"];
            collector.LastName = (string)reader["LastName"];
            collector.BirthDate = (DateTime)reader["BirthDate"];
            collector.RegistrationDate = (DateTime)reader["RegistrationDate"];
            collector.ZoneWork = (string)reader["ZoneWork"];
            collector.MoneyCharge = (double)reader["MoneyCharge"];
            return collector;
        }

        public void Save(debtCollector collector)
        {
            using (var command = Connection.CreateCommand())
            {
                command.CommandText = "PKG_INSERTA.INSERTA_DEBTCOLLECTOR";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(":ID", OracleDbType.Varchar2).Value = collector.ID;
                command.Parameters.Add(":FirstName", OracleDbType.Varchar2).Value = collector.FirstName;
                command.Parameters.Add(":SecondName", OracleDbType.Varchar2).Value = collector.SecondName;
                command.Parameters.Add(":LastName", OracleDbType.Varchar2).Value = collector.LastName;
                command.Parameters.Add(":BirthDate", OracleDbType.Date).Value = collector.BirthDate;
                command.Parameters.Add(":RegistrationDate", OracleDbType.Date).Value = collector.RegistrationDate;
                command.Parameters.Add(":ZoneWork", OracleDbType.Varchar2).Value = collector.ZoneWork;
                command.Parameters.Add(":MoneyCharge", OracleDbType.Varchar2).Value = collector.MoneyCharge;
                command.ExecuteNonQuery();


            }
        }
    }
}
