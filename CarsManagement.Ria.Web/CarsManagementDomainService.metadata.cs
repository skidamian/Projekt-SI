
namespace CarsManagement.Ria.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies samochodyMetadata as the class
    // that carries additional metadata for the samochody class.
    [MetadataTypeAttribute(typeof(samochody.samochodyMetadata))]
    public partial class samochody
    {

        // This class allows you to attach custom attributes to properties
        // of the samochody class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class samochodyMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private samochodyMetadata()
            {
            }

            public bool ac { get; set; }

            public int id { get; set; }

            public string marka { get; set; }

            public bool nw { get; set; }

            public bool oc { get; set; }

            public string opis { get; set; }

            public short rok_produkcji { get; set; }

            public string status_ { get; set; }
        }
    }
}
