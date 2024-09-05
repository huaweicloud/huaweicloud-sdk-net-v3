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
    /// 
    /// </summary>
    public class RouterWithStatus 
    {

        /// <summary>
        /// 资源状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 关联VPC的ID。
        /// </summary>
        [JsonProperty("router_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RouterId { get; set; }

        /// <summary>
        /// 关联VPC所在的region。
        /// </summary>
        [JsonProperty("router_region", NullValueHandling = NullValueHandling.Ignore)]
        public string RouterRegion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RouterWithStatus {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  routerId: ").Append(RouterId).Append("\n");
            sb.Append("  routerRegion: ").Append(RouterRegion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RouterWithStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RouterWithStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.RouterId == input.RouterId ||
                    (this.RouterId != null &&
                    this.RouterId.Equals(input.RouterId))
                ) && 
                (
                    this.RouterRegion == input.RouterRegion ||
                    (this.RouterRegion != null &&
                    this.RouterRegion.Equals(input.RouterRegion))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.RouterId != null)
                    hashCode = hashCode * 59 + this.RouterId.GetHashCode();
                if (this.RouterRegion != null)
                    hashCode = hashCode * 59 + this.RouterRegion.GetHashCode();
                return hashCode;
            }
        }
    }
}
