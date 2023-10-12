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
    /// 
    /// </summary>
    public class InvocationInfo 
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
        /// 任务类型(INSTALL 安装，UPDATE 升级，ROLLBACK 回滚，RETRY 重试)
        /// </summary>
        /// <value>任务类型(INSTALL 安装，UPDATE 升级，ROLLBACK 回滚，RETRY 重试)</value>
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
        /// 任务状态，PENDING 待执行，RUNNING 运行中，TIMEOUT 超时，FAILED 失败，SUCCEEDED 成功，CANCELED 取消，ROLLBACKED已回退
        /// </summary>
        /// <value>任务状态，PENDING 待执行，RUNNING 运行中，TIMEOUT 超时，FAILED 失败，SUCCEEDED 成功，CANCELED 取消，ROLLBACKED已回退</value>
        [JsonConverter(typeof(EnumClassConverter<InvocationStatusEnum>))]
        public class InvocationStatusEnum
        {
            /// <summary>
            /// Enum PENDING for value: PENDING
            /// </summary>
            public static readonly InvocationStatusEnum PENDING = new InvocationStatusEnum("PENDING");

            /// <summary>
            /// Enum RUNNING for value: RUNNING
            /// </summary>
            public static readonly InvocationStatusEnum RUNNING = new InvocationStatusEnum("RUNNING");

            /// <summary>
            /// Enum TIMEOUT for value: TIMEOUT
            /// </summary>
            public static readonly InvocationStatusEnum TIMEOUT = new InvocationStatusEnum("TIMEOUT");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly InvocationStatusEnum FAILED = new InvocationStatusEnum("FAILED");

            /// <summary>
            /// Enum SUCCEEDED for value: SUCCEEDED
            /// </summary>
            public static readonly InvocationStatusEnum SUCCEEDED = new InvocationStatusEnum("SUCCEEDED");

            /// <summary>
            /// Enum CANCELED for value: CANCELED
            /// </summary>
            public static readonly InvocationStatusEnum CANCELED = new InvocationStatusEnum("CANCELED");

            /// <summary>
            /// Enum ROLLBACKED for value: ROLLBACKED
            /// </summary>
            public static readonly InvocationStatusEnum ROLLBACKED = new InvocationStatusEnum("ROLLBACKED");

            private static readonly Dictionary<string, InvocationStatusEnum> StaticFields =
            new Dictionary<string, InvocationStatusEnum>()
            {
                { "PENDING", PENDING },
                { "RUNNING", RUNNING },
                { "TIMEOUT", TIMEOUT },
                { "FAILED", FAILED },
                { "SUCCEEDED", SUCCEEDED },
                { "CANCELED", CANCELED },
                { "ROLLBACKED", ROLLBACKED },
            };

            private string _value;

            public InvocationStatusEnum()
            {

            }

            public InvocationStatusEnum(string value)
            {
                _value = value;
            }

            public static InvocationStatusEnum FromValue(string value)
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

                if (this.Equals(obj as InvocationStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InvocationStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InvocationStatusEnum a, InvocationStatusEnum b)
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

            public static bool operator !=(InvocationStatusEnum a, InvocationStatusEnum b)
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
        /// 任务id
        /// </summary>
        [JsonProperty("invocation_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InvocationId { get; set; }

        /// <summary>
        /// 主机id
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 主机名称
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 主机类型，ECS弹性云服务器，BMS裸金属服务器
        /// </summary>
        [JsonProperty("instance_type", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceTypeEnum InstanceType { get; set; }
        /// <summary>
        /// 内网ip列表
        /// </summary>
        [JsonProperty("intranet_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IntranetIps { get; set; }

        /// <summary>
        /// 弹性公网ip列表
        /// </summary>
        [JsonProperty("elastic_ips", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ElasticIps { get; set; }

        /// <summary>
        /// 任务类型(INSTALL 安装，UPDATE 升级，ROLLBACK 回滚，RETRY 重试)
        /// </summary>
        [JsonProperty("invocation_type", NullValueHandling = NullValueHandling.Ignore)]
        public InvocationTypeEnum InvocationType { get; set; }
        /// <summary>
        /// 任务状态，PENDING 待执行，RUNNING 运行中，TIMEOUT 超时，FAILED 失败，SUCCEEDED 成功，CANCELED 取消，ROLLBACKED已回退
        /// </summary>
        [JsonProperty("invocation_status", NullValueHandling = NullValueHandling.Ignore)]
        public InvocationStatusEnum InvocationStatus { get; set; }
        /// <summary>
        /// 任务对象，目前仅支持telescope
        /// </summary>
        [JsonProperty("invocation_target", NullValueHandling = NullValueHandling.Ignore)]
        public InvocationTargetEnum InvocationTarget { get; set; }
        /// <summary>
        /// 任务创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// 任务更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }

        /// <summary>
        /// 当前版本
        /// </summary>
        [JsonProperty("current_version", NullValueHandling = NullValueHandling.Ignore)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// 目标版本
        /// </summary>
        [JsonProperty("target_version", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvocationInfo {\n");
            sb.Append("  invocationId: ").Append(InvocationId).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  instanceType: ").Append(InstanceType).Append("\n");
            sb.Append("  intranetIps: ").Append(IntranetIps).Append("\n");
            sb.Append("  elasticIps: ").Append(ElasticIps).Append("\n");
            sb.Append("  invocationType: ").Append(InvocationType).Append("\n");
            sb.Append("  invocationStatus: ").Append(InvocationStatus).Append("\n");
            sb.Append("  invocationTarget: ").Append(InvocationTarget).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  currentVersion: ").Append(CurrentVersion).Append("\n");
            sb.Append("  targetVersion: ").Append(TargetVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InvocationInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InvocationInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InvocationId == input.InvocationId ||
                    (this.InvocationId != null &&
                    this.InvocationId.Equals(input.InvocationId))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.InstanceName == input.InstanceName ||
                    (this.InstanceName != null &&
                    this.InstanceName.Equals(input.InstanceName))
                ) && 
                (
                    this.InstanceType == input.InstanceType ||
                    (this.InstanceType != null &&
                    this.InstanceType.Equals(input.InstanceType))
                ) && 
                (
                    this.IntranetIps == input.IntranetIps ||
                    this.IntranetIps != null &&
                    input.IntranetIps != null &&
                    this.IntranetIps.SequenceEqual(input.IntranetIps)
                ) && 
                (
                    this.ElasticIps == input.ElasticIps ||
                    this.ElasticIps != null &&
                    input.ElasticIps != null &&
                    this.ElasticIps.SequenceEqual(input.ElasticIps)
                ) && 
                (
                    this.InvocationType == input.InvocationType ||
                    (this.InvocationType != null &&
                    this.InvocationType.Equals(input.InvocationType))
                ) && 
                (
                    this.InvocationStatus == input.InvocationStatus ||
                    (this.InvocationStatus != null &&
                    this.InvocationStatus.Equals(input.InvocationStatus))
                ) && 
                (
                    this.InvocationTarget == input.InvocationTarget ||
                    (this.InvocationTarget != null &&
                    this.InvocationTarget.Equals(input.InvocationTarget))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) && 
                (
                    this.CurrentVersion == input.CurrentVersion ||
                    (this.CurrentVersion != null &&
                    this.CurrentVersion.Equals(input.CurrentVersion))
                ) && 
                (
                    this.TargetVersion == input.TargetVersion ||
                    (this.TargetVersion != null &&
                    this.TargetVersion.Equals(input.TargetVersion))
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
                if (this.InvocationId != null)
                    hashCode = hashCode * 59 + this.InvocationId.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceName != null)
                    hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.InstanceType != null)
                    hashCode = hashCode * 59 + this.InstanceType.GetHashCode();
                if (this.IntranetIps != null)
                    hashCode = hashCode * 59 + this.IntranetIps.GetHashCode();
                if (this.ElasticIps != null)
                    hashCode = hashCode * 59 + this.ElasticIps.GetHashCode();
                if (this.InvocationType != null)
                    hashCode = hashCode * 59 + this.InvocationType.GetHashCode();
                if (this.InvocationStatus != null)
                    hashCode = hashCode * 59 + this.InvocationStatus.GetHashCode();
                if (this.InvocationTarget != null)
                    hashCode = hashCode * 59 + this.InvocationTarget.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.CurrentVersion != null)
                    hashCode = hashCode * 59 + this.CurrentVersion.GetHashCode();
                if (this.TargetVersion != null)
                    hashCode = hashCode * 59 + this.TargetVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
