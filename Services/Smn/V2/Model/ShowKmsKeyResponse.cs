using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Smn.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowKmsKeyResponse : SdkResponse
    {
        /// <summary>
        /// 密钥的状态字段，为枚举类型。 - ENABLED状态为密钥启用状态，此时发布的消息均使用该主密钥创建的数据密钥进行加解密。 - TO_BE_ACTIVATED状态为密钥待激活状态，当密钥未激活时，发布主题消息会返回失败，请前往DEW服务对密钥进行操作。 - DISABLED状态为密钥禁用状态，当密钥已被禁用时，发布主题消息会返回失败，请前往DEW服务对密钥进行操作。 - PENDING_DELETION状态为密钥计划删除状态，当密钥已被计划删除时，发布主题消息仍能正常使用该密钥。 - PENDING_IMPORT状态为密钥计划导入状态，当密钥计划导入时，发布主题消息会返回失败，请前往DEW服务对密钥进行操作。 - DELETED状态为密钥已删除状态，当密钥已删除后，SMN无法从DEW服务处获取有效的密钥，此时发布主题消息会返回失败，请重新在主题下配置可用的密钥。
        /// </summary>
        /// <value>密钥的状态字段，为枚举类型。 - ENABLED状态为密钥启用状态，此时发布的消息均使用该主密钥创建的数据密钥进行加解密。 - TO_BE_ACTIVATED状态为密钥待激活状态，当密钥未激活时，发布主题消息会返回失败，请前往DEW服务对密钥进行操作。 - DISABLED状态为密钥禁用状态，当密钥已被禁用时，发布主题消息会返回失败，请前往DEW服务对密钥进行操作。 - PENDING_DELETION状态为密钥计划删除状态，当密钥已被计划删除时，发布主题消息仍能正常使用该密钥。 - PENDING_IMPORT状态为密钥计划导入状态，当密钥计划导入时，发布主题消息会返回失败，请前往DEW服务对密钥进行操作。 - DELETED状态为密钥已删除状态，当密钥已删除后，SMN无法从DEW服务处获取有效的密钥，此时发布主题消息会返回失败，请重新在主题下配置可用的密钥。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum ENABLED for value: ENABLED
            /// </summary>
            public static readonly StatusEnum ENABLED = new StatusEnum("ENABLED");

            /// <summary>
            /// Enum TO_BE_ACTIVATED for value: TO_BE_ACTIVATED
            /// </summary>
            public static readonly StatusEnum TO_BE_ACTIVATED = new StatusEnum("TO_BE_ACTIVATED");

            /// <summary>
            /// Enum DISABLED for value: DISABLED
            /// </summary>
            public static readonly StatusEnum DISABLED = new StatusEnum("DISABLED");

            /// <summary>
            /// Enum PENDING_DELETION for value: PENDING_DELETION
            /// </summary>
            public static readonly StatusEnum PENDING_DELETION = new StatusEnum("PENDING_DELETION");

            /// <summary>
            /// Enum PENDING_IMPORT for value: PENDING_IMPORT
            /// </summary>
            public static readonly StatusEnum PENDING_IMPORT = new StatusEnum("PENDING_IMPORT");

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            public static readonly StatusEnum DELETED = new StatusEnum("DELETED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "ENABLED", ENABLED },
                { "TO_BE_ACTIVATED", TO_BE_ACTIVATED },
                { "DISABLED", DISABLED },
                { "PENDING_DELETION", PENDING_DELETION },
                { "PENDING_IMPORT", PENDING_IMPORT },
                { "DELETED", DELETED },
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
        /// 在DEW服务上创建的用户主密钥对应的密钥ID，具体参考在DEW服务上创建密钥章节。
        /// </summary>
        [JsonProperty("key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string KeyId { get; set; }

        /// <summary>
        /// 密钥的状态字段，为枚举类型。 - ENABLED状态为密钥启用状态，此时发布的消息均使用该主密钥创建的数据密钥进行加解密。 - TO_BE_ACTIVATED状态为密钥待激活状态，当密钥未激活时，发布主题消息会返回失败，请前往DEW服务对密钥进行操作。 - DISABLED状态为密钥禁用状态，当密钥已被禁用时，发布主题消息会返回失败，请前往DEW服务对密钥进行操作。 - PENDING_DELETION状态为密钥计划删除状态，当密钥已被计划删除时，发布主题消息仍能正常使用该密钥。 - PENDING_IMPORT状态为密钥计划导入状态，当密钥计划导入时，发布主题消息会返回失败，请前往DEW服务对密钥进行操作。 - DELETED状态为密钥已删除状态，当密钥已删除后，SMN无法从DEW服务处获取有效的密钥，此时发布主题消息会返回失败，请重新在主题下配置可用的密钥。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 密钥对应的资源ID，该ID由SMN服务生成。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 请求的唯一标识ID。
        /// </summary>
        [JsonProperty("request_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RequestId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowKmsKeyResponse {\n");
            sb.Append("  keyId: ").Append(KeyId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  requestId: ").Append(RequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowKmsKeyResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowKmsKeyResponse input)
        {
            if (input == null) return false;
            if (this.KeyId != input.KeyId || (this.KeyId != null && !this.KeyId.Equals(input.KeyId))) return false;
            if (this.Status != input.Status) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.RequestId != input.RequestId || (this.RequestId != null && !this.RequestId.Equals(input.RequestId))) return false;

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
                if (this.KeyId != null) hashCode = hashCode * 59 + this.KeyId.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RequestId != null) hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
