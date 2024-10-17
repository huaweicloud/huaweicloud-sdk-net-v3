using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kafka.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ModifyInstanceConfigsResponse : SdkResponse
    {

        /// <summary>
        /// 配置修改任务ID。
        /// </summary>
        [JsonProperty("job_id", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 本次修改动态配置参数个数。
        /// </summary>
        [JsonProperty("dynamic_config", NullValueHandling = NullValueHandling.Ignore)]
        public int? DynamicConfig { get; set; }

        /// <summary>
        /// 本次修改静态配置参数个数。
        /// </summary>
        [JsonProperty("static_config", NullValueHandling = NullValueHandling.Ignore)]
        public int? StaticConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModifyInstanceConfigsResponse {\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  dynamicConfig: ").Append(DynamicConfig).Append("\n");
            sb.Append("  staticConfig: ").Append(StaticConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModifyInstanceConfigsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModifyInstanceConfigsResponse input)
        {
            if (input == null) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.DynamicConfig != input.DynamicConfig || (this.DynamicConfig != null && !this.DynamicConfig.Equals(input.DynamicConfig))) return false;
            if (this.StaticConfig != input.StaticConfig || (this.StaticConfig != null && !this.StaticConfig.Equals(input.StaticConfig))) return false;

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
                if (this.DynamicConfig != null) hashCode = hashCode * 59 + this.DynamicConfig.GetHashCode();
                if (this.StaticConfig != null) hashCode = hashCode * 59 + this.StaticConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
