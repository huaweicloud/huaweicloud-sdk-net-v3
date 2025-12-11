using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class SwitchGaussMySqlConfigurationResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释**：  应用参数模板的任务ID。  **取值范围**：  不涉及。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// **参数解释**：  参数模板的名称。  **取值范围**：  支持Default-TaurusDB V2.0和用户自定义参数模板，其中Default-TaurusDB V2.0表示TaurusDB系统默认参数模板。
        /// </summary>
        [JsonProperty("param_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ParamGroupName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SwitchGaussMySqlConfigurationResponse {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  paramGroupName: ").Append(ParamGroupName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SwitchGaussMySqlConfigurationResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SwitchGaussMySqlConfigurationResponse input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.ParamGroupName != input.ParamGroupName || (this.ParamGroupName != null && !this.ParamGroupName.Equals(input.ParamGroupName))) return false;

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
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.ParamGroupName != null) hashCode = hashCode * 59 + this.ParamGroupName.GetHashCode();
                return hashCode;
            }
        }
    }
}
