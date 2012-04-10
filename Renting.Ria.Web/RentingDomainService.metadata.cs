
namespace Renting.Ria.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies rezerwacjeMetadata as the class
    // that carries additional metadata for the rezerwacje class.
    [MetadataTypeAttribute(typeof(rezerwacje.rezerwacjeMetadata))]
    public partial class rezerwacje
    {

        // This class allows you to attach custom attributes to properties
        // of the rezerwacje class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class rezerwacjeMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private rezerwacjeMetadata()
            {
            }

            public DateTime data_wypozyczenia { get; set; }

            public Nullable<DateTime> data_zwrotu { get; set; }

            public int id { get; set; }

            public int klient_id { get; set; }

            public int pracownik_id { get; set; }

            public int samochod_id { get; set; }

            public string status_ { get; set; }

            public string uwagi { get; set; }
        }
    }
}
