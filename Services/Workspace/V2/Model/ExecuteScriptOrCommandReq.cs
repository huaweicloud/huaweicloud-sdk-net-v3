using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 批量执行脚本请求体。
    /// </summary>
    public class ExecuteScriptOrCommandReq 
    {

        /// <summary>
        /// 灰度资源数量。
        /// </summary>
        [JsonProperty("gray_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? GrayCount { get; set; }

        /// <summary>
        /// 资源类型，如桌面(DESKTOP)。
        /// </summary>
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// 灰度执行脚本的资源列表。
        /// </summary>
        [JsonProperty("gray_resource_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> GrayResourceIds { get; set; }

        /// <summary>
        /// 灰度失败阈值，达到阈值后停止进行下一批资源执行脚本，小于gray_count。
        /// </summary>
        [JsonProperty("gray_fail_threshold", NullValueHandling = NullValueHandling.Ignore)]
        public int? GrayFailThreshold { get; set; }

        /// <summary>
        /// 执行脚本的资源列表。
        /// </summary>
        [JsonProperty("resource_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// 执行的脚本列表。
        /// </summary>
        [JsonProperty("script_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ScriptIds { get; set; }

        /// <summary>
        /// 执行脚本的超时时间，单位分钟。
        /// </summary>
        [JsonProperty("execution_timeout", NullValueHandling = NullValueHandling.Ignore)]
        public int? ExecutionTimeout { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExecuteScriptOrCommandReq {\n");
            sb.Append("  grayCount: ").Append(GrayCount).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  grayResourceIds: ").Append(GrayResourceIds).Append("\n");
            sb.Append("  grayFailThreshold: ").Append(GrayFailThreshold).Append("\n");
            sb.Append("  resourceIds: ").Append(ResourceIds).Append("\n");
            sb.Append("  scriptIds: ").Append(ScriptIds).Append("\n");
            sb.Append("  executionTimeout: ").Append(ExecutionTimeout).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExecuteScriptOrCommandReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ExecuteScriptOrCommandReq input)
        {
            if (input == null) return false;
            if (this.GrayCount != input.GrayCount || (this.GrayCount != null && !this.GrayCount.Equals(input.GrayCount))) return false;
            if (this.ResourceType != input.ResourceType || (this.ResourceType != null && !this.ResourceType.Equals(input.ResourceType))) return false;
            if (this.GrayResourceIds != input.GrayResourceIds || (this.GrayResourceIds != null && input.GrayResourceIds != null && !this.GrayResourceIds.SequenceEqual(input.GrayResourceIds))) return false;
            if (this.GrayFailThreshold != input.GrayFailThreshold || (this.GrayFailThreshold != null && !this.GrayFailThreshold.Equals(input.GrayFailThreshold))) return false;
            if (this.ResourceIds != input.ResourceIds || (this.ResourceIds != null && input.ResourceIds != null && !this.ResourceIds.SequenceEqual(input.ResourceIds))) return false;
            if (this.ScriptIds != input.ScriptIds || (this.ScriptIds != null && input.ScriptIds != null && !this.ScriptIds.SequenceEqual(input.ScriptIds))) return false;
            if (this.ExecutionTimeout != input.ExecutionTimeout || (this.ExecutionTimeout != null && !this.ExecutionTimeout.Equals(input.ExecutionTimeout))) return false;

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
                if (this.GrayCount != null) hashCode = hashCode * 59 + this.GrayCount.GetHashCode();
                if (this.ResourceType != null) hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.GrayResourceIds != null) hashCode = hashCode * 59 + this.GrayResourceIds.GetHashCode();
                if (this.GrayFailThreshold != null) hashCode = hashCode * 59 + this.GrayFailThreshold.GetHashCode();
                if (this.ResourceIds != null) hashCode = hashCode * 59 + this.ResourceIds.GetHashCode();
                if (this.ScriptIds != null) hashCode = hashCode * 59 + this.ScriptIds.GetHashCode();
                if (this.ExecutionTimeout != null) hashCode = hashCode * 59 + this.ExecutionTimeout.GetHashCode();
                return hashCode;
            }
        }
    }
}
