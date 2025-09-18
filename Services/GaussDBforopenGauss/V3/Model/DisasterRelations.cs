using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 对端容灾关系信息。
    /// </summary>
    public class DisasterRelations 
    {
        /// <summary>
        /// 容灾角色。
        /// </summary>
        /// <value>容灾角色。</value>
        [JsonConverter(typeof(EnumClassConverter<DisasterRoleEnum>))]
        public class DisasterRoleEnum
        {
            /// <summary>
            /// Enum DISASTER for value: disaster
            /// </summary>
            public static readonly DisasterRoleEnum DISASTER = new DisasterRoleEnum("disaster");

            /// <summary>
            /// Enum MASTER for value: master
            /// </summary>
            public static readonly DisasterRoleEnum MASTER = new DisasterRoleEnum("master");

            private static readonly Dictionary<string, DisasterRoleEnum> StaticFields =
            new Dictionary<string, DisasterRoleEnum>()
            {
                { "disaster", DISASTER },
                { "master", MASTER },
            };

            private string _value;

            public DisasterRoleEnum()
            {

            }

            public DisasterRoleEnum(string value)
            {
                _value = value;
            }

            public static DisasterRoleEnum FromValue(string value)
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

                if (this.Equals(obj as DisasterRoleEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DisasterRoleEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DisasterRoleEnum a, DisasterRoleEnum b)
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

            public static bool operator !=(DisasterRoleEnum a, DisasterRoleEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 容灾类型。
        /// </summary>
        [JsonProperty("disaster_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DisasterType { get; set; }

        /// <summary>
        /// 容灾任务名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 容灾角色。
        /// </summary>
        [JsonProperty("disaster_role", NullValueHandling = NullValueHandling.Ignore)]
        public DisasterRoleEnum DisasterRole { get; set; }
        /// <summary>
        /// 创建时间，格式为“yyyy-mm-dd hh:mm:ss”。
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public string Created { get; set; }

        /// <summary>
        /// 更新时间，格式为“yyyy-mm-dd hh:mm:ss”。
        /// </summary>
        [JsonProperty("updated", NullValueHandling = NullValueHandling.Ignore)]
        public string Updated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("slave_region_instance_info", NullValueHandling = NullValueHandling.Ignore)]
        public RegionInstanceInfo SlaveRegionInstanceInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("master_region_instance_info", NullValueHandling = NullValueHandling.Ignore)]
        public RegionInstanceInfo MasterRegionInstanceInfo { get; set; }

        /// <summary>
        /// 容灾记录id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 容灾关系唯一id。
        /// </summary>
        [JsonProperty("synchronization_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SynchronizationId { get; set; }

        /// <summary>
        /// 当前region实例id。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 当前region实例名称。
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 当前region实例状态。
        /// </summary>
        [JsonProperty("instance_status", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceStatus { get; set; }

        /// <summary>
        /// 容灾记录状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 预校验失败原因。
        /// </summary>
        [JsonProperty("precheck_failed_reason", NullValueHandling = NullValueHandling.Ignore)]
        public string PrecheckFailedReason { get; set; }

        /// <summary>
        /// 实例当前操作action。
        /// </summary>
        [JsonProperty("actions", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Actions { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisasterRelations {\n");
            sb.Append("  disasterType: ").Append(DisasterType).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  disasterRole: ").Append(DisasterRole).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  updated: ").Append(Updated).Append("\n");
            sb.Append("  slaveRegionInstanceInfo: ").Append(SlaveRegionInstanceInfo).Append("\n");
            sb.Append("  masterRegionInstanceInfo: ").Append(MasterRegionInstanceInfo).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  synchronizationId: ").Append(SynchronizationId).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  instanceStatus: ").Append(InstanceStatus).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  precheckFailedReason: ").Append(PrecheckFailedReason).Append("\n");
            sb.Append("  actions: ").Append(Actions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DisasterRelations);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DisasterRelations input)
        {
            if (input == null) return false;
            if (this.DisasterType != input.DisasterType || (this.DisasterType != null && !this.DisasterType.Equals(input.DisasterType))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.DisasterRole != input.DisasterRole) return false;
            if (this.Created != input.Created || (this.Created != null && !this.Created.Equals(input.Created))) return false;
            if (this.Updated != input.Updated || (this.Updated != null && !this.Updated.Equals(input.Updated))) return false;
            if (this.SlaveRegionInstanceInfo != input.SlaveRegionInstanceInfo || (this.SlaveRegionInstanceInfo != null && !this.SlaveRegionInstanceInfo.Equals(input.SlaveRegionInstanceInfo))) return false;
            if (this.MasterRegionInstanceInfo != input.MasterRegionInstanceInfo || (this.MasterRegionInstanceInfo != null && !this.MasterRegionInstanceInfo.Equals(input.MasterRegionInstanceInfo))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.SynchronizationId != input.SynchronizationId || (this.SynchronizationId != null && !this.SynchronizationId.Equals(input.SynchronizationId))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.InstanceStatus != input.InstanceStatus || (this.InstanceStatus != null && !this.InstanceStatus.Equals(input.InstanceStatus))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.PrecheckFailedReason != input.PrecheckFailedReason || (this.PrecheckFailedReason != null && !this.PrecheckFailedReason.Equals(input.PrecheckFailedReason))) return false;
            if (this.Actions != input.Actions || (this.Actions != null && input.Actions != null && !this.Actions.SequenceEqual(input.Actions))) return false;

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
                if (this.DisasterType != null) hashCode = hashCode * 59 + this.DisasterType.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.DisasterRole.GetHashCode();
                if (this.Created != null) hashCode = hashCode * 59 + this.Created.GetHashCode();
                if (this.Updated != null) hashCode = hashCode * 59 + this.Updated.GetHashCode();
                if (this.SlaveRegionInstanceInfo != null) hashCode = hashCode * 59 + this.SlaveRegionInstanceInfo.GetHashCode();
                if (this.MasterRegionInstanceInfo != null) hashCode = hashCode * 59 + this.MasterRegionInstanceInfo.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.SynchronizationId != null) hashCode = hashCode * 59 + this.SynchronizationId.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.InstanceStatus != null) hashCode = hashCode * 59 + this.InstanceStatus.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.PrecheckFailedReason != null) hashCode = hashCode * 59 + this.PrecheckFailedReason.GetHashCode();
                if (this.Actions != null) hashCode = hashCode * 59 + this.Actions.GetHashCode();
                return hashCode;
            }
        }
    }
}
