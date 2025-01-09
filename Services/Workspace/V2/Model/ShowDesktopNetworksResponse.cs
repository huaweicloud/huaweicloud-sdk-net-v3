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
    /// Response Object
    /// </summary>
    public class ShowDesktopNetworksResponse : SdkResponse
    {

        /// <summary>
        /// 桌面网络信息列表
        /// </summary>
        [JsonProperty("networks", NullValueHandling = NullValueHandling.Ignore)]
        public List<DesktopNetworkResult> Networks { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowDesktopNetworksResponse {\n");
            sb.Append("  networks: ").Append(Networks).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowDesktopNetworksResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowDesktopNetworksResponse input)
        {
            if (input == null) return false;
            if (this.Networks != input.Networks || (this.Networks != null && input.Networks != null && !this.Networks.SequenceEqual(input.Networks))) return false;

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
                if (this.Networks != null) hashCode = hashCode * 59 + this.Networks.GetHashCode();
                return hashCode;
            }
        }
    }
}
