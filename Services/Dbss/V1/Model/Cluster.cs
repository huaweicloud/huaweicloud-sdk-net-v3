using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dbss.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Cluster 
    {
        /// <summary>
        /// 计费模式  - Period: 包周期  - Demand: 按需
        /// </summary>
        /// <value>计费模式  - Period: 包周期  - Demand: 按需</value>
        [JsonConverter(typeof(EnumClassConverter<ChargeModelEnum>))]
        public class ChargeModelEnum
        {
            /// <summary>
            /// Enum PERIOD for value: Period
            /// </summary>
            public static readonly ChargeModelEnum PERIOD = new ChargeModelEnum("Period");

            /// <summary>
            /// Enum DEMAND for value: Demand
            /// </summary>
            public static readonly ChargeModelEnum DEMAND = new ChargeModelEnum("Demand");

            /// <summary>
            /// Enum TEST for value: Test
            /// </summary>
            public static readonly ChargeModelEnum TEST = new ChargeModelEnum("Test");

            private static readonly Dictionary<string, ChargeModelEnum> StaticFields =
            new Dictionary<string, ChargeModelEnum>()
            {
                { "Period", PERIOD },
                { "Demand", DEMAND },
                { "Test", TEST },
            };

            private string _value;

            public ChargeModelEnum()
            {

            }

            public ChargeModelEnum(string value)
            {
                _value = value;
            }

            public static ChargeModelEnum FromValue(string value)
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

                if (this.Equals(obj as ChargeModelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ChargeModelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ChargeModelEnum a, ChargeModelEnum b)
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

            public static bool operator !=(ChargeModelEnum a, ChargeModelEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 部署方式  - CLOUD: 云上  - OUTSIDE：云外
        /// </summary>
        /// <value>部署方式  - CLOUD: 云上  - OUTSIDE：云外</value>
        [JsonConverter(typeof(EnumClassConverter<DeployModeEnum>))]
        public class DeployModeEnum
        {
            /// <summary>
            /// Enum CLOUD for value: CLOUD
            /// </summary>
            public static readonly DeployModeEnum CLOUD = new DeployModeEnum("CLOUD");

            /// <summary>
            /// Enum OUTSIDE for value: OUTSIDE
            /// </summary>
            public static readonly DeployModeEnum OUTSIDE = new DeployModeEnum("OUTSIDE");

            private static readonly Dictionary<string, DeployModeEnum> StaticFields =
            new Dictionary<string, DeployModeEnum>()
            {
                { "CLOUD", CLOUD },
                { "OUTSIDE", OUTSIDE },
            };

            private string _value;

            public DeployModeEnum()
            {

            }

            public DeployModeEnum(string value)
            {
                _value = value;
            }

            public static DeployModeEnum FromValue(string value)
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

                if (this.Equals(obj as DeployModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DeployModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DeployModeEnum a, DeployModeEnum b)
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

            public static bool operator !=(DeployModeEnum a, DeployModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("activate_info", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceActivateInfo ActivateInfo { get; set; }

        /// <summary>
        /// 计费模式  - Period: 包周期  - Demand: 按需
        /// </summary>
        [JsonProperty("charge_model", NullValueHandling = NullValueHandling.Ignore)]
        public ChargeModelEnum ChargeModel { get; set; }
        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
        public string Comment { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("created", NullValueHandling = NullValueHandling.Ignore)]
        public long? Created { get; set; }

        /// <summary>
        /// 部署方式  - CLOUD: 云上  - OUTSIDE：云外
        /// </summary>
        [JsonProperty("deploy_mode", NullValueHandling = NullValueHandling.Ignore)]
        public DeployModeEnum DeployMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public ServerList Detail { get; set; }

        /// <summary>
        /// 企业项目ID
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("expired", NullValueHandling = NullValueHandling.Ignore)]
        public long? Expired { get; set; }

        /// <summary>
        /// 浮动IP
        /// </summary>
        [JsonProperty("float_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string FloatIp { get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 是否激活备用
        /// </summary>
        [JsonProperty("is_active_standby", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsActiveStandby { get; set; }

        /// <summary>
        /// 使用天数
        /// </summary>
        [JsonProperty("keep_days", NullValueHandling = NullValueHandling.Ignore)]
        public string KeepDays { get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 最新版本
        /// </summary>
        [JsonProperty("new_version", NullValueHandling = NullValueHandling.Ignore)]
        public string NewVersion { get; set; }

        /// <summary>
        /// 公网IP
        /// </summary>
        [JsonProperty("public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIp { get; set; }

        /// <summary>
        /// 剩余天数
        /// </summary>
        [JsonProperty("remain_days", NullValueHandling = NullValueHandling.Ignore)]
        public string RemainDays { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Cluster {\n");
            sb.Append("  activateInfo: ").Append(ActivateInfo).Append("\n");
            sb.Append("  chargeModel: ").Append(ChargeModel).Append("\n");
            sb.Append("  comment: ").Append(Comment).Append("\n");
            sb.Append("  created: ").Append(Created).Append("\n");
            sb.Append("  deployMode: ").Append(DeployMode).Append("\n");
            sb.Append("  detail: ").Append(Detail).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  expired: ").Append(Expired).Append("\n");
            sb.Append("  floatIp: ").Append(FloatIp).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  isActiveStandby: ").Append(IsActiveStandby).Append("\n");
            sb.Append("  keepDays: ").Append(KeepDays).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  newVersion: ").Append(NewVersion).Append("\n");
            sb.Append("  publicIp: ").Append(PublicIp).Append("\n");
            sb.Append("  remainDays: ").Append(RemainDays).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Cluster);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Cluster input)
        {
            if (input == null) return false;
            if (this.ActivateInfo != input.ActivateInfo || (this.ActivateInfo != null && !this.ActivateInfo.Equals(input.ActivateInfo))) return false;
            if (this.ChargeModel != input.ChargeModel) return false;
            if (this.Comment != input.Comment || (this.Comment != null && !this.Comment.Equals(input.Comment))) return false;
            if (this.Created != input.Created || (this.Created != null && !this.Created.Equals(input.Created))) return false;
            if (this.DeployMode != input.DeployMode) return false;
            if (this.Detail != input.Detail || (this.Detail != null && !this.Detail.Equals(input.Detail))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.Expired != input.Expired || (this.Expired != null && !this.Expired.Equals(input.Expired))) return false;
            if (this.FloatIp != input.FloatIp || (this.FloatIp != null && !this.FloatIp.Equals(input.FloatIp))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.IsActiveStandby != input.IsActiveStandby || (this.IsActiveStandby != null && !this.IsActiveStandby.Equals(input.IsActiveStandby))) return false;
            if (this.KeepDays != input.KeepDays || (this.KeepDays != null && !this.KeepDays.Equals(input.KeepDays))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.NewVersion != input.NewVersion || (this.NewVersion != null && !this.NewVersion.Equals(input.NewVersion))) return false;
            if (this.PublicIp != input.PublicIp || (this.PublicIp != null && !this.PublicIp.Equals(input.PublicIp))) return false;
            if (this.RemainDays != input.RemainDays || (this.RemainDays != null && !this.RemainDays.Equals(input.RemainDays))) return false;

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
                if (this.ActivateInfo != null) hashCode = hashCode * 59 + this.ActivateInfo.GetHashCode();
                hashCode = hashCode * 59 + this.ChargeModel.GetHashCode();
                if (this.Comment != null) hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.Created != null) hashCode = hashCode * 59 + this.Created.GetHashCode();
                hashCode = hashCode * 59 + this.DeployMode.GetHashCode();
                if (this.Detail != null) hashCode = hashCode * 59 + this.Detail.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Expired != null) hashCode = hashCode * 59 + this.Expired.GetHashCode();
                if (this.FloatIp != null) hashCode = hashCode * 59 + this.FloatIp.GetHashCode();
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.IsActiveStandby != null) hashCode = hashCode * 59 + this.IsActiveStandby.GetHashCode();
                if (this.KeepDays != null) hashCode = hashCode * 59 + this.KeepDays.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NewVersion != null) hashCode = hashCode * 59 + this.NewVersion.GetHashCode();
                if (this.PublicIp != null) hashCode = hashCode * 59 + this.PublicIp.GetHashCode();
                if (this.RemainDays != null) hashCode = hashCode * 59 + this.RemainDays.GetHashCode();
                return hashCode;
            }
        }
    }
}
