using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateDefectRequestBody 
    {

        /// <summary>
        /// **参数解释：** MergeKey，问题ID。[[查询缺陷详情](ShowTaskDefectsV2.xml)](tag:hws,hws_hk)[查询缺陷详情](tag:fcs,hcs,hcs_sm,hcs_site,hcs_sitesm)响应中的defect_id字段 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("defect_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DefectId { get; set; }

        /// <summary>
        /// **参数解释：** 问题状态。 **约束限制：** [不涉及。](tag:hws,hws_hk)[状态为0、1的问题无法直接修改到状态3。](tag:fcs,hcs,hcs_sm,hcs_site,hcs_sitesm) **取值范围：** - 0：待处理。 - 1：已解决。 - 2：已忽略。 [- 3：重新打开（需打开忽略审核开关）。](tag:fcs,hcs,hcs_sm,hcs_site,hcs_sitesm) [- 4：待审核（需打开忽略审核开关）。](tag:fcs,hcs,hcs_sm,hcs_site,hcs_sitesm) **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("defect_status", NullValueHandling = NullValueHandling.Ignore)]
        public string DefectStatus { get; set; }

        /// <summary>
        /// **参数解释：** 问题忽略的审核人用户名。 **约束限制：** defect_status取值为4（需打开忽略审核开关）时，必填。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("approver", NullValueHandling = NullValueHandling.Ignore)]
        public string Approver { get; set; }

        /// <summary>
        /// **参数解释：** 本次修改问题状态操作的备注。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        /// <summary>
        /// **参数解释：** [忽略类型，将问题修改为待审核状态时选填。](tag:fcs,hcs,hcs_sm,hcs_site,hcs_sitesm)[废弃字段。](tag:hws,hws_hk) **约束限制：** 不涉及。 **取值范围：** - NO_RISK：评估无风险暂不解决。 - FALSE_POSITIVES：纯属工具误报。 - THIRD_PARTY：开源及第三方。 - EFFUCUENCY_RETAIN：性能敏感保留危险函数。 - NO_SUPPORT_INKERNEL：不支持的内核危险函数。 - EXCLUDE_SCENES：规范例外场景。 - COMPATIBLE_THIRD_PARTY：兼容第三方。 **默认取值：** NO_RISK
        /// </summary>
        [JsonProperty("ignoreType", NullValueHandling = NullValueHandling.Ignore)]
        public string IgnoreType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDefectRequestBody {\n");
            sb.Append("  defectId: ").Append(DefectId).Append("\n");
            sb.Append("  defectStatus: ").Append(DefectStatus).Append("\n");
            sb.Append("  approver: ").Append(Approver).Append("\n");
            sb.Append("  comment: ").Append(Comment).Append("\n");
            sb.Append("  ignoreType: ").Append(IgnoreType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateDefectRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateDefectRequestBody input)
        {
            if (input == null) return false;
            if (this.DefectId != input.DefectId || (this.DefectId != null && !this.DefectId.Equals(input.DefectId))) return false;
            if (this.DefectStatus != input.DefectStatus || (this.DefectStatus != null && !this.DefectStatus.Equals(input.DefectStatus))) return false;
            if (this.Approver != input.Approver || (this.Approver != null && !this.Approver.Equals(input.Approver))) return false;
            if (this.Comment != input.Comment || (this.Comment != null && !this.Comment.Equals(input.Comment))) return false;
            if (this.IgnoreType != input.IgnoreType || (this.IgnoreType != null && !this.IgnoreType.Equals(input.IgnoreType))) return false;

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
                if (this.DefectId != null) hashCode = hashCode * 59 + this.DefectId.GetHashCode();
                if (this.DefectStatus != null) hashCode = hashCode * 59 + this.DefectStatus.GetHashCode();
                if (this.Approver != null) hashCode = hashCode * 59 + this.Approver.GetHashCode();
                if (this.Comment != null) hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.IgnoreType != null) hashCode = hashCode * 59 + this.IgnoreType.GetHashCode();
                return hashCode;
            }
        }
    }
}
