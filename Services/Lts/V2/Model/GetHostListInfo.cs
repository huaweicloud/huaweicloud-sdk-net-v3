using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 主机详细信息
    /// </summary>
    public class GetHostListInfo 
    {
        /// <summary>
        /// 主机状态。 uninstall:未安装 running:运行 offline:离线 error:异常 plugin error:插件错误 installing:安装中 install-fail:安装失败 upgrading:升级中 upgrading-transient:升级中 upgrade failed:升级失败 upgrade-fail:升级失败 uninstalling:卸载中 uninstalling-transient:卸载中 authentication error:鉴权失败
        /// </summary>
        /// <value>主机状态。 uninstall:未安装 running:运行 offline:离线 error:异常 plugin error:插件错误 installing:安装中 install-fail:安装失败 upgrading:升级中 upgrading-transient:升级中 upgrade failed:升级失败 upgrade-fail:升级失败 uninstalling:卸载中 uninstalling-transient:卸载中 authentication error:鉴权失败</value>
        [JsonConverter(typeof(EnumClassConverter<HostStatusEnum>))]
        public class HostStatusEnum
        {
            /// <summary>
            /// Enum UNINSTALL for value: uninstall
            /// </summary>
            public static readonly HostStatusEnum UNINSTALL = new HostStatusEnum("uninstall");

            /// <summary>
            /// Enum RUNNING for value: running
            /// </summary>
            public static readonly HostStatusEnum RUNNING = new HostStatusEnum("running");

            /// <summary>
            /// Enum OFFLINE for value: offline
            /// </summary>
            public static readonly HostStatusEnum OFFLINE = new HostStatusEnum("offline");

            /// <summary>
            /// Enum ERROR for value: error
            /// </summary>
            public static readonly HostStatusEnum ERROR = new HostStatusEnum("error");

            /// <summary>
            /// Enum PLUGIN_ERROR for value: plugin error
            /// </summary>
            public static readonly HostStatusEnum PLUGIN_ERROR = new HostStatusEnum("plugin error");

            /// <summary>
            /// Enum INSTALLING for value: installing
            /// </summary>
            public static readonly HostStatusEnum INSTALLING = new HostStatusEnum("installing");

            /// <summary>
            /// Enum INSTALL_FAIL for value: install-fail
            /// </summary>
            public static readonly HostStatusEnum INSTALL_FAIL = new HostStatusEnum("install-fail");

            /// <summary>
            /// Enum UPGRADING for value: upgrading
            /// </summary>
            public static readonly HostStatusEnum UPGRADING = new HostStatusEnum("upgrading");

            /// <summary>
            /// Enum UPGRADING_TRANSIENT for value: upgrading-transient
            /// </summary>
            public static readonly HostStatusEnum UPGRADING_TRANSIENT = new HostStatusEnum("upgrading-transient");

            /// <summary>
            /// Enum UPGRADE_FAILED for value: upgrade failed
            /// </summary>
            public static readonly HostStatusEnum UPGRADE_FAILED = new HostStatusEnum("upgrade failed");

            /// <summary>
            /// Enum UPGRADE_FAIL for value: upgrade-fail
            /// </summary>
            public static readonly HostStatusEnum UPGRADE_FAIL = new HostStatusEnum("upgrade-fail");

            /// <summary>
            /// Enum UNINSTALLING for value: uninstalling
            /// </summary>
            public static readonly HostStatusEnum UNINSTALLING = new HostStatusEnum("uninstalling");

            /// <summary>
            /// Enum UNINSTALLING_TRANSIENT for value: uninstalling-transient
            /// </summary>
            public static readonly HostStatusEnum UNINSTALLING_TRANSIENT = new HostStatusEnum("uninstalling-transient");

            /// <summary>
            /// Enum AUTHENTICATION_ERROR for value: authentication error
            /// </summary>
            public static readonly HostStatusEnum AUTHENTICATION_ERROR = new HostStatusEnum("authentication error");

            private static readonly Dictionary<string, HostStatusEnum> StaticFields =
            new Dictionary<string, HostStatusEnum>()
            {
                { "uninstall", UNINSTALL },
                { "running", RUNNING },
                { "offline", OFFLINE },
                { "error", ERROR },
                { "plugin error", PLUGIN_ERROR },
                { "installing", INSTALLING },
                { "install-fail", INSTALL_FAIL },
                { "upgrading", UPGRADING },
                { "upgrading-transient", UPGRADING_TRANSIENT },
                { "upgrade failed", UPGRADE_FAILED },
                { "upgrade-fail", UPGRADE_FAIL },
                { "uninstalling", UNINSTALLING },
                { "uninstalling-transient", UNINSTALLING_TRANSIENT },
                { "authentication error", AUTHENTICATION_ERROR },
            };

            private string _value;

            public HostStatusEnum()
            {

            }

            public HostStatusEnum(string value)
            {
                _value = value;
            }

            public static HostStatusEnum FromValue(string value)
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

                if (this.Equals(obj as HostStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(HostStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(HostStatusEnum a, HostStatusEnum b)
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

            public static bool operator !=(HostStatusEnum a, HostStatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 主机类型。linux:linux类型,windows:windows类型
        /// </summary>
        /// <value>主机类型。linux:linux类型,windows:windows类型</value>
        [JsonConverter(typeof(EnumClassConverter<HostTypeEnum>))]
        public class HostTypeEnum
        {
            /// <summary>
            /// Enum LINUX for value: linux
            /// </summary>
            public static readonly HostTypeEnum LINUX = new HostTypeEnum("linux");

            /// <summary>
            /// Enum WINDOWS for value: windows
            /// </summary>
            public static readonly HostTypeEnum WINDOWS = new HostTypeEnum("windows");

            private static readonly Dictionary<string, HostTypeEnum> StaticFields =
            new Dictionary<string, HostTypeEnum>()
            {
                { "linux", LINUX },
                { "windows", WINDOWS },
            };

            private string _value;

            public HostTypeEnum()
            {

            }

            public HostTypeEnum(string value)
            {
                _value = value;
            }

            public static HostTypeEnum FromValue(string value)
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

                if (this.Equals(obj as HostTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(HostTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(HostTypeEnum a, HostTypeEnum b)
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

            public static bool operator !=(HostTypeEnum a, HostTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 主机ID
        /// </summary>
        [JsonProperty("host_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HostId { get; set; }

        /// <summary>
        /// 主机IP
        /// </summary>
        [JsonProperty("host_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string HostIp { get; set; }

        /// <summary>
        /// 主机名称
        /// </summary>
        [JsonProperty("host_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HostName { get; set; }

        /// <summary>
        /// 主机状态。 uninstall:未安装 running:运行 offline:离线 error:异常 plugin error:插件错误 installing:安装中 install-fail:安装失败 upgrading:升级中 upgrading-transient:升级中 upgrade failed:升级失败 upgrade-fail:升级失败 uninstalling:卸载中 uninstalling-transient:卸载中 authentication error:鉴权失败
        /// </summary>
        [JsonProperty("host_status", NullValueHandling = NullValueHandling.Ignore)]
        public HostStatusEnum HostStatus { get; set; }
        /// <summary>
        /// 主机类型。linux:linux类型,windows:windows类型
        /// </summary>
        [JsonProperty("host_type", NullValueHandling = NullValueHandling.Ignore)]
        public HostTypeEnum HostType { get; set; }
        /// <summary>
        /// 主机版本
        /// </summary>
        [JsonProperty("host_version", NullValueHandling = NullValueHandling.Ignore)]
        public string HostVersion { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public long? UpdateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetHostListInfo {\n");
            sb.Append("  hostId: ").Append(HostId).Append("\n");
            sb.Append("  hostIp: ").Append(HostIp).Append("\n");
            sb.Append("  hostName: ").Append(HostName).Append("\n");
            sb.Append("  hostStatus: ").Append(HostStatus).Append("\n");
            sb.Append("  hostType: ").Append(HostType).Append("\n");
            sb.Append("  hostVersion: ").Append(HostVersion).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetHostListInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetHostListInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HostId == input.HostId ||
                    (this.HostId != null &&
                    this.HostId.Equals(input.HostId))
                ) && 
                (
                    this.HostIp == input.HostIp ||
                    (this.HostIp != null &&
                    this.HostIp.Equals(input.HostIp))
                ) && 
                (
                    this.HostName == input.HostName ||
                    (this.HostName != null &&
                    this.HostName.Equals(input.HostName))
                ) && 
                (
                    this.HostStatus == input.HostStatus ||
                    (this.HostStatus != null &&
                    this.HostStatus.Equals(input.HostStatus))
                ) && 
                (
                    this.HostType == input.HostType ||
                    (this.HostType != null &&
                    this.HostType.Equals(input.HostType))
                ) && 
                (
                    this.HostVersion == input.HostVersion ||
                    (this.HostVersion != null &&
                    this.HostVersion.Equals(input.HostVersion))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
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
                if (this.HostId != null)
                    hashCode = hashCode * 59 + this.HostId.GetHashCode();
                if (this.HostIp != null)
                    hashCode = hashCode * 59 + this.HostIp.GetHashCode();
                if (this.HostName != null)
                    hashCode = hashCode * 59 + this.HostName.GetHashCode();
                if (this.HostStatus != null)
                    hashCode = hashCode * 59 + this.HostStatus.GetHashCode();
                if (this.HostType != null)
                    hashCode = hashCode * 59 + this.HostType.GetHashCode();
                if (this.HostVersion != null)
                    hashCode = hashCode * 59 + this.HostVersion.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
