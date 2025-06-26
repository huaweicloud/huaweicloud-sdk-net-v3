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
    /// Response Object
    /// </summary>
    public class ShowServerGroupStateResponse : SdkResponse
    {

        /// <summary>
        /// 对应状态的服务器数量，参考ServerStatus。
        /// </summary>
        [JsonProperty("aps_status", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, int?> ApsStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowServerGroupStateResponse {\n");
            sb.Append("  apsStatus: ").Append(ApsStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowServerGroupStateResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowServerGroupStateResponse input)
        {
            if (input == null) return false;
            if (this.ApsStatus != input.ApsStatus || (this.ApsStatus != null && input.ApsStatus != null && !this.ApsStatus.SequenceEqual(input.ApsStatus))) return false;

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
                if (this.ApsStatus != null) hashCode = hashCode * 59 + this.ApsStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
