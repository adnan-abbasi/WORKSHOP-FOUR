using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************************
 AUTHER: ADNAN ABBASI
 DATE:MARCH 30,2019
 PURPOSE: TO DEAL WITH THE DATABSE OPERATIONS RELATED TO PACKAGE      
 ************************************************************/

namespace TravelExpertsAdmin
{
    public static class PackagesDB
    {
        // TO display all packages
        public static DataTable GetAllPackages()

         {
            DataTable pkgtable = new DataTable();
                     
           

                SqlConnection conn = TravelExpertsDB.GetConnection();
                conn.Open();
                try
                {
                    string statement = "SELECT * FROM Packages ";
                SqlCommand comm = new SqlCommand(statement, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(comm);
                adapter.Fill(pkgtable);
            
                
                // concurrency error catch
            }
            catch(Exception ex)
                {
                throw ex;
                }
            finally { conn.Close(); }
            

            return pkgtable;

                    }
   //**************************************************************************************************************************
        //THIS METHOD IS RESPONSIBLE TO GET A SPECIFIC OBJECT AND LOAD IT IN A LIST OF TYPE PACKAGE

        public static Packages GetPackageById(int pkgId)

        {
            
                  Packages pkg = new Packages();

            SqlConnection connection = TravelExpertsDB.GetConnection();
            
                string statement = "SELECT * FROM Packages where PackageId=@pkgId";
                SqlCommand cmd = new SqlCommand(statement, connection);
                cmd.Parameters.AddWithValue("@pkgId", pkgId);
               
                try
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
                    if (reader.Read()) // we have  a customer
                    {
                    pkg.PkgId=(int)reader["PackageId"];
                    pkg.PkgName = reader["PkgName"].ToString();
                    pkg.PkgSartDate = reader["PkgStartDate"].ToString();
                    pkg.PkgEndDate = reader["PkgEndDate"].ToString();
                    pkg.PkgDescription = reader["PkgDesc"].ToString();
                    pkg.PkgBasePrice = (decimal)reader["PkgBasePrice"];
                    pkg.PkgAgencyCommition =(decimal) reader["PkgAgencyCommission"];
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }

                return pkg;
            }
  //**************************************************************************************************************************

        //THIS METHOD IS RESPONSIBLE TO GET THE LIST OF ALL PACKAGE ID FOR DROP DOWN LIST.
        /// <summary>
        /// 
        /// </summary>
        /// <returns>integer List</returns>
        public static List<int> GetAllPacakgeIds()
        {
            List<int> listOfPackageId = new List<int>(); // empty  INT  orderid List


            // createction
            SqlConnection connection = TravelExpertsDB.GetConnection();

            // create command object
            string selectStatement = "SELECT PackageId from Packages";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();
                SqlDataReader dr = selectCommand.ExecuteReader();

                while (dr.Read())// read next row of data
                {

                    listOfPackageId.Add((int)dr["PackageId"]);

                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return listOfPackageId;
        }
//**************************************************************************************************************************
        // TO ADD A NEW PACKAGE
        public static bool AddNewPackage(Packages newPackage)
        {
            bool success = true;
            SqlConnection con = TravelExpertsDB.GetConnection();
           
            string AddStatement = "INSERT INTO PACKAGES([PkgName],"+
                " [PkgStartDate], [PkgEndDate], [PkgDesc], "+
                "[PkgBasePrice], [PkgAgencyCommission] )"+
                "VALUES(@NewName, @NewPkgStartDate, @NewPKgEndDate, @NewPkgDesc, @NewPkgBasePrice,@NewPkgAgencyCommission)";

            SqlCommand cmd = new SqlCommand(AddStatement, con);

            cmd.Parameters.AddWithValue("@NewName", newPackage.PkgName);
            cmd.Parameters.AddWithValue("@NewPkgStartDate", newPackage.PkgSartDate);
            cmd.Parameters.AddWithValue("@NewPKgEndDate", newPackage.PkgEndDate);
            cmd.Parameters.AddWithValue("@NewPkgDesc", newPackage.PkgDescription);
            cmd.Parameters.AddWithValue("@NewPkgBasePrice", newPackage.PkgBasePrice);
            cmd.Parameters.AddWithValue("@NewPkgAgencyCommission", newPackage.PkgAgencyCommition);

           
            try
            {
                con.Open();
                int rowsUpdated = cmd.ExecuteNonQuery();
                if (rowsUpdated == 0) success = false; // did not update (another user updated or deleted)
            }
            catch (Exception ex)
            {
                throw ex;// add date validation.
            }
            finally
            {
                con.Close();
            }

            return success;
        }
//**************************************************************************************************************************

        // THIS METHOD IS RESPONSIBLE TO UPDATE ANY FIELD IN PACKAGES EXCEPTE THE ID

        public static bool UpdatePackage(Packages oldPackage, Packages newPackage)
        {
            bool success = true;
            SqlConnection con = TravelExpertsDB.GetConnection();
           
            string updateStatement = "UPDATE Packages SET " +
                                     "PkgName = @NewName, " +
                                     "PkgStartDate = @NewPkgStartDate, " +
                                     "PkgEndDate = @NewPKgEndDate, " +
                                     "PkgDesc = @NewPkgDesc, " +
                                     "PkgBasePrice = @NewPkgBasePrice, " +
                                     "PkgAgencyCommission = @NewPkgAgencyCommission " +
                                     "WHERE PackageId = @OldPackageID  " + // to identify record to update
                                                                              // remaining conditions for optimistic concurrency
                                     " AND PkgName = @OldName " +
                                     " AND PkgStartDate = @OldPkgStartDate " +
                                     " AND PkgEndDate = @OldPKgEndDate " +
                                     "AND PkgDesc = @OldPkgDesc " +
                                     "AND PkgBasePrice = @OldPkgBasePrice " +
                                     "AND PkgAgencyCommission = @OldPkgAgencyCommission ";

            SqlCommand cmd = new SqlCommand(updateStatement, con);

            cmd.Parameters.AddWithValue("@NewName", newPackage.PkgName);
            cmd.Parameters.AddWithValue("@NewPkgStartDate", newPackage.PkgSartDate);
            cmd.Parameters.AddWithValue("@NewPKgEndDate", newPackage.PkgEndDate);
            cmd.Parameters.AddWithValue("@NewPkgDesc", newPackage.PkgDescription);
            cmd.Parameters.AddWithValue("@NewPkgBasePrice", newPackage.PkgBasePrice);
            cmd.Parameters.AddWithValue("@NewPkgAgencyCommission", newPackage.PkgAgencyCommition);

            cmd.Parameters.AddWithValue("@OldPackageID", oldPackage.PkgId);
            cmd.Parameters.AddWithValue("@OldName", oldPackage.PkgName);
            cmd.Parameters.AddWithValue("@OldPkgStartDate", oldPackage.PkgSartDate);
            cmd.Parameters.AddWithValue("@OldPKgEndDate", oldPackage.PkgEndDate);
            cmd.Parameters.AddWithValue("@OldPkgDesc", oldPackage.PkgDescription);
            cmd.Parameters.AddWithValue("@OldPkgBasePrice", oldPackage.PkgBasePrice);
            cmd.Parameters.AddWithValue("@OldPkgAgencyCommission", oldPackage.PkgAgencyCommition);

            try
            {
                con.Open();
                int rowsUpdated = cmd.ExecuteNonQuery();
                if (rowsUpdated == 0) success = false; // did not update (another user updated or deleted)
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return success;
        }

    }
}
