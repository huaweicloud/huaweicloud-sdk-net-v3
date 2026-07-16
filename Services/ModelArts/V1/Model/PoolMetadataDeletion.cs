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
    /// 删除资源池时的metadata信息。
    /// </summary>
    public class PoolMetadataDeletion 
    {

        /// <summary>
        /// **参数描述**： 系统自动生成的pool名称，相当于poolId。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数描述**： 时间戳，例如\&quot;2021-11-01T03:49:41Z\&quot;。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("creationTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string CreationTimestamp { get; set; }

        /// <summary>
        /// **参数描述**： 时间戳，例如\&quot;2021-11-01T03:49:41Z\&quot;。 **取值范围**： 不涉及。
        /// </summary>
        [JsonProperty("deletionTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string DeletionTimestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("labels", NullValueHandling = NullValueHandling.Ignore)]
        public PoolMetaLabels Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("annotations", NullValueHandling = NullValueHandling.Ignore)]
        public PoolMetaAnnotations Annotations { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoolMetadataDeletion {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  creationTimestamp: ").Append(CreationTimestamp).Append("\n");
            sb.Append("  deletionTimestamp: ").Append(DeletionTimestamp).Append("\n");
            sb.Append("  labels: ").Append(Labels).Append("\n");
            sb.Append("  annotations: ").Append(Annotations).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PoolMetadataDeletion);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PoolMetadataDeletion input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.CreationTimestamp != input.CreationTimestamp || (this.CreationTimestamp != null && !this.CreationTimestamp.Equals(input.CreationTimestamp))) return false;
            if (this.DeletionTimestamp != input.DeletionTimestamp || (this.DeletionTimestamp != null && !this.DeletionTimestamp.Equals(input.DeletionTimestamp))) return false;
            if (this.Labels != input.Labels || (this.Labels != null && !this.Labels.Equals(input.Labels))) return false;
            if (this.Annotations != input.Annotations || (this.Annotations != null && !this.Annotations.Equals(input.Annotations))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.CreationTimestamp != null) hashCode = hashCode * 59 + this.CreationTimestamp.GetHashCode();
                if (this.DeletionTimestamp != null) hashCode = hashCode * 59 + this.DeletionTimestamp.GetHashCode();
                if (this.Labels != null) hashCode = hashCode * 59 + this.Labels.GetHashCode();
                if (this.Annotations != null) hashCode = hashCode * 59 + this.Annotations.GetHashCode();
                return hashCode;
            }
        }
    }
}
