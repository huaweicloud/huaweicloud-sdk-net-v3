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
    /// 资源池状态信息。
    /// </summary>
    public class NetworkStatus 
    {

        /// <summary>
        /// **参数解释**：网络资源的当前状态。 **取值范围**：可选值如下： - Creating：网络创建中。 - Active：网络正常。 - Abnormal：网络异常。
        /// </summary>
        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public string Phase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("connectionStatus", NullValueHandling = NullValueHandling.Ignore)]
        public NetworkConnectionStatus ConnectionStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NetworkStatus {\n");
            sb.Append("  phase: ").Append(Phase).Append("\n");
            sb.Append("  connectionStatus: ").Append(ConnectionStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NetworkStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NetworkStatus input)
        {
            if (input == null) return false;
            if (this.Phase != input.Phase || (this.Phase != null && !this.Phase.Equals(input.Phase))) return false;
            if (this.ConnectionStatus != input.ConnectionStatus || (this.ConnectionStatus != null && !this.ConnectionStatus.Equals(input.ConnectionStatus))) return false;

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
                if (this.Phase != null) hashCode = hashCode * 59 + this.Phase.GetHashCode();
                if (this.ConnectionStatus != null) hashCode = hashCode * 59 + this.ConnectionStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
