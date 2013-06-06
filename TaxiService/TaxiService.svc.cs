﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using ServicesDataContracts;
using System.Data.SqlClient;


public class TaxiService : ITaxiService
{
    public TaxiPriceInfo GetTaxiPriceInfo(TaxiPriceInfoRequest taxiPriceInfoRequest)
    {
        List<Taxi> taxis = new List<Taxi>();
        Taxi taxi1 = new Taxi();
        taxi1.Id = 1;
        taxi1.PricePerKm = 5.00;
        taxi1.Type = "Sedan";
        taxis.Add(taxi1);

        Taxi taxiMetLaagstePrijs = null;
        foreach (Taxi taxi in taxis)
        {
            if (taxiMetLaagstePrijs == null || taxiMetLaagstePrijs.PricePerKm > taxi.PricePerKm)
                taxiMetLaagstePrijs = taxi;
        }

        TaxiPriceInfo priceInfo = new TaxiPriceInfo();
        priceInfo.Price = taxiMetLaagstePrijs.PricePerKm * 10; //statische 10km
        priceInfo.TaxiId = taxiMetLaagstePrijs.Id;
        priceInfo.TaxiType = taxiMetLaagstePrijs.Type;
        priceInfo.DepartureAddress = taxiPriceInfoRequest.DepartureAddress;
        priceInfo.AmountOfPassengers = taxiPriceInfoRequest.AmountOfPassengers;
        priceInfo.DateTime = taxiPriceInfoRequest.DateTime;
        priceInfo.DestinationAddress = taxiPriceInfoRequest.DestinationAddress;
        priceInfo.IsDepartureTime = taxiPriceInfoRequest.IsDepartureTime;

        return priceInfo;
    }


    public TaxiBooking DoTaxiBooking(TaxiBookingRequest taxiBookingRequest)
    {
        string userToken = taxiBookingRequest.UserToken;
        //call user-service for verification

        TaxiBooking taxiBooking = new TaxiBooking();
        taxiBooking.TaxiId = taxiBookingRequest.TaxiId;
        taxiBooking.TaxiType = taxiBookingRequest.TaxiType;
        taxiBooking.Price = taxiBookingRequest.Price;
        taxiBooking.DepartureAddress = taxiBookingRequest.DepartureAddress;
        taxiBooking.DestinationAddress = taxiBookingRequest.DestinationAddress;
        taxiBooking.DateTime = taxiBookingRequest.DateTime;
        taxiBooking.IsDepartureTime = taxiBookingRequest.IsDepartureTime;
        taxiBooking.AmountOfPassengers = taxiBookingRequest.AmountOfPassengers;

        //open connection to database

        try
        {
            SqlConnection thisConnection = new SqlConnection(@"Network Library=DBMSSOCN;Data Source=tcp:apv8jive40.database.windows.net,1433;database=team3-to8;User id=michael@apv8jive40;Password=Ditisonzedatabase!;");
            thisConnection.Open();
            //start by creating new command
            SqlCommand thisCommand = thisConnection.CreateCommand();
            //insert new row to table "TaxiBooking"
            //for testing will be used random id generator, taxiID will always be 999.
            Random random = new Random();
            int Id = random.Next(1, 10000);
            int TaxiId = 999;

            //link it to user [Not yet implemented] 
            thisCommand.CommandText = "INSERT INTO TaxiBooking values('" +Id+ "', '" +TaxiId+ "')";
            thisCommand.ExecuteNonQuery();
            thisConnection.Close();
        }
        catch (SqlException e)
        {

        }

        


        return taxiBooking;
    }

    public UserBookings GetUserBookings(UserBookingsRequest userBookingsRequest)
    {
        string userToken = userBookingsRequest.UserToken;
        //call user-service for verification

        bool bookingIsSpecified = (userBookingsRequest.BookingId == null);

        UserBookings ubs = new UserBookings();
        ubs.TaxiBookings = new List<TaxiBooking>();
        if (bookingIsSpecified)
        {
            TaxiBooking tb = new TaxiBooking();
            //select * from TaxiBooking where bookingId = userBookingsRequest.BookingId
            //set tb with select data
            ubs.TaxiBookings.Add(tb);
        }
        else
        {
            //select * from TaxiBooking where user = user...
            //add TaxiBooking objects to ubs.TaxiBookings
        }

        return ubs;
    }

    public bool CancelBooking(CancelBookingRequest cancelBookingRequest)
    {
        throw new NotImplementedException();
    }


    public string[] GetCitys(string country)
    {
        throw new NotImplementedException();
    }

    public string[] GetAddress(GetAddressRequest getAddressRequest)
    {
        throw new NotImplementedException();
    }

    public string[] GetSpecialLocations(string locationType)
    {
        throw new NotImplementedException();
    }
}
