using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 更新中心网络连接信息的请求体。
    /// </summary>
    public class UpdateCentralNetworkConnectionRequestBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("central_network_connection", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateCentralNetworkConnection CentralNetworkConnection { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCentralNetworkConnectionRequestBody {\n");
            sb.Append("  centralNetworkConnection: ").Append(CentralNetworkConnection).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateCentralNetworkConnectionRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateCentralNetworkConnectionRequestBody input)
        {
            if (input == null) return false;
            if (this.CentralNetworkConnection != input.CentralNetworkConnection || (this.CentralNetworkConnection != null && !this.CentralNetworkConnection.Equals(input.CentralNetworkConnection))) return false;

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
                if (this.CentralNetworkConnection != null) hashCode = hashCode * 59 + this.CentralNetworkConnection.GetHashCode();
                return hashCode;
            }
        }
    }
}
