﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Hotel
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    //  *** Start programmer edit section *** (Using statements)

    //  *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Reservation.
    /// </summary>
    //  *** Start programmer edit section *** (Reservation CustomAttributes)

    //  *** End programmer edit section *** (Reservation CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ReservationE", new string[] {
            "Comment as \'Comment\'",
            "StartDate as \'Start date\'",
            "EndDate as \'End date\'",
            "Person as \'Person\'",
            "Person.Name as \'Name\'",
            "Room as \'Room\'",
            "Room.Description as \'Description\'"})]
    [View("ReservationL", new string[] {
            "Comment as \'Comment\'",
            "StartDate as \'Start date\'",
            "EndDate as \'End date\'",
            "Person.Name as \'Name\'",
            "Room.Description as \'Description\'"})]
    public class Reservation : ICSSoft.STORMNET.DataObject
    {
        
        private string fComment;
        
        private System.DateTime fStartDate = System.DateTime.Now;
        
        private ICSSoft.STORMNET.UserDataTypes.NullableDateTime fEndDate;
        
        private IIS.Hotel.Person fPerson;
        
        private IIS.Hotel.Room fRoom;
        
        //  *** Start programmer edit section *** (Reservation CustomMembers)

        //  *** End programmer edit section *** (Reservation CustomMembers)

        
        /// <summary>
        /// Comment.
        /// </summary>
        //  *** Start programmer edit section *** (Reservation.Comment CustomAttributes)

        //  *** End programmer edit section *** (Reservation.Comment CustomAttributes)
        [StrLen(255)]
        public virtual string Comment
        {
            get
            {
                //  *** Start programmer edit section *** (Reservation.Comment Get start)

                //  *** End programmer edit section *** (Reservation.Comment Get start)
                string result = this.fComment;
                //  *** Start programmer edit section *** (Reservation.Comment Get end)

                //  *** End programmer edit section *** (Reservation.Comment Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Reservation.Comment Set start)

                //  *** End programmer edit section *** (Reservation.Comment Set start)
                this.fComment = value;
                //  *** Start programmer edit section *** (Reservation.Comment Set end)

                //  *** End programmer edit section *** (Reservation.Comment Set end)
            }
        }
        
        /// <summary>
        /// StartDate.
        /// </summary>
        //  *** Start programmer edit section *** (Reservation.StartDate CustomAttributes)

        //  *** End programmer edit section *** (Reservation.StartDate CustomAttributes)
        public virtual System.DateTime StartDate
        {
            get
            {
                //  *** Start programmer edit section *** (Reservation.StartDate Get start)

                //  *** End programmer edit section *** (Reservation.StartDate Get start)
                System.DateTime result = this.fStartDate;
                //  *** Start programmer edit section *** (Reservation.StartDate Get end)

                //  *** End programmer edit section *** (Reservation.StartDate Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Reservation.StartDate Set start)

                //  *** End programmer edit section *** (Reservation.StartDate Set start)
                this.fStartDate = value;
                //  *** Start programmer edit section *** (Reservation.StartDate Set end)

                //  *** End programmer edit section *** (Reservation.StartDate Set end)
            }
        }
        
        /// <summary>
        /// EndDate.
        /// </summary>
        //  *** Start programmer edit section *** (Reservation.EndDate CustomAttributes)

        //  *** End programmer edit section *** (Reservation.EndDate CustomAttributes)
        public virtual ICSSoft.STORMNET.UserDataTypes.NullableDateTime EndDate
        {
            get
            {
                //  *** Start programmer edit section *** (Reservation.EndDate Get start)

                //  *** End programmer edit section *** (Reservation.EndDate Get start)
                ICSSoft.STORMNET.UserDataTypes.NullableDateTime result = this.fEndDate;
                //  *** Start programmer edit section *** (Reservation.EndDate Get end)

                //  *** End programmer edit section *** (Reservation.EndDate Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Reservation.EndDate Set start)

                //  *** End programmer edit section *** (Reservation.EndDate Set start)
                this.fEndDate = value;
                //  *** Start programmer edit section *** (Reservation.EndDate Set end)

                //  *** End programmer edit section *** (Reservation.EndDate Set end)
            }
        }
        
        /// <summary>
        /// Reservation.
        /// </summary>
        //  *** Start programmer edit section *** (Reservation.Person CustomAttributes)

        //  *** End programmer edit section *** (Reservation.Person CustomAttributes)
        [NotNull()]
        public virtual IIS.Hotel.Person Person
        {
            get
            {
                //  *** Start programmer edit section *** (Reservation.Person Get start)

                //  *** End programmer edit section *** (Reservation.Person Get start)
                IIS.Hotel.Person result = this.fPerson;
                //  *** Start programmer edit section *** (Reservation.Person Get end)

                //  *** End programmer edit section *** (Reservation.Person Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Reservation.Person Set start)

                //  *** End programmer edit section *** (Reservation.Person Set start)
                this.fPerson = value;
                //  *** Start programmer edit section *** (Reservation.Person Set end)

                //  *** End programmer edit section *** (Reservation.Person Set end)
            }
        }
        
        /// <summary>
        /// Reservation.
        /// </summary>
        //  *** Start programmer edit section *** (Reservation.Room CustomAttributes)

        //  *** End programmer edit section *** (Reservation.Room CustomAttributes)
        [NotNull()]
        public virtual IIS.Hotel.Room Room
        {
            get
            {
                //  *** Start programmer edit section *** (Reservation.Room Get start)

                //  *** End programmer edit section *** (Reservation.Room Get start)
                IIS.Hotel.Room result = this.fRoom;
                //  *** Start programmer edit section *** (Reservation.Room Get end)

                //  *** End programmer edit section *** (Reservation.Room Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (Reservation.Room Set start)

                //  *** End programmer edit section *** (Reservation.Room Set start)
                this.fRoom = value;
                //  *** Start programmer edit section *** (Reservation.Room Set end)

                //  *** End programmer edit section *** (Reservation.Room Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ReservationE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ReservationE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ReservationE", typeof(IIS.Hotel.Reservation));
                }
            }
            
            /// <summary>
            /// "ReservationL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ReservationL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ReservationL", typeof(IIS.Hotel.Reservation));
                }
            }
        }
    }
}