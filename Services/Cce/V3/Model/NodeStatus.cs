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
    /// 
    /// </summary>
    public class NodeStatus 
    {
        /// <summary>
        /// 节点状态：节点资源生命周期管理（如安装卸载等）状态和集群内k8s node状态的综合体现，取值如下 - Build：创建中，表示节点正处于创建过程中。 - Installing：纳管中，表示节点正处于纳管过程中。 - Upgrading：升级中，表示节点正处于升级过程中。 - Active：正常，表示节点处于正常状态。 - Abnormal：异常，表示节点处于异常状态。 - Deleting： 删除中，表示节点正处于删除过程中。 - Error：故障，表示节点处于故障状态。
        /// </summary>
        /// <value>节点状态：节点资源生命周期管理（如安装卸载等）状态和集群内k8s node状态的综合体现，取值如下 - Build：创建中，表示节点正处于创建过程中。 - Installing：纳管中，表示节点正处于纳管过程中。 - Upgrading：升级中，表示节点正处于升级过程中。 - Active：正常，表示节点处于正常状态。 - Abnormal：异常，表示节点处于异常状态。 - Deleting： 删除中，表示节点正处于删除过程中。 - Error：故障，表示节点处于故障状态。</value>
        [JsonConverter(typeof(EnumClassConverter<PhaseEnum>))]
        public class PhaseEnum
        {
            /// <summary>
            /// Enum BUILD for value: Build
            /// </summary>
            public static readonly PhaseEnum BUILD = new PhaseEnum("Build");

            /// <summary>
            /// Enum INSTALLING for value: Installing
            /// </summary>
            public static readonly PhaseEnum INSTALLING = new PhaseEnum("Installing");

            /// <summary>
            /// Enum UPGRADING for value: Upgrading
            /// </summary>
            public static readonly PhaseEnum UPGRADING = new PhaseEnum("Upgrading");

            /// <summary>
            /// Enum ACTIVE for value: Active
            /// </summary>
            public static readonly PhaseEnum ACTIVE = new PhaseEnum("Active");

            /// <summary>
            /// Enum ABNORMAL for value: Abnormal
            /// </summary>
            public static readonly PhaseEnum ABNORMAL = new PhaseEnum("Abnormal");

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
                { "Build", BUILD },
                { "Installing", INSTALLING },
                { "Upgrading", UPGRADING },
                { "Active", ACTIVE },
                { "Abnormal", ABNORMAL },
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
        /// 节点状态：节点资源生命周期管理（如安装卸载等）状态和集群内k8s node状态的综合体现，取值如下 - Build：创建中，表示节点正处于创建过程中。 - Installing：纳管中，表示节点正处于纳管过程中。 - Upgrading：升级中，表示节点正处于升级过程中。 - Active：正常，表示节点处于正常状态。 - Abnormal：异常，表示节点处于异常状态。 - Deleting： 删除中，表示节点正处于删除过程中。 - Error：故障，表示节点处于故障状态。
        /// </summary>
        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public PhaseEnum Phase { get; set; }
        /// <summary>
        /// 节点最近一次状态检查时间。集群处于异常、冻结或者中间态（例如创建中）时，节点的状态检查动作可能受影响。检查时间超过5分的节点状态不具有参考意义。
        /// </summary>
        [JsonProperty("lastProbeTime", NullValueHandling = NullValueHandling.Ignore)]
        public string LastProbeTime { get; set; }

        /// <summary>
        /// 创建或删除时的任务ID。
        /// </summary>
        [JsonProperty("jobID", NullValueHandling = NullValueHandling.Ignore)]
        public string JobID { get; set; }

        /// <summary>
        /// 底层云服务器或裸金属节点ID。
        /// </summary>
        [JsonProperty("serverId", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerId { get; set; }

        /// <summary>
        /// 节点主网卡私有网段IP地址。
        /// </summary>
        [JsonProperty("privateIP", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateIP { get; set; }

        /// <summary>
        /// 节点主网卡私有网段IPv6地址。
        /// </summary>
        [JsonProperty("privateIPv6IP", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateIPv6IP { get; set; }

        /// <summary>
        /// 节点弹性公网IP地址。如果ECS的数据没有实时同步，可在界面上通过“同步节点信息”手动进行更新。
        /// </summary>
        [JsonProperty("publicIP", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIP { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("deleteStatus", NullValueHandling = NullValueHandling.Ignore)]
        public DeleteStatus DeleteStatus { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NodeStatus {\n");
            sb.Append("  phase: ").Append(Phase).Append("\n");
            sb.Append("  lastProbeTime: ").Append(LastProbeTime).Append("\n");
            sb.Append("  jobID: ").Append(JobID).Append("\n");
            sb.Append("  serverId: ").Append(ServerId).Append("\n");
            sb.Append("  privateIP: ").Append(PrivateIP).Append("\n");
            sb.Append("  privateIPv6IP: ").Append(PrivateIPv6IP).Append("\n");
            sb.Append("  publicIP: ").Append(PublicIP).Append("\n");
            sb.Append("  deleteStatus: ").Append(DeleteStatus).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as NodeStatus);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(NodeStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Phase == input.Phase ||
                    (this.Phase != null &&
                    this.Phase.Equals(input.Phase))
                ) && 
                (
                    this.LastProbeTime == input.LastProbeTime ||
                    (this.LastProbeTime != null &&
                    this.LastProbeTime.Equals(input.LastProbeTime))
                ) && 
                (
                    this.JobID == input.JobID ||
                    (this.JobID != null &&
                    this.JobID.Equals(input.JobID))
                ) && 
                (
                    this.ServerId == input.ServerId ||
                    (this.ServerId != null &&
                    this.ServerId.Equals(input.ServerId))
                ) && 
                (
                    this.PrivateIP == input.PrivateIP ||
                    (this.PrivateIP != null &&
                    this.PrivateIP.Equals(input.PrivateIP))
                ) && 
                (
                    this.PrivateIPv6IP == input.PrivateIPv6IP ||
                    (this.PrivateIPv6IP != null &&
                    this.PrivateIPv6IP.Equals(input.PrivateIPv6IP))
                ) && 
                (
                    this.PublicIP == input.PublicIP ||
                    (this.PublicIP != null &&
                    this.PublicIP.Equals(input.PublicIP))
                ) && 
                (
                    this.DeleteStatus == input.DeleteStatus ||
                    (this.DeleteStatus != null &&
                    this.DeleteStatus.Equals(input.DeleteStatus))
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
                if (this.Phase != null)
                    hashCode = hashCode * 59 + this.Phase.GetHashCode();
                if (this.LastProbeTime != null)
                    hashCode = hashCode * 59 + this.LastProbeTime.GetHashCode();
                if (this.JobID != null)
                    hashCode = hashCode * 59 + this.JobID.GetHashCode();
                if (this.ServerId != null)
                    hashCode = hashCode * 59 + this.ServerId.GetHashCode();
                if (this.PrivateIP != null)
                    hashCode = hashCode * 59 + this.PrivateIP.GetHashCode();
                if (this.PrivateIPv6IP != null)
                    hashCode = hashCode * 59 + this.PrivateIPv6IP.GetHashCode();
                if (this.PublicIP != null)
                    hashCode = hashCode * 59 + this.PublicIP.GetHashCode();
                if (this.DeleteStatus != null)
                    hashCode = hashCode * 59 + this.DeleteStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
