using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 支持的区域。
    /// </summary>
    public class Region 
    {
        /// <summary>
        /// Defines usedScenes
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<UsedScenesEnum>))]
        public class UsedScenesEnum
        {
            /// <summary>
            /// Enum ER for value: er
            /// </summary>
            public static readonly UsedScenesEnum ER = new UsedScenesEnum("er");

            /// <summary>
            /// Enum VPC for value: vpc
            /// </summary>
            public static readonly UsedScenesEnum VPC = new UsedScenesEnum("vpc");

            /// <summary>
            /// Enum VGW for value: vgw
            /// </summary>
            public static readonly UsedScenesEnum VGW = new UsedScenesEnum("vgw");

            private static readonly Dictionary<string, UsedScenesEnum> StaticFields =
            new Dictionary<string, UsedScenesEnum>()
            {
                { "er", ER },
                { "vpc", VPC },
                { "vgw", VGW },
            };

            private string _value;

            public UsedScenesEnum()
            {

            }

            public UsedScenesEnum(string value)
            {
                _value = value;
            }

            public static UsedScenesEnum FromValue(string value)
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

                if (this.Equals(obj as UsedScenesEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(UsedScenesEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(UsedScenesEnum a, UsedScenesEnum b)
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

            public static bool operator !=(UsedScenesEnum a, UsedScenesEnum b)
            {
                return !(a == b);
            }
        }



        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("area_id", NullValueHandling = NullValueHandling.Ignore)]
        public AreaIdDef AreaId { get; set; }
        /// <summary>
        /// 区域ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 大区名称。
        /// </summary>
        [JsonProperty("area_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AreaName { get; set; }

        /// <summary>
        /// 云连接使用场景。  - er（企业路由器） - vpc（虚拟私有云） - vgw（虚拟网关）
        /// </summary>
        [JsonProperty("used_scenes", NullValueHandling = NullValueHandling.Ignore)]
        public List<UsedScenesEnum> UsedScenes { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Region {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  areaId: ").Append(AreaId).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  areaName: ").Append(AreaName).Append("\n");
            sb.Append("  usedScenes: ").Append(UsedScenes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Region);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Region input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.AreaId != input.AreaId) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.AreaName != input.AreaName || (this.AreaName != null && !this.AreaName.Equals(input.AreaName))) return false;
            if (this.UsedScenes != input.UsedScenes || (this.UsedScenes != null && input.UsedScenes != null && !this.UsedScenes.SequenceEqual(input.UsedScenes))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.AreaId.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AreaName != null) hashCode = hashCode * 59 + this.AreaName.GetHashCode();
                hashCode = hashCode * 59 + this.UsedScenes.GetHashCode();
                return hashCode;
            }
        }
    }
}
