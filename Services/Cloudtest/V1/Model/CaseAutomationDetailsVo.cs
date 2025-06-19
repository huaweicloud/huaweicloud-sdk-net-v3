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
    /// 用例自动化率详情
    /// </summary>
    public class CaseAutomationDetailsVo 
    {

        /// <summary>
        /// 用例自动化率
        /// </summary>
        [JsonProperty("case_automation_rate", NullValueHandling = NullValueHandling.Ignore)]
        public string CaseAutomationRate { get; set; }

        /// <summary>
        /// 服务类型对应的用例数目
        /// </summary>
        [JsonProperty("service_type_number_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<NameAndValueVo> ServiceTypeNumberList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CaseAutomationDetailsVo {\n");
            sb.Append("  caseAutomationRate: ").Append(CaseAutomationRate).Append("\n");
            sb.Append("  serviceTypeNumberList: ").Append(ServiceTypeNumberList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CaseAutomationDetailsVo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CaseAutomationDetailsVo input)
        {
            if (input == null) return false;
            if (this.CaseAutomationRate != input.CaseAutomationRate || (this.CaseAutomationRate != null && !this.CaseAutomationRate.Equals(input.CaseAutomationRate))) return false;
            if (this.ServiceTypeNumberList != input.ServiceTypeNumberList || (this.ServiceTypeNumberList != null && input.ServiceTypeNumberList != null && !this.ServiceTypeNumberList.SequenceEqual(input.ServiceTypeNumberList))) return false;

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
                if (this.CaseAutomationRate != null) hashCode = hashCode * 59 + this.CaseAutomationRate.GetHashCode();
                if (this.ServiceTypeNumberList != null) hashCode = hashCode * 59 + this.ServiceTypeNumberList.GetHashCode();
                return hashCode;
            }
        }
    }
}
