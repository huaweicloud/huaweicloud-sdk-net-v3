using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V2.Model
{
    /// <summary>
    /// 企业项目关联资源的状态
    /// </summary>
    public class EpResourceStatistics 
    {

        /// <summary>
        /// **参数解释** 企业项目ID。 **取值范围** 长度[0,64]个字符. 
        /// </summary>
        [JsonProperty("extend_relation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ExtendRelationId { get; set; }

        /// <summary>
        /// **参数解释** 告警中的资源数。 **取值范围** 0-9999999 
        /// </summary>
        [JsonProperty("unhealthy", NullValueHandling = NullValueHandling.Ignore)]
        public int? Unhealthy { get; set; }

        /// <summary>
        /// **参数解释** 资源总数。 **取值范围** 0-9999999 
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// **参数解释** 已触发的资源数。 **取值范围** 0-9999999 
        /// </summary>
        [JsonProperty("event_unhealthy", NullValueHandling = NullValueHandling.Ignore)]
        public int? EventUnhealthy { get; set; }

        /// <summary>
        /// **参数解释** 资源类型数。 **取值范围** 0-9999999 
        /// </summary>
        [JsonProperty("namespaces", NullValueHandling = NullValueHandling.Ignore)]
        public int? Namespaces { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EpResourceStatistics {\n");
            sb.Append("  extendRelationId: ").Append(ExtendRelationId).Append("\n");
            sb.Append("  unhealthy: ").Append(Unhealthy).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  eventUnhealthy: ").Append(EventUnhealthy).Append("\n");
            sb.Append("  namespaces: ").Append(Namespaces).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EpResourceStatistics);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EpResourceStatistics input)
        {
            if (input == null) return false;
            if (this.ExtendRelationId != input.ExtendRelationId || (this.ExtendRelationId != null && !this.ExtendRelationId.Equals(input.ExtendRelationId))) return false;
            if (this.Unhealthy != input.Unhealthy || (this.Unhealthy != null && !this.Unhealthy.Equals(input.Unhealthy))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.EventUnhealthy != input.EventUnhealthy || (this.EventUnhealthy != null && !this.EventUnhealthy.Equals(input.EventUnhealthy))) return false;
            if (this.Namespaces != input.Namespaces || (this.Namespaces != null && !this.Namespaces.Equals(input.Namespaces))) return false;

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
                if (this.ExtendRelationId != null) hashCode = hashCode * 59 + this.ExtendRelationId.GetHashCode();
                if (this.Unhealthy != null) hashCode = hashCode * 59 + this.Unhealthy.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.EventUnhealthy != null) hashCode = hashCode * 59 + this.EventUnhealthy.GetHashCode();
                if (this.Namespaces != null) hashCode = hashCode * 59 + this.Namespaces.GetHashCode();
                return hashCode;
            }
        }
    }
}
