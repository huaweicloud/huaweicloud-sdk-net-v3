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
    /// **参数解释** 资源分组修改请求体
    /// </summary>
    public class PutResourceGroupReq 
    {

        /// <summary>
        /// **参数解释** 资源分组名称。 **约束限制** 不涉及。 **取值范围** 包含字母、数字、_、-或汉字，长度为[1,128]个字符。 **默认取值** 不涉及。
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// **参数解释** 标签动态匹配时的关联标签。 **约束限制** type为TAG时必传，不超过50个标签。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<ResourceGroupTagRelation> Tags { get; set; }

        /// <summary>
        /// **参数解释** 资源匹配规则为组合匹配时传入的参数，已废弃。 **约束限制** type为COMB时传入，不超过50个条件。
        /// </summary>
        [JsonProperty("enterprise_project_id_and_tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<EnterpriseProjectIdAndTags> EnterpriseProjectIdAndTags { get; set; }

        /// <summary>
        /// **参数解释** 匹配企业项目时关联的企业项目ID。 **约束限制** type为EPS时必传，不超过50个企业项目。
        /// </summary>
        [JsonProperty("extend_relation_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExtendRelationIds { get; set; }

        /// <summary>
        /// **参数解释** 实例名称匹配参数。 **约束限制** type为NAME时必传，不超过50个实例。 
        /// </summary>
        [JsonProperty("instances", NullValueHandling = NullValueHandling.Ignore)]
        public List<Instance> Instances { get; set; }

        /// <summary>
        /// **参数解释** 资源层级为云产品时的云产品名称 **约束限制** 不涉及。 **取值范围** 一般由\&quot;服务命名空间,服务首层维度名称\&quot;组成，如\&quot;SYS.ECS,instance_id\&quot;。多个云产品则用“;”隔开，如\&quot;SERVICE.BMS,instance_id;SYS.ECS,instance_id\&quot;。不超过10240个字符。 **默认取值** 不涉及。
        /// </summary>
        [JsonProperty("product_names", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductNames { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("comb_relation", NullValueHandling = NullValueHandling.Ignore)]
        public CombRelation CombRelation { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PutResourceGroupReq {\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  enterpriseProjectIdAndTags: ").Append(EnterpriseProjectIdAndTags).Append("\n");
            sb.Append("  extendRelationIds: ").Append(ExtendRelationIds).Append("\n");
            sb.Append("  instances: ").Append(Instances).Append("\n");
            sb.Append("  productNames: ").Append(ProductNames).Append("\n");
            sb.Append("  combRelation: ").Append(CombRelation).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PutResourceGroupReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PutResourceGroupReq input)
        {
            if (input == null) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.EnterpriseProjectIdAndTags != input.EnterpriseProjectIdAndTags || (this.EnterpriseProjectIdAndTags != null && input.EnterpriseProjectIdAndTags != null && !this.EnterpriseProjectIdAndTags.SequenceEqual(input.EnterpriseProjectIdAndTags))) return false;
            if (this.ExtendRelationIds != input.ExtendRelationIds || (this.ExtendRelationIds != null && input.ExtendRelationIds != null && !this.ExtendRelationIds.SequenceEqual(input.ExtendRelationIds))) return false;
            if (this.Instances != input.Instances || (this.Instances != null && input.Instances != null && !this.Instances.SequenceEqual(input.Instances))) return false;
            if (this.ProductNames != input.ProductNames || (this.ProductNames != null && !this.ProductNames.Equals(input.ProductNames))) return false;
            if (this.CombRelation != input.CombRelation || (this.CombRelation != null && !this.CombRelation.Equals(input.CombRelation))) return false;

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
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.EnterpriseProjectIdAndTags != null) hashCode = hashCode * 59 + this.EnterpriseProjectIdAndTags.GetHashCode();
                if (this.ExtendRelationIds != null) hashCode = hashCode * 59 + this.ExtendRelationIds.GetHashCode();
                if (this.Instances != null) hashCode = hashCode * 59 + this.Instances.GetHashCode();
                if (this.ProductNames != null) hashCode = hashCode * 59 + this.ProductNames.GetHashCode();
                if (this.CombRelation != null) hashCode = hashCode * 59 + this.CombRelation.GetHashCode();
                return hashCode;
            }
        }
    }
}
