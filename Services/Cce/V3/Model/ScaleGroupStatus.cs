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
    /// 伸缩组当前详细状态信息
    /// </summary>
    public class ScaleGroupStatus 
    {
        /// <summary>
        /// 伸缩组状态。 - 空值：可用（伸缩组当前节点数已达到预期，且无伸缩中的节点） - Synchronizing：伸缩中（伸缩组当前节点数未达到预期，且无伸缩中的节点） - Synchronized：伸缩等待中（伸缩组当前节点数未达到预期，或者存在伸缩中的节点） - SoldOut：伸缩组当前不可扩容（兼容字段，标记节点池资源售罄、资源配额不足等不可扩容状态） &gt; 上述伸缩组状态已废弃，仅兼容保留，不建议使用，替代感知方式如下： &gt; - 伸缩组扩缩状态：可通过desiredNodeCount/existingNodeCount/upcomingNodeCount节点状态统计信息，精确感知当前伸缩组扩缩状态。 &gt; - 伸缩组可扩容状态：可通过conditions感知伸缩组详细状态，其中\&quot;Scalable\&quot;可替代SoldOut语义。 - Deleting：删除中 - Error：错误 
        /// </summary>
        /// <value>伸缩组状态。 - 空值：可用（伸缩组当前节点数已达到预期，且无伸缩中的节点） - Synchronizing：伸缩中（伸缩组当前节点数未达到预期，且无伸缩中的节点） - Synchronized：伸缩等待中（伸缩组当前节点数未达到预期，或者存在伸缩中的节点） - SoldOut：伸缩组当前不可扩容（兼容字段，标记节点池资源售罄、资源配额不足等不可扩容状态） &gt; 上述伸缩组状态已废弃，仅兼容保留，不建议使用，替代感知方式如下： &gt; - 伸缩组扩缩状态：可通过desiredNodeCount/existingNodeCount/upcomingNodeCount节点状态统计信息，精确感知当前伸缩组扩缩状态。 &gt; - 伸缩组可扩容状态：可通过conditions感知伸缩组详细状态，其中\&quot;Scalable\&quot;可替代SoldOut语义。 - Deleting：删除中 - Error：错误 </value>
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
        /// 伸缩组名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 伸缩组uuid
        /// </summary>
        [JsonProperty("uid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uid { get; set; }

        /// <summary>
        /// 伸缩组创建时间
        /// </summary>
        [JsonProperty("creationTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string CreationTimestamp { get; set; }

        /// <summary>
        /// 伸缩组更新时间
        /// </summary>
        [JsonProperty("updateTimestamp", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTimestamp { get; set; }

        /// <summary>
        /// 伸缩组状态。 - 空值：可用（伸缩组当前节点数已达到预期，且无伸缩中的节点） - Synchronizing：伸缩中（伸缩组当前节点数未达到预期，且无伸缩中的节点） - Synchronized：伸缩等待中（伸缩组当前节点数未达到预期，或者存在伸缩中的节点） - SoldOut：伸缩组当前不可扩容（兼容字段，标记节点池资源售罄、资源配额不足等不可扩容状态） &gt; 上述伸缩组状态已废弃，仅兼容保留，不建议使用，替代感知方式如下： &gt; - 伸缩组扩缩状态：可通过desiredNodeCount/existingNodeCount/upcomingNodeCount节点状态统计信息，精确感知当前伸缩组扩缩状态。 &gt; - 伸缩组可扩容状态：可通过conditions感知伸缩组详细状态，其中\&quot;Scalable\&quot;可替代SoldOut语义。 - Deleting：删除中 - Error：错误 
        /// </summary>
        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public PhaseEnum Phase { get; set; }
        /// <summary>
        /// 伸缩组期望节点数
        /// </summary>
        [JsonProperty("desiredNodeCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? DesiredNodeCount { get; set; }

        /// <summary>
        /// 订单未支付节点个数
        /// </summary>
        [JsonProperty("unpaidScaleNodeCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? UnpaidScaleNodeCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("existingNodeCount", NullValueHandling = NullValueHandling.Ignore)]
        public ScaleGroupStatusExistingNodeCount ExistingNodeCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("upcomingNodeCount", NullValueHandling = NullValueHandling.Ignore)]
        public ScaleGroupStatusUpcomingNodeCount UpcomingNodeCount { get; set; }

        /// <summary>
        /// 伸缩组禁止缩容的节点数
        /// </summary>
        [JsonProperty("scaleDownDisabledNodeCount", NullValueHandling = NullValueHandling.Ignore)]
        public int? ScaleDownDisabledNodeCount { get; set; }

        /// <summary>
        /// 伸缩组当前详细状态列表，详情参见Condition类型定义。
        /// </summary>
        [JsonProperty("conditions", NullValueHandling = NullValueHandling.Ignore)]
        public List<NodePoolCondition> Conditions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScaleGroupStatus {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  uid: ").Append(Uid).Append("\n");
            sb.Append("  creationTimestamp: ").Append(CreationTimestamp).Append("\n");
            sb.Append("  updateTimestamp: ").Append(UpdateTimestamp).Append("\n");
            sb.Append("  phase: ").Append(Phase).Append("\n");
            sb.Append("  desiredNodeCount: ").Append(DesiredNodeCount).Append("\n");
            sb.Append("  unpaidScaleNodeCount: ").Append(UnpaidScaleNodeCount).Append("\n");
            sb.Append("  existingNodeCount: ").Append(ExistingNodeCount).Append("\n");
            sb.Append("  upcomingNodeCount: ").Append(UpcomingNodeCount).Append("\n");
            sb.Append("  scaleDownDisabledNodeCount: ").Append(ScaleDownDisabledNodeCount).Append("\n");
            sb.Append("  conditions: ").Append(Conditions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ScaleGroupStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ScaleGroupStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Uid == input.Uid ||
                    (this.Uid != null &&
                    this.Uid.Equals(input.Uid))
                ) && 
                (
                    this.CreationTimestamp == input.CreationTimestamp ||
                    (this.CreationTimestamp != null &&
                    this.CreationTimestamp.Equals(input.CreationTimestamp))
                ) && 
                (
                    this.UpdateTimestamp == input.UpdateTimestamp ||
                    (this.UpdateTimestamp != null &&
                    this.UpdateTimestamp.Equals(input.UpdateTimestamp))
                ) && 
                (
                    this.Phase == input.Phase ||
                    (this.Phase != null &&
                    this.Phase.Equals(input.Phase))
                ) && 
                (
                    this.DesiredNodeCount == input.DesiredNodeCount ||
                    (this.DesiredNodeCount != null &&
                    this.DesiredNodeCount.Equals(input.DesiredNodeCount))
                ) && 
                (
                    this.UnpaidScaleNodeCount == input.UnpaidScaleNodeCount ||
                    (this.UnpaidScaleNodeCount != null &&
                    this.UnpaidScaleNodeCount.Equals(input.UnpaidScaleNodeCount))
                ) && 
                (
                    this.ExistingNodeCount == input.ExistingNodeCount ||
                    (this.ExistingNodeCount != null &&
                    this.ExistingNodeCount.Equals(input.ExistingNodeCount))
                ) && 
                (
                    this.UpcomingNodeCount == input.UpcomingNodeCount ||
                    (this.UpcomingNodeCount != null &&
                    this.UpcomingNodeCount.Equals(input.UpcomingNodeCount))
                ) && 
                (
                    this.ScaleDownDisabledNodeCount == input.ScaleDownDisabledNodeCount ||
                    (this.ScaleDownDisabledNodeCount != null &&
                    this.ScaleDownDisabledNodeCount.Equals(input.ScaleDownDisabledNodeCount))
                ) && 
                (
                    this.Conditions == input.Conditions ||
                    this.Conditions != null &&
                    input.Conditions != null &&
                    this.Conditions.SequenceEqual(input.Conditions)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Uid != null)
                    hashCode = hashCode * 59 + this.Uid.GetHashCode();
                if (this.CreationTimestamp != null)
                    hashCode = hashCode * 59 + this.CreationTimestamp.GetHashCode();
                if (this.UpdateTimestamp != null)
                    hashCode = hashCode * 59 + this.UpdateTimestamp.GetHashCode();
                if (this.Phase != null)
                    hashCode = hashCode * 59 + this.Phase.GetHashCode();
                if (this.DesiredNodeCount != null)
                    hashCode = hashCode * 59 + this.DesiredNodeCount.GetHashCode();
                if (this.UnpaidScaleNodeCount != null)
                    hashCode = hashCode * 59 + this.UnpaidScaleNodeCount.GetHashCode();
                if (this.ExistingNodeCount != null)
                    hashCode = hashCode * 59 + this.ExistingNodeCount.GetHashCode();
                if (this.UpcomingNodeCount != null)
                    hashCode = hashCode * 59 + this.UpcomingNodeCount.GetHashCode();
                if (this.ScaleDownDisabledNodeCount != null)
                    hashCode = hashCode * 59 + this.ScaleDownDisabledNodeCount.GetHashCode();
                if (this.Conditions != null)
                    hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                return hashCode;
            }
        }
    }
}
