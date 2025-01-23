using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 资源信息。
    /// </summary>
    public class ResourceCheckResource 
    {
        /// <summary>
        /// 实例部署模式。
        /// </summary>
        /// <value>实例部署模式。</value>
        [JsonConverter(typeof(EnumClassConverter<ModeEnum>))]
        public class ModeEnum
        {
            /// <summary>
            /// Enum CLUSTER for value: Cluster
            /// </summary>
            public static readonly ModeEnum CLUSTER = new ModeEnum("Cluster");

            /// <summary>
            /// Enum SINGLE for value: Single
            /// </summary>
            public static readonly ModeEnum SINGLE = new ModeEnum("Single");

            private static readonly Dictionary<string, ModeEnum> StaticFields =
            new Dictionary<string, ModeEnum>()
            {
                { "Cluster", CLUSTER },
                { "Single", SINGLE },
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

            public static bool operator !=(ModeEnum a, ModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 实例数量。
        /// </summary>
        [JsonProperty("instance_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceNum { get; set; }

        /// <summary>
        /// 实例部署模式。
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public ModeEnum Mode { get; set; }
        /// <summary>
        /// 可用区类型，目前仅支持single。
        /// </summary>
        [JsonProperty("availability_zone_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZoneMode { get; set; }

        /// <summary>
        /// FE节点数量。
        /// </summary>
        [JsonProperty("fe_node_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? FeNodeNum { get; set; }

        /// <summary>
        /// BE节点数量。
        /// </summary>
        [JsonProperty("be_node_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? BeNodeNum { get; set; }

        /// <summary>
        /// FE规格码。
        /// </summary>
        [JsonProperty("fe_flavor_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string FeFlavorRef { get; set; }

        /// <summary>
        /// BE规格码。
        /// </summary>
        [JsonProperty("be_flavor_ref", NullValueHandling = NullValueHandling.Ignore)]
        public string BeFlavorRef { get; set; }

        /// <summary>
        /// 可用区码。选填，校验可用区码是否正确。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// HTAP实例子网即TaurusDB实例子网。 获取方法请参见[获取子网ID](https://support.huaweicloud.com/api-vpc/vpc_subnet01_0003.html)。
        /// </summary>
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceCheckResource {\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  instanceNum: ").Append(InstanceNum).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  availabilityZoneMode: ").Append(AvailabilityZoneMode).Append("\n");
            sb.Append("  feNodeNum: ").Append(FeNodeNum).Append("\n");
            sb.Append("  beNodeNum: ").Append(BeNodeNum).Append("\n");
            sb.Append("  feFlavorRef: ").Append(FeFlavorRef).Append("\n");
            sb.Append("  beFlavorRef: ").Append(BeFlavorRef).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResourceCheckResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResourceCheckResource input)
        {
            if (input == null) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.InstanceNum != input.InstanceNum || (this.InstanceNum != null && !this.InstanceNum.Equals(input.InstanceNum))) return false;
            if (this.Mode != input.Mode) return false;
            if (this.AvailabilityZoneMode != input.AvailabilityZoneMode || (this.AvailabilityZoneMode != null && !this.AvailabilityZoneMode.Equals(input.AvailabilityZoneMode))) return false;
            if (this.FeNodeNum != input.FeNodeNum || (this.FeNodeNum != null && !this.FeNodeNum.Equals(input.FeNodeNum))) return false;
            if (this.BeNodeNum != input.BeNodeNum || (this.BeNodeNum != null && !this.BeNodeNum.Equals(input.BeNodeNum))) return false;
            if (this.FeFlavorRef != input.FeFlavorRef || (this.FeFlavorRef != null && !this.FeFlavorRef.Equals(input.FeFlavorRef))) return false;
            if (this.BeFlavorRef != input.BeFlavorRef || (this.BeFlavorRef != null && !this.BeFlavorRef.Equals(input.BeFlavorRef))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;

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
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.InstanceNum != null) hashCode = hashCode * 59 + this.InstanceNum.GetHashCode();
                hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.AvailabilityZoneMode != null) hashCode = hashCode * 59 + this.AvailabilityZoneMode.GetHashCode();
                if (this.FeNodeNum != null) hashCode = hashCode * 59 + this.FeNodeNum.GetHashCode();
                if (this.BeNodeNum != null) hashCode = hashCode * 59 + this.BeNodeNum.GetHashCode();
                if (this.FeFlavorRef != null) hashCode = hashCode * 59 + this.FeFlavorRef.GetHashCode();
                if (this.BeFlavorRef != null) hashCode = hashCode * 59 + this.BeFlavorRef.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                return hashCode;
            }
        }
    }
}
