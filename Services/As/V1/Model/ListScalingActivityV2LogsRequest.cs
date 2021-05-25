using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListScalingActivityV2LogsRequest 
    {
        /// <summary>
        /// 查询的伸缩活动类型（查询多类型使用逗号分隔）：NORMAL：普通伸缩活动；MANNUAL_REMOVE：从伸缩组手动移除实例；MANNUAL_DELETE：从伸缩组手动移除实例并删除实例；ELB_CHECK_DELETE：ELB检查移除并删除实例；DIFF：期望实例数与实际实例 不一致；MODIFY_ELB：LB迁移
        /// </summary>
        /// <value>查询的伸缩活动类型（查询多类型使用逗号分隔）：NORMAL：普通伸缩活动；MANNUAL_REMOVE：从伸缩组手动移除实例；MANNUAL_DELETE：从伸缩组手动移除实例并删除实例；ELB_CHECK_DELETE：ELB检查移除并删除实例；DIFF：期望实例数与实际实例 不一致；MODIFY_ELB：LB迁移</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum NORMAL for value: NORMAL
            /// </summary>
            public static readonly TypeEnum NORMAL = new TypeEnum("NORMAL");

            /// <summary>
            /// Enum MANNUAL_REMOVE for value: MANNUAL_REMOVE
            /// </summary>
            public static readonly TypeEnum MANNUAL_REMOVE = new TypeEnum("MANNUAL_REMOVE");

            /// <summary>
            /// Enum MANNUAL_DELETE for value: MANNUAL_DELETE
            /// </summary>
            public static readonly TypeEnum MANNUAL_DELETE = new TypeEnum("MANNUAL_DELETE");

            /// <summary>
            /// Enum MANNUAL_ADD for value: MANNUAL_ADD
            /// </summary>
            public static readonly TypeEnum MANNUAL_ADD = new TypeEnum("MANNUAL_ADD");

            /// <summary>
            /// Enum ELB_CHECK_DELETE for value: ELB_CHECK_DELETE
            /// </summary>
            public static readonly TypeEnum ELB_CHECK_DELETE = new TypeEnum("ELB_CHECK_DELETE");

            /// <summary>
            /// Enum AUDIT_CHECK_DELETE for value: AUDIT_CHECK_DELETE
            /// </summary>
            public static readonly TypeEnum AUDIT_CHECK_DELETE = new TypeEnum("AUDIT_CHECK_DELETE");

            /// <summary>
            /// Enum MODIFY_ELB for value: MODIFY_ELB
            /// </summary>
            public static readonly TypeEnum MODIFY_ELB = new TypeEnum("MODIFY_ELB");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "NORMAL", NORMAL },
                { "MANNUAL_REMOVE", MANNUAL_REMOVE },
                { "MANNUAL_DELETE", MANNUAL_DELETE },
                { "MANNUAL_ADD", MANNUAL_ADD },
                { "ELB_CHECK_DELETE", ELB_CHECK_DELETE },
                { "AUDIT_CHECK_DELETE", AUDIT_CHECK_DELETE },
                { "MODIFY_ELB", MODIFY_ELB },
            };

            private string Value;

            public TypeEnum(string value)
            {
                Value = value;
            }

            public static TypeEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 查询的伸缩活动状态：SUCCESS：成功；FAIL：失败；DOING：伸缩中
        /// </summary>
        /// <value>查询的伸缩活动状态：SUCCESS：成功；FAIL：失败；DOING：伸缩中</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            public static readonly StatusEnum SUCCESS = new StatusEnum("SUCCESS");

            /// <summary>
            /// Enum FAIL for value: FAIL
            /// </summary>
            public static readonly StatusEnum FAIL = new StatusEnum("FAIL");

            /// <summary>
            /// Enum DOING for value: DOING
            /// </summary>
            public static readonly StatusEnum DOING = new StatusEnum("DOING");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "SUCCESS", SUCCESS },
                { "FAIL", FAIL },
                { "DOING", DOING },
            };

            private string Value;

            public StatusEnum(string value)
            {
                Value = value;
            }

            public static StatusEnum FromValue(string value)
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
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 伸缩组ID。
        /// </summary>
        [SDKProperty("scaling_group_id", IsPath = true)]
        [JsonProperty("scaling_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ScalingGroupId { get; set; }

        /// <summary>
        /// 伸缩活动日志ID
        /// </summary>
        [SDKProperty("log_id", IsQuery = true)]
        [JsonProperty("log_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogId { get; set; }

        /// <summary>
        /// 查询的起始时间，格式是“yyyy-MM-ddThh:mm:ssZ”。
        /// </summary>
        [SDKProperty("start_time", IsQuery = true)]
        [JsonProperty("start_time", NullValueHandling = NullValueHandling.Ignore)]
        public string StartTime { get; set; }

        /// <summary>
        /// 查询的截止时间，格式是“yyyy-MM-ddThh:mm:ssZ”。
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 查询的起始行号，默认为0。
        /// </summary>
        [SDKProperty("start_number", IsQuery = true)]
        [JsonProperty("start_number", NullValueHandling = NullValueHandling.Ignore)]
        public int? StartNumber { get; set; }

        /// <summary>
        /// 查询记录数，默认20，最大100。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 查询的伸缩活动类型（查询多类型使用逗号分隔）：NORMAL：普通伸缩活动；MANNUAL_REMOVE：从伸缩组手动移除实例；MANNUAL_DELETE：从伸缩组手动移除实例并删除实例；ELB_CHECK_DELETE：ELB检查移除并删除实例；DIFF：期望实例数与实际实例 不一致；MODIFY_ELB：LB迁移
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 查询的伸缩活动状态：SUCCESS：成功；FAIL：失败；DOING：伸缩中
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }

        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListScalingActivityV2LogsRequest {\n");
            sb.Append("  scalingGroupId: ").Append(ScalingGroupId).Append("\n");
            sb.Append("  logId: ").Append(LogId).Append("\n");
            sb.Append("  startTime: ").Append(StartTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  startNumber: ").Append(StartNumber).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListScalingActivityV2LogsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListScalingActivityV2LogsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ScalingGroupId == input.ScalingGroupId ||
                    (this.ScalingGroupId != null &&
                    this.ScalingGroupId.Equals(input.ScalingGroupId))
                ) && 
                (
                    this.LogId == input.LogId ||
                    (this.LogId != null &&
                    this.LogId.Equals(input.LogId))
                ) && 
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
                    this.StartNumber == input.StartNumber ||
                    (this.StartNumber != null &&
                    this.StartNumber.Equals(input.StartNumber))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.ScalingGroupId != null)
                    hashCode = hashCode * 59 + this.ScalingGroupId.GetHashCode();
                if (this.LogId != null)
                    hashCode = hashCode * 59 + this.LogId.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.StartNumber != null)
                    hashCode = hashCode * 59 + this.StartNumber.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
