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
    /// Request Object
    /// </summary>
    public class ListTasksRequest 
    {

        /// <summary>
        /// 查询开始时间，格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始，Z指时区偏移量
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 查询结束时间，格式为“yyyy-mm-ddThh:mm:ssZ”，且大于查询开始时间，时间跨度不超过30天。 其中，T指某个时间的开始，Z指时区偏移量。
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 任务状态： 取值为“Running”为执行中； 取值为“Completed”为完成； 取值为“Failed” 为失败。
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 任务名称。对应取值如下： - \&quot;CreateMongoDB\&quot;：创建集群实例 - \&quot;CreateMongoDBReplica\&quot;：创建副本集实例 - \&quot;CreateMongoDBReplicaSingle\&quot;：创建单节点实例 - \&quot;EnlargeMongoDBVolume\&quot;：磁盘扩容 - \&quot;ResizeMongoDBInstance\&quot;：社区版实例规格变更 - \&quot;ResizeDfvMongoDBInstance\&quot;：社区增强版实例规格变更 - \&quot;EnlargeMongoDBGroup\&quot;：添加节点 - \&quot;ReplicaSetEnlargeNode\&quot;：副本集添加备节点 - \&quot;AddReadonlyNode\&quot;：添加只读节点 - \&quot;RestartInstance\&quot;：重启集群实例 - \&quot;RestartGroup\&quot;：重启集群节点组 - \&quot;RestartNode\&quot;：重启集群节点 - \&quot;RestartReplicaSetInstance\&quot;：重启副本集实例 - \&quot;RestartReplicaSingleInstance\&quot;：重启单节点实例 - \&quot;SwitchPrimary\&quot;：主备切换 - \&quot;ModifyIp\&quot;：修改内网地址 - \&quot;ModifySecurityGroup\&quot;：修改安全组 - \&quot;ModifyPort\&quot;：修改数据库端口 - \&quot;BindPublicIP\&quot;：绑定弹性IP - \&quot;UnbindPublicIP\&quot;：解绑弹性IP - \&quot;SwitchInstanceSSL\&quot;：切换SSL - \&quot;AzMigrate\&quot;：迁移可用区 - \&quot;CreateIp\&quot;：显示shard/config IP - \&quot;ModifyOpLogSize\&quot;：修改oplog大小 - \&quot;RestoreMongoDB\&quot;：集群恢复到新实例 - \&quot;RestoreMongoDB_Replica\&quot;：副本集恢复到新实例 - \&quot;RestoreMongoDB_Replica_Single\&quot;：单节点恢复到新实例 - \&quot;RestoreMongoDB_Replica_PITR\&quot;：副本集恢复到指定时间点 - \&quot;MongodbSnapshotBackup\&quot;：创建物理备份 - \&quot;MongodbSnapshotEBackup\&quot;：创建快照备份 - \&quot;MongodbRestoreData2CurrentInstance\&quot;：备份恢复到当前实例 - \&quot;MongodbRestoreData2NewInstance\&quot;：备份恢复到新实例 - \&quot;MongodbPitr2CurrentInstance\&quot;：备份恢复到当前实例指定时间点 - \&quot;MongodbPitr2NewInstance\&quot;：备份恢复到新实例指定时间点 - \&quot;MongodbRecycleBackup\&quot;：备份回收 - \&quot;MongodbRestoreTable\&quot;：库表级时间点恢复 - \&quot;UpgradeDatabaseVersion\&quot;：升级数据库补丁
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 索引位置，偏移量。从第一条数据偏移offset条数据后开始查询，默认为0（偏移0条数据，表示从第一条数据开始查询），必须为数字，不能为负数。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询记录数。默认为100，不能为负数，最小值为1，最大值为100。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTasksRequest {\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTasksRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTasksRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
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
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
