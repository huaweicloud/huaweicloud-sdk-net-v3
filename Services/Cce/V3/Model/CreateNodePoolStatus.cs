using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreateNodePoolStatus 
    {
        /// <summary>
        /// 节点池状态。 - 空值：可用（节点池当前节点数已达到预期，且无伸缩中的节点） - Synchronizing：伸缩中（节点池当前节点数未达到预期，且无伸缩中的节点） - Synchronized：伸缩等待中（节点池当前节点数未达到预期，或者存在伸缩中的节点） - SoldOut：节点池当前不可扩容（兼容字段，标记节点池资源售罄、资源配额不足等不可扩容状态） &gt; 上述节点池状态已废弃，仅兼容保留，不建议使用，替代感知方式如下： &gt; - 节点池扩缩状态：可通过currentNode/creatingNode/deletingNode节点状态统计信息，精确感知当前节点池扩缩状态。 &gt; - 节点池可扩容状态：可通过conditions感知节点池详细状态，其中\&quot;Scalable\&quot;可替代SoldOut语义。 - Deleting：删除中 - Error：错误 
        /// </summary>
        /// <value>节点池状态。 - 空值：可用（节点池当前节点数已达到预期，且无伸缩中的节点） - Synchronizing：伸缩中（节点池当前节点数未达到预期，且无伸缩中的节点） - Synchronized：伸缩等待中（节点池当前节点数未达到预期，或者存在伸缩中的节点） - SoldOut：节点池当前不可扩容（兼容字段，标记节点池资源售罄、资源配额不足等不可扩容状态） &gt; 上述节点池状态已废弃，仅兼容保留，不建议使用，替代感知方式如下： &gt; - 节点池扩缩状态：可通过currentNode/creatingNode/deletingNode节点状态统计信息，精确感知当前节点池扩缩状态。 &gt; - 节点池可扩容状态：可通过conditions感知节点池详细状态，其中\&quot;Scalable\&quot;可替代SoldOut语义。 - Deleting：删除中 - Error：错误 </value>
        [JsonConverter(typeof(EnumClassConverter<PhaseEnum>))]
        public class PhaseEnum
        {
            /// <summary>
            /// Enum SYNCHRONIZING for value: Synchronizing
            /// </summary>
            public static readonly PhaseEnum SYNCHRONIZING = new PhaseEnum("Synchronizing");

            /// <summary>
            /// Enum SYNCHRONIZED for value: Synchronized
            /// </summary>
            public static readonly PhaseEnum SYNCHRONIZED = new PhaseEnum("Synchronized");

            /// <summary>
            /// Enum SOLDOUT for value: SoldOut
            /// </summary>
            public static readonly PhaseEnum SOLDOUT = new PhaseEnum("SoldOut");

            /// <summary>
            /// Enum DELETING for value: Deleting
            /// </summary>
            public static readonly PhaseEnum DELETING = new PhaseEnum("Deleting");

            /// <summary>
            /// Enum ERROR for value: Error
            /// </summary>
            public static readonly PhaseEnum ERROR = new PhaseEnum("Error");

            private static readonly Dictionary<string, PhaseEnum> StaticFields =
            new Dictionary<string, PhaseEnum>()
            {
                { "Synchronizing", SYNCHRONIZING },
                { "Synchronized", SYNCHRONIZED },
                { "SoldOut", SOLDOUT },
                { "Deleting", DELETING },
                { "Error", ERROR },
            };

            private string _value;

            public PhaseEnum()
            {

            }

            public PhaseEnum(string value)
            {
                _value = value;
            }

            public static PhaseEnum FromValue(string value)
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

                if (this.Equals(obj as PhaseEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PhaseEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PhaseEnum a, PhaseEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(PhaseEnum a, PhaseEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 当前节点池中所有节点数量（不含删除中的节点）。
        /// </summary>
        [JsonProperty("currentNode", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentNode { get; set; }

        /// <summary>
        /// 当前节点池中处于创建流程中的节点数量。
        /// </summary>
        [JsonProperty("creatingNode", NullValueHandling = NullValueHandling.Ignore)]
        public int? CreatingNode { get; set; }

        /// <summary>
        /// 当前节点池中删除中的节点数量。
        /// </summary>
        [JsonProperty("deletingNode", NullValueHandling = NullValueHandling.Ignore)]
        public int? DeletingNode { get; set; }

        /// <summary>
        /// 节点池状态。 - 空值：可用（节点池当前节点数已达到预期，且无伸缩中的节点） - Synchronizing：伸缩中（节点池当前节点数未达到预期，且无伸缩中的节点） - Synchronized：伸缩等待中（节点池当前节点数未达到预期，或者存在伸缩中的节点） - SoldOut：节点池当前不可扩容（兼容字段，标记节点池资源售罄、资源配额不足等不可扩容状态） &gt; 上述节点池状态已废弃，仅兼容保留，不建议使用，替代感知方式如下： &gt; - 节点池扩缩状态：可通过currentNode/creatingNode/deletingNode节点状态统计信息，精确感知当前节点池扩缩状态。 &gt; - 节点池可扩容状态：可通过conditions感知节点池详细状态，其中\&quot;Scalable\&quot;可替代SoldOut语义。 - Deleting：删除中 - Error：错误 
        /// </summary>
        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public PhaseEnum Phase { get; set; }
        /// <summary>
        /// 节点池当前详细状态列表，详情参见Condition类型定义。 
        /// </summary>
        [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<NodePoolCondition> Conditions { get; set; }

        /// <summary>
        /// 伸缩组当前详细状态信息，详情参见ScaleGroupStatus类型定义
        /// </summary>
        [JsonProperty("scaleGroupStatuses", NullValueHandling = NullValueHandling.Ignore)]
        public List<ScaleGroupStatus> ScaleGroupStatuses { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateNodePoolStatus {\n");
            sb.Append("  currentNode: ").Append(CurrentNode).Append("\n");
            sb.Append("  creatingNode: ").Append(CreatingNode).Append("\n");
            sb.Append("  deletingNode: ").Append(DeletingNode).Append("\n");
            sb.Append("  phase: ").Append(Phase).Append("\n");
            sb.Append("  conditions: ").Append(Conditions).Append("\n");
            sb.Append("  scaleGroupStatuses: ").Append(ScaleGroupStatuses).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateNodePoolStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateNodePoolStatus input)
        {
            if (input == null) return false;
            if (this.CurrentNode != input.CurrentNode || (this.CurrentNode != null && !this.CurrentNode.Equals(input.CurrentNode))) return false;
            if (this.CreatingNode != input.CreatingNode || (this.CreatingNode != null && !this.CreatingNode.Equals(input.CreatingNode))) return false;
            if (this.DeletingNode != input.DeletingNode || (this.DeletingNode != null && !this.DeletingNode.Equals(input.DeletingNode))) return false;
            if (this.Phase != input.Phase) return false;
            if (this.Conditions != input.Conditions || (this.Conditions != null && input.Conditions != null && !this.Conditions.SequenceEqual(input.Conditions))) return false;
            if (this.ScaleGroupStatuses != input.ScaleGroupStatuses || (this.ScaleGroupStatuses != null && input.ScaleGroupStatuses != null && !this.ScaleGroupStatuses.SequenceEqual(input.ScaleGroupStatuses))) return false;

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
                if (this.CurrentNode != null) hashCode = hashCode * 59 + this.CurrentNode.GetHashCode();
                if (this.CreatingNode != null) hashCode = hashCode * 59 + this.CreatingNode.GetHashCode();
                if (this.DeletingNode != null) hashCode = hashCode * 59 + this.DeletingNode.GetHashCode();
                hashCode = hashCode * 59 + this.Phase.GetHashCode();
                if (this.Conditions != null) hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                if (this.ScaleGroupStatuses != null) hashCode = hashCode * 59 + this.ScaleGroupStatuses.GetHashCode();
                return hashCode;
            }
        }
    }
}
