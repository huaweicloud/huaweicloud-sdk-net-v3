using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class AddOrUpdateMetricOrEventAlarmRuleRequest 
    {

        /// <summary>
        /// 告警规则id。 - 新增告警时，填写\&quot;add-alarm-action\&quot; - 更新告警时，填写“update-alarm-action”
        /// </summary>
        [SDKProperty("action_id", IsQuery = true)]
        [JsonProperty("action_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ActionId { get; set; }

        /// <summary>
        /// 企业项目id。 - 查询单个企业项目下实例，填写企业项目id。  - 查询所有企业项目下实例，填写“all_granted_eps”。
        /// </summary>
        [SDKProperty("Enterprise-Project-Id", IsHeader = true)]
        [JsonProperty("Enterprise-Project-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public AddOrUpdateAlarmRuleV4RequestBody Body { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddOrUpdateMetricOrEventAlarmRuleRequest {\n");
            sb.Append("  actionId: ").Append(ActionId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddOrUpdateMetricOrEventAlarmRuleRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddOrUpdateMetricOrEventAlarmRuleRequest input)
        {
            if (input == null) return false;
            if (this.ActionId != input.ActionId || (this.ActionId != null && !this.ActionId.Equals(input.ActionId))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Body != input.Body || (this.Body != null && !this.Body.Equals(input.Body))) return false;

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
                if (this.ActionId != null) hashCode = hashCode * 59 + this.ActionId.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Body != null) hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
