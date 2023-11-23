using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 单个实例需要设置的LTS策略。
    /// </summary>
    public class UpdateLtsConfigRequestBodyLtsConfigs 
    {

        /// <summary>
        /// 实例ID，可以调用“[查询实例列表和详情](x-wc://file&#x3D;zh-cn_topic_0000001369935045.xml)”接口获取。如果未申请实例，可以调用“[创建实例](x-wc://file&#x3D;zh-cn_topic_0000001369734929.xml)”接口创建。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("log_type", NullValueHandling = NullValueHandling.Ignore)]
        public LtsLogType LogType { get; set; }
        /// <summary>
        /// LTS日志组ID。可通过云日志服务-“查询账号下所有日志组”API接口获取。
        /// </summary>
        [JsonProperty("lts_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LtsGroupId { get; set; }

        /// <summary>
        /// LTS日志流ID。可通过云日志服务-“查询指定日志组下的所有日志流”API接口获取。
        /// </summary>
        [JsonProperty("lts_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LtsStreamId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateLtsConfigRequestBodyLtsConfigs {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  logType: ").Append(LogType).Append("\n");
            sb.Append("  ltsGroupId: ").Append(LtsGroupId).Append("\n");
            sb.Append("  ltsStreamId: ").Append(LtsStreamId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateLtsConfigRequestBodyLtsConfigs);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateLtsConfigRequestBodyLtsConfigs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.LogType == input.LogType ||
                    (this.LogType != null &&
                    this.LogType.Equals(input.LogType))
                ) && 
                (
                    this.LtsGroupId == input.LtsGroupId ||
                    (this.LtsGroupId != null &&
                    this.LtsGroupId.Equals(input.LtsGroupId))
                ) && 
                (
                    this.LtsStreamId == input.LtsStreamId ||
                    (this.LtsStreamId != null &&
                    this.LtsStreamId.Equals(input.LtsStreamId))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.LogType != null)
                    hashCode = hashCode * 59 + this.LogType.GetHashCode();
                if (this.LtsGroupId != null)
                    hashCode = hashCode * 59 + this.LtsGroupId.GetHashCode();
                if (this.LtsStreamId != null)
                    hashCode = hashCode * 59 + this.LtsStreamId.GetHashCode();
                return hashCode;
            }
        }
    }
}
