using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// 主机信息详情
    /// </summary>
    public class DeploymentHostDetail 
    {
        /// <summary>
        /// 操作系统：windows|linux，需要和主机集群保持一致
        /// </summary>
        /// <value>操作系统：windows|linux，需要和主机集群保持一致</value>
        [JsonConverter(typeof(EnumClassConverter<OsEnum>))]
        public class OsEnum
        {
            /// <summary>
            /// Enum WINDOWS for value: windows
            /// </summary>
            public static readonly OsEnum WINDOWS = new OsEnum("windows");

            /// <summary>
            /// Enum LINUX for value: linux
            /// </summary>
            public static readonly OsEnum LINUX = new OsEnum("linux");

            private static readonly Dictionary<string, OsEnum> StaticFields =
            new Dictionary<string, OsEnum>()
            {
                { "windows", WINDOWS },
                { "linux", LINUX },
            };

            private string _value;

            public OsEnum()
            {

            }

            public OsEnum(string value)
            {
                _value = value;
            }

            public static OsEnum FromValue(string value)
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

                if (this.Equals(obj as OsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OsEnum a, OsEnum b)
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

            public static bool operator !=(OsEnum a, OsEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 主机集群id
        /// </summary>
        [JsonProperty("group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupId { get; set; }

        /// <summary>
        /// 主机名称
        /// </summary>
        [JsonProperty("host_name", NullValueHandling = NullValueHandling.Ignore)]
        public string HostName { get; set; }

        /// <summary>
        /// IP，请输入弹性ip格式：161.17.101.12
        /// </summary>
        [JsonProperty("ip", NullValueHandling = NullValueHandling.Ignore)]
        public string Ip { get; set; }

        /// <summary>
        /// ssh端口，如：22
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// 操作系统：windows|linux，需要和主机集群保持一致
        /// </summary>
        [JsonProperty("os", NullValueHandling = NullValueHandling.Ignore)]
        public OsEnum Os { get; set; }
        /// <summary>
        /// 是否为代理机
        /// </summary>
        [JsonProperty("as_proxy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AsProxy { get; set; }

        /// <summary>
        /// 代理机id
        /// </summary>
        [JsonProperty("proxy_host_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProxyHostId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("authorization", NullValueHandling = NullValueHandling.Ignore)]
        public DeploymentHostAuthorizationBody Authorization { get; set; }

        /// <summary>
        /// 免费启用应用运维服务（AOM），提供指标监控、日志查询、告警功能（自动安装数据采集器 ICAgent，仅支持华为云linux主机）
        /// </summary>
        [JsonProperty("install_icagent", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InstallIcagent { get; set; }

        /// <summary>
        /// 主机ID
        /// </summary>
        [JsonProperty("host_id", NullValueHandling = NullValueHandling.Ignore)]
        public string HostId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("proxy_host", NullValueHandling = NullValueHandling.Ignore)]
        public DeploymentHostDetail ProxyHost { get; set; }

        /// <summary>
        /// 主机集群名
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("permission", NullValueHandling = NullValueHandling.Ignore)]
        public PermissionHostDetail Permission { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 最后连接时间
        /// </summary>
        [JsonProperty("lastest_connection_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastestConnectionTime { get; set; }

        /// <summary>
        /// 连接状态
        /// </summary>
        [JsonProperty("connection_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectionStatus { get; set; }

        /// <summary>
        /// 拥有者名称
        /// </summary>
        [JsonProperty("owner_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerName { get; set; }

        /// <summary>
        /// 维护者id
        /// </summary>
        [JsonProperty("updator_id", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatorId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NickName { get; set; }

        /// <summary>
        /// 拥有者id
        /// </summary>
        [JsonProperty("owner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OwnerId { get; set; }

        /// <summary>
        /// 维护者名称
        /// </summary>
        [JsonProperty("updator_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UpdatorName { get; set; }

        /// <summary>
        /// 连接结果
        /// </summary>
        [JsonProperty("connection_result", NullValueHandling = NullValueHandling.Ignore)]
        public string ConnectionResult { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeploymentHostDetail {\n");
            sb.Append("  groupId: ").Append(GroupId).Append("\n");
            sb.Append("  hostName: ").Append(HostName).Append("\n");
            sb.Append("  ip: ").Append(Ip).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  os: ").Append(Os).Append("\n");
            sb.Append("  asProxy: ").Append(AsProxy).Append("\n");
            sb.Append("  proxyHostId: ").Append(ProxyHostId).Append("\n");
            sb.Append("  authorization: ").Append(Authorization).Append("\n");
            sb.Append("  installIcagent: ").Append(InstallIcagent).Append("\n");
            sb.Append("  hostId: ").Append(HostId).Append("\n");
            sb.Append("  proxyHost: ").Append(ProxyHost).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  projectName: ").Append(ProjectName).Append("\n");
            sb.Append("  permission: ").Append(Permission).Append("\n");
            sb.Append("  updateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  lastestConnectionTime: ").Append(LastestConnectionTime).Append("\n");
            sb.Append("  connectionStatus: ").Append(ConnectionStatus).Append("\n");
            sb.Append("  ownerName: ").Append(OwnerName).Append("\n");
            sb.Append("  updatorId: ").Append(UpdatorId).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  nickName: ").Append(NickName).Append("\n");
            sb.Append("  ownerId: ").Append(OwnerId).Append("\n");
            sb.Append("  updatorName: ").Append(UpdatorName).Append("\n");
            sb.Append("  connectionResult: ").Append(ConnectionResult).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeploymentHostDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeploymentHostDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.HostName == input.HostName ||
                    (this.HostName != null &&
                    this.HostName.Equals(input.HostName))
                ) && 
                (
                    this.Ip == input.Ip ||
                    (this.Ip != null &&
                    this.Ip.Equals(input.Ip))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.Os == input.Os ||
                    (this.Os != null &&
                    this.Os.Equals(input.Os))
                ) && 
                (
                    this.AsProxy == input.AsProxy ||
                    (this.AsProxy != null &&
                    this.AsProxy.Equals(input.AsProxy))
                ) && 
                (
                    this.ProxyHostId == input.ProxyHostId ||
                    (this.ProxyHostId != null &&
                    this.ProxyHostId.Equals(input.ProxyHostId))
                ) && 
                (
                    this.Authorization == input.Authorization ||
                    (this.Authorization != null &&
                    this.Authorization.Equals(input.Authorization))
                ) && 
                (
                    this.InstallIcagent == input.InstallIcagent ||
                    (this.InstallIcagent != null &&
                    this.InstallIcagent.Equals(input.InstallIcagent))
                ) && 
                (
                    this.HostId == input.HostId ||
                    (this.HostId != null &&
                    this.HostId.Equals(input.HostId))
                ) && 
                (
                    this.ProxyHost == input.ProxyHost ||
                    (this.ProxyHost != null &&
                    this.ProxyHost.Equals(input.ProxyHost))
                ) && 
                (
                    this.GroupName == input.GroupName ||
                    (this.GroupName != null &&
                    this.GroupName.Equals(input.GroupName))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ProjectName == input.ProjectName ||
                    (this.ProjectName != null &&
                    this.ProjectName.Equals(input.ProjectName))
                ) && 
                (
                    this.Permission == input.Permission ||
                    (this.Permission != null &&
                    this.Permission.Equals(input.Permission))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) && 
                (
                    this.LastestConnectionTime == input.LastestConnectionTime ||
                    (this.LastestConnectionTime != null &&
                    this.LastestConnectionTime.Equals(input.LastestConnectionTime))
                ) && 
                (
                    this.ConnectionStatus == input.ConnectionStatus ||
                    (this.ConnectionStatus != null &&
                    this.ConnectionStatus.Equals(input.ConnectionStatus))
                ) && 
                (
                    this.OwnerName == input.OwnerName ||
                    (this.OwnerName != null &&
                    this.OwnerName.Equals(input.OwnerName))
                ) && 
                (
                    this.UpdatorId == input.UpdatorId ||
                    (this.UpdatorId != null &&
                    this.UpdatorId.Equals(input.UpdatorId))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.NickName == input.NickName ||
                    (this.NickName != null &&
                    this.NickName.Equals(input.NickName))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.UpdatorName == input.UpdatorName ||
                    (this.UpdatorName != null &&
                    this.UpdatorName.Equals(input.UpdatorName))
                ) && 
                (
                    this.ConnectionResult == input.ConnectionResult ||
                    (this.ConnectionResult != null &&
                    this.ConnectionResult.Equals(input.ConnectionResult))
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
                if (this.GroupId != null)
                    hashCode = hashCode * 59 + this.GroupId.GetHashCode();
                if (this.HostName != null)
                    hashCode = hashCode * 59 + this.HostName.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Os != null)
                    hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.AsProxy != null)
                    hashCode = hashCode * 59 + this.AsProxy.GetHashCode();
                if (this.ProxyHostId != null)
                    hashCode = hashCode * 59 + this.ProxyHostId.GetHashCode();
                if (this.Authorization != null)
                    hashCode = hashCode * 59 + this.Authorization.GetHashCode();
                if (this.InstallIcagent != null)
                    hashCode = hashCode * 59 + this.InstallIcagent.GetHashCode();
                if (this.HostId != null)
                    hashCode = hashCode * 59 + this.HostId.GetHashCode();
                if (this.ProxyHost != null)
                    hashCode = hashCode * 59 + this.ProxyHost.GetHashCode();
                if (this.GroupName != null)
                    hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ProjectName != null)
                    hashCode = hashCode * 59 + this.ProjectName.GetHashCode();
                if (this.Permission != null)
                    hashCode = hashCode * 59 + this.Permission.GetHashCode();
                if (this.UpdateTime != null)
                    hashCode = hashCode * 59 + this.UpdateTime.GetHashCode();
                if (this.LastestConnectionTime != null)
                    hashCode = hashCode * 59 + this.LastestConnectionTime.GetHashCode();
                if (this.ConnectionStatus != null)
                    hashCode = hashCode * 59 + this.ConnectionStatus.GetHashCode();
                if (this.OwnerName != null)
                    hashCode = hashCode * 59 + this.OwnerName.GetHashCode();
                if (this.UpdatorId != null)
                    hashCode = hashCode * 59 + this.UpdatorId.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.NickName != null)
                    hashCode = hashCode * 59 + this.NickName.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.UpdatorName != null)
                    hashCode = hashCode * 59 + this.UpdatorName.GetHashCode();
                if (this.ConnectionResult != null)
                    hashCode = hashCode * 59 + this.ConnectionResult.GetHashCode();
                return hashCode;
            }
        }
    }
}
