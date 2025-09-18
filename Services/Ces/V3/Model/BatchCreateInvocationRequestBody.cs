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
        /// **参数解释**: 任务类型 **取值范围**: - INSTALL：安装 - UPDATE：升级 - ROLLBACK：回滚 - RETRY：重试 - SET_REMOTE_INSTALLER：设置远程安装主机 - REMOTE_INSTALL：执行远程安装 
        /// </summary>
        /// <value>**参数解释**: 任务类型 **取值范围**: - INSTALL：安装 - UPDATE：升级 - ROLLBACK：回滚 - RETRY：重试 - SET_REMOTE_INSTALLER：设置远程安装主机 - REMOTE_INSTALL：执行远程安装 </value>
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

            /// <summary>
            /// Enum SET_REMOTE_INSTALLER for value: SET_REMOTE_INSTALLER
            /// </summary>
            public static readonly InvocationTypeEnum SET_REMOTE_INSTALLER = new InvocationTypeEnum("SET_REMOTE_INSTALLER");

            /// <summary>
            /// Enum REMOTE_INSTALL for value: REMOTE_INSTALL
            /// </summary>
            public static readonly InvocationTypeEnum REMOTE_INSTALL = new InvocationTypeEnum("REMOTE_INSTALL");

            private static readonly Dictionary<string, InvocationTypeEnum> StaticFields =
            new Dictionary<string, InvocationTypeEnum>()
            {
                { "INSTALL", INSTALL },
                { "UPDATE", UPDATE },
                { "ROLLBACK", ROLLBACK },
                { "RETRY", RETRY },
                { "SET_REMOTE_INSTALLER", SET_REMOTE_INSTALLER },
                { "REMOTE_INSTALL", REMOTE_INSTALL },
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

            public static bool operator !=(InvocationTypeEnum a, InvocationTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**: 任务对象，目前仅支持telescope **取值范围**: - telescope：主机监控插件telescope 
        /// </summary>
        /// <value>**参数解释**: 任务对象，目前仅支持telescope **取值范围**: - telescope：主机监控插件telescope </value>
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

            public static bool operator !=(InvocationTargetEnum a, InvocationTargetEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**: 插件升级时需要选择升级“基础版本”还是“增强版本” **取值范围**: - BASIC_VERSION: 升级成基础版本 - ADVANCE_VERSION: 升级成增强版本 
        /// </summary>
        /// <value>**参数解释**: 插件升级时需要选择升级“基础版本”还是“增强版本” **取值范围**: - BASIC_VERSION: 升级成基础版本 - ADVANCE_VERSION: 升级成增强版本 </value>
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

            public static bool operator !=(VersionTypeEnum a, VersionTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释**: Agent任务接口调用源 **取值范围**: - CES: 由Console调用 - APICOM_BMS: 由裸金属服务器调用 - ADMIN_SERVER: 由运维平台调用 
        /// </summary>
        /// <value>**参数解释**: Agent任务接口调用源 **取值范围**: - CES: 由Console调用 - APICOM_BMS: 由裸金属服务器调用 - ADMIN_SERVER: 由运维平台调用 </value>
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

            public static bool operator !=(OriginEnum a, OriginEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释**: 主机id列表（INSTALL和UPDATE时必须） **取值范围**: 数组长度范围为[1,100] 
        /// </summary>
        [JsonProperty("instance_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// **参数解释**: 任务类型 **取值范围**: - INSTALL：安装 - UPDATE：升级 - ROLLBACK：回滚 - RETRY：重试 - SET_REMOTE_INSTALLER：设置远程安装主机 - REMOTE_INSTALL：执行远程安装 
        /// </summary>
        [JsonProperty("invocation_type", NullValueHandling = NullValueHandling.Ignore)]
        public InvocationTypeEnum InvocationType { get; set; }
        /// <summary>
        /// **参数解释**: 任务对象，目前仅支持telescope **取值范围**: - telescope：主机监控插件telescope 
        /// </summary>
        [JsonProperty("invocation_target", NullValueHandling = NullValueHandling.Ignore)]
        public InvocationTargetEnum InvocationTarget { get; set; }
        /// <summary>
        /// **参数解释**: 任务ID列表（ROLLBACK和RETRY时必须） **取值范围**: 数组长度范围为[1,100] 
        /// </summary>
        [JsonProperty("invocation_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InvocationIds { get; set; }

        /// <summary>
        /// **参数解释**: 插件升级时需要选择升级“基础版本”还是“增强版本” **取值范围**: - BASIC_VERSION: 升级成基础版本 - ADVANCE_VERSION: 升级成增强版本 
        /// </summary>
        [JsonProperty("version_type", NullValueHandling = NullValueHandling.Ignore)]
        public VersionTypeEnum VersionType { get; set; }
        /// <summary>
        /// **参数解释**: Agent任务接口调用源 **取值范围**: - CES: 由Console调用 - APICOM_BMS: 由裸金属服务器调用 - ADMIN_SERVER: 由运维平台调用 
        /// </summary>
        [JsonProperty("origin", NullValueHandling = NullValueHandling.Ignore)]
        public OriginEnum Origin { get; set; }
        /// <summary>
        /// **参数解释**: 版本号 **取值范围**: 数组长度范围为[0,64] 
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// **参数解释**: 创建远程安装任务时需要下发的被安装主机相关信息 **取值范围**: 数组长度范围为[0,100] 
        /// </summary>
        [JsonProperty("remote_install_meta", NullValueHandling = NullValueHandling.Ignore)]
        public List<RemoteInstallHostInfo> RemoteInstallMeta { get; set; }



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
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  remoteInstallMeta: ").Append(RemoteInstallMeta).Append("\n");
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
            if (input == null) return false;
            if (this.InstanceIds != input.InstanceIds || (this.InstanceIds != null && input.InstanceIds != null && !this.InstanceIds.SequenceEqual(input.InstanceIds))) return false;
            if (this.InvocationType != input.InvocationType) return false;
            if (this.InvocationTarget != input.InvocationTarget) return false;
            if (this.InvocationIds != input.InvocationIds || (this.InvocationIds != null && input.InvocationIds != null && !this.InvocationIds.SequenceEqual(input.InvocationIds))) return false;
            if (this.VersionType != input.VersionType) return false;
            if (this.Origin != input.Origin) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.RemoteInstallMeta != input.RemoteInstallMeta || (this.RemoteInstallMeta != null && input.RemoteInstallMeta != null && !this.RemoteInstallMeta.SequenceEqual(input.RemoteInstallMeta))) return false;

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
                if (this.InstanceIds != null) hashCode = hashCode * 59 + this.InstanceIds.GetHashCode();
                hashCode = hashCode * 59 + this.InvocationType.GetHashCode();
                hashCode = hashCode * 59 + this.InvocationTarget.GetHashCode();
                if (this.InvocationIds != null) hashCode = hashCode * 59 + this.InvocationIds.GetHashCode();
                hashCode = hashCode * 59 + this.VersionType.GetHashCode();
                hashCode = hashCode * 59 + this.Origin.GetHashCode();
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.RemoteInstallMeta != null) hashCode = hashCode * 59 + this.RemoteInstallMeta.GetHashCode();
                return hashCode;
            }
        }
    }
}
