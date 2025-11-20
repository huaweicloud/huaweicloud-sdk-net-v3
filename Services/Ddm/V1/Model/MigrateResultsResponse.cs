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
    public class MigrateResultsResponse : SdkResponse
    {

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 原始分片数。
        /// </summary>
        [JsonProperty("original_shard_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? OriginalShardNum { get; set; }

        /// <summary>
        /// 现分片数。
        /// </summary>
        [JsonProperty("after_shard_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? AfterShardNum { get; set; }

        /// <summary>
        /// 分片变更前关联的后端DN信息。
        /// </summary>
        [JsonProperty("original_dn_info_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<MigrateDnInfoOpenResponse> OriginalDnInfoList { get; set; }

        /// <summary>
        /// 分片变更后关联的后端DN信息。
        /// </summary>
        [JsonProperty("after_dn_info_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<MigrateDnInfoOpenResponse> AfterDnInfoList { get; set; }

        /// <summary>
        /// 是否手动切换路由。
        /// </summary>
        [JsonProperty("switch_route_is_manual", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SwitchRouteIsManual { get; set; }

        /// <summary>
        /// 自动切换路由开始时间。
        /// </summary>
        [JsonProperty("auto_switch_begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AutoSwitchBeginTime { get; set; }

        /// <summary>
        /// 自动切换路由结束时间。
        /// </summary>
        [JsonProperty("auto_switch_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string AutoSwitchEndTime { get; set; }

        /// <summary>
        /// 分片变更的节点。
        /// </summary>
        [JsonProperty("node_id_for_migrate", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeIdForMigrate { get; set; }

        /// <summary>
        /// 是否独占式。
        /// </summary>
        [JsonProperty("is_exclusive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsExclusive { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrateResultsResponse {\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  originalShardNum: ").Append(OriginalShardNum).Append("\n");
            sb.Append("  afterShardNum: ").Append(AfterShardNum).Append("\n");
            sb.Append("  originalDnInfoList: ").Append(OriginalDnInfoList).Append("\n");
            sb.Append("  afterDnInfoList: ").Append(AfterDnInfoList).Append("\n");
            sb.Append("  switchRouteIsManual: ").Append(SwitchRouteIsManual).Append("\n");
            sb.Append("  autoSwitchBeginTime: ").Append(AutoSwitchBeginTime).Append("\n");
            sb.Append("  autoSwitchEndTime: ").Append(AutoSwitchEndTime).Append("\n");
            sb.Append("  nodeIdForMigrate: ").Append(NodeIdForMigrate).Append("\n");
            sb.Append("  isExclusive: ").Append(IsExclusive).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigrateResultsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MigrateResultsResponse input)
        {
            if (input == null) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.OriginalShardNum != input.OriginalShardNum || (this.OriginalShardNum != null && !this.OriginalShardNum.Equals(input.OriginalShardNum))) return false;
            if (this.AfterShardNum != input.AfterShardNum || (this.AfterShardNum != null && !this.AfterShardNum.Equals(input.AfterShardNum))) return false;
            if (this.OriginalDnInfoList != input.OriginalDnInfoList || (this.OriginalDnInfoList != null && input.OriginalDnInfoList != null && !this.OriginalDnInfoList.SequenceEqual(input.OriginalDnInfoList))) return false;
            if (this.AfterDnInfoList != input.AfterDnInfoList || (this.AfterDnInfoList != null && input.AfterDnInfoList != null && !this.AfterDnInfoList.SequenceEqual(input.AfterDnInfoList))) return false;
            if (this.SwitchRouteIsManual != input.SwitchRouteIsManual || (this.SwitchRouteIsManual != null && !this.SwitchRouteIsManual.Equals(input.SwitchRouteIsManual))) return false;
            if (this.AutoSwitchBeginTime != input.AutoSwitchBeginTime || (this.AutoSwitchBeginTime != null && !this.AutoSwitchBeginTime.Equals(input.AutoSwitchBeginTime))) return false;
            if (this.AutoSwitchEndTime != input.AutoSwitchEndTime || (this.AutoSwitchEndTime != null && !this.AutoSwitchEndTime.Equals(input.AutoSwitchEndTime))) return false;
            if (this.NodeIdForMigrate != input.NodeIdForMigrate || (this.NodeIdForMigrate != null && !this.NodeIdForMigrate.Equals(input.NodeIdForMigrate))) return false;
            if (this.IsExclusive != input.IsExclusive || (this.IsExclusive != null && !this.IsExclusive.Equals(input.IsExclusive))) return false;

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
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.OriginalShardNum != null) hashCode = hashCode * 59 + this.OriginalShardNum.GetHashCode();
                if (this.AfterShardNum != null) hashCode = hashCode * 59 + this.AfterShardNum.GetHashCode();
                if (this.OriginalDnInfoList != null) hashCode = hashCode * 59 + this.OriginalDnInfoList.GetHashCode();
                if (this.AfterDnInfoList != null) hashCode = hashCode * 59 + this.AfterDnInfoList.GetHashCode();
                if (this.SwitchRouteIsManual != null) hashCode = hashCode * 59 + this.SwitchRouteIsManual.GetHashCode();
                if (this.AutoSwitchBeginTime != null) hashCode = hashCode * 59 + this.AutoSwitchBeginTime.GetHashCode();
                if (this.AutoSwitchEndTime != null) hashCode = hashCode * 59 + this.AutoSwitchEndTime.GetHashCode();
                if (this.NodeIdForMigrate != null) hashCode = hashCode * 59 + this.NodeIdForMigrate.GetHashCode();
                if (this.IsExclusive != null) hashCode = hashCode * 59 + this.IsExclusive.GetHashCode();
                return hashCode;
            }
        }
    }
}
