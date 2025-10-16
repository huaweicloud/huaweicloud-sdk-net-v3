using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowAuthorizeTxtRecordRequest 
    {

        /// <summary>
        /// 待创建的子域名。
        /// </summary>
        [SDKProperty("zone_name", IsQuery = true)]
        [JsonProperty("zone_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAuthorizeTxtRecordRequest {\n");
            sb.Append("  zoneName: ").Append(ZoneName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAuthorizeTxtRecordRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAuthorizeTxtRecordRequest input)
        {
            if (input == null) return false;
            if (this.ZoneName != input.ZoneName || (this.ZoneName != null && !this.ZoneName.Equals(input.ZoneName))) return false;

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
                if (this.ZoneName != null) hashCode = hashCode * 59 + this.ZoneName.GetHashCode();
                return hashCode;
            }
        }
    }
}
