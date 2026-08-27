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
    public class ListRemoteProviderModelsResponse : SdkResponse
    {

        /// <summary>
        /// 远端模型总数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 远程模型列表。
        /// </summary>
        [JsonProperty("remote_models", NullValueHandling = NullValueHandling.Ignore)]
        public List<BaseModeInfo> RemoteModels { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListRemoteProviderModelsResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  remoteModels: ").Append(RemoteModels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListRemoteProviderModelsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListRemoteProviderModelsResponse input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.RemoteModels != input.RemoteModels || (this.RemoteModels != null && input.RemoteModels != null && !this.RemoteModels.SequenceEqual(input.RemoteModels))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.RemoteModels != null) hashCode = hashCode * 59 + this.RemoteModels.GetHashCode();
                return hashCode;
            }
        }
    }
}
