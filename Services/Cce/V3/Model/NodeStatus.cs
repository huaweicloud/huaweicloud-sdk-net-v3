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
        /// 节点状态。
        /// </summary>
        /// <value>节点状态。</value>
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
            /// Enum INSTALLED for value: Installed
            /// </summary>
            public static readonly PhaseEnum INSTALLED = new PhaseEnum("Installed");

            /// <summary>
            /// Enum SHUTDOWN for value: ShutDown
            /// </summary>
            public static readonly PhaseEnum SHUTDOWN = new PhaseEnum("ShutDown");

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
                { "Installed", INSTALLED },
                { "ShutDown", SHUTDOWN },
                { "Upgrading", UPGRADING },
                { "Active", ACTIVE },
                { "Abnormal", ABNORMAL },
                { "Deleting", DELETING },
                { "Error", ERROR },
            };

            private string Value;

            public PhaseEnum(string value)
            {
                Value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 节点状态。
        /// </summary>
        [JsonProperty("phase", NullValueHandling = NullValueHandling.Ignore)]
        public PhaseEnum Phase { get; set; }
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
            sb.Append("  jobID: ").Append(JobID).Append("\n");
            sb.Append("  serverId: ").Append(ServerId).Append("\n");
            sb.Append("  privateIP: ").Append(PrivateIP).Append("\n");
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
                if (this.JobID != null)
                    hashCode = hashCode * 59 + this.JobID.GetHashCode();
                if (this.ServerId != null)
                    hashCode = hashCode * 59 + this.ServerId.GetHashCode();
                if (this.PrivateIP != null)
                    hashCode = hashCode * 59 + this.PrivateIP.GetHashCode();
                if (this.PublicIP != null)
                    hashCode = hashCode * 59 + this.PublicIP.GetHashCode();
                if (this.DeleteStatus != null)
                    hashCode = hashCode * 59 + this.DeleteStatus.GetHashCode();
                return hashCode;
            }
        }
    }
}
