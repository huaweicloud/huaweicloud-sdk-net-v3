using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cfw.V1.Model
{
    /// <summary>
    /// 查询地址组详情数据
    /// </summary>
    public class AddressSetDetailResponseDTOData 
    {
        /// <summary>
        /// 地址类型0 ipv4,1 ipv6
        /// </summary>
        /// <value>地址类型0 ipv4,1 ipv6</value>
        [JsonConverter(typeof(EnumClassConverter<AddressTypeEnum>))]
        public class AddressTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            public static readonly AddressTypeEnum NUMBER_0 = new AddressTypeEnum(0);

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly AddressTypeEnum NUMBER_1 = new AddressTypeEnum(1);

            private static readonly Dictionary<int?, AddressTypeEnum> StaticFields =
            new Dictionary<int?, AddressTypeEnum>()
            {
                { 0, NUMBER_0 },
                { 1, NUMBER_1 },
            };

            private int? _value;

            public AddressTypeEnum()
            {

            }

            public AddressTypeEnum(int? value)
            {
                _value = value;
            }

            public static AddressTypeEnum FromValue(int? value)
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

            public int? GetValue()
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

                if (this.Equals(obj as AddressTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AddressTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AddressTypeEnum a, AddressTypeEnum b)
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

            public static bool operator !=(AddressTypeEnum a, AddressTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 地址组id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 地址组名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 地址组描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 地址组类型，0表示自定义地址组，1表示WAF回源IP地址组，2表示DDoS回源IP地址组，3表示NAT64转换地址组
        /// </summary>
        [JsonProperty("address_set_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AddressSetType { get; set; }

        /// <summary>
        /// 地址类型0 ipv4,1 ipv6
        /// </summary>
        [JsonProperty("address_type", NullValueHandling = NullValueHandling.Ignore)]
        public AddressTypeEnum AddressType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressSetDetailResponseDTOData {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  addressSetType: ").Append(AddressSetType).Append("\n");
            sb.Append("  addressType: ").Append(AddressType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddressSetDetailResponseDTOData);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddressSetDetailResponseDTOData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.AddressSetType == input.AddressSetType ||
                    (this.AddressSetType != null &&
                    this.AddressSetType.Equals(input.AddressSetType))
                ) && 
                (
                    this.AddressType == input.AddressType ||
                    (this.AddressType != null &&
                    this.AddressType.Equals(input.AddressType))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.AddressSetType != null)
                    hashCode = hashCode * 59 + this.AddressSetType.GetHashCode();
                if (this.AddressType != null)
                    hashCode = hashCode * 59 + this.AddressType.GetHashCode();
                return hashCode;
            }
        }
    }
}
