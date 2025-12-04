using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// DDM绑定的弹性公网IP信息
    /// </summary>
    public class PublicIpInfo 
    {
        /// <summary>
        /// 弹性公网IP的类型。
        /// </summary>
        /// <value>弹性公网IP的类型。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum _5_BGP_BGP_ for value: 5_bgp（全动态BGP）
            /// </summary>
            public static readonly TypeEnum _5_BGP_BGP_ = new TypeEnum("5_bgp（全动态BGP）");

            /// <summary>
            /// Enum _5_SBGP_BGP_ for value: 5_sbgp（静态BGP）
            /// </summary>
            public static readonly TypeEnum _5_SBGP_BGP_ = new TypeEnum("5_sbgp（静态BGP）");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "5_bgp（全动态BGP）", _5_BGP_BGP_ },
                { "5_sbgp（静态BGP）", _5_SBGP_BGP_ },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 绑定弹性公网IP的实体类型（目前只支持绑定node）。
        /// </summary>
        /// <value>绑定弹性公网IP的实体类型（目前只支持绑定node）。</value>
        [JsonConverter(typeof(EnumClassConverter<BindingEntityTypeEnum>))]
        public class BindingEntityTypeEnum
        {
            /// <summary>
            /// Enum NODE_ for value: node（节点）
            /// </summary>
            public static readonly BindingEntityTypeEnum NODE_ = new BindingEntityTypeEnum("node（节点）");

            /// <summary>
            /// Enum NODE_GROUP_ for value: node_group（节点组）
            /// </summary>
            public static readonly BindingEntityTypeEnum NODE_GROUP_ = new BindingEntityTypeEnum("node_group（节点组）");

            private static readonly Dictionary<string, BindingEntityTypeEnum> StaticFields =
            new Dictionary<string, BindingEntityTypeEnum>()
            {
                { "node（节点）", NODE_ },
                { "node_group（节点组）", NODE_GROUP_ },
            };

            private string _value;

            public BindingEntityTypeEnum()
            {

            }

            public BindingEntityTypeEnum(string value)
            {
                _value = value;
            }

            public static BindingEntityTypeEnum FromValue(string value)
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

                if (this.Equals(obj as BindingEntityTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BindingEntityTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BindingEntityTypeEnum a, BindingEntityTypeEnum b)
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

            public static bool operator !=(BindingEntityTypeEnum a, BindingEntityTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 弹性公网IP唯一标识。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 弹性公网IP的类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 弹性公网IP的地址。
        /// </summary>
        [JsonProperty("public_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicIp { get; set; }

        /// <summary>
        /// 绑定弹性公网IP的私有IP地址。
        /// </summary>
        [JsonProperty("private_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string PrivateIp { get; set; }

        /// <summary>
        /// 绑定弹性公网IP的实体ID。
        /// </summary>
        [JsonProperty("binding_entity_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BindingEntityId { get; set; }

        /// <summary>
        /// 绑定弹性公网IP的实体名称。
        /// </summary>
        [JsonProperty("binding_entity_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BindingEntityName { get; set; }

        /// <summary>
        /// 绑定弹性公网IP的实体类型（目前只支持绑定node）。
        /// </summary>
        [JsonProperty("binding_entity_type", NullValueHandling = NullValueHandling.Ignore)]
        public BindingEntityTypeEnum BindingEntityType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublicIpInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  publicIp: ").Append(PublicIp).Append("\n");
            sb.Append("  privateIp: ").Append(PrivateIp).Append("\n");
            sb.Append("  bindingEntityId: ").Append(BindingEntityId).Append("\n");
            sb.Append("  bindingEntityName: ").Append(BindingEntityName).Append("\n");
            sb.Append("  bindingEntityType: ").Append(BindingEntityType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublicIpInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PublicIpInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Type != input.Type) return false;
            if (this.PublicIp != input.PublicIp || (this.PublicIp != null && !this.PublicIp.Equals(input.PublicIp))) return false;
            if (this.PrivateIp != input.PrivateIp || (this.PrivateIp != null && !this.PrivateIp.Equals(input.PrivateIp))) return false;
            if (this.BindingEntityId != input.BindingEntityId || (this.BindingEntityId != null && !this.BindingEntityId.Equals(input.BindingEntityId))) return false;
            if (this.BindingEntityName != input.BindingEntityName || (this.BindingEntityName != null && !this.BindingEntityName.Equals(input.BindingEntityName))) return false;
            if (this.BindingEntityType != input.BindingEntityType) return false;

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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.PublicIp != null) hashCode = hashCode * 59 + this.PublicIp.GetHashCode();
                if (this.PrivateIp != null) hashCode = hashCode * 59 + this.PrivateIp.GetHashCode();
                if (this.BindingEntityId != null) hashCode = hashCode * 59 + this.BindingEntityId.GetHashCode();
                if (this.BindingEntityName != null) hashCode = hashCode * 59 + this.BindingEntityName.GetHashCode();
                hashCode = hashCode * 59 + this.BindingEntityType.GetHashCode();
                return hashCode;
            }
        }
    }
}
