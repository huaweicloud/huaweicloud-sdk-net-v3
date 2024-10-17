using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 异步创建任务请求体。
    /// </summary>
    public class AsyncCreateJobReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("base_info", NullValueHandling = NullValueHandling.Ignore)]
        public JobBaseInfo BaseInfo { get; set; }

        /// <summary>
        /// 创建任务数据库信息体。
        /// </summary>
        [JsonProperty("source_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public List<JobEndpointInfo> SourceEndpoint { get; set; }

        /// <summary>
        /// 创建任务数据库信息体。
        /// </summary>
        [JsonProperty("target_endpoint", NullValueHandling = NullValueHandling.Ignore)]
        public List<JobEndpointInfo> TargetEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("alarm_notify", NullValueHandling = NullValueHandling.Ignore)]
        public AlarmNotifyConfig AlarmNotify { get; set; }

        /// <summary>
        /// 限速信息体。 - 限速：自定义的最大迁移速度，迁移过程中的迁移速度将不会超过该速度。 - 不限速：对迁移速度不进行限制，通常会最大化使用源数据库的出口带宽。该流速模式同时会对源数据库造成读消耗，消耗取决于源数据库的出口带宽。比如：源数据库的出口带宽为100MB/s，假设高速模式使用了80%带宽，则迁移对源数据库将造成80MB/s的读操作IO消耗。
        /// </summary>
        [JsonProperty("speed_limit", NullValueHandling = NullValueHandling.Ignore)]
        public List<SpeedLimitInfo> SpeedLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("user_migration", NullValueHandling = NullValueHandling.Ignore)]
        public UserMigrationInfo UserMigration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("policy_config", NullValueHandling = NullValueHandling.Ignore)]
        public PolicyConfig PolicyConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("db_object", NullValueHandling = NullValueHandling.Ignore)]
        public DbObject DbObject { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("db_param", NullValueHandling = NullValueHandling.Ignore)]
        public DbParamInfo DbParam { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tuning_params", NullValueHandling = NullValueHandling.Ignore)]
        public TuningParamInfo TuningParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("period_order", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodOrderInfo PeriodOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("node_info", NullValueHandling = NullValueHandling.Ignore)]
        public JobNodeInfo NodeInfo { get; set; }

        /// <summary>
        /// 指定公网IP的信息
        /// </summary>
        [JsonProperty("public_ip_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<PublicIpConfig> PublicIpList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AsyncCreateJobReq {\n");
            sb.Append("  baseInfo: ").Append(BaseInfo).Append("\n");
            sb.Append("  sourceEndpoint: ").Append(SourceEndpoint).Append("\n");
            sb.Append("  targetEndpoint: ").Append(TargetEndpoint).Append("\n");
            sb.Append("  alarmNotify: ").Append(AlarmNotify).Append("\n");
            sb.Append("  speedLimit: ").Append(SpeedLimit).Append("\n");
            sb.Append("  userMigration: ").Append(UserMigration).Append("\n");
            sb.Append("  policyConfig: ").Append(PolicyConfig).Append("\n");
            sb.Append("  dbObject: ").Append(DbObject).Append("\n");
            sb.Append("  dbParam: ").Append(DbParam).Append("\n");
            sb.Append("  tuningParams: ").Append(TuningParams).Append("\n");
            sb.Append("  periodOrder: ").Append(PeriodOrder).Append("\n");
            sb.Append("  nodeInfo: ").Append(NodeInfo).Append("\n");
            sb.Append("  publicIpList: ").Append(PublicIpList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AsyncCreateJobReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AsyncCreateJobReq input)
        {
            if (input == null) return false;
            if (this.BaseInfo != input.BaseInfo || (this.BaseInfo != null && !this.BaseInfo.Equals(input.BaseInfo))) return false;
            if (this.SourceEndpoint != input.SourceEndpoint || (this.SourceEndpoint != null && input.SourceEndpoint != null && !this.SourceEndpoint.SequenceEqual(input.SourceEndpoint))) return false;
            if (this.TargetEndpoint != input.TargetEndpoint || (this.TargetEndpoint != null && input.TargetEndpoint != null && !this.TargetEndpoint.SequenceEqual(input.TargetEndpoint))) return false;
            if (this.AlarmNotify != input.AlarmNotify || (this.AlarmNotify != null && !this.AlarmNotify.Equals(input.AlarmNotify))) return false;
            if (this.SpeedLimit != input.SpeedLimit || (this.SpeedLimit != null && input.SpeedLimit != null && !this.SpeedLimit.SequenceEqual(input.SpeedLimit))) return false;
            if (this.UserMigration != input.UserMigration || (this.UserMigration != null && !this.UserMigration.Equals(input.UserMigration))) return false;
            if (this.PolicyConfig != input.PolicyConfig || (this.PolicyConfig != null && !this.PolicyConfig.Equals(input.PolicyConfig))) return false;
            if (this.DbObject != input.DbObject || (this.DbObject != null && !this.DbObject.Equals(input.DbObject))) return false;
            if (this.DbParam != input.DbParam || (this.DbParam != null && !this.DbParam.Equals(input.DbParam))) return false;
            if (this.TuningParams != input.TuningParams || (this.TuningParams != null && !this.TuningParams.Equals(input.TuningParams))) return false;
            if (this.PeriodOrder != input.PeriodOrder || (this.PeriodOrder != null && !this.PeriodOrder.Equals(input.PeriodOrder))) return false;
            if (this.NodeInfo != input.NodeInfo || (this.NodeInfo != null && !this.NodeInfo.Equals(input.NodeInfo))) return false;
            if (this.PublicIpList != input.PublicIpList || (this.PublicIpList != null && input.PublicIpList != null && !this.PublicIpList.SequenceEqual(input.PublicIpList))) return false;

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
                if (this.BaseInfo != null) hashCode = hashCode * 59 + this.BaseInfo.GetHashCode();
                if (this.SourceEndpoint != null) hashCode = hashCode * 59 + this.SourceEndpoint.GetHashCode();
                if (this.TargetEndpoint != null) hashCode = hashCode * 59 + this.TargetEndpoint.GetHashCode();
                if (this.AlarmNotify != null) hashCode = hashCode * 59 + this.AlarmNotify.GetHashCode();
                if (this.SpeedLimit != null) hashCode = hashCode * 59 + this.SpeedLimit.GetHashCode();
                if (this.UserMigration != null) hashCode = hashCode * 59 + this.UserMigration.GetHashCode();
                if (this.PolicyConfig != null) hashCode = hashCode * 59 + this.PolicyConfig.GetHashCode();
                if (this.DbObject != null) hashCode = hashCode * 59 + this.DbObject.GetHashCode();
                if (this.DbParam != null) hashCode = hashCode * 59 + this.DbParam.GetHashCode();
                if (this.TuningParams != null) hashCode = hashCode * 59 + this.TuningParams.GetHashCode();
                if (this.PeriodOrder != null) hashCode = hashCode * 59 + this.PeriodOrder.GetHashCode();
                if (this.NodeInfo != null) hashCode = hashCode * 59 + this.NodeInfo.GetHashCode();
                if (this.PublicIpList != null) hashCode = hashCode * 59 + this.PublicIpList.GetHashCode();
                return hashCode;
            }
        }
    }
}
