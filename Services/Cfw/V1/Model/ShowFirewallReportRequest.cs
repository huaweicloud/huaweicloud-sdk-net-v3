using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowFirewallReportRequest 
    {

        /// <summary>
        /// **参数解释**： 防火墙ID，用户创建防火墙实例后产生的唯一ID，配置后可区分不同防火墙，可通过[防火墙ID获取方式](cfw_02_0028.xml)获取 **约束限制**： 不涉及 **取值范围**： 32位UUID **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("fw_instance_id", IsQuery = true)]
        [JsonProperty("fw_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FwInstanceId { get; set; }

        /// <summary>
        /// **参数解释**： 安全报告模板ID **约束限制**： 不涉及 **取值范围**： 32位UUID **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("report_profile_id", IsQuery = true)]
        [JsonProperty("report_profile_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportProfileId { get; set; }

        /// <summary>
        /// **参数解释**： 安全报告ID，可以通过调用[查询安全报告发送历史接口]获得，通过返回值中的data.records.report_id获得 **约束限制**： 不涉及 **取值范围**： 32位UUID **默认取值**： 不涉及
        /// </summary>
        [SDKProperty("report_id", IsPath = true)]
        [JsonProperty("report_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ReportId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowFirewallReportRequest {\n");
            sb.Append("  fwInstanceId: ").Append(FwInstanceId).Append("\n");
            sb.Append("  reportProfileId: ").Append(ReportProfileId).Append("\n");
            sb.Append("  reportId: ").Append(ReportId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowFirewallReportRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowFirewallReportRequest input)
        {
            if (input == null) return false;
            if (this.FwInstanceId != input.FwInstanceId || (this.FwInstanceId != null && !this.FwInstanceId.Equals(input.FwInstanceId))) return false;
            if (this.ReportProfileId != input.ReportProfileId || (this.ReportProfileId != null && !this.ReportProfileId.Equals(input.ReportProfileId))) return false;
            if (this.ReportId != input.ReportId || (this.ReportId != null && !this.ReportId.Equals(input.ReportId))) return false;

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
                if (this.FwInstanceId != null) hashCode = hashCode * 59 + this.FwInstanceId.GetHashCode();
                if (this.ReportProfileId != null) hashCode = hashCode * 59 + this.ReportProfileId.GetHashCode();
                if (this.ReportId != null) hashCode = hashCode * 59 + this.ReportId.GetHashCode();
                return hashCode;
            }
        }
    }
}
