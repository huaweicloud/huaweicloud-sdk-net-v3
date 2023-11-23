using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aom.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AccessCodeModel 
    {
        /// <summary>
        /// 状态 enable:开启 unenable:关闭
        /// </summary>
        /// <value>状态 enable:开启 unenable:关闭</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ENABLE for value: enable
            /// </summary>
            public static readonly StatusEnum ENABLE = new StatusEnum("enable");

            /// <summary>
            /// Enum UNENABLE for value: unenable
            /// </summary>
            public static readonly StatusEnum UNENABLE = new StatusEnum("unenable");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "enable", ENABLE },
                { "unenable", UNENABLE },
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// access_code
        /// </summary>
        [JsonProperty("access_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessCode { get; set; }

        /// <summary>
        /// access_code_id
        /// </summary>
        [JsonProperty("access_code_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessCodeId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("create_at", NullValueHandling = NullValueHandling.Ignore)]
        public long? CreateAt { get; set; }

        /// <summary>
        /// 状态 enable:开启 unenable:关闭
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessCodeModel {\n");
            sb.Append("  accessCode: ").Append(AccessCode).Append("\n");
            sb.Append("  accessCodeId: ").Append(AccessCodeId).Append("\n");
            sb.Append("  createAt: ").Append(CreateAt).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessCodeModel);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccessCodeModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccessCode == input.AccessCode ||
                    (this.AccessCode != null &&
                    this.AccessCode.Equals(input.AccessCode))
                ) && 
                (
                    this.AccessCodeId == input.AccessCodeId ||
                    (this.AccessCodeId != null &&
                    this.AccessCodeId.Equals(input.AccessCodeId))
                ) && 
                (
                    this.CreateAt == input.CreateAt ||
                    (this.CreateAt != null &&
                    this.CreateAt.Equals(input.CreateAt))
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
                if (this.AccessCode != null)
                    hashCode = hashCode * 59 + this.AccessCode.GetHashCode();
                if (this.AccessCodeId != null)
                    hashCode = hashCode * 59 + this.AccessCodeId.GetHashCode();
                if (this.CreateAt != null)
                    hashCode = hashCode * 59 + this.CreateAt.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
