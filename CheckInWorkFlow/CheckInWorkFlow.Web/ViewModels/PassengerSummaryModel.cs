using System;
using System.ComponentModel.DataAnnotations;
using CheckInWorkFlow.Data.Models;

namespace CheckInWorkFlow.Web.ViewModels
{
    public class PassengerSummaryModel
    {
        public int PassengerCount { get; set; }
        public decimal TotalWeight { get; set; }
    }
}