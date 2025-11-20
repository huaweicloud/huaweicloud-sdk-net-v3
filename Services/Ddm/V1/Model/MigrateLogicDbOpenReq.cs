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
    /// 
    /// </summary>
    public class MigrateLogicDbOpenReq 
    {

        /// <summary>
        /// 关联的后端DN信息。
        /// </summary>
        [JsonProperty("data_nodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<DataNode> DataNodes { get; set; }

        /// <summary>
        /// 路由切换开始时间。
        /// </summary>
        [JsonProperty("switch_route_begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string SwitchRouteBeginTime { get; set; }

        /// <summary>
        /// 路由切换结束时间。
        /// </summary>
        [JsonProperty("switch_route_end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string SwitchRouteEndTime { get; set; }

        /// <summary>
        /// 新分片数。
        /// </summary>
        [JsonProperty("new_shard_number", NullValueHandling = NullValueHandling.Ignore)]
        public string NewShardNumber { get; set; }

        /// <summary>
        /// 是否独占。
        /// </summary>
        [JsonProperty("is_exclusive", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsExclusive { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigrateLogicDbOpenReq {\n");
            sb.Append("  dataNodes: ").Append(DataNodes).Append("\n");
            sb.Append("  switchRouteBeginTime: ").Append(SwitchRouteBeginTime).Append("\n");
            sb.Append("  switchRouteEndTime: ").Append(SwitchRouteEndTime).Append("\n");
            sb.Append("  newShardNumber: ").Append(NewShardNumber).Append("\n");
            sb.Append("  isExclusive: ").Append(IsExclusive).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MigrateLogicDbOpenReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MigrateLogicDbOpenReq input)
        {
            if (input == null) return false;
            if (this.DataNodes != input.DataNodes || (this.DataNodes != null && input.DataNodes != null && !this.DataNodes.SequenceEqual(input.DataNodes))) return false;
            if (this.SwitchRouteBeginTime != input.SwitchRouteBeginTime || (this.SwitchRouteBeginTime != null && !this.SwitchRouteBeginTime.Equals(input.SwitchRouteBeginTime))) return false;
            if (this.SwitchRouteEndTime != input.SwitchRouteEndTime || (this.SwitchRouteEndTime != null && !this.SwitchRouteEndTime.Equals(input.SwitchRouteEndTime))) return false;
            if (this.NewShardNumber != input.NewShardNumber || (this.NewShardNumber != null && !this.NewShardNumber.Equals(input.NewShardNumber))) return false;
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
                if (this.DataNodes != null) hashCode = hashCode * 59 + this.DataNodes.GetHashCode();
                if (this.SwitchRouteBeginTime != null) hashCode = hashCode * 59 + this.SwitchRouteBeginTime.GetHashCode();
                if (this.SwitchRouteEndTime != null) hashCode = hashCode * 59 + this.SwitchRouteEndTime.GetHashCode();
                if (this.NewShardNumber != null) hashCode = hashCode * 59 + this.NewShardNumber.GetHashCode();
                if (this.IsExclusive != null) hashCode = hashCode * 59 + this.IsExclusive.GetHashCode();
                return hashCode;
            }
        }
    }
}
