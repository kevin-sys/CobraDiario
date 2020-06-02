using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;
using Oracle.ManagedDataAccess.Client;



namespace BLL
{
    public class DebtCollectorService
    {
        DebtCollectorRepository repository;
        OracleConnection Connection;
        public DebtCollectorService()
        {


            string ConnectionString = " DATA SOURCE = localhost:1521 / xepdb1; USER ID = KEVIN;Password=admin";

            Connection = new OracleConnection(ConnectionString);
            repository = new DebtCollectorRepository(Connection);
        }

        public class Answer
        {
            public IList<debtCollector> debtCollectors { get; set; }
            public string Message { get; set; }
            public bool IsError { get; set; }
        }

        public Answer Save(debtCollector collector)
        {
            var answer = new Answer();
            answer.IsError = false;
            try
            {
                Connection.Open();
                repository.Save(collector);
                answer.Message = $"Se registro satisfactoriamente al cobradiario {collector.FirstName}";
                return answer;
            }
            catch (Exception e)
            {
                Connection.Close();
                answer.IsError = true;
                answer.Message = "Error de Base de Datos:" + e.Message.ToString();
                return answer;
            }
            finally
            {
                Connection.Close();
            }
        }
    }
}
