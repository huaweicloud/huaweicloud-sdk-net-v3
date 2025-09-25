using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsPipeline.V2.Model
{
    /// <summary>
    /// 流水线并发管理
    /// </summary>
    public class PipelineConcurrencyMgmt 
    {

        /// <summary>
        /// **参数解释**： 流水线ID，可以通过[查询流水线列表](ListPipelines.xml)接口，其中pipelines.pipelineId即为流水线ID。 **约束限制**： 不涉及。 **取值范围**： 32位字符串。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("pipeline_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PipelineId { get; set; }

        /// <summary>
        /// **参数解释**： [流水线并发个数](tag:hws,hws_hk,hws_eu,ctc,cmcc,g42,sbc,hcs,hcs_site,hcs_sm,hcs_sitesm,fcs)[，最大并发受套餐和购买并发数限制](tag:hws,hws_hk,hws_eu,ctc,cmcc,g42,sbc)[。](tag:hws,hws_hk,hws_eu,ctc,cmcc,g42,sbc,hcs,hcs_site,hcs_sm,hcs_sitesm,fcs) **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("concurrency_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? ConcurrencyNumber { get; set; }

        /// <summary>
        /// **参数解释**： 超出并发数时排队策略。 **约束限制**： 不涉及。 **取值范围**： - ABORT：忽略不执行。 - QUEUE：排队等待。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("exceed_action", NullValueHandling = NullValueHandling.Ignore)]
        public string ExceedAction { get; set; }

        /// <summary>
        /// **参数解释**： 创建时间。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// **参数解释**： 更新时间。 **约束限制**： 不涉及。 **取值范围**： 不涉及。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// **参数解释**： 是否启用。 **约束限制**： 不涉及。 **取值范围**： - true：启用。 - false：未启用。 **默认取值**： 不涉及。 
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PipelineConcurrencyMgmt {\n");
            sb.Append("  pipelineId: ").Append(PipelineId).Append("\n");
            sb.Append("  concurrencyNumber: ").Append(ConcurrencyNumber).Append("\n");
            sb.Append("  exceedAction: ").Append(ExceedAction).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PipelineConcurrencyMgmt);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PipelineConcurrencyMgmt input)
        {
            if (input == null) return false;
            if (this.PipelineId != input.PipelineId || (this.PipelineId != null && !this.PipelineId.Equals(input.PipelineId))) return false;
            if (this.ConcurrencyNumber != input.ConcurrencyNumber || (this.ConcurrencyNumber != null && !this.ConcurrencyNumber.Equals(input.ConcurrencyNumber))) return false;
            if (this.ExceedAction != input.ExceedAction || (this.ExceedAction != null && !this.ExceedAction.Equals(input.ExceedAction))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.UpdateTime != input.UpdateTime || (this.UpdateTime != null && !this.UpdateTime.Equals(input.UpdateTime))) return false;
            if (this.Enable != input.Enable || (this.Enable != null && !this.Enable.Equals(input.Enable))) return false;

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
                if (this.PipelineId != null) hashCode = hashCode * 59 + this.PipelineId.GetHashCode();
                if (this.ConcurrencyNumber != null) hashCode = hashCode * 59 + this.ConcurrencyNumber.GetHashCode();
                if (this.ExceedAction != null) hashCode = hashCode * 59 + this.ExceedAction.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null) hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.Enable != null) hashCode = hashCode * 59 + this.Enable.GetHashCode();
                return hashCode;
            }
        }
    }
}
