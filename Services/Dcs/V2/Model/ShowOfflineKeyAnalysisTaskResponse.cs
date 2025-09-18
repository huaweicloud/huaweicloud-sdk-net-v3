using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowOfflineKeyAnalysisTaskResponse : SdkResponse
    {
        /// <summary>
        /// **参数解释**： 分析类型。 **取值范围**： new_backup：新建备份并分析。 old_backup：历史备份文件分析。 
        /// </summary>
        /// <value>**参数解释**： 分析类型。 **取值范围**： new_backup：新建备份并分析。 old_backup：历史备份文件分析。 </value>
        [JsonConverter(typeof(EnumClassConverter<AnalysisTypeEnum>))]
        public class AnalysisTypeEnum
        {
            /// <summary>
            /// Enum NEW_BACKUP for value: new_backup
            /// </summary>
            public static readonly AnalysisTypeEnum NEW_BACKUP = new AnalysisTypeEnum("new_backup");

            /// <summary>
            /// Enum OLD_BACKUP for value: old_backup
            /// </summary>
            public static readonly AnalysisTypeEnum OLD_BACKUP = new AnalysisTypeEnum("old_backup");

            private static readonly Dictionary<string, AnalysisTypeEnum> StaticFields =
            new Dictionary<string, AnalysisTypeEnum>()
            {
                { "new_backup", NEW_BACKUP },
                { "old_backup", OLD_BACKUP },
            };

            private string _value;

            public AnalysisTypeEnum()
            {

            }

            public AnalysisTypeEnum(string value)
            {
                _value = value;
            }

            public static AnalysisTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as AnalysisTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AnalysisTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AnalysisTypeEnum a, AnalysisTypeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(AnalysisTypeEnum a, AnalysisTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**： 任务执行记录ID（此ID对应“查询离线全量key分析详情”参数中的任务ID）。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释**： 实例ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释**： 节点ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        /// <summary>
        /// **参数解释**： 备份ID。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupId { get; set; }

        /// <summary>
        /// **参数解释**： 分片名称。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// **参数解释**： 节点ipv4地址。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("node_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeIp { get; set; }

        /// <summary>
        /// **参数解释**： 节点ipv6地址。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("node_ipv6", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeIpv6 { get; set; }

        /// <summary>
        /// **参数解释**： 节点类型。 **取值范围**： master：主节点 slave：从节点 
        /// </summary>
        [JsonProperty("node_type", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeType { get; set; }

        /// <summary>
        /// **参数解释**： 分析类型。 **取值范围**： new_backup：新建备份并分析。 old_backup：历史备份文件分析。 
        /// </summary>
        [JsonProperty("analysis_type", NullValueHandling = NullValueHandling.Ignore)]
        public AnalysisTypeEnum AnalysisType { get; set; }
        /// <summary>
        /// **参数解释**： 分析任务开始时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("started_at", NullValueHandling = NullValueHandling.Ignore)]
        public string StartedAt { get; set; }

        /// <summary>
        /// **参数解释**： 分析任务结束时间。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("finished_at", NullValueHandling = NullValueHandling.Ignore)]
        public string FinishedAt { get; set; }

        /// <summary>
        /// **参数解释**： 前缀Key列表。 
        /// </summary>
        [JsonProperty("largest_key_prefixes", NullValueHandling = NullValueHandling.Ignore)]
        public List<LargestKeyPrefix> LargestKeyPrefixes { get; set; }

        /// <summary>
        /// **参数解释**： 大key列表。 
        /// </summary>
        [JsonProperty("largest_keys", NullValueHandling = NullValueHandling.Ignore)]
        public List<LargestKey> LargestKeys { get; set; }

        /// <summary>
        /// **参数解释**： Key的总大小，单位：Bytes。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("total_bytes", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalBytes { get; set; }

        /// <summary>
        /// **参数解释**： Key的总数。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("total_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalNum { get; set; }

        /// <summary>
        /// **参数解释**： 每种类型key的总大小，单位：Bytes。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("type_bytes", NullValueHandling = NullValueHandling.Ignore)]
        public List<KeyTypeByte> TypeBytes { get; set; }

        /// <summary>
        /// **参数解释**： 每种类型key总数。 **取值范围**： 不涉及。 
        /// </summary>
        [JsonProperty("type_num", NullValueHandling = NullValueHandling.Ignore)]
        public List<KeyTypeNum> TypeNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowOfflineKeyAnalysisTaskResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  nodeId: ").Append(NodeId).Append("\n");
            sb.Append("  backupId: ").Append(BackupId).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  nodeIp: ").Append(NodeIp).Append("\n");
            sb.Append("  nodeIpv6: ").Append(NodeIpv6).Append("\n");
            sb.Append("  nodeType: ").Append(NodeType).Append("\n");
            sb.Append("  analysisType: ").Append(AnalysisType).Append("\n");
            sb.Append("  startedAt: ").Append(StartedAt).Append("\n");
            sb.Append("  finishedAt: ").Append(FinishedAt).Append("\n");
            sb.Append("  largestKeyPrefixes: ").Append(LargestKeyPrefixes).Append("\n");
            sb.Append("  largestKeys: ").Append(LargestKeys).Append("\n");
            sb.Append("  totalBytes: ").Append(TotalBytes).Append("\n");
            sb.Append("  totalNum: ").Append(TotalNum).Append("\n");
            sb.Append("  typeBytes: ").Append(TypeBytes).Append("\n");
            sb.Append("  typeNum: ").Append(TypeNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowOfflineKeyAnalysisTaskResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowOfflineKeyAnalysisTaskResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.NodeId != input.NodeId || (this.NodeId != null && !this.NodeId.Equals(input.NodeId))) return false;
            if (this.BackupId != input.BackupId || (this.BackupId != null && !this.BackupId.Equals(input.BackupId))) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.NodeIp != input.NodeIp || (this.NodeIp != null && !this.NodeIp.Equals(input.NodeIp))) return false;
            if (this.NodeIpv6 != input.NodeIpv6 || (this.NodeIpv6 != null && !this.NodeIpv6.Equals(input.NodeIpv6))) return false;
            if (this.NodeType != input.NodeType || (this.NodeType != null && !this.NodeType.Equals(input.NodeType))) return false;
            if (this.AnalysisType != input.AnalysisType) return false;
            if (this.StartedAt != input.StartedAt || (this.StartedAt != null && !this.StartedAt.Equals(input.StartedAt))) return false;
            if (this.FinishedAt != input.FinishedAt || (this.FinishedAt != null && !this.FinishedAt.Equals(input.FinishedAt))) return false;
            if (this.LargestKeyPrefixes != input.LargestKeyPrefixes || (this.LargestKeyPrefixes != null && input.LargestKeyPrefixes != null && !this.LargestKeyPrefixes.SequenceEqual(input.LargestKeyPrefixes))) return false;
            if (this.LargestKeys != input.LargestKeys || (this.LargestKeys != null && input.LargestKeys != null && !this.LargestKeys.SequenceEqual(input.LargestKeys))) return false;
            if (this.TotalBytes != input.TotalBytes || (this.TotalBytes != null && !this.TotalBytes.Equals(input.TotalBytes))) return false;
            if (this.TotalNum != input.TotalNum || (this.TotalNum != null && !this.TotalNum.Equals(input.TotalNum))) return false;
            if (this.TypeBytes != input.TypeBytes || (this.TypeBytes != null && input.TypeBytes != null && !this.TypeBytes.SequenceEqual(input.TypeBytes))) return false;
            if (this.TypeNum != input.TypeNum || (this.TypeNum != null && input.TypeNum != null && !this.TypeNum.SequenceEqual(input.TypeNum))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.NodeId != null) hashCode = hashCode * 59 + this.NodeId.GetHashCode();
                if (this.BackupId != null) hashCode = hashCode * 59 + this.BackupId.GetHashCode();
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.NodeIp != null) hashCode = hashCode * 59 + this.NodeIp.GetHashCode();
                if (this.NodeIpv6 != null) hashCode = hashCode * 59 + this.NodeIpv6.GetHashCode();
                if (this.NodeType != null) hashCode = hashCode * 59 + this.NodeType.GetHashCode();
                hashCode = hashCode * 59 + this.AnalysisType.GetHashCode();
                if (this.StartedAt != null) hashCode = hashCode * 59 + this.StartedAt.GetHashCode();
                if (this.FinishedAt != null) hashCode = hashCode * 59 + this.FinishedAt.GetHashCode();
                if (this.LargestKeyPrefixes != null) hashCode = hashCode * 59 + this.LargestKeyPrefixes.GetHashCode();
                if (this.LargestKeys != null) hashCode = hashCode * 59 + this.LargestKeys.GetHashCode();
                if (this.TotalBytes != null) hashCode = hashCode * 59 + this.TotalBytes.GetHashCode();
                if (this.TotalNum != null) hashCode = hashCode * 59 + this.TotalNum.GetHashCode();
                if (this.TypeBytes != null) hashCode = hashCode * 59 + this.TypeBytes.GetHashCode();
                if (this.TypeNum != null) hashCode = hashCode * 59 + this.TypeNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
