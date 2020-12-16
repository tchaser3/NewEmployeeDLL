/* Title:           Employee Class
 * Date:            4-24-17
 * Author:          Terry Holmes
 * 
 * Description:     This is for the employee Class */

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

namespace NewEmployeeDLL
{
    public class EmployeeClass
    {
        //setting up the class
        EventLogClass TheEventLogClass = new EventLogClass();

        //setting up the data
        EmployeesDataSet aEmployeesDataSet;
        EmployeesDataSet TheEmployeesDataSet;
        EmployeesDataSetTableAdapters.employeesTableAdapter aEmployeesTableAdapter;

        EmployeeGroupDataSet aEmployeeGroupDataSet;
        EmployeeGroupDataSetTableAdapters.employeegroupTableAdapter aEmployeeGroupTableAdapter;

        EmployeeIDDataSet aEmployeeIDDataSet;
        EmployeeIDDataSetTableAdapters.employeeidTableAdapter aEmployeeIDTableAdapter;

        FindActiveEmployeesDataSet aFindActiveEmployeesDataSet;
        FindActiveEmployeesDataSetTableAdapters.FindActiveEmployeesTableAdapter aFindActiveEmployeesTableAdapter;

        FindEmployeeByEmployeeIDDataSet aFindEmployeeByEmployeeIDDataSet;
        FindEmployeeByEmployeeIDDataSetTableAdapters.FindEmployeeByEmployeeIDTableAdapter aFindEmployeeByEmployeeIDTableAdapter;

        FindEmployeeByLastNameDataSet aFindEmployeeByLastNameDataSet;
        FindEmployeeByLastNameDataSetTableAdapters.FindEmployeeByLastNameTableAdapter aFindEmployeeByLastNameTableAdapter;

        FindEmployeesByGroupDataSet aFindEmployeesByGroupDataSet;
        FindEmployeesByGroupDataSetTableAdapters.FindEmployeesByGroupTableAdapter aFindEmployeesByGroupTableAdapter;

        FindPartsWarehousesDataSet aFindPartsWarehouseDataSet;
        FindPartsWarehousesDataSetTableAdapters.FindPartsWarehousesTableAdapter aFindPartsWarehouseTableAdapter;

        FindWarehousesDataSet aFindWarehousesDataSet;
        FindWarehousesDataSetTableAdapters.FindWarehousesTableAdapter aFindWarehousesTableAdapter;

        VerifyEmployeeDataSet aVerifyEmployeeDataSet;
        VerifyEmployeeDataSetTableAdapters.VerifyEmployeeTableAdapter aVerifyEmployeeTableAdapter;

        VerifyLogonDataSet aVerifyLogonDataSet;
        VerifyLogonDataSetTableAdapters.VerifyLogonTableAdapter aVerifyLogonTableAdapter;

        FindEmployeeGroupByGroupIDDataSet aFindEmployeeGroupByGroupIDDataSet;
        FindEmployeeGroupByGroupIDDataSetTableAdapters.FindEmployeeGroupByGroupIDTableAdapter aFindEmployeeGroupByGroupIDTableAdapter;

        FindEmployeeGroupByGroupNameDataSet aFindEmployeeGroupByGroupNameDataSet;
        FindEmployeeGroupByGroupNameDataSetTableAdapters.FindEmployeeGroupByGroupNameTableAdapter aFindEmployeeGroupByGroupNameTableAdapter;

        InsertEmployeeGroup aInsertEmployeeGroup;
        InsertEmployeeGroupTableAdapters.QueriesTableAdapter aInsertEmployeeGroupTableAdapter;

        ComboEmployeeDataSet aComboEmployeeDataSet = new ComboEmployeeDataSet();
        FindEmployeeByLastNameDataSet TheFindEmployeeByLastNameDataSet = new FindEmployeeByLastNameDataSet();

        FindAllEmployeesByLastNameDataSet aFindAllEmployeesByLastNameDataSet;
        FindAllEmployeesByLastNameDataSetTableAdapters.FindAllEmployeeByLastNameTableAdapter aFindAllEmployeesByLastNameTableAdapter;

        FindSortedEmployeeGroupDataSet aFindSortedEmployeeGroupDataSet;
        FindSortedEmployeeGroupDataSetTableAdapters.FindSortedEmployeeGroupTableAdapter aFindSortedEmployeeGroupTableAdapter;

        InsertEmployeeEntryTableAdapters.QueriesTableAdapter aInsertEmployeeTableAdapter;

        UpdateEmployeeEntryTableAdapters.QueriesTableAdapter aUpdateEmployeeTableAdapter;

        DeactivateEmployeeEntryTableAdapters.QueriesTableAdapter aDeactivateEmployeeTableAdapter;

        FindDeactivatedEmployeesDataSet aFindDeactivatedEmployeesDataSet;
        FindDeactivatedEmployeesDataSetTableAdapters.FindDeactivatedEmployeesTableAdapter aFindDeactivatedEmployeesTableAdapter;

        UpdateEmployeeEmailAddressEntryTableAdapters.QueriesTableAdapter aUpdateEmployeeEmailAddressTableAdapter;

        FindEmployeeEmailAddressDataSet aFindEmployeeEmailAddressDataSet;
        FindEmployeeEmailAddressDataSetTableAdapters.FindEmployeeEmailAddressTableAdapter aFindEmployeeEmailAddressTableAdapter;

        FindSortedEmployeeManagersDataSet aFindSortedEmployeeManagersDataSet;
        FindSortedEmployeeManagersDataSetTableAdapters.FindSortedEmployeeManagersTableAdapter aFindSortedEmployeeManagersTableAdapter;

        UpdateEmployeePayInformationEntryTableAdapters.QueriesTableAdapter aUpdateEmployeePayInformationTableAdapter;

        FindAllActiveEmployeeInformationDataSet aFindAllActiveEmployeeInformationDataSet;
        FindAllActiveEmployeeInformationDataSetTableAdapters.FindAllActiveEmployeeInformationTableAdapter aFindAllActiveEmployeeInformationTableAdapter;

        FindActiveNonExemptEmployeesDataSet aFindActiveNonExemptEmployeesDataSet;
        FindActiveNonExemptEmployeesDataSetTableAdapters.FindActiveNonExemptEmployeesTableAdapter aFindActiveNonExemptEmployeesTableAdapter;

        FindEmployeeByPayIDDataSet aFindEmployeebyPayIDDataSet;
        FindEmployeeByPayIDDataSetTableAdapters.FindEmployeeByPayIDTableAdapter aFindEmployeeByPayIDTableAdapter;

        UpdateEmployeeEndDateEntryTableAdapters.QueriesTableAdapter aUpdateEmployeeEndDateTableAdapter;

        UpdateEmployeeStartDateEntryTableAdapters.QueriesTableAdapter aUpdateEmployeeStartDateTableAdapter;

        FindAllActiveNonExemptEmployeesDataSet aFindAllActiveNonExemptEmployeesDataSet;
        FindAllActiveNonExemptEmployeesDataSetTableAdapters.FindAllActiveNonExemptEmployeesTableAdapter aFindAllActiveNonExemptEmployeesTableAdapter;

        FindActiveNonExemptEmployeesByPayDateDataSet aFindActiveNonExemptEmployeesByPayDateDataSet;
        FindActiveNonExemptEmployeesByPayDateDataSetTableAdapters.FindActiveNonExemptEmployeesByPayDateTableAdapter aFindActiveNonExemptEmployeesbyPayDateTableAdapter;

        FindEmployeeByDepartmentDataSet aFindEmployeeByDepartmentDataSet;
        FindEmployeeByDepartmentDataSetTableAdapters.FindEmployeeByDepartmentTableAdapter aFindEmployeeByDepartmentTableAdapter;

        VerifyDesignEmployeeLogonDataSet aVerifyDesignEmployeeLogonDataSet;
        VerifyDesignEmployeeLogonDataSetTableAdapters.VerifyDesigEmployeeLogonTableAdapter aVerifyDesignEmployeeLogonTableAdapter;

        FindDesignEmployeesDataSet aFindDesignEmployeesDataSet;
        FindDesignEmployeesDataSetTableAdapters.FindDesignEmployeesTableAdapter aFindDesignEmployeesTableAdapter;

        FindWarehouseByWarehouseNameDataSet aFindWarehouseByWarehouseNameDataSet;
        FindWarehouseByWarehouseNameDataSetTableAdapters.FindWarehouseByWarehouseNameTableAdapter aFindWarehouseByWarehouseNameTableAdapter;

        FindProductionManagersDataSet aFindProductionManagersDataSet;
        FindProductionManagersDataSetTableAdapters.FindProductionManagersTableAdapter aFindProductionManagersTableAdapter;

        FindSortedManagersHourlyEmployeesDataSet aFindSortedManagersHourlyEmployeesDataSet;
        FindSortedManagersHourlyEmployeesDataSetTableAdapters.FindSortedManagersHourlyEmployeesTableAdapter aFindSortedManagersHourlyEmployeesTableAdapter;

        FindEmployeesForMaterialsDataSet aFindEmployeesForMaterialsDataSet;
        FindEmployeesForMaterialsDataSetTableAdapters.FindEmployeesForMaterialsTableAdapter aFindEmployeesForMaterialsTableAdapter;

        FindEmployeeManagerForLastYearDataSet aFindEmployeeManagerForLastYearDataSet;
        FindEmployeeManagerForLastYearDataSetTableAdapters.FindEmployeeManagersForLastYearTableAdapter aFindEmployeeManagerForLastYearTableAdapter;

        FindEmployeesForDataEntryForLastYearDataSet aFindEmployeesForDataEntryForLastYearDataSet;
        FindEmployeesForDataEntryForLastYearDataSetTableAdapters.FindEmployeesForDataEntryForLastYearTableAdapter aFindEmployeesForDataEntryForLastYearTableAdapter;

        FindEmployeeByLastNameEndDateDataSet aFindEmployeeByLastNameEndDateDataSet;
        FindEmployeeByLastNameEndDateDataSetTableAdapters.FindEmployeesByLastNameEndDateTableAdapter aFindEmployeeByLastNameEndDateTableAdapter;

        public FindEmployeeByLastNameEndDateDataSet FindEmployeeByLastNameEndDate(string strLastName, DateTime datEndDate)
        {
            try
            {
                aFindEmployeeByLastNameEndDateDataSet = new FindEmployeeByLastNameEndDateDataSet();
                aFindEmployeeByLastNameEndDateTableAdapter = new FindEmployeeByLastNameEndDateDataSetTableAdapters.FindEmployeesByLastNameEndDateTableAdapter();
                aFindEmployeeByLastNameEndDateTableAdapter.Fill(aFindEmployeeByLastNameEndDateDataSet.FindEmployeesByLastNameEndDate, strLastName, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "The Employee Class // Find Employee By Last Name End Date " + Ex.Message);

            }

            return aFindEmployeeByLastNameEndDateDataSet;
        }
        public FindEmployeesForDataEntryForLastYearDataSet FindEmployeesForDataEntryForLastYear(DateTime datStartDate, string strLastName)
        {
            try
            {
                aFindEmployeesForDataEntryForLastYearDataSet = new FindEmployeesForDataEntryForLastYearDataSet();
                aFindEmployeesForDataEntryForLastYearTableAdapter = new FindEmployeesForDataEntryForLastYearDataSetTableAdapters.FindEmployeesForDataEntryForLastYearTableAdapter();
                aFindEmployeesForDataEntryForLastYearTableAdapter.Fill(aFindEmployeesForDataEntryForLastYearDataSet.FindEmployeesForDataEntryForLastYear, datStartDate, strLastName);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Class // Find Employees For Data entry For Last Year " + Ex.Message);
            }

            return aFindEmployeesForDataEntryForLastYearDataSet;
        }
        public FindEmployeeManagerForLastYearDataSet FindEmployeeManagerForLastYear(DateTime datStartDate)
        {
            try
            {
                aFindEmployeeManagerForLastYearDataSet = new FindEmployeeManagerForLastYearDataSet();
                aFindEmployeeManagerForLastYearTableAdapter = new FindEmployeeManagerForLastYearDataSetTableAdapters.FindEmployeeManagersForLastYearTableAdapter();
                aFindEmployeeManagerForLastYearTableAdapter.Fill(aFindEmployeeManagerForLastYearDataSet.FindEmployeeManagersForLastYear, datStartDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Class // Find Employee Manager For Last Year " + Ex.Message);
            }

            return aFindEmployeeManagerForLastYearDataSet;
        }
        public FindEmployeesForMaterialsDataSet FindEmployeesForMaterials(string strLastName)
        {
            try
            {
                aFindEmployeesForMaterialsDataSet = new FindEmployeesForMaterialsDataSet();
                aFindEmployeesForMaterialsTableAdapter = new FindEmployeesForMaterialsDataSetTableAdapters.FindEmployeesForMaterialsTableAdapter();
                aFindEmployeesForMaterialsTableAdapter.Fill(aFindEmployeesForMaterialsDataSet.FindEmployeesForMaterials, strLastName);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Class // Find Employees For Materials " + Ex.Message);
            }

            return aFindEmployeesForMaterialsDataSet;
        }
        public FindSortedManagersHourlyEmployeesDataSet FindSortedManagersHourlyEmployees(int intManagerID)
        {
            try
            {
                aFindSortedManagersHourlyEmployeesDataSet = new FindSortedManagersHourlyEmployeesDataSet();
                aFindSortedManagersHourlyEmployeesTableAdapter = new FindSortedManagersHourlyEmployeesDataSetTableAdapters.FindSortedManagersHourlyEmployeesTableAdapter();
                aFindSortedManagersHourlyEmployeesTableAdapter.Fill(aFindSortedManagersHourlyEmployeesDataSet.FindSortedManagersHourlyEmployees, intManagerID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Class // Find Sorted Managers Hourly Employees " + Ex.Message);
            }

            return aFindSortedManagersHourlyEmployeesDataSet;
        }
        public FindProductionManagersDataSet FindProductionManagers()
        {
            try
            {
                aFindProductionManagersDataSet = new FindProductionManagersDataSet();
                aFindProductionManagersTableAdapter = new FindProductionManagersDataSetTableAdapters.FindProductionManagersTableAdapter();
                aFindProductionManagersTableAdapter.Fill(aFindProductionManagersDataSet.FindProductionManagers);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Class // Find Production Managers " + Ex.Message);
            }

            return aFindProductionManagersDataSet;
        }
        public FindWarehouseByWarehouseNameDataSet FindWarehouseByWarehouseName(string strWarehouseName)
        {
            try
            {
                aFindWarehouseByWarehouseNameDataSet = new FindWarehouseByWarehouseNameDataSet();
                aFindWarehouseByWarehouseNameTableAdapter = new FindWarehouseByWarehouseNameDataSetTableAdapters.FindWarehouseByWarehouseNameTableAdapter();
                aFindWarehouseByWarehouseNameTableAdapter.Fill(aFindWarehouseByWarehouseNameDataSet.FindWarehouseByWarehouseName, strWarehouseName);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Class // Find Warehouse By Warehouse Name " + Ex.Message);
            }

            return aFindWarehouseByWarehouseNameDataSet;
        }
        public FindDesignEmployeesDataSet FindDesignEmployees()
        {
            try
            {
                aFindDesignEmployeesDataSet = new FindDesignEmployeesDataSet();
                aFindDesignEmployeesTableAdapter = new FindDesignEmployeesDataSetTableAdapters.FindDesignEmployeesTableAdapter();
                aFindDesignEmployeesTableAdapter.Fill(aFindDesignEmployeesDataSet.FindDesignEmployees);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employees Class // Find Design Employees " + Ex.Message);
            }

            return aFindDesignEmployeesDataSet;
        }
        public VerifyDesignEmployeeLogonDataSet VerifyDesignEmployeeLogon(int intEmployeeID, string strLastName)
        {
            try
            {
                aVerifyDesignEmployeeLogonDataSet = new VerifyDesignEmployeeLogonDataSet();
                aVerifyDesignEmployeeLogonTableAdapter = new VerifyDesignEmployeeLogonDataSetTableAdapters.VerifyDesigEmployeeLogonTableAdapter();
                aVerifyDesignEmployeeLogonTableAdapter.Fill(aVerifyDesignEmployeeLogonDataSet.VerifyDesigEmployeeLogon, intEmployeeID, strLastName);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Class // Verify Design Employee Logon " + Ex.Message);
            }

            return aVerifyDesignEmployeeLogonDataSet;
        }
        public FindEmployeeByDepartmentDataSet FindEmployeeByDepartment(string strDepartment)
        {
            try
            {
                aFindEmployeeByDepartmentDataSet = new FindEmployeeByDepartmentDataSet();
                aFindEmployeeByDepartmentTableAdapter = new FindEmployeeByDepartmentDataSetTableAdapters.FindEmployeeByDepartmentTableAdapter();
                aFindEmployeeByDepartmentTableAdapter.Fill(aFindEmployeeByDepartmentDataSet.FindEmployeeByDepartment, strDepartment);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Class // Find Employee By Department " + Ex.Message);
            }

            return aFindEmployeeByDepartmentDataSet;
        }
        public FindActiveNonExemptEmployeesByPayDateDataSet FindActiveNonExemptEmployeesByPayDate(DateTime datPayDate)
        {
            try
            {
                aFindActiveNonExemptEmployeesByPayDateDataSet = new FindActiveNonExemptEmployeesByPayDateDataSet();
                aFindActiveNonExemptEmployeesbyPayDateTableAdapter = new FindActiveNonExemptEmployeesByPayDateDataSetTableAdapters.FindActiveNonExemptEmployeesByPayDateTableAdapter();
                aFindActiveNonExemptEmployeesbyPayDateTableAdapter.Fill(aFindActiveNonExemptEmployeesByPayDateDataSet.FindActiveNonExemptEmployeesByPayDate, datPayDate);
            }
            catch(Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Class // Find Active Non Exempt Employees By Pay Date " + Ex.Message);
            }

            return aFindActiveNonExemptEmployeesByPayDateDataSet;
        }
        public FindAllActiveNonExemptEmployeesDataSet FindAllActiveNoExemptEmployees()
        {
            try
            {
                aFindAllActiveNonExemptEmployeesDataSet = new FindAllActiveNonExemptEmployeesDataSet();
                aFindAllActiveNonExemptEmployeesTableAdapter = new FindAllActiveNonExemptEmployeesDataSetTableAdapters.FindAllActiveNonExemptEmployeesTableAdapter();
                aFindAllActiveNonExemptEmployeesTableAdapter.Fill(aFindAllActiveNonExemptEmployeesDataSet.FindAllActiveNonExemptEmployees);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Class // Find All Active Non Exempt Employees " + Ex.Message);
            }

            return aFindAllActiveNonExemptEmployeesDataSet;
        }
        public bool UpdateEmployeeStartDate(int intEmployeeID, DateTime datStartDate)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateEmployeeStartDateTableAdapter = new UpdateEmployeeStartDateEntryTableAdapters.QueriesTableAdapter();
                aUpdateEmployeeStartDateTableAdapter.UpdateEmployeeStartDate(intEmployeeID, datStartDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Class // Update Employee Start Date " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateEmployeeEndDate(int intEmployeeID, DateTime datEndDate)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateEmployeeEndDateTableAdapter = new UpdateEmployeeEndDateEntryTableAdapters.QueriesTableAdapter();
                aUpdateEmployeeEndDateTableAdapter.UpdateEmployeeEndDate(intEmployeeID, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Class // Update Employee End Date " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindEmployeeByPayIDDataSet FindEmployeeByPayID(int intPayID)
        {
            try
            {
                aFindEmployeebyPayIDDataSet = new FindEmployeeByPayIDDataSet();
                aFindEmployeeByPayIDTableAdapter = new FindEmployeeByPayIDDataSetTableAdapters.FindEmployeeByPayIDTableAdapter();
                aFindEmployeeByPayIDTableAdapter.Fill(aFindEmployeebyPayIDDataSet.FindEmployeeByPayID, intPayID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Class // Find Employee By Pay ID " + Ex.Message);
            }

            return aFindEmployeebyPayIDDataSet;
        }
        public FindActiveNonExemptEmployeesDataSet FindActiveNonExemptEmployees()
        {
            try
            {
                aFindActiveNonExemptEmployeesDataSet = new FindActiveNonExemptEmployeesDataSet();
                aFindActiveNonExemptEmployeesTableAdapter = new FindActiveNonExemptEmployeesDataSetTableAdapters.FindActiveNonExemptEmployeesTableAdapter();
                aFindActiveNonExemptEmployeesTableAdapter.Fill(aFindActiveNonExemptEmployeesDataSet.FindActiveNonExemptEmployees);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Class // Find Active Non Exempt Employees " + Ex.Message);
            }

            return aFindActiveNonExemptEmployeesDataSet;
        }
        public FindAllActiveEmployeeInformationDataSet FindAllActiveEmployeeInformation()
        {
            try
            {
                aFindAllActiveEmployeeInformationDataSet = new FindAllActiveEmployeeInformationDataSet();
                aFindAllActiveEmployeeInformationTableAdapter = new FindAllActiveEmployeeInformationDataSetTableAdapters.FindAllActiveEmployeeInformationTableAdapter();
                aFindAllActiveEmployeeInformationTableAdapter.Fill(aFindAllActiveEmployeeInformationDataSet.FindAllActiveEmployeeInformation);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Class // Find All Active Employee iNformation " + Ex.Message);
            }

            return aFindAllActiveEmployeeInformationDataSet;
        }
        public bool UpdateEmployeePayInformation(int intEmployeeID, string strDepartment, string strSalaryType, int intManagerID, int intPayID)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateEmployeePayInformationTableAdapter = new UpdateEmployeePayInformationEntryTableAdapters.QueriesTableAdapter();
                aUpdateEmployeePayInformationTableAdapter.UpdateEmployeePayInformation(intEmployeeID, strDepartment, strSalaryType, intManagerID, intPayID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Class // Update Employee Pay Information " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindSortedEmployeeManagersDataSet FindSortedEmployeeManagers()
        {
            try
            {
                aFindSortedEmployeeManagersDataSet = new FindSortedEmployeeManagersDataSet();
                aFindSortedEmployeeManagersTableAdapter = new FindSortedEmployeeManagersDataSetTableAdapters.FindSortedEmployeeManagersTableAdapter();
                aFindSortedEmployeeManagersTableAdapter.Fill(aFindSortedEmployeeManagersDataSet.FindSortedEmployeeManagers);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Class // Find Sorted Employee Managers " + Ex.Message);
            }

            return aFindSortedEmployeeManagersDataSet;
        }
        public FindEmployeeEmailAddressDataSet FindEmployeeEmailAddress(int intEmployeeID)
        {
            try
            {
                aFindEmployeeEmailAddressDataSet = new FindEmployeeEmailAddressDataSet();
                aFindEmployeeEmailAddressTableAdapter = new FindEmployeeEmailAddressDataSetTableAdapters.FindEmployeeEmailAddressTableAdapter();
                aFindEmployeeEmailAddressTableAdapter.Fill(aFindEmployeeEmailAddressDataSet.FindEmployeeEmailAddress, intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Class // Find Employees Email " + Ex.Message);
            }

            return aFindEmployeeEmailAddressDataSet;
        }
        public bool UpdateEmployeeEmailAddress(int intEmployeeID, string strEmailAddress)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateEmployeeEmailAddressTableAdapter = new UpdateEmployeeEmailAddressEntryTableAdapters.QueriesTableAdapter();
                aUpdateEmployeeEmailAddressTableAdapter.UpdateEmployeeEmailAddress(intEmployeeID, strEmailAddress);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee class // Update Employee Email Address " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindDeactivatedEmployeesDataSet FindDeactivatedEmployees()
        {
            try
            {
                aFindDeactivatedEmployeesDataSet = new FindDeactivatedEmployeesDataSet();
                aFindDeactivatedEmployeesTableAdapter = new FindDeactivatedEmployeesDataSetTableAdapters.FindDeactivatedEmployeesTableAdapter();
                aFindDeactivatedEmployeesTableAdapter.Fill(aFindDeactivatedEmployeesDataSet.FindDeactivatedEmployees);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Class // Find Deactivated Employees " + Ex.Message);
            }

            return aFindDeactivatedEmployeesDataSet;
        }
        public bool DeactivateEmployee(int intEmployeeID)
        {
            bool blnFatalError = false;

            try
            {
                aDeactivateEmployeeTableAdapter = new DeactivateEmployeeEntryTableAdapters.QueriesTableAdapter();
                aDeactivateEmployeeTableAdapter.DeactivateEmployee(intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Class // Deactivate Employee " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateEmployee(int intEmployeeID, string strFirstName, string strLastName, string strPhoneNumber, bool blnActive, string strEmployeeGroup, string strHomeOffice, string strEmployeeType, string strEmailAddress, string strSalaryType, string strDepartment, int intManagerID)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateEmployeeTableAdapter = new UpdateEmployeeEntryTableAdapters.QueriesTableAdapter();
                aUpdateEmployeeTableAdapter.UpdateEmployee(intEmployeeID, strFirstName, strLastName, strPhoneNumber, blnActive, strEmployeeGroup, strHomeOffice, strEmployeeType, strEmailAddress, strSalaryType, strDepartment, intManagerID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Class // Update Employee " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertEmployee(int intEmployeeID, string strFirstName, string strLastName, string strPhoneNumber, bool blnActive, string strEmployeeGroup, string strHomeOffice, string strEmployeeType, string strEmailAddress, string strSalaryType, string strDepartment, int intManagerID, int intPayID)
        {
            bool blnFatalError = false;

            try
            {
                aInsertEmployeeTableAdapter = new InsertEmployeeEntryTableAdapters.QueriesTableAdapter();
                aInsertEmployeeTableAdapter.InsertEmployee(intEmployeeID, strFirstName, strLastName, strPhoneNumber, blnActive, strEmployeeGroup, strHomeOffice, strEmployeeType, strEmailAddress, strSalaryType, strDepartment, intManagerID, intPayID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Class // Insert Employee " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindSortedEmployeeGroupDataSet FindSortedEmpoyeeGroup()
        {
            try
            {
                aFindSortedEmployeeGroupDataSet = new FindSortedEmployeeGroupDataSet();
                aFindSortedEmployeeGroupTableAdapter = new FindSortedEmployeeGroupDataSetTableAdapters.FindSortedEmployeeGroupTableAdapter();
                aFindSortedEmployeeGroupTableAdapter.Fill(aFindSortedEmployeeGroupDataSet.FindSortedEmployeeGroup);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Employee Class // Find Sorted Employee Group " + Ex.Message);
            }

            return aFindSortedEmployeeGroupDataSet;
        }
        public FindAllEmployeesByLastNameDataSet FindAllEmployeesByLastName(string strLastName)
        {
            try
            {
                aFindAllEmployeesByLastNameDataSet = new FindAllEmployeesByLastNameDataSet();
                aFindAllEmployeesByLastNameTableAdapter = new FindAllEmployeesByLastNameDataSetTableAdapters.FindAllEmployeeByLastNameTableAdapter();
                aFindAllEmployeesByLastNameTableAdapter.Fill(aFindAllEmployeesByLastNameDataSet.FindAllEmployeeByLastName, strLastName);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, Ex.Message);
            }

            return aFindAllEmployeesByLastNameDataSet;
        }
        public ComboEmployeeDataSet FillEmployeeComboBox(string strLastName)
        {
            //setting local variables
            int intCounter;
            int intNumberOfRecords;
            string strFullName;
            string strFirstName;
            int intEmployeeID;

            aComboEmployeeDataSet.employees.Rows.Clear();

            try
            {
                TheFindEmployeeByLastNameDataSet = FindEmployeesByLastNameKeyWord(strLastName);

                intNumberOfRecords = TheFindEmployeeByLastNameDataSet.FindEmployeeByLastName.Rows.Count - 1;

                if(intNumberOfRecords > -1)
                {
                    for(intCounter = 0; intCounter <= intNumberOfRecords; intCounter++)
                    {
                        strFirstName = TheFindEmployeeByLastNameDataSet.FindEmployeeByLastName[intCounter].FirstName;
                        intEmployeeID = TheFindEmployeeByLastNameDataSet.FindEmployeeByLastName[intCounter].EmployeeID;
                        strLastName = TheFindEmployeeByLastNameDataSet.FindEmployeeByLastName[intCounter].LastName;

                        strFullName = strFirstName + " " + strLastName;

                        ComboEmployeeDataSet.employeesRow NewEmployeeRow = aComboEmployeeDataSet.employees.NewemployeesRow();

                        NewEmployeeRow.EmployeeID = intEmployeeID;
                        NewEmployeeRow.FirstName = strFirstName;
                        NewEmployeeRow.LastName = strLastName;
                        NewEmployeeRow.FullName = strFullName;

                        aComboEmployeeDataSet.employees.Rows.Add(NewEmployeeRow);
                    }
                }
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "New Employee DLL // Fill Employee Combo Box " + Ex.Message);
            }

            return aComboEmployeeDataSet;
        }
        public FindEmployeeByLastNameDataSet FindEmployeesByLastNameKeyWord(string strLastName)
        {
            try
            {
                strLastName = "%" + strLastName + "%";

                aFindEmployeeByLastNameDataSet = new FindEmployeeByLastNameDataSet();
                aFindEmployeeByLastNameTableAdapter = new FindEmployeeByLastNameDataSetTableAdapters.FindEmployeeByLastNameTableAdapter();
                aFindEmployeeByLastNameTableAdapter.Fill(aFindEmployeeByLastNameDataSet.FindEmployeeByLastName, strLastName);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "New Employee DLL // Find Employees By Last Name Key Word // " + Ex.Message);
            }

            return aFindEmployeeByLastNameDataSet;
        }
        public FindWarehousesDataSet FindWarehouses()
        {
            try
            {
                aFindWarehousesDataSet = new FindWarehousesDataSet();
                aFindWarehousesTableAdapter = new FindWarehousesDataSetTableAdapters.FindWarehousesTableAdapter();
                aFindWarehousesTableAdapter.Fill(aFindWarehousesDataSet.FindWarehouses);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "New Employee DLL // Find Parts Warehouses // " + Ex.Message);
            }

            return aFindWarehousesDataSet;
        }
        public FindPartsWarehousesDataSet FindPartsWarehouses()
        {
            try
            {
                aFindPartsWarehouseDataSet = new FindPartsWarehousesDataSet();
                aFindPartsWarehouseTableAdapter = new FindPartsWarehousesDataSetTableAdapters.FindPartsWarehousesTableAdapter();
                aFindPartsWarehouseTableAdapter.Fill(aFindPartsWarehouseDataSet.FindPartsWarehouses);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "New Employee DLL // Find Parts Warehouses // " + Ex.Message);
            }

            return aFindPartsWarehouseDataSet;
        }
        public FindEmployeeByEmployeeIDDataSet FindEmployeeByEmployeeID(int intEmployeeID)
        {
            try
            {
                aFindEmployeeByEmployeeIDDataSet = new FindEmployeeByEmployeeIDDataSet();
                aFindEmployeeByEmployeeIDTableAdapter = new FindEmployeeByEmployeeIDDataSetTableAdapters.FindEmployeeByEmployeeIDTableAdapter();
                aFindEmployeeByEmployeeIDTableAdapter.Fill(aFindEmployeeByEmployeeIDDataSet.FindEmployeeByEmployeeID, intEmployeeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "New Employee DLL // Verify Employee // " + Ex.Message);
            }

            return aFindEmployeeByEmployeeIDDataSet;
        }
        public FindEmployeeGroupByGroupIDDataSet FindEmployeeGroupByID(int intGroupID)
        {
            try
            {
                aFindEmployeeGroupByGroupIDDataSet = new FindEmployeeGroupByGroupIDDataSet();
                aFindEmployeeGroupByGroupIDTableAdapter = new FindEmployeeGroupByGroupIDDataSetTableAdapters.FindEmployeeGroupByGroupIDTableAdapter();
                aFindEmployeeGroupByGroupIDTableAdapter.Fill(aFindEmployeeGroupByGroupIDDataSet.FindEmployeeGroupByGroupID, intGroupID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "New Employee DLL // Find Employee Group By ID // " + Ex.Message);
            }

            return aFindEmployeeGroupByGroupIDDataSet;
        }
        public FindEmployeeGroupByGroupNameDataSet FindEmployeeGroupByName(string strGroup)
        {
            try
            {
                aFindEmployeeGroupByGroupNameDataSet = new FindEmployeeGroupByGroupNameDataSet();
                aFindEmployeeGroupByGroupNameTableAdapter = new FindEmployeeGroupByGroupNameDataSetTableAdapters.FindEmployeeGroupByGroupNameTableAdapter();
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "New Employee DLL // Find Employee Group By Name // " + Ex.Message);
            }

            return aFindEmployeeGroupByGroupNameDataSet;
        }
        public bool CreateEmployeeGroup(string strGroup)
        {
            bool blnFatalError = false;

            try
            {
                aInsertEmployeeGroup = new InsertEmployeeGroup();
                aInsertEmployeeGroupTableAdapter = new InsertEmployeeGroupTableAdapters.QueriesTableAdapter();
                aInsertEmployeeGroupTableAdapter.InsertEmployeeGroup(strGroup);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "New Employee DLL // Create Employee Group // " + Ex.Message);
            }

            return blnFatalError;
        }
        public EmployeeGroupDataSet GetEmployeeGroupInfo()
        {
            try
            {
                aEmployeeGroupDataSet = new EmployeeGroupDataSet();
                aEmployeeGroupTableAdapter = new EmployeeGroupDataSetTableAdapters.employeegroupTableAdapter();
                aEmployeeGroupTableAdapter.Fill(aEmployeeGroupDataSet.employeegroup);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "New Employee DLL // Get Employee Group Info // " + Ex.Message);
            }

            return aEmployeeGroupDataSet;
        }
        public void UpdateEmployeeGroupInfo(EmployeeGroupDataSet aEmployeeGroupDataSet)
        {
            try
            {
                aEmployeeGroupTableAdapter = new EmployeeGroupDataSetTableAdapters.employeegroupTableAdapter();
                aEmployeeGroupTableAdapter.Update(aEmployeeGroupDataSet.employeegroup);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "New Employee DLL // Get Employee Group Info // " + Ex.Message);
            }
        }
        public VerifyLogonDataSet VerifyLogon(int intEmployeeID, string strLastName)
        {
            try
            {
                aVerifyLogonDataSet = new VerifyLogonDataSet();
                aVerifyLogonTableAdapter = new VerifyLogonDataSetTableAdapters.VerifyLogonTableAdapter();
                aVerifyLogonTableAdapter.Fill(aVerifyLogonDataSet.VerifyLogon, intEmployeeID, strLastName);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "New Employee DLL // Verify Employee // " + Ex.Message);
            }

            return aVerifyLogonDataSet;
        }
        public FindEmployeesByGroupDataSet FindEmployeesByGroup(string strGroup)
        {
            try
            {
                aFindEmployeesByGroupDataSet = new FindEmployeesByGroupDataSet();
                aFindEmployeesByGroupTableAdapter = new FindEmployeesByGroupDataSetTableAdapters.FindEmployeesByGroupTableAdapter();
                aFindEmployeesByGroupTableAdapter.Fill(aFindEmployeesByGroupDataSet.FindEmployeesByGroup, strGroup);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "New Employee DLL // Find Employees By Group // " + Ex.Message);
            }

            return aFindEmployeesByGroupDataSet;
        }
        public VerifyEmployeeDataSet VerifyEmployee(string strFirstName, string strLastName)
        {
            try
            {
                aVerifyEmployeeDataSet = new VerifyEmployeeDataSet();
                aVerifyEmployeeTableAdapter = new VerifyEmployeeDataSetTableAdapters.VerifyEmployeeTableAdapter();
                aVerifyEmployeeTableAdapter.Fill(aVerifyEmployeeDataSet.VerifyEmployee, strFirstName, strLastName);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "New Employee DLL // Verify Employee // " + Ex.Message);
            }

            return aVerifyEmployeeDataSet;
        }
        public FindActiveEmployeesDataSet FindActiveEmployees()
        {
            try
            {
                aFindActiveEmployeesDataSet = new FindActiveEmployeesDataSet();
                aFindActiveEmployeesTableAdapter = new FindActiveEmployeesDataSetTableAdapters.FindActiveEmployeesTableAdapter();
                aFindActiveEmployeesTableAdapter.Fill(aFindActiveEmployeesDataSet.FindActiveEmployees);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "New Employee DLL // Find Active Employee // " + Ex.Message);
            }

            return aFindActiveEmployeesDataSet;
        }
        public bool CreateNewEmployee(string strFirstName, string strGroup, string strHomeOffice, string strLastName, string strPhoneNumber, string strType)
        {
            bool blnFatalError = false;

            try
            {
                TheEmployeesDataSet = GetEmployeesInfo();

                EmployeesDataSet.employeesRow NewEmployeeRow = TheEmployeesDataSet.employees.NewemployeesRow();

                NewEmployeeRow.Active = true;
                NewEmployeeRow.EmployeeID = CreateEmployeeID();
                NewEmployeeRow.FirstName = strFirstName;
                NewEmployeeRow.EmployeeGroup = strGroup;
                NewEmployeeRow.HomeOffice = strHomeOffice;
                NewEmployeeRow.LastName = strLastName;
                NewEmployeeRow.PhoneNumber = strPhoneNumber;
                NewEmployeeRow.EmployeeType = strType;

                TheEmployeesDataSet.employees.Rows.Add(NewEmployeeRow);
                UpdateEmployeesDB(TheEmployeesDataSet);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "New Employee DLL // Create New Employee // " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public EmployeesDataSet GetEmployeesInfo()
        {
            try
            {
                aEmployeesDataSet = new EmployeesDataSet();
                aEmployeesTableAdapter = new EmployeesDataSetTableAdapters.employeesTableAdapter();
                aEmployeesTableAdapter.Fill(aEmployeesDataSet.employees);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "New Employee DLL // Get Employees Info // " + Ex.Message);
            }

            return aEmployeesDataSet;
        }
        public void UpdateEmployeesDB(EmployeesDataSet aEmployeesDataSet)
        {
            try
            {
                aEmployeesTableAdapter = new EmployeesDataSetTableAdapters.employeesTableAdapter();
                aEmployeesTableAdapter.Update(aEmployeesDataSet.employees);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "New Employee DLL // Update Employees DB // " + Ex.Message);
            }
        }
        public int CreateEmployeeID()
        {
            int intEmployeeID = 0;

            try
            {
                //filling data set
                aEmployeeIDDataSet = new EmployeeIDDataSet();
                aEmployeeIDTableAdapter = new EmployeeIDDataSetTableAdapters.employeeidTableAdapter();
                aEmployeeIDTableAdapter.Fill(aEmployeeIDDataSet.employeeid);

                //creating id
                intEmployeeID = aEmployeeIDDataSet.employeeid[0].EmployeeID;
                intEmployeeID++;

                aEmployeeIDDataSet.employeeid[0].EmployeeID = intEmployeeID;
                aEmployeeIDTableAdapter.Update(aEmployeeIDDataSet.employeeid);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "New Employee DLL // Create Employee ID // " + Ex.Message);
            }

            //returning value
            return intEmployeeID;
        }
        
    }
}
