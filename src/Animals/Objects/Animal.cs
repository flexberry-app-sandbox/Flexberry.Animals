﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Animals
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Animal.
    /// </summary>
    // *** Start programmer edit section *** (Animal CustomAttributes)

    // *** End programmer edit section *** (Animal CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("AnimalE", new string[] {
            "Name as \'Name\'"})]
    [AssociatedDetailViewAttribute("AnimalE", "Burrows", "BurrowE", true, "", "Burrows", true, new string[] {
            ""})]
    [View("AnimalL", new string[] {
            "Name as \'Name\'"})]
    public class Animal : ICSSoft.STORMNET.DataObject
    {
        
        private string fName;
        
        private IIS.Animals.DetailArrayOfBurrow fBurrows;
        
        // *** Start programmer edit section *** (Animal CustomMembers)

        // *** End programmer edit section *** (Animal CustomMembers)

        
        /// <summary>
        /// Name.
        /// </summary>
        // *** Start programmer edit section *** (Animal.Name CustomAttributes)

        // *** End programmer edit section *** (Animal.Name CustomAttributes)
        [StrLen(255)]
        public virtual string Name
        {
            get
            {
                // *** Start programmer edit section *** (Animal.Name Get start)

                // *** End programmer edit section *** (Animal.Name Get start)
                string result = this.fName;
                // *** Start programmer edit section *** (Animal.Name Get end)

                // *** End programmer edit section *** (Animal.Name Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Animal.Name Set start)

                // *** End programmer edit section *** (Animal.Name Set start)
                this.fName = value;
                // *** Start programmer edit section *** (Animal.Name Set end)

                // *** End programmer edit section *** (Animal.Name Set end)
            }
        }
        
        /// <summary>
        /// Animal.
        /// </summary>
        // *** Start programmer edit section *** (Animal.Burrows CustomAttributes)

        // *** End programmer edit section *** (Animal.Burrows CustomAttributes)
        public virtual IIS.Animals.DetailArrayOfBurrow Burrows
        {
            get
            {
                // *** Start programmer edit section *** (Animal.Burrows Get start)

                // *** End programmer edit section *** (Animal.Burrows Get start)
                if ((this.fBurrows == null))
                {
                    this.fBurrows = new IIS.Animals.DetailArrayOfBurrow(this);
                }
                IIS.Animals.DetailArrayOfBurrow result = this.fBurrows;
                // *** Start programmer edit section *** (Animal.Burrows Get end)

                // *** End programmer edit section *** (Animal.Burrows Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Animal.Burrows Set start)

                // *** End programmer edit section *** (Animal.Burrows Set start)
                this.fBurrows = value;
                // *** Start programmer edit section *** (Animal.Burrows Set end)

                // *** End programmer edit section *** (Animal.Burrows Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "AnimalE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View AnimalE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("AnimalE", typeof(IIS.Animals.Animal));
                }
            }
            
            /// <summary>
            /// "AnimalL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View AnimalL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("AnimalL", typeof(IIS.Animals.Animal));
                }
            }
        }
    }
}
