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
    /// 
    /// </summary>
    public class DiskVolumes 
    {

        /// <summary>
        /// 实例ID或组ID或节点ID。可以调用“查询实例列表和详情”接口获取。如果未申请实例，可以调用“创建实例”接口创建。 - 当变更的实例类型是集群，如果变更的是shard组或者config组的参数模板，传值为组ID。如果变更的是mongos节点的参数模板，传值为节点ID。 - 当变更的实例类型是副本集或单节点，传值为实例ID。
        /// </summary>
        [JsonProperty("entity_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EntityId { get; set; }

        /// <summary>
        /// 实例名称或组名称或节点名称
        /// </summary>
        [JsonProperty("entity_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EntityName { get; set; }

        /// <summary>
        /// group_type。取值范围： - mongos，表示集群mongos节点类型。 - shard，表示集群shard节点类型。 - config，表示集群config节点类型。 - replica，表示副本集类型。 - single，表示单节点类型。 - readonly，表示只读节点类型。
        /// </summary>
        [JsonProperty("group_type", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupType { get; set; }

        /// <summary>
        /// 使用量，保留两位小数，单位(GB)
        /// </summary>
        [JsonProperty("used", NullValueHandling = NullValueHandling.Ignore)]
        public string Used { get; set; }

        /// <summary>
        /// 总大小，单位(GB)
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public string Size { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiskVolumes {\n");
            sb.Append("  entityId: ").Append(EntityId).Append("\n");
            sb.Append("  entityName: ").Append(EntityName).Append("\n");
            sb.Append("  groupType: ").Append(GroupType).Append("\n");
            sb.Append("  used: ").Append(Used).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DiskVolumes);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DiskVolumes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.EntityName == input.EntityName ||
                    (this.EntityName != null &&
                    this.EntityName.Equals(input.EntityName))
                ) && 
                (
                    this.GroupType == input.GroupType ||
                    (this.GroupType != null &&
                    this.GroupType.Equals(input.GroupType))
                ) && 
                (
                    this.Used == input.Used ||
                    (this.Used != null &&
                    this.Used.Equals(input.Used))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
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
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.EntityName != null)
                    hashCode = hashCode * 59 + this.EntityName.GetHashCode();
                if (this.GroupType != null)
                    hashCode = hashCode * 59 + this.GroupType.GetHashCode();
                if (this.Used != null)
                    hashCode = hashCode * 59 + this.Used.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                return hashCode;
            }
        }
    }
}
