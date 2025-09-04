using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResRelation 
    {

        /// <summary>
        /// |参数名称：当前费用对应的资源ID| |参数约束及描述：当前费用对应的资源ID|
        /// </summary>
        [JsonProperty("self_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SelfResourceId { get; set; }

        /// <summary>
        /// |参数名称：当前费用对应资源ID关联的资源信息。| |参数约束及描述：当前费用对应资源ID关联的资源信息，数组个数不超过2层|
        /// </summary>
        [JsonProperty("relation_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<RelationInfo> RelationInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResRelation {\n");
            sb.Append("  selfResourceId: ").Append(SelfResourceId).Append("\n");
            sb.Append("  relationInfos: ").Append(RelationInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResRelation);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResRelation input)
        {
            if (input == null) return false;
            if (this.SelfResourceId != input.SelfResourceId || (this.SelfResourceId != null && !this.SelfResourceId.Equals(input.SelfResourceId))) return false;
            if (this.RelationInfos != input.RelationInfos || (this.RelationInfos != null && input.RelationInfos != null && !this.RelationInfos.SequenceEqual(input.RelationInfos))) return false;

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
                if (this.SelfResourceId != null) hashCode = hashCode * 59 + this.SelfResourceId.GetHashCode();
                if (this.RelationInfos != null) hashCode = hashCode * 59 + this.RelationInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
