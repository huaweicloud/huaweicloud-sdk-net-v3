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
    /// 中心网络策略文档。
    /// </summary>
    public class CentralNetworkPolicyDocument 
    {

        /// <summary>
        /// 中心网络默认平面的名称。
        /// </summary>
        [JsonProperty("default_plane", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultPlane { get; set; }

        /// <summary>
        /// 中心网络平面列表。
        /// </summary>
        [JsonProperty("planes", NullValueHandling = NullValueHandling.Ignore)]
        public List<CentralNetworkPlaneDocument> Planes { get; set; }

        /// <summary>
        /// 中心网络ER实例列表。
        /// </summary>
        [JsonProperty("er_instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<AssociateErInstanceDocument> ErInstances { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CentralNetworkPolicyDocument {\n");
            sb.Append("  defaultPlane: ").Append(DefaultPlane).Append("\n");
            sb.Append("  planes: ").Append(Planes).Append("\n");
            sb.Append("  erInstances: ").Append(ErInstances).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CentralNetworkPolicyDocument);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CentralNetworkPolicyDocument input)
        {
            if (input == null) return false;
            if (this.DefaultPlane != input.DefaultPlane || (this.DefaultPlane != null && !this.DefaultPlane.Equals(input.DefaultPlane))) return false;
            if (this.Planes != input.Planes || (this.Planes != null && input.Planes != null && !this.Planes.SequenceEqual(input.Planes))) return false;
            if (this.ErInstances != input.ErInstances || (this.ErInstances != null && input.ErInstances != null && !this.ErInstances.SequenceEqual(input.ErInstances))) return false;

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
                if (this.DefaultPlane != null) hashCode = hashCode * 59 + this.DefaultPlane.GetHashCode();
                if (this.Planes != null) hashCode = hashCode * 59 + this.Planes.GetHashCode();
                if (this.ErInstances != null) hashCode = hashCode * 59 + this.ErInstances.GetHashCode();
                return hashCode;
            }
        }
    }
}
