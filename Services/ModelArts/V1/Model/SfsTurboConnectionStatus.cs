using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// 通过挂载网卡方式打通网络参数模型。
    /// </summary>
    public class SfsTurboConnectionStatus 
    {

        /// <summary>
        /// **参数解释**：sfsTurbo实例的名称。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释**：sfsTurbo实例的ID。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("sfsId", NullValueHandling = NullValueHandling.Ignore)]
        public string SfsId { get; set; }

        /// <summary>
        /// **参数解释**：关联方式。 **取值范围**：可选值如下： - VpcPort：通过挂载网卡直通 - Peering：通过对等连接打通
        /// </summary>
        [JsonProperty("connectionType", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectionType { get; set; }

        /// <summary>
        /// **参数解释**：SFS Turbo的访问地址。 **取值范围**：不涉及。
        /// </summary>
        [JsonProperty("ipAddr", NullValueHandling = NullValueHandling.Ignore)]
        public string IpAddr { get; set; }

        /// <summary>
        /// **参数解释**：与SFS Turbo的连接状态信息。 **取值范围**：可选值如下： - Active：SFS连通状态正常 - Abnormal：SFS连通状态异常 - Creating：SFS连通状态创建关联中 - Deleting：SFS连通状态解除关联中
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SfsTurboConnectionStatus {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  sfsId: ").Append(SfsId).Append("\n");
            sb.Append("  connectionType: ").Append(ConnectionType).Append("\n");
            sb.Append("  ipAddr: ").Append(IpAddr).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SfsTurboConnectionStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SfsTurboConnectionStatus input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.SfsId != input.SfsId || (this.SfsId != null && !this.SfsId.Equals(input.SfsId))) return false;
            if (this.ConnectionType != input.ConnectionType || (this.ConnectionType != null && !this.ConnectionType.Equals(input.ConnectionType))) return false;
            if (this.IpAddr != input.IpAddr || (this.IpAddr != null && !this.IpAddr.Equals(input.IpAddr))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SfsId != null) hashCode = hashCode * 59 + this.SfsId.GetHashCode();
                if (this.ConnectionType != null) hashCode = hashCode * 59 + this.ConnectionType.GetHashCode();
                if (this.IpAddr != null) hashCode = hashCode * 59 + this.IpAddr.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
