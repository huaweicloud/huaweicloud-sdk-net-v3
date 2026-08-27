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
    public class SaveImChannelsResponse : SdkResponse
    {

        /// <summary>
        /// 配置 ID 列表
        /// </summary>
        [JsonProperty("config_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ConfigIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveImChannelsResponse {\n");
            sb.Append("  configIds: ").Append(ConfigIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SaveImChannelsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SaveImChannelsResponse input)
        {
            if (input == null) return false;
            if (this.ConfigIds != input.ConfigIds || (this.ConfigIds != null && input.ConfigIds != null && !this.ConfigIds.SequenceEqual(input.ConfigIds))) return false;

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
                if (this.ConfigIds != null) hashCode = hashCode * 59 + this.ConfigIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
