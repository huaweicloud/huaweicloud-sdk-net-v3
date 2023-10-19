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
    /// description
    /// </summary>
    public class IpsSwitchDTO 
    {
        /// <summary>
        /// 补丁类型，仅支持虚拟补丁，值为2。
        /// </summary>
        /// <value>补丁类型，仅支持虚拟补丁，值为2。</value>
        [JsonConverter(typeof(EnumClassConverter<IpsTypeEnum>))]
        public class IpsTypeEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            public static readonly IpsTypeEnum NUMBER_1 = new IpsTypeEnum(1);

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            public static readonly IpsTypeEnum NUMBER_2 = new IpsTypeEnum(2);

            private static readonly Dictionary<int?, IpsTypeEnum> StaticFields =
            new Dictionary<int?, IpsTypeEnum>()
            {
                { 1, NUMBER_1 },
                { 2, NUMBER_2 },
            };

            private int? _value;

            public IpsTypeEnum()
            {

            }

            public IpsTypeEnum(int? value)
            {
                _value = value;
            }

            public static IpsTypeEnum FromValue(int? value)
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

                if (this.Equals(obj as IpsTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(IpsTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(IpsTypeEnum a, IpsTypeEnum b)
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

            public static bool operator !=(IpsTypeEnum a, IpsTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 防护对象id，是创建云防火墙后用于区分互联网边界防护和VPC边界防护的标志id，可通过调用查询防火墙实例接口获得，注意type为0的为互联网边界防护对象id，type为1的为VPC边界防护对象id。具体可参考APIExlorer和帮助中心FAQ。
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// 补丁类型，仅支持虚拟补丁，值为2。
        /// </summary>
        [JsonProperty("ips_type", NullValueHandling = NullValueHandling.Ignore)]
        public IpsTypeEnum IpsType { get; set; }
        /// <summary>
        /// ips特性开关状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpsSwitchDTO {\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  ipsType: ").Append(IpsType).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IpsSwitchDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IpsSwitchDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
                ) && 
                (
                    this.IpsType == input.IpsType ||
                    (this.IpsType != null &&
                    this.IpsType.Equals(input.IpsType))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.ObjectId != null)
                    hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.IpsType != null)
                    hashCode = hashCode * 59 + this.IpsType.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
