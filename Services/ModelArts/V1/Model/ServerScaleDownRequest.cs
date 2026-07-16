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
    /// 超节点缩容请求
    /// </summary>
    public class ServerScaleDownRequest 
    {

        /// <summary>
        /// 超节点ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 规格信息
        /// </summary>
        [JsonProperty("flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string Flavor { get; set; }

        /// <summary>
        /// 缩容节点id
        /// </summary>
        [JsonProperty("server_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ServerIds { get; set; }

        /// <summary>
        /// 资源规格信息
        /// </summary>
        [JsonProperty("resource_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceFlavor { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServerScaleDownRequest {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  flavor: ").Append(Flavor).Append("\n");
            sb.Append("  serverIds: ").Append(ServerIds).Append("\n");
            sb.Append("  resourceFlavor: ").Append(ResourceFlavor).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ServerScaleDownRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ServerScaleDownRequest input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Flavor != input.Flavor || (this.Flavor != null && !this.Flavor.Equals(input.Flavor))) return false;
            if (this.ServerIds != input.ServerIds || (this.ServerIds != null && input.ServerIds != null && !this.ServerIds.SequenceEqual(input.ServerIds))) return false;
            if (this.ResourceFlavor != input.ResourceFlavor || (this.ResourceFlavor != null && !this.ResourceFlavor.Equals(input.ResourceFlavor))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Flavor != null) hashCode = hashCode * 59 + this.Flavor.GetHashCode();
                if (this.ServerIds != null) hashCode = hashCode * 59 + this.ServerIds.GetHashCode();
                if (this.ResourceFlavor != null) hashCode = hashCode * 59 + this.ResourceFlavor.GetHashCode();
                return hashCode;
            }
        }
    }
}
