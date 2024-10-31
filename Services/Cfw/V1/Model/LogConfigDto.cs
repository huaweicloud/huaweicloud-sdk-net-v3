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
    /// 
    /// </summary>
    public class LogConfigDto 
    {

        /// <summary>
        /// 防火墙id，可通过[防火墙ID获取方式](cfw_02_0028.xml)获取
        /// </summary>
        [JsonProperty("fw_instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FwInstanceId { get; set; }

        /// <summary>
        /// 是否开启LTS，1表示是，0表示不是
        /// </summary>
        [JsonProperty("lts_enable", NullValueHandling = NullValueHandling.Ignore)]
        public int? LtsEnable { get; set; }

        /// <summary>
        /// LTS日志分组id,可通过查询LTS（云日志服务）下查询账号下所有日志组接口获得，通过返回值中的log_groups.log_group_id（.表示各对象之间层级的区分）获得
        /// </summary>
        [JsonProperty("lts_log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LtsLogGroupId { get; set; }

        /// <summary>
        /// 攻击日志流id,可通过查询LTS（云日志服务）下查询指定日志组下的所有日志流接口获得，通过返回值中的log_streams.log_stream_id（.表示各对象之间层级的区分）获得
        /// </summary>
        [JsonProperty("lts_attack_log_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LtsAttackLogStreamId { get; set; }

        /// <summary>
        /// 是否开启攻击日志流，1表示是，0表示不是
        /// </summary>
        [JsonProperty("lts_attack_log_stream_enable", NullValueHandling = NullValueHandling.Ignore)]
        public int? LtsAttackLogStreamEnable { get; set; }

        /// <summary>
        /// 访问控制日志流id,可通过查询LTS（云日志服务）下查询指定日志组下的所有日志流接口获得，通过返回值中的log_streams.log_stream_id（.表示各对象之间层级的区分）获得
        /// </summary>
        [JsonProperty("lts_access_log_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LtsAccessLogStreamId { get; set; }

        /// <summary>
        /// 是否开启访问控制流，1表示是，0表示不是
        /// </summary>
        [JsonProperty("lts_access_log_stream_enable", NullValueHandling = NullValueHandling.Ignore)]
        public int? LtsAccessLogStreamEnable { get; set; }

        /// <summary>
        /// 流量日志id,可通过查询LTS（云日志服务）下查询指定日志组下的所有日志流接口获得，通过返回值中的log_streams.log_stream_id（.表示各对象之间层级的区分）获得
        /// </summary>
        [JsonProperty("lts_flow_log_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LtsFlowLogStreamId { get; set; }

        /// <summary>
        /// 是否开启流量日志，1表示是，0表示不是
        /// </summary>
        [JsonProperty("lts_flow_log_stream_enable", NullValueHandling = NullValueHandling.Ignore)]
        public int? LtsFlowLogStreamEnable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogConfigDto {\n");
            sb.Append("  fwInstanceId: ").Append(FwInstanceId).Append("\n");
            sb.Append("  ltsEnable: ").Append(LtsEnable).Append("\n");
            sb.Append("  ltsLogGroupId: ").Append(LtsLogGroupId).Append("\n");
            sb.Append("  ltsAttackLogStreamId: ").Append(LtsAttackLogStreamId).Append("\n");
            sb.Append("  ltsAttackLogStreamEnable: ").Append(LtsAttackLogStreamEnable).Append("\n");
            sb.Append("  ltsAccessLogStreamId: ").Append(LtsAccessLogStreamId).Append("\n");
            sb.Append("  ltsAccessLogStreamEnable: ").Append(LtsAccessLogStreamEnable).Append("\n");
            sb.Append("  ltsFlowLogStreamId: ").Append(LtsFlowLogStreamId).Append("\n");
            sb.Append("  ltsFlowLogStreamEnable: ").Append(LtsFlowLogStreamEnable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as LogConfigDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(LogConfigDto input)
        {
            if (input == null) return false;
            if (this.FwInstanceId != input.FwInstanceId || (this.FwInstanceId != null && !this.FwInstanceId.Equals(input.FwInstanceId))) return false;
            if (this.LtsEnable != input.LtsEnable || (this.LtsEnable != null && !this.LtsEnable.Equals(input.LtsEnable))) return false;
            if (this.LtsLogGroupId != input.LtsLogGroupId || (this.LtsLogGroupId != null && !this.LtsLogGroupId.Equals(input.LtsLogGroupId))) return false;
            if (this.LtsAttackLogStreamId != input.LtsAttackLogStreamId || (this.LtsAttackLogStreamId != null && !this.LtsAttackLogStreamId.Equals(input.LtsAttackLogStreamId))) return false;
            if (this.LtsAttackLogStreamEnable != input.LtsAttackLogStreamEnable || (this.LtsAttackLogStreamEnable != null && !this.LtsAttackLogStreamEnable.Equals(input.LtsAttackLogStreamEnable))) return false;
            if (this.LtsAccessLogStreamId != input.LtsAccessLogStreamId || (this.LtsAccessLogStreamId != null && !this.LtsAccessLogStreamId.Equals(input.LtsAccessLogStreamId))) return false;
            if (this.LtsAccessLogStreamEnable != input.LtsAccessLogStreamEnable || (this.LtsAccessLogStreamEnable != null && !this.LtsAccessLogStreamEnable.Equals(input.LtsAccessLogStreamEnable))) return false;
            if (this.LtsFlowLogStreamId != input.LtsFlowLogStreamId || (this.LtsFlowLogStreamId != null && !this.LtsFlowLogStreamId.Equals(input.LtsFlowLogStreamId))) return false;
            if (this.LtsFlowLogStreamEnable != input.LtsFlowLogStreamEnable || (this.LtsFlowLogStreamEnable != null && !this.LtsFlowLogStreamEnable.Equals(input.LtsFlowLogStreamEnable))) return false;

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
                if (this.LtsEnable != null) hashCode = hashCode * 59 + this.LtsEnable.GetHashCode();
                if (this.LtsLogGroupId != null) hashCode = hashCode * 59 + this.LtsLogGroupId.GetHashCode();
                if (this.LtsAttackLogStreamId != null) hashCode = hashCode * 59 + this.LtsAttackLogStreamId.GetHashCode();
                if (this.LtsAttackLogStreamEnable != null) hashCode = hashCode * 59 + this.LtsAttackLogStreamEnable.GetHashCode();
                if (this.LtsAccessLogStreamId != null) hashCode = hashCode * 59 + this.LtsAccessLogStreamId.GetHashCode();
                if (this.LtsAccessLogStreamEnable != null) hashCode = hashCode * 59 + this.LtsAccessLogStreamEnable.GetHashCode();
                if (this.LtsFlowLogStreamId != null) hashCode = hashCode * 59 + this.LtsFlowLogStreamId.GetHashCode();
                if (this.LtsFlowLogStreamEnable != null) hashCode = hashCode * 59 + this.LtsFlowLogStreamEnable.GetHashCode();
                return hashCode;
            }
        }
    }
}
