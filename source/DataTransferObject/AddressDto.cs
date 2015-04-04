//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataTransferObject
{
    using System;using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;using Newtonsoft.Json;
    using System.Collections.Generic;
    
    [DataContract()]
    public partial class AddressDto : UIPaging
    {
        [Key()] 
        [Required] 
        [DataMember] 
        public int AddressID  {get; set; }
     
        [Required] 
     
        [StringLength(60)]
        [DataMember] 
        public string AddressLine1  {get; set; }
     
        [StringLength(60)]
        [DataMember] 
        public string AddressLine2  {get; set; }
     
        [Required] 
     
        [StringLength(30)]
        [DataMember] 
        public string City  {get; set; }
     
        [Required] 
        [DataMember] 
        public int StateProvinceID  {get; set; }
     
        [Required] 
     
        [StringLength(15)]
        [DataMember] 
        public string PostalCode  {get; set; }
     
        [Required] 
        [DataMember] 
        public System.Guid rowguid  {get; set; }
     
        [Required] 
        [DataMember] 
        public System.DateTime ModifiedDate  {get; set; }
    
         public override string ToString()
         {
             return JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
         }
    }
}
