using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateInstanceParamResponse : SdkResponse
    {

        /// <summary>
        /// 节点列表。
        /// </summary>
        [JsonProperty("nodeList", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeList { get; set; }

        /// <summary>
        /// 是否需要重启实例。
        /// </summary>
        [JsonProperty("needRestart", NullValueHandling = NullValueHandling.Ignore)]
        public bool? NeedRestart { get; set; }

        /// <summary>
        /// 任务id。
        /// </summary>
        [JsonProperty("jobId", NullValueHandling = NullValueHandling.Ignore)]
        public string JobId { get; set; }

        /// <summary>
        /// 参数组id。
        /// </summary>
        [JsonProperty("configId", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigId { get; set; }

        /// <summary>
        /// 参数组名称。
        /// </summary>
        [JsonProperty("configName", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateInstanceParamResponse {\n");
            sb.Append("  nodeList: ").Append(NodeList).Append("\n");
            sb.Append("  needRestart: ").Append(NeedRestart).Append("\n");
            sb.Append("  jobId: ").Append(JobId).Append("\n");
            sb.Append("  configId: ").Append(ConfigId).Append("\n");
            sb.Append("  configName: ").Append(ConfigName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateInstanceParamResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateInstanceParamResponse input)
        {
            if (input == null) return false;
            if (this.NodeList != input.NodeList || (this.NodeList != null && !this.NodeList.Equals(input.NodeList))) return false;
            if (this.NeedRestart != input.NeedRestart || (this.NeedRestart != null && !this.NeedRestart.Equals(input.NeedRestart))) return false;
            if (this.JobId != input.JobId || (this.JobId != null && !this.JobId.Equals(input.JobId))) return false;
            if (this.ConfigId != input.ConfigId || (this.ConfigId != null && !this.ConfigId.Equals(input.ConfigId))) return false;
            if (this.ConfigName != input.ConfigName || (this.ConfigName != null && !this.ConfigName.Equals(input.ConfigName))) return false;

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
                if (this.NodeList != null) hashCode = hashCode * 59 + this.NodeList.GetHashCode();
                if (this.NeedRestart != null) hashCode = hashCode * 59 + this.NeedRestart.GetHashCode();
                if (this.JobId != null) hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.ConfigId != null) hashCode = hashCode * 59 + this.ConfigId.GetHashCode();
                if (this.ConfigName != null) hashCode = hashCode * 59 + this.ConfigName.GetHashCode();
                return hashCode;
            }
        }
    }
}
