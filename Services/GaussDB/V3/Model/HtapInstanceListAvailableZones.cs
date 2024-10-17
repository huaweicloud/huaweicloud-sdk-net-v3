using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class HtapInstanceListAvailableZones 
    {

        /// <summary>
        /// 可用区码。
        /// </summary>
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        /// <summary>
        /// 可用区描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 可用区类型。
        /// </summary>
        [JsonProperty("az_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AzType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HtapInstanceListAvailableZones {\n");
            sb.Append("  code: ").Append(Code).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  azType: ").Append(AzType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HtapInstanceListAvailableZones);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HtapInstanceListAvailableZones input)
        {
            if (input == null) return false;
            if (this.Code != input.Code || (this.Code != null && !this.Code.Equals(input.Code))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.AzType != input.AzType || (this.AzType != null && !this.AzType.Equals(input.AzType))) return false;

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
                if (this.Code != null) hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AzType != null) hashCode = hashCode * 59 + this.AzType.GetHashCode();
                return hashCode;
            }
        }
    }
}
