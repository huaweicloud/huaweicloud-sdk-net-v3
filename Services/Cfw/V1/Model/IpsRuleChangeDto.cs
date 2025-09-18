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
    /// 
    /// </summary>
    public class IpsRuleChangeDto 
    {
        /// <summary>
        /// ips规则状态
        /// </summary>
        /// <value>ips规则状态</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum OBSERVE for value: OBSERVE
            /// </summary>
            public static readonly StatusEnum OBSERVE = new StatusEnum("OBSERVE");

            /// <summary>
            /// Enum ENABLE for value: ENABLE
            /// </summary>
            public static readonly StatusEnum ENABLE = new StatusEnum("ENABLE");

            /// <summary>
            /// Enum CLOSE for value: CLOSE
            /// </summary>
            public static readonly StatusEnum CLOSE = new StatusEnum("CLOSE");

            /// <summary>
            /// Enum DEFAULT for value: DEFAULT
            /// </summary>
            public static readonly StatusEnum DEFAULT = new StatusEnum("DEFAULT");

            /// <summary>
            /// Enum ALL_DEFAULT for value: ALL_DEFAULT
            /// </summary>
            public static readonly StatusEnum ALL_DEFAULT = new StatusEnum("ALL_DEFAULT");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "OBSERVE", OBSERVE },
                { "ENABLE", ENABLE },
                { "CLOSE", CLOSE },
                { "DEFAULT", DEFAULT },
                { "ALL_DEFAULT", ALL_DEFAULT },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// ips的id列表
        /// </summary>
        [JsonProperty("ips_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> IpsIds { get; set; }

        /// <summary>
        /// 防护对象id
        /// </summary>
        [JsonProperty("object_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ObjectId { get; set; }

        /// <summary>
        /// ips规则状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpsRuleChangeDto {\n");
            sb.Append("  ipsIds: ").Append(IpsIds).Append("\n");
            sb.Append("  objectId: ").Append(ObjectId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IpsRuleChangeDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IpsRuleChangeDto input)
        {
            if (input == null) return false;
            if (this.IpsIds != input.IpsIds || (this.IpsIds != null && input.IpsIds != null && !this.IpsIds.SequenceEqual(input.IpsIds))) return false;
            if (this.ObjectId != input.ObjectId || (this.ObjectId != null && !this.ObjectId.Equals(input.ObjectId))) return false;
            if (this.Status != input.Status) return false;

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
                if (this.IpsIds != null) hashCode = hashCode * 59 + this.IpsIds.GetHashCode();
                if (this.ObjectId != null) hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
