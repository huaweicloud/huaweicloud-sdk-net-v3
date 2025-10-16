using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class CheckClusterPortResponse : SdkResponse
    {
        /// <summary>
        /// PROXY：代理模式端口 TUNNEL：隧道模式自定端口 TUNNEL_FIXED：隧道模式的固定隧道端口
        /// </summary>
        /// <value>PROXY：代理模式端口 TUNNEL：隧道模式自定端口 TUNNEL_FIXED：隧道模式的固定隧道端口</value>
        [JsonConverter(typeof(EnumClassConverter<ModeEnum>))]
        public class ModeEnum
        {
            /// <summary>
            /// Enum TUNNEL_FIXED for value: TUNNEL_FIXED
            /// </summary>
            public static readonly ModeEnum TUNNEL_FIXED = new ModeEnum("TUNNEL_FIXED");

            /// <summary>
            /// Enum TUNNEL for value: TUNNEL
            /// </summary>
            public static readonly ModeEnum TUNNEL = new ModeEnum("TUNNEL");

            /// <summary>
            /// Enum PROXY for value: PROXY
            /// </summary>
            public static readonly ModeEnum PROXY = new ModeEnum("PROXY");

            private static readonly Dictionary<string, ModeEnum> StaticFields =
            new Dictionary<string, ModeEnum>()
            {
                { "TUNNEL_FIXED", TUNNEL_FIXED },
                { "TUNNEL", TUNNEL },
                { "PROXY", PROXY },
            };

            private string _value;

            public ModeEnum()
            {

            }

            public ModeEnum(string value)
            {
                _value = value;
            }

            public static ModeEnum FromValue(string value)
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

                if (this.Equals(obj as ModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModeEnum a, ModeEnum b)
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

            public static bool operator !=(ModeEnum a, ModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// uuid
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 该端口归属的集群id
        /// </summary>
        [JsonProperty("cluster_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClusterId { get; set; }

        /// <summary>
        /// 租户的elbId
        /// </summary>
        [JsonProperty("elb_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ElbId { get; set; }

        /// <summary>
        /// 租户的elb的ip
        /// </summary>
        [JsonProperty("elb_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string ElbIp { get; set; }

        /// <summary>
        /// PROXY：代理模式端口 TUNNEL：隧道模式自定端口 TUNNEL_FIXED：隧道模式的固定隧道端口
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public ModeEnum Mode { get; set; }
        /// <summary>
        /// elb监听端口
        /// </summary>
        [JsonProperty("listener_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// elb监听器id
        /// </summary>
        [JsonProperty("listener_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ListenerId { get; set; }

        /// <summary>
        /// 后端服务组绑定的后端服务器的业务端口
        /// </summary>
        [JsonProperty("server_group_port", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServerGroupPort { get; set; }

        /// <summary>
        /// 后端服务组id
        /// </summary>
        [JsonProperty("server_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerGroupId { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 最后验证时间
        /// </summary>
        [JsonProperty("validate_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ValidateTime { get; set; }

        /// <summary>
        /// 资源是否异常。 由于该接口功能是cpcs操作租户的elb。而租户是可以二次操作cpcs创建的端口映射的。cpcs提供了一个检测接口，用以检测cpcs创建的这一套监听端口是否有误。
        /// </summary>
        [JsonProperty("wrong", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Wrong { get; set; }

        /// <summary>
        /// 若端口有误。即wrong&#x3D;true时。该字段描述错误的地方
        /// </summary>
        [JsonProperty("wrong_msg", NullValueHandling = NullValueHandling.Ignore)]
        public string WrongMsg { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckClusterPortResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  clusterId: ").Append(ClusterId).Append("\n");
            sb.Append("  elbId: ").Append(ElbId).Append("\n");
            sb.Append("  elbIp: ").Append(ElbIp).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  listenerPort: ").Append(ListenerPort).Append("\n");
            sb.Append("  listenerId: ").Append(ListenerId).Append("\n");
            sb.Append("  serverGroupPort: ").Append(ServerGroupPort).Append("\n");
            sb.Append("  serverGroupId: ").Append(ServerGroupId).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  validateTime: ").Append(ValidateTime).Append("\n");
            sb.Append("  wrong: ").Append(Wrong).Append("\n");
            sb.Append("  wrongMsg: ").Append(WrongMsg).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CheckClusterPortResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CheckClusterPortResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.ClusterId != input.ClusterId || (this.ClusterId != null && !this.ClusterId.Equals(input.ClusterId))) return false;
            if (this.ElbId != input.ElbId || (this.ElbId != null && !this.ElbId.Equals(input.ElbId))) return false;
            if (this.ElbIp != input.ElbIp || (this.ElbIp != null && !this.ElbIp.Equals(input.ElbIp))) return false;
            if (this.Mode != input.Mode) return false;
            if (this.ListenerPort != input.ListenerPort || (this.ListenerPort != null && !this.ListenerPort.Equals(input.ListenerPort))) return false;
            if (this.ListenerId != input.ListenerId || (this.ListenerId != null && !this.ListenerId.Equals(input.ListenerId))) return false;
            if (this.ServerGroupPort != input.ServerGroupPort || (this.ServerGroupPort != null && !this.ServerGroupPort.Equals(input.ServerGroupPort))) return false;
            if (this.ServerGroupId != input.ServerGroupId || (this.ServerGroupId != null && !this.ServerGroupId.Equals(input.ServerGroupId))) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.ValidateTime != input.ValidateTime || (this.ValidateTime != null && !this.ValidateTime.Equals(input.ValidateTime))) return false;
            if (this.Wrong != input.Wrong || (this.Wrong != null && !this.Wrong.Equals(input.Wrong))) return false;
            if (this.WrongMsg != input.WrongMsg || (this.WrongMsg != null && !this.WrongMsg.Equals(input.WrongMsg))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ClusterId != null) hashCode = hashCode * 59 + this.ClusterId.GetHashCode();
                if (this.ElbId != null) hashCode = hashCode * 59 + this.ElbId.GetHashCode();
                if (this.ElbIp != null) hashCode = hashCode * 59 + this.ElbIp.GetHashCode();
                hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.ListenerPort != null) hashCode = hashCode * 59 + this.ListenerPort.GetHashCode();
                if (this.ListenerId != null) hashCode = hashCode * 59 + this.ListenerId.GetHashCode();
                if (this.ServerGroupPort != null) hashCode = hashCode * 59 + this.ServerGroupPort.GetHashCode();
                if (this.ServerGroupId != null) hashCode = hashCode * 59 + this.ServerGroupId.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ValidateTime != null) hashCode = hashCode * 59 + this.ValidateTime.GetHashCode();
                if (this.Wrong != null) hashCode = hashCode * 59 + this.Wrong.GetHashCode();
                if (this.WrongMsg != null) hashCode = hashCode * 59 + this.WrongMsg.GetHashCode();
                return hashCode;
            }
        }
    }
}
