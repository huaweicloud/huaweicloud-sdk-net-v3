using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// wdh参数
    /// </summary>
    public class WdhParam 
    {

        /// <summary>
        /// 在指定的桌面专属主机上创建桌面。  - dedicated：桌面专属主机。
        /// </summary>
        [JsonProperty("tenancy", NullValueHandling = NullValueHandling.Ignore)]
        public string Tenancy { get; set; }

        /// <summary>
        /// 桌面专属主机的ID。 指定桌面专属主机的ID则将桌面放置到此桌面专属主机。 未指定桌面专属主机的ID则使用自动放置功能放置到可用的桌面专属主机。 注意： - 仅在tenancy指定为dedicated时此字段生效。 - 若要使用自动放置功能来创建桌面，您需要先开启桌面专属主机的自动放置功能。
        /// </summary>
        [JsonProperty("dedicated_host_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DedicatedHostId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WdhParam {\n");
            sb.Append("  tenancy: ").Append(Tenancy).Append("\n");
            sb.Append("  dedicatedHostId: ").Append(DedicatedHostId).Append("\n");
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
            if (this.Tenancy != input.Tenancy || (this.Tenancy != null && !this.Tenancy.Equals(input.Tenancy))) return false;
            if (this.DedicatedHostId != input.DedicatedHostId || (this.DedicatedHostId != null && !this.DedicatedHostId.Equals(input.DedicatedHostId))) return false;

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
                if (this.Tenancy != null) hashCode = hashCode * 59 + this.Tenancy.GetHashCode();
                if (this.DedicatedHostId != null) hashCode = hashCode * 59 + this.DedicatedHostId.GetHashCode();
                return hashCode;
            }
        }
    }
}
