﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Corts.Models.Classes;

namespace Corts.Models
{
    public class MaintenanceViewModel
    {
        [Display(Name = "Car")]
        public string Car { get; set; }

        [Display(Name = "Car")]
        public string CarType { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        //Mileage
        [Required]
        [Display(Name = "Mileage")]
        [Range(0, int.MaxValue, ErrorMessage = "Mileage must be a positive number")]
        public int Mileage { get; set; }

        
        [Display(Name = "Spent")]
        [Range(0, int.MaxValue, ErrorMessage = "Spent must be a positive number")]
        public Nullable<int> Spent { get; set; }

        [Display(Name = "Did you get your inspection done?")]
        public bool Inspection { get; set; }


        //Bool elements for checkboxes
        [Display(Name = "Air Filter")]
        public bool AirFilterBox { get; set; }
        [Display(Name = "Oil Change")]
        public bool OilChangeBox { get; set; }
        [Display(Name = "Ignition System")]
        public bool IgnitionSystemBox { get; set; }
        [Display(Name = "Brakes")]
        public bool BrakesBox { get; set; }
        [Display(Name = "Battery")]
        public bool BatteryBox { get; set; }
        [Display(Name = "HVAC")]
        public bool HVACBox { get; set; }
        [Display(Name = "Power Steering")]
        public bool PowerSteeringBox { get; set; }
        [Display(Name = "Coolant")]
        public bool CoolantBox { get; set; }
        [Display(Name = "Transmission Fluid")]
        public bool TransFluidBox { get; set; }
        [Display(Name = "Fuel Filter")]
        public bool FuelFilterBox { get; set; }
        [Display(Name = "Radiator Hoses")]
        public bool RadiatorHosesBox { get; set; }
        [Display(Name = "Suspension")]
        public bool SuspensionBox { get; set; }
        [Display(Name = "Spark Plugs")]
        public bool SparkPlugsBox { get; set; }
        [Display(Name = "Engine Drive Belts")]
        public bool EngineDriveBeltsBox { get; set; }
        [Display(Name = "Tires")]
        public bool TiresBox { get; set; }

        // This property will hold all available maintenanceobjects for selection
        //public List<MaintenanceObject> MaintenanceItems { get; set; }

        //public List<MaintenanceObject> DefaultMaintenance { get; set; }

        //public List<string> SubmittedMaintenance { get; set; }
    }
}