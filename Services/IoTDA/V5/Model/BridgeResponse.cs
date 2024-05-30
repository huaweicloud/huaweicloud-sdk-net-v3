using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class BridgeResponse 
    {

        /// <summary>
        /// 网桥ID
        /// </summary>
        [JsonProperty("bridge_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BridgeId { get; set; }

        /// <summary>
        /// 网桥名称。
        /// </summary>
        [JsonProperty("bridge_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BridgeName { get; set; }

        /// <summary>
        /// 网桥状态。 - ONLINE：网桥在线。 - OFFLINE：网桥离线。 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BridgeResponse {\n");
            sb.Append("  bridgeId: ").Append(BridgeId).Append("\n");
            sb.Append("  bridgeName: ").Append(BridgeName).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BridgeResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BridgeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BridgeId == input.BridgeId ||
                    (this.BridgeId != null &&
                    this.BridgeId.Equals(input.BridgeId))
                ) && 
                (
                    this.BridgeName == input.BridgeName ||
                    (this.BridgeName != null &&
                    this.BridgeName.Equals(input.BridgeName))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.BridgeId != null)
                    hashCode = hashCode * 59 + this.BridgeId.GetHashCode();
                if (this.BridgeName != null)
                    hashCode = hashCode * 59 + this.BridgeName.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
