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
    /// Response Object
    /// </summary>
    public class UpdatePeriodToOnDemandInstantlyResponse : SdkResponse
    {

        /// <summary>
        /// |参数名称：包年包月即时转按需结果| |参数约束以及描述：包年包月即时转按需结果。HTTP 200的时候返回该字段，具体参见ToOndemandServiceResult。|
        /// </summary>
        [JsonProperty("to_ondemand_service_results", NullValueHandling = NullValueHandling.Ignore)]
        public List<ToOndemandServiceResult> ToOndemandServiceResults { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdatePeriodToOnDemandInstantlyResponse {\n");
            sb.Append("  toOndemandServiceResults: ").Append(ToOndemandServiceResults).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdatePeriodToOnDemandInstantlyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdatePeriodToOnDemandInstantlyResponse input)
        {
            if (input == null) return false;
            if (this.ToOndemandServiceResults != input.ToOndemandServiceResults || (this.ToOndemandServiceResults != null && input.ToOndemandServiceResults != null && !this.ToOndemandServiceResults.SequenceEqual(input.ToOndemandServiceResults))) return false;

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
                if (this.ToOndemandServiceResults != null) hashCode = hashCode * 59 + this.ToOndemandServiceResults.GetHashCode();
                return hashCode;
            }
        }
    }
}
