﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelDeskProject.Models;


public class Request
{
    [Key]
    public int RequestId { get; set; }
    public int UserId { get; set; }
    public int DepartmentId { get; set; }
    public string ReasonForTravelling { get; set; }
    public int BookingTypeId { get; set; }
    public int ProjectId { get; set; }
    public int ManagerId { get; set; }
    public int StatusId { get; set; }
    public string AadharNo { get; set; }
    //Manager
    public string? StatusReason { get; set; }


    //HotelBooking
    public int? NumberOfDays { get; set; }
    public int? MealTypeId { get; set; }
    public int? MealPreferenceTypeId { get; set; }
    public DateTime? StayDate { get; set; }
    public int? HotelLocationId { get; set; }

    //AirTicketBooking
    public int? FlightTypeId { get; set; }
    public int? To { get; set; }
    public int? From { get; set; }
    public string? PassportNo { get; set; }
    public DateTime? FlightDate { get; set; }
    //5 permanent fields
    public int CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public int? UpdatedBy { get; set; }
    public DateTime UpdatedOn { get; set; }
    public bool IsActive { get; set; }
    //BookingId will be generated.
    public int? BookingId { get; set; }

    [ForeignKey("UserId")]
    public User? User { get; set; }
}