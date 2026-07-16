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
    /// Request Object
    /// </summary>
    public class ListWorkloadsRequest 
    {

        /// <summary>
        /// **参数解释**：资源池的ID，取值自资源池详情的metadata.name字段。 **约束限制**：不涉及。 **取值范围**：只能以小写字母开头，数字、中划线组成，不能以中划线结尾，且长度为[36-63]个字符。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("pool_name", IsPath = true)]
        [JsonProperty("pool_name", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolName { get; set; }

        /// <summary>
        /// **参数解释**：节点IP地址，用于过滤在该节点上运行的workload。支持多个IP，传递多个参数或用逗号分隔. **约束限制**：指定此参数时，不支持分页（limit/offset会被忽略）。 **取值范围**：不涉及。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("hostip", IsQuery = true)]
        [JsonProperty("hostip", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Hostip { get; set; }

        /// <summary>
        /// **参数解释**：根据作业类型查询资源池作业列表。 **约束限制**：不涉及。 **取值范围**：可选值如下： - train：训练作业 - infer：推理服务 - notebook：Notebook作业 - x-infer：新版推理作业 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// **参数解释**：根据作业状态查询资源池作业列表。 **约束限制**：不涉及。 **取值范围**：可选值如下： - Queue：排队中的作业。 - Pending：等待中的作业。 - Abnormal：异常的作业。 - Terminating：中止中的作业。 - Creating：创建中的作业。 - Running：运行中的作业。 - Completed：已完成的作业。 - Terminated：已终止的作业。 - Failed：运行失败的作业。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// **参数解释**：查询资源池作业列表的排序条件。 **约束限制**：不涉及。 **取值范围**：可选值如下： - create_time：根据作业创建时间排序。 **默认取值**：不涉及。
        /// </summary>
        [SDKProperty("sort", IsQuery = true)]
        [JsonProperty("sort", NullValueHandling = NullValueHandling.Ignore)]
        public string Sort { get; set; }

        /// <summary>
        /// **参数解释**：指定查询资源池作业列表是否按照升序排序。 **约束限制**：需要配合sort查询参数使用。 **取值范围**：可选值如下： - true：按照升序排序。 - false：按照降序排序。 **默认取值**：false。
        /// </summary>
        [SDKProperty("ascend", IsQuery = true)]
        [JsonProperty("ascend", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ascend { get; set; }

        /// <summary>
        /// **参数解释**：分页查询的偏移量。 **约束限制**：不涉及。 **取值范围**：0-2147483647。 **默认取值**：0。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public string Offset { get; set; }

        /// <summary>
        /// **参数解释**：分页单次查询返回的资源数量。 **约束限制**：不涉及。 **取值范围**：0 - 500。 **默认取值**：500。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListWorkloadsRequest {\n");
            sb.Append("  poolName: ").Append(PoolName).Append("\n");
            sb.Append("  hostip: ").Append(Hostip).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  sort: ").Append(Sort).Append("\n");
            sb.Append("  ascend: ").Append(Ascend).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListWorkloadsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListWorkloadsRequest input)
        {
            if (input == null) return false;
            if (this.PoolName != input.PoolName || (this.PoolName != null && !this.PoolName.Equals(input.PoolName))) return false;
            if (this.Hostip != input.Hostip || (this.Hostip != null && input.Hostip != null && !this.Hostip.SequenceEqual(input.Hostip))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Sort != input.Sort || (this.Sort != null && !this.Sort.Equals(input.Sort))) return false;
            if (this.Ascend != input.Ascend || (this.Ascend != null && !this.Ascend.Equals(input.Ascend))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.PoolName != null) hashCode = hashCode * 59 + this.PoolName.GetHashCode();
                if (this.Hostip != null) hashCode = hashCode * 59 + this.Hostip.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Sort != null) hashCode = hashCode * 59 + this.Sort.GetHashCode();
                if (this.Ascend != null) hashCode = hashCode * 59 + this.Ascend.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
