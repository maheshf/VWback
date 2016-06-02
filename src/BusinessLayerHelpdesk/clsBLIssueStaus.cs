using System;
using System.Data;
using System.Data.SqlClient;
using DataLayerHelpDesk;
using ModelHelpdesk;
using V2.CommonServices.Exceptions;
using V2.CommonServices.FileLogger;

namespace V2.Helpdesk.BusinessLayer
{
	/// <summary>
	/// Summary description for clsBLIssueStaus.
	/// </summary>
	public class clsBLIssueStaus
	{
		clsIssueStatus objclsIssueStatus ;
		clsDlIssueStatus objclsDlIssueStatus;

		
		public clsBLIssueStaus()
		{
			try
			{
			objclsDlIssueStatus = new clsDlIssueStatus() ;
			objclsIssueStatus = new clsIssueStatus ();
		}
			catch(V2Exceptions ex)
			{
				throw ;
			}

			catch(System.Exception ex)
			{
                
				FileLog objFileLog = FileLog.GetLogger();
				objFileLog.WriteLine(LogType.Error, ex.Message, "clsBLIssueStaus.cs", "clsBLIssueStaus", ex.StackTrace);
				throw new V2Exceptions();
			}
		}

		public DataSet getDsIssueStatus(clsIssueStatus objclsIssueStatus)
		{
			try
			{
				return objclsDlIssueStatus.getDsIssueStatus (objclsIssueStatus);
			
			}
			catch(V2Exceptions ex)
			{
				throw ;
			}

			catch(System.Exception ex)
			{
                
				FileLog objFileLog = FileLog.GetLogger();
				objFileLog.WriteLine(LogType.Error, ex.Message, "clsBLIssueStaus.cs", "getDsIssueStatus", ex.StackTrace);
				throw new V2Exceptions();
			}
		}
        public DataSet getYears()
        {
            try
            {
                return objclsDlIssueStatus.getYears();

            }
            catch (V2Exceptions ex)
            {
                throw;
            }

            catch (System.Exception ex)
            {

                FileLog objFileLog = FileLog.GetLogger();
                objFileLog.WriteLine(LogType.Error, ex.Message, "clsBLIssueStaus.cs", "getYears", ex.StackTrace);
                throw new V2Exceptions();
            }
        }

		public DataSet BindData(clsIssueStatus objclsIssueStatus)
		{
			try
			{
				return objclsDlIssueStatus.BindData (objclsIssueStatus);
			
			}
			catch(V2Exceptions ex)
			{
				throw ;
			}

			catch(System.Exception ex)
			{
                
				FileLog objFileLog = FileLog.GetLogger();
				objFileLog.WriteLine(LogType.Error, ex.Message, "clsBLIssueStaus.cs", "BindData", ex.StackTrace);
				throw new V2Exceptions();
			}
		}
		
	}
}
