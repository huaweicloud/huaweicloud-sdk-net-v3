using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ces.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListAgentInvocationsRequest 
    {
        /// <summary>
        /// 主机类型，ECS弹性云服务器，BMS裸金属服务器
        /// </summary>
        /// <value>主机类型，ECS弹性云服务器，BMS裸金属服务器</value>
        [JsonConverter(typeof(EnumClassConverter<InstanceTypeEnum>))]
        public class InstanceTypeEnum
        {
            /// <summary>
            /// Enum ECS for value: ECS
            /// </summary>
            public static readonly InstanceTypeEnum ECS = new InstanceTypeEnum("ECS");

            /// <summary>
            /// Enum BMS for value: BMS
            /// </summary>
            public static readonly InstanceTypeEnum BMS = new InstanceTypeEnum("BMS");

            private static readonly Dictionary<string, InstanceTypeEnum> StaticFields =
            new Dictionary<string, InstanceTypeEnum>()
            {
                { "ECS", ECS },
                { "BMS", BMS },
            };

            private string _value;

            public InstanceTypeEnum()
            {

            }

            public InstanceTypeEnum(string value)
            {
                _value = value;
            }

            public static InstanceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as InstanceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InstanceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InstanceTypeEnum a, InstanceTypeEnum b)
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

            public static bool operator !=(InstanceTypeEnum a, InstanceTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 任务类型，INSTALL 安装，UPDATE 升级，ROLLBACK 回退，RETRY 重试
        /// </summary>
        /// <value>任务类型，INSTALL 安装，UPDATE 升级，ROLLBACK 回退，RETRY 重试</value>
        [JsonConverter(typeof(EnumClassConverter<InvocationTypeEnum>))]
        public class InvocationTypeEnum
        {
            /// <summary>
            /// Enum INSTALL for value: INSTALL
            /// </summary>
            public static readonly InvocationTypeEnum INSTALL = new InvocationTypeEnum("INSTALL");

            /// <summary>
            /// Enum UPDATE for value: UPDATE
            /// </summary>
            public static readonly InvocationTypeEnum UPDATE = new InvocationTypeEnum("UPDATE");

            /// <summary>
            /// Enum ROLLBACK for value: ROLLBACK
            /// </summary>
            public static readonly InvocationTypeEnum ROLLBACK = new InvocationTypeEnum("ROLLBACK");

            /// <summary>
            /// Enum RETRY for value: RETRY
            /// </summary>
            public static readonly InvocationTypeEnum RETRY = new InvocationTypeEnum("RETRY");

            private static readonly Dictionary<string, InvocationTypeEnum> StaticFields =
            new Dictionary<string, InvocationTypeEnum>()
            {
                { "INSTALL", INSTALL },
                { "UPDATE", UPDATE },
                { "ROLLBACK", ROLLBACK },
                { "RETRY", RETRY },
            };

            private string _value;

            public InvocationTypeEnum()
            {

            }

            public InvocationTypeEnum(string value)
            {
                _value = value;
            }

            public static InvocationTypeEnum FromValue(string value)
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

                if (this.Equals(obj as InvocationTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InvocationTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InvocationTypeEnum a, InvocationTypeEnum b)
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

            public static bool operator !=(InvocationTypeEnum a, InvocationTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 任务对象，目前仅支持telescope
        /// </summary>
        /// <value>任务对象，目前仅支持telescope</value>
        [JsonConverter(typeof(EnumClassConverter<InvocationTargetEnum>))]
        public class InvocationTargetEnum
        {
            /// <summary>
            /// Enum TELESCOPE for value: telescope
            /// </summary>
            public static readonly InvocationTargetEnum TELESCOPE = new InvocationTargetEnum("telescope");

            private static readonly Dictionary<string, InvocationTargetEnum> StaticFields =
            new Dictionary<string, InvocationTargetEnum>()
            {
                { "telescope", TELESCOPE },
            };

            private string _value;

            public InvocationTargetEnum()
            {

            }

            public InvocationTargetEnum(string value)
            {
                _value = value;
            }

            public static InvocationTargetEnum FromValue(string value)
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

                if (this.Equals(obj as InvocationTargetEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InvocationTargetEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InvocationTargetEnum a, InvocationTargetEnum b)
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

            public static bool operator !=(InvocationTargetEnum a, InvocationTargetEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 主机id
        /// </summary>
        [SDKProperty("instance_id", IsQuery = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 主机类型，ECS弹性云服务器，BMS裸金属服务器
        /// </summary>
        [SDKProperty("instance_type", IsQuery = true)]
        [JsonProperty("instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceTypeEnum InstanceType { get; set; }
        /// <summary>
        /// 任务id
        /// </summary>
        [SDKProperty("invocation_id", IsQuery = true)]
        [JsonProperty("invocation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InvocationId { get; set; }

        /// <summary>
        /// 任务类型，INSTALL 安装，UPDATE 升级，ROLLBACK 回退，RETRY 重试
        /// </summary>
        [SDKProperty("invocation_type", IsQuery = true)]
        [JsonProperty("invocation_type", NullValueHandling = NullValueHandling.Ignore)]
        public InvocationTypeEnum InvocationType { get; set; }
        /// <summary>
        /// 任务对象，目前仅支持telescope
        /// </summary>
        [SDKProperty("invocation_target", IsQuery = true)]
        [JsonProperty("invocation_target", NullValueHandling = NullValueHandling.Ignore)]
        public InvocationTargetEnum InvocationTarget { get; set; }
        /// <summary>
        /// 分页偏移量
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 分页大小
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
            sb.Append("class ListAgentInvocationsRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceType: ").Append(InstanceType).Append("\n");
            sb.Append("  invocationId: ").Append(InvocationId).Append("\n");
            sb.Append("  invocationType: ").Append(InvocationType).Append("\n");
            sb.Append("  invocationTarget: ").Append(InvocationTarget).Append("\n");
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
            return this.Equals(input as ListAgentInvocationsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAgentInvocationsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.InstanceType == input.InstanceType ||
                    (this.InstanceType != null &&
                    this.InstanceType.Equals(input.InstanceType))
                ) && 
                (
                    this.InvocationId == input.InvocationId ||
                    (this.InvocationId != null &&
                    this.InvocationId.Equals(input.InvocationId))
                ) && 
                (
                    this.InvocationType == input.InvocationType ||
                    (this.InvocationType != null &&
                    this.InvocationType.Equals(input.InvocationType))
                ) && 
                (
                    this.InvocationTarget == input.InvocationTarget ||
                    (this.InvocationTarget != null &&
                    this.InvocationTarget.Equals(input.InvocationTarget))
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
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceType != null)
                    hashCode = hashCode * 59 + this.InstanceType.GetHashCode();
                if (this.InvocationId != null)
                    hashCode = hashCode * 59 + this.InvocationId.GetHashCode();
                if (this.InvocationType != null)
                    hashCode = hashCode * 59 + this.InvocationType.GetHashCode();
                if (this.InvocationTarget != null)
                    hashCode = hashCode * 59 + this.InvocationTarget.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
