//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cfdiEntidadesGP
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwCfdiConceptos
    {
        public Nullable<long> id { get; set; }
        public short soptype { get; set; }
        public string sopnumbe { get; set; }
        public int LNITMSEQ { get; set; }
        public string ITEMNMBR { get; set; }
        public string SERLTNUM { get; set; }
        public string ITEMDESC { get; set; }
        public int CMPNTSEQ { get; set; }
        public string udemSunat { get; set; }
        public string claveProdSunat { get; set; }
        public string NoIdentificacion { get; set; }
        public string Descripcion { get; set; }
        public Nullable<decimal> precioUniConIva { get; set; }
        public Nullable<decimal> valorUni { get; set; }
        public Nullable<decimal> importe { get; set; }
        public decimal cantidad { get; set; }
        public Nullable<decimal> descuento { get; set; }
        public Nullable<decimal> descuentoBaseImponible { get; set; }
        public Nullable<decimal> descuentoPorcentaje { get; set; }
        public string descuentoCodigo { get; set; }
        public decimal montoIva { get; set; }
        public decimal montoImponibleIva { get; set; }
        public Nullable<decimal> porcentajeIva { get; set; }
        public string tipoTributo { get; set; }
        public string tipoAfectacion { get; set; }
        public string operacionOnerosa { get; set; }
    }
}
