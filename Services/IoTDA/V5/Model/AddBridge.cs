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
    /// 添加网桥结构体。
    /// </summary>
    public class AddBridge 
    {

        /// <summary>
        /// 网桥名称。**取值范围**：长度不超过64，只允许中文、字母、数字、以及_?&#39;#().,&amp;%@!-等字符的组合。
        /// </summary>
        [JsonProperty("bridge_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BridgeName { get; set; }

        /// <summary>
        /// 网桥ID。**取值范围**：长度不超过36，只允许字母、数字、_-字符的组合。
        /// </summary>
        [JsonProperty("bridge_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BridgeId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddBridge {\n");
            sb.Append("  bridgeName: ").Append(BridgeName).Append("\n");
            sb.Append("  bridgeId: ").Append(BridgeId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddBridge);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddBridge input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BridgeName == input.BridgeName ||
                    (this.BridgeName != null &&
                    this.BridgeName.Equals(input.BridgeName))
                ) && 
                (
                    this.BridgeId == input.BridgeId ||
                    (this.BridgeId != null &&
                    this.BridgeId.Equals(input.BridgeId))
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
                if (this.BridgeName != null)
                    hashCode = hashCode * 59 + this.BridgeName.GetHashCode();
                if (this.BridgeId != null)
                    hashCode = hashCode * 59 + this.BridgeId.GetHashCode();
                return hashCode;
            }
        }
    }
}
