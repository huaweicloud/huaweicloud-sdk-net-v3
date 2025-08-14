using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// wdh参数。
    /// </summary>
    public class WdhParam 
    {

        /// <summary>
        ///  云办公主机id。
        /// </summary>
        [JsonProperty("dedicated_host_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        ///  类型。
        /// </summary>
        [JsonProperty("tenancy", NullValueHandling = NullValueHandling.Ignore)]
        public string Tenancy { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WdhParam {\n");
            sb.Append("  dedicatedHostId: ").Append(DedicatedHostId).Append("\n");
            sb.Append("  tenancy: ").Append(Tenancy).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as WdhParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(WdhParam input)
        {
            if (input == null) return false;
            if (this.DedicatedHostId != input.DedicatedHostId || (this.DedicatedHostId != null && !this.DedicatedHostId.Equals(input.DedicatedHostId))) return false;
            if (this.Tenancy != input.Tenancy || (this.Tenancy != null && !this.Tenancy.Equals(input.Tenancy))) return false;

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
                if (this.DedicatedHostId != null) hashCode = hashCode * 59 + this.DedicatedHostId.GetHashCode();
                if (this.Tenancy != null) hashCode = hashCode * 59 + this.Tenancy.GetHashCode();
                return hashCode;
            }
        }
    }
}
