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
    /// UpdateBlackWhiteListDto
    /// </summary>
    public class UpdateBlackWhiteListDto 
    {
        /// <summary>
        /// 黑白名单类型4：黑名单，5：白名单
        /// </summary>
        /// <value>黑白名单类型4：黑名单，5：白名单</value>
        [JsonConverter(typeof(EnumClassConverter<ListTypeEnum>))]
        public class ListTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            public static readonly ListTypeEnum NUMBER_4 = new ListTypeEnum(4);

            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            public static readonly ListTypeEnum NUMBER_5 = new ListTypeEnum(5);

            private static readonly Dictionary<int?, ListTypeEnum> StaticFields =
            new Dictionary<int?, ListTypeEnum>()
            {
                { 4, NUMBER_4 },
                { 5, NUMBER_5 },
            };

            private int? _value;

            public ListTypeEnum()
            {

            }

            public ListTypeEnum(int? value)
            {
                _value = value;
            }

            public static ListTypeEnum FromValue(int? value)
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

                if (this.Equals(obj as ListTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ListTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ListTypeEnum a, ListTypeEnum b)
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

            public static bool operator !=(ListTypeEnum a, ListTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 地址方向0：源地址1：目的地址
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public int? Direction { get; set; }

        /// <summary>
        /// 地址类型0：ipv4,1:ipv6,2:domain
        /// </summary>
        [JsonProperty("address_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? AddressType { get; set; }

        /// <summary>
        /// ip地址
        /// </summary>
        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string Address { get; set; }

        /// <summary>
        /// 协议类型:TCP为6, UDP为17,ICMP为1,ICMPV6为58,ANY为-1
        /// </summary>
        [JsonProperty("protocol", NullValueHandling = NullValueHandling.Ignore)]
        public int? Protocol { get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public string Port { get; set; }

        /// <summary>
        /// 黑白名单类型4：黑名单，5：白名单
        /// </summary>
        [JsonProperty("list_type", NullValueHandling = NullValueHandling.Ignore)]
        public ListTypeEnum ListType { get; set; }
        /// <summary>
        /// 防护对象id，是创建云防火墙后用于区分互联网边界防护和VPC边界防护的标志id，可通过调用查询防火墙实例接口获得，注意type为0的为互联网边界防护对象id，type为1的为VPC边界防护对象id。具体可参考APIExlorer和帮助中心FAQ。
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateBlackWhiteListDto {\n");
            sb.Append("  direction: ").Append(Direction).Append("\n");
            sb.Append("  addressType: ").Append(AddressType).Append("\n");
            sb.Append("  address: ").Append(Address).Append("\n");
            sb.Append("  protocol: ").Append(Protocol).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  listType: ").Append(ListType).Append("\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateBlackWhiteListDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateBlackWhiteListDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.AddressType == input.AddressType ||
                    (this.AddressType != null &&
                    this.AddressType.Equals(input.AddressType))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Protocol == input.Protocol ||
                    (this.Protocol != null &&
                    this.Protocol.Equals(input.Protocol))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.ListType == input.ListType ||
                    (this.ListType != null &&
                    this.ListType.Equals(input.ListType))
                ) && 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
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
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.AddressType != null)
                    hashCode = hashCode * 59 + this.AddressType.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Protocol != null)
                    hashCode = hashCode * 59 + this.Protocol.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.ListType != null)
                    hashCode = hashCode * 59 + this.ListType.GetHashCode();
                if (this.ObjectId != null)
                    hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
