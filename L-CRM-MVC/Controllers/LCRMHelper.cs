using L_CRM_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L_CRM_MVC.Controllers
{
    public static class LCRMHelper
    {

        public static bool isValidPolicyHolder(Customer customer)
        {
            bool isValid = false;

            if (string.IsNullOrEmpty(customer.Name) || string.IsNullOrEmpty(customer.PhoneNumber) || string.IsNullOrEmpty(customer.Address) ||
                string.IsNullOrEmpty(customer.CustomerType.Description) || (customer.BillAmount < 0))
                isValid = false; //if any of the fields are null or empty the 
            else
                isValid = true; //Else the values are valid


            return isValid;
        }

        public static bool isValidLead(Customer customer)
        {
            bool isValid = false;

            if (string.IsNullOrEmpty(customer.Name) || string.IsNullOrEmpty(customer.PhoneNumber))
                isValid = false; //if any of the fields are null or empty the 
            else
                isValid = true; //Else the values are valid


            return isValid;
        }
    }
}