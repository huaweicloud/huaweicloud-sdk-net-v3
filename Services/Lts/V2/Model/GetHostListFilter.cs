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
    /// 查询主机信息过滤参数
    /// </summary>
    public class GetHostListFilter 
    {
        /// <summary>
        /// 主机状态。可以根据主机状态进行过滤。 uninstall:未安装 running:运行 offline:离线 error:异常 plugin error:插件错误 installing:安装中 install-fail:安装失败 upgrading:升级中 upgrading-transient:升级中 upgrade failed:升级失败 upgrade-fail:升级失败 uninstalling:卸载中 uninstalling-transient:卸载中 authentication error:鉴权失败
        /// </summary>
        /// <value>主机状态。可以根据主机状态进行过滤。 uninstall:未安装 running:运行 offline:离线 error:异常 plugin error:插件错误 installing:安装中 install-fail:安装失败 upgrading:升级中 upgrading-transient:升级中 upgrade failed:升级失败 upgrade-fail:升级失败 uninstalling:卸载中 uninstalling-transient:卸载中 authentication error:鉴权失败</value>
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
        /// 主机名称列表。可以根据主机名称列表，进行批量过滤。
        /// </summary>
        [JsonProperty("host_name_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> HostNameList { get; set; }

        /// <summary>
        /// 主机ID列表。可以根据主机IP列表，进行批量过滤。
        /// </summary>
        [JsonProperty("host_ip_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> HostIpList { get; set; }

        /// <summary>
        /// 主机状态。可以根据主机状态进行过滤。 uninstall:未安装 running:运行 offline:离线 error:异常 plugin error:插件错误 installing:安装中 install-fail:安装失败 upgrading:升级中 upgrading-transient:升级中 upgrade failed:升级失败 upgrade-fail:升级失败 uninstalling:卸载中 uninstalling-transient:卸载中 authentication error:鉴权失败
        /// </summary>
        [JsonProperty("host_status", NullValueHandling = NullValueHandling.Ignore)]
        public HostStatusEnum HostStatus { get; set; }
        /// <summary>
        /// 主机版本。可以根据主机版本进行过滤。
        /// </summary>
        [JsonProperty("host_version", NullValueHandling = NullValueHandling.Ignore)]
        public string HostVersion { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetHostListFilter {\n");
            sb.Append("  hostNameList: ").Append(HostNameList).Append("\n");
            sb.Append("  hostIpList: ").Append(HostIpList).Append("\n");
            sb.Append("  hostStatus: ").Append(HostStatus).Append("\n");
            sb.Append("  hostVersion: ").Append(HostVersion).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetHostListFilter);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetHostListFilter input)
        {
            if (input == null) return false;
            if (this.HostNameList != input.HostNameList || (this.HostNameList != null && input.HostNameList != null && !this.HostNameList.SequenceEqual(input.HostNameList))) return false;
            if (this.HostIpList != input.HostIpList || (this.HostIpList != null && input.HostIpList != null && !this.HostIpList.SequenceEqual(input.HostIpList))) return false;
            if (this.HostStatus != input.HostStatus) return false;
            if (this.HostVersion != input.HostVersion || (this.HostVersion != null && !this.HostVersion.Equals(input.HostVersion))) return false;

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
                if (this.HostNameList != null) hashCode = hashCode * 59 + this.HostNameList.GetHashCode();
                if (this.HostIpList != null) hashCode = hashCode * 59 + this.HostIpList.GetHashCode();
                hashCode = hashCode * 59 + this.HostStatus.GetHashCode();
                if (this.HostVersion != null) hashCode = hashCode * 59 + this.HostVersion.GetHashCode();
                return hashCode;
            }
        }
    }
}
