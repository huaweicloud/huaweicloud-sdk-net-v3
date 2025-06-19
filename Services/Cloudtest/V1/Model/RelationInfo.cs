using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RelationInfo 
    {

        /// <summary>
        /// 需求id
        /// </summary>
        [JsonProperty("dr_number", NullValueHandling = NullValueHandling.Ignore)]
        public string DrNumber { get; set; }

        /// <summary>
        /// 用例uri
        /// </summary>
        [JsonProperty("test_case_uri", NullValueHandling = NullValueHandling.Ignore)]
        public string TestCaseUri { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [JsonProperty("relate_type", NullValueHandling = NullValueHandling.Ignore)]
        public string RelateType { get; set; }

        /// <summary>
        /// 资源类型
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [JsonProperty("source_system", NullValueHandling = NullValueHandling.Ignore)]
        public string SourceSystem { get; set; }

        /// <summary>
        /// 关联资源编号
        /// </summary>
        [JsonProperty("association_number", NullValueHandling = NullValueHandling.Ignore)]
        public string AssociationNumber { get; set; }

        /// <summary>
        /// 逻辑region，外部使用公有云实际区域，内部使用默认值
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RelationInfo {\n");
            sb.Append("  drNumber: ").Append(DrNumber).Append("\n");
            sb.Append("  testCaseUri: ").Append(TestCaseUri).Append("\n");
            sb.Append("  relateType: ").Append(RelateType).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  sourceSystem: ").Append(SourceSystem).Append("\n");
            sb.Append("  associationNumber: ").Append(AssociationNumber).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RelationInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RelationInfo input)
        {
            if (input == null) return false;
            if (this.DrNumber != input.DrNumber || (this.DrNumber != null && !this.DrNumber.Equals(input.DrNumber))) return false;
            if (this.TestCaseUri != input.TestCaseUri || (this.TestCaseUri != null && !this.TestCaseUri.Equals(input.TestCaseUri))) return false;
            if (this.RelateType != input.RelateType || (this.RelateType != null && !this.RelateType.Equals(input.RelateType))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.SourceSystem != input.SourceSystem || (this.SourceSystem != null && !this.SourceSystem.Equals(input.SourceSystem))) return false;
            if (this.AssociationNumber != input.AssociationNumber || (this.AssociationNumber != null && !this.AssociationNumber.Equals(input.AssociationNumber))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;

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
                if (this.DrNumber != null) hashCode = hashCode * 59 + this.DrNumber.GetHashCode();
                if (this.TestCaseUri != null) hashCode = hashCode * 59 + this.TestCaseUri.GetHashCode();
                if (this.RelateType != null) hashCode = hashCode * 59 + this.RelateType.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.SourceSystem != null) hashCode = hashCode * 59 + this.SourceSystem.GetHashCode();
                if (this.AssociationNumber != null) hashCode = hashCode * 59 + this.AssociationNumber.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                return hashCode;
            }
        }
    }
}
