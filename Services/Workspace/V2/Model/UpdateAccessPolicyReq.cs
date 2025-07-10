using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateAccessPolicyReq 
    {
        /// <summary>
        /// 操作类别。 * ADD_IP： 添加IP * DELETE_IP： 删除IP
        /// </summary>
        /// <value>操作类别。 * ADD_IP： 添加IP * DELETE_IP： 删除IP</value>
        [JsonConverter(typeof(EnumClassConverter<OperationTypeEnum>))]
        public class OperationTypeEnum
        {
            /// <summary>
            /// Enum ADD_IP for value: ADD_IP
            /// </summary>
            public static readonly OperationTypeEnum ADD_IP = new OperationTypeEnum("ADD_IP");

            /// <summary>
            /// Enum DELETE_IP for value: DELETE_IP
            /// </summary>
            public static readonly OperationTypeEnum DELETE_IP = new OperationTypeEnum("DELETE_IP");

            private static readonly Dictionary<string, OperationTypeEnum> StaticFields =
            new Dictionary<string, OperationTypeEnum>()
            {
                { "ADD_IP", ADD_IP },
                { "DELETE_IP", DELETE_IP },
            };

            private string _value;

            public OperationTypeEnum()
            {

            }

            public OperationTypeEnum(string value)
            {
                _value = value;
            }

            public static OperationTypeEnum FromValue(string value)
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

                if (this.Equals(obj as OperationTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OperationTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OperationTypeEnum a, OperationTypeEnum b)
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

            public static bool operator !=(OperationTypeEnum a, OperationTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 操作类别。 * ADD_IP： 添加IP * DELETE_IP： 删除IP
        /// </summary>
        [JsonProperty("operation_type", NullValueHandling = NullValueHandling.Ignore)]
        public OperationTypeEnum OperationType { get; set; }
        /// <summary>
        /// 策略的ip列表。
        /// </summary>
        [JsonProperty("ip_white_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<IpInfo> IpWhiteList { get; set; }

        /// <summary>
        /// IP白名单是否生效。
        /// </summary>
        [JsonProperty("is_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsEnable { get; set; }

        /// <summary>
        /// IP白名单是否禁止所有Ip接入。
        /// </summary>
        [JsonProperty("is_block_all", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBlockAll { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAccessPolicyReq {\n");
            sb.Append("  operationType: ").Append(OperationType).Append("\n");
            sb.Append("  ipWhiteList: ").Append(IpWhiteList).Append("\n");
            sb.Append("  isEnable: ").Append(IsEnable).Append("\n");
            sb.Append("  isBlockAll: ").Append(IsBlockAll).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateAccessPolicyReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateAccessPolicyReq input)
        {
            if (input == null) return false;
            if (this.OperationType != input.OperationType) return false;
            if (this.IpWhiteList != input.IpWhiteList || (this.IpWhiteList != null && input.IpWhiteList != null && !this.IpWhiteList.SequenceEqual(input.IpWhiteList))) return false;
            if (this.IsEnable != input.IsEnable || (this.IsEnable != null && !this.IsEnable.Equals(input.IsEnable))) return false;
            if (this.IsBlockAll != input.IsBlockAll || (this.IsBlockAll != null && !this.IsBlockAll.Equals(input.IsBlockAll))) return false;

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
                hashCode = hashCode * 59 + this.OperationType.GetHashCode();
                if (this.IpWhiteList != null) hashCode = hashCode * 59 + this.IpWhiteList.GetHashCode();
                if (this.IsEnable != null) hashCode = hashCode * 59 + this.IsEnable.GetHashCode();
                if (this.IsBlockAll != null) hashCode = hashCode * 59 + this.IsBlockAll.GetHashCode();
                return hashCode;
            }
        }
    }
}
