﻿
namespace CarsManagement.Ria.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies produktyMetadata as the class
    // that carries additional metadata for the produkty class.
    [MetadataTypeAttribute(typeof(produkty.produktyMetadata))]
    public partial class produkty
    {

        // This class allows you to attach custom attributes to properties
        // of the produkty class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class produktyMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private produktyMetadata()
            {
            }

            public Nullable<decimal> cena { get; set; }

            public string ID_produktu { get; set; }

            public string info { get; set; }

            public string nazwa { get; set; }

            public string producent { get; set; }
        }
    }
}
