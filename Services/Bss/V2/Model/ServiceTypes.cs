using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ServiceTypes 
    {

        /// <summary>
        /// 云服务类型的名称。
        /// </summary>
        [JsonProperty("service_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTypeName { get; set; }

        /// <summary>
        /// 云服务类型的编码。
        /// </summary>
        [JsonProperty("service_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTypeCode { get; set; }

        /// <summary>
        /// 云服务类型的缩写。
        /// </summary>
        [JsonProperty("abbreviation", NullValueHandling = NullValueHandling.Ignore)]
        public string Abbreviation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceTypes {\n");
            sb.Append("  serviceTypeName: ").Append(ServiceTypeName).Append("\n");
            sb.Append("  serviceTypeCode: ").Append(ServiceTypeCode).Append("\n");
            sb.Append("  abbreviation: ").Append(Abbreviation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServiceTypes);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServiceTypes input)
        {
            if (input == null) return false;
            if (this.ServiceTypeName != input.ServiceTypeName || (this.ServiceTypeName != null && !this.ServiceTypeName.Equals(input.ServiceTypeName))) return false;
            if (this.ServiceTypeCode != input.ServiceTypeCode || (this.ServiceTypeCode != null && !this.ServiceTypeCode.Equals(input.ServiceTypeCode))) return false;
            if (this.Abbreviation != input.Abbreviation || (this.Abbreviation != null && !this.Abbreviation.Equals(input.Abbreviation))) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.ServiceTypeName != null) hashCode = hashCode * 59 + this.ServiceTypeName.GetHashCode();
                if (this.ServiceTypeCode != null) hashCode = hashCode * 59 + this.ServiceTypeCode.GetHashCode();
                if (this.Abbreviation != null) hashCode = hashCode * 59 + this.Abbreviation.GetHashCode();
                return hashCode;
            }
        }
    }
}
