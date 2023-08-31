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
    public class BatchCreateInvocationRequestBody 
    {
        /// <summary>
        /// 任务类型，INSTALL 安装，UPDATE升级，ROLLBACK回退，RETRY重试
        /// </summary>
        /// <value>任务类型，INSTALL 安装，UPDATE升级，ROLLBACK回退，RETRY重试</value>
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
        /// 插件升级时需要选择升级“基础版本”还是“增强版本”，传值“BASIC_VERSION”表示升级成基础版本，传值“ADVANCE_VERSION”表示升级成增强版本
        /// </summary>
        /// <value>插件升级时需要选择升级“基础版本”还是“增强版本”，传值“BASIC_VERSION”表示升级成基础版本，传值“ADVANCE_VERSION”表示升级成增强版本</value>
        [JsonConverter(typeof(EnumClassConverter<VersionTypeEnum>))]
        public class VersionTypeEnum
        {
            /// <summary>
            /// Enum BASIC_VERSION for value: BASIC_VERSION
            /// </summary>
            public static readonly VersionTypeEnum BASIC_VERSION = new VersionTypeEnum("BASIC_VERSION");

            /// <summary>
            /// Enum ADVANCE_VERSION for value: ADVANCE_VERSION
            /// </summary>
            public static readonly VersionTypeEnum ADVANCE_VERSION = new VersionTypeEnum("ADVANCE_VERSION");

            private static readonly Dictionary<string, VersionTypeEnum> StaticFields =
            new Dictionary<string, VersionTypeEnum>()
            {
                { "BASIC_VERSION", BASIC_VERSION },
                { "ADVANCE_VERSION", ADVANCE_VERSION },
            };

            private string _value;

            public VersionTypeEnum()
            {

            }

            public VersionTypeEnum(string value)
            {
                _value = value;
            }

            public static VersionTypeEnum FromValue(string value)
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

                if (this.Equals(obj as VersionTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VersionTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VersionTypeEnum a, VersionTypeEnum b)
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

            public static bool operator !=(VersionTypeEnum a, VersionTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// Agent任务接口调用源，CES表示由Console调用，APICOM_BMS表示由裸金属服务器调用，ADMIN_SERVER表示由运维平台调用
        /// </summary>
        /// <value>Agent任务接口调用源，CES表示由Console调用，APICOM_BMS表示由裸金属服务器调用，ADMIN_SERVER表示由运维平台调用</value>
        [JsonConverter(typeof(EnumClassConverter<OriginEnum>))]
        public class OriginEnum
        {
            /// <summary>
            /// Enum CES for value: CES
            /// </summary>
            public static readonly OriginEnum CES = new OriginEnum("CES");

            /// <summary>
            /// Enum APICOM_BMS for value: APICOM_BMS
            /// </summary>
            public static readonly OriginEnum APICOM_BMS = new OriginEnum("APICOM_BMS");

            /// <summary>
            /// Enum ADMIN_SERVER for value: ADMIN_SERVER
            /// </summary>
            public static readonly OriginEnum ADMIN_SERVER = new OriginEnum("ADMIN_SERVER");

            private static readonly Dictionary<string, OriginEnum> StaticFields =
            new Dictionary<string, OriginEnum>()
            {
                { "CES", CES },
                { "APICOM_BMS", APICOM_BMS },
                { "ADMIN_SERVER", ADMIN_SERVER },
            };

            private string _value;

            public OriginEnum()
            {

            }

            public OriginEnum(string value)
            {
                _value = value;
            }

            public static OriginEnum FromValue(string value)
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

                if (this.Equals(obj as OriginEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OriginEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OriginEnum a, OriginEnum b)
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

            public static bool operator !=(OriginEnum a, OriginEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 主机id列表（INSTALL和UPDATE时必须）
        /// </summary>
        [JsonProperty("instance_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// 任务类型，INSTALL 安装，UPDATE升级，ROLLBACK回退，RETRY重试
        /// </summary>
        [JsonProperty("invocation_type", NullValueHandling = NullValueHandling.Ignore)]
        public InvocationTypeEnum InvocationType { get; set; }
        /// <summary>
        /// 任务对象，目前仅支持telescope
        /// </summary>
        [JsonProperty("invocation_target", NullValueHandling = NullValueHandling.Ignore)]
        public InvocationTargetEnum InvocationTarget { get; set; }
        /// <summary>
        /// 任务ID列表（ROLLBACK和RETRY时必须）
        /// </summary>
        [JsonProperty("invocation_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InvocationIds { get; set; }

        /// <summary>
        /// 插件升级时需要选择升级“基础版本”还是“增强版本”，传值“BASIC_VERSION”表示升级成基础版本，传值“ADVANCE_VERSION”表示升级成增强版本
        /// </summary>
        [JsonProperty("version_type", NullValueHandling = NullValueHandling.Ignore)]
        public VersionTypeEnum VersionType { get; set; }
        /// <summary>
        /// Agent任务接口调用源，CES表示由Console调用，APICOM_BMS表示由裸金属服务器调用，ADMIN_SERVER表示由运维平台调用
        /// </summary>
        [JsonProperty("origin", NullValueHandling = NullValueHandling.Ignore)]
        public OriginEnum Origin { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchCreateInvocationRequestBody {\n");
            sb.Append("  instanceIds: ").Append(InstanceIds).Append("\n");
            sb.Append("  invocationType: ").Append(InvocationType).Append("\n");
            sb.Append("  invocationTarget: ").Append(InvocationTarget).Append("\n");
            sb.Append("  invocationIds: ").Append(InvocationIds).Append("\n");
            sb.Append("  versionType: ").Append(VersionType).Append("\n");
            sb.Append("  origin: ").Append(Origin).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchCreateInvocationRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchCreateInvocationRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceIds == input.InstanceIds ||
                    this.InstanceIds != null &&
                    input.InstanceIds != null &&
                    this.InstanceIds.SequenceEqual(input.InstanceIds)
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
                    this.InvocationIds == input.InvocationIds ||
                    this.InvocationIds != null &&
                    input.InvocationIds != null &&
                    this.InvocationIds.SequenceEqual(input.InvocationIds)
                ) && 
                (
                    this.VersionType == input.VersionType ||
                    (this.VersionType != null &&
                    this.VersionType.Equals(input.VersionType))
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
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
                if (this.InstanceIds != null)
                    hashCode = hashCode * 59 + this.InstanceIds.GetHashCode();
                if (this.InvocationType != null)
                    hashCode = hashCode * 59 + this.InvocationType.GetHashCode();
                if (this.InvocationTarget != null)
                    hashCode = hashCode * 59 + this.InvocationTarget.GetHashCode();
                if (this.InvocationIds != null)
                    hashCode = hashCode * 59 + this.InvocationIds.GetHashCode();
                if (this.VersionType != null)
                    hashCode = hashCode * 59 + this.VersionType.GetHashCode();
                if (this.Origin != null)
                    hashCode = hashCode * 59 + this.Origin.GetHashCode();
                return hashCode;
            }
        }
    }
}
