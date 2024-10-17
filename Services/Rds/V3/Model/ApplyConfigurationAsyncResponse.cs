using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ApplyConfigurationAsyncResponse : SdkResponse
    {

        /// <summary>
        /// 参数组ID。
        /// </summary>
        [JsonProperty("configuration_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigurationId { get; set; }

        /// <summary>
        /// 参数组名称。
        /// </summary>
        [JsonProperty("configuration_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigurationName { get; set; }

        /// <summary>
        /// 参数模板是否都应用成功。 - “true”表示参数模板都应用成功。 - “false”表示存在应用失败的参数模板。
        /// </summary>
        [JsonProperty("success", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Success { get; set; }

        /// <summary>
        /// 任务流id
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplyConfigurationAsyncResponse {\n");
            sb.Append("  configurationId: ").Append(ConfigurationId).Append("\n");
            sb.Append("  configurationName: ").Append(ConfigurationName).Append("\n");
            sb.Append("  success: ").Append(Success).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplyConfigurationAsyncResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplyConfigurationAsyncResponse input)
        {
            if (input == null) return false;
            if (this.ConfigurationId != input.ConfigurationId || (this.ConfigurationId != null && !this.ConfigurationId.Equals(input.ConfigurationId))) return false;
            if (this.ConfigurationName != input.ConfigurationName || (this.ConfigurationName != null && !this.ConfigurationName.Equals(input.ConfigurationName))) return false;
            if (this.Success != input.Success || (this.Success != null && !this.Success.Equals(input.Success))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;

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
                if (this.ConfigurationId != null) hashCode = hashCode * 59 + this.ConfigurationId.GetHashCode();
                if (this.ConfigurationName != null) hashCode = hashCode * 59 + this.ConfigurationName.GetHashCode();
                if (this.Success != null) hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                return hashCode;
            }
        }
    }
}
