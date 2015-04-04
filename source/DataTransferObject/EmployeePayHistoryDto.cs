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
    public partial class EmployeePayHistoryDto : UIPaging
    {
        [Key()] 
        [Required] 
        [DataMember] 
        public int EmployeeID  {get; set; }
        [Key()] 
        [Required] 
        [DataMember] 
        public System.DateTime RateChangeDate  {get; set; }
     
        [Required] 
        [DataMember] 
        public decimal Rate  {get; set; }
     
        [Required] 
        [DataMember] 
        public byte PayFrequency  {get; set; }
     
        [Required] 
        [DataMember] 
        public System.DateTime ModifiedDate  {get; set; }
    
        //[DataMember] 
        //[JsonProperty("Employees")]
        //public virtual Employee Employees { get; set; }
    
         public override string ToString()
         {
             return JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
         }
    }
}
