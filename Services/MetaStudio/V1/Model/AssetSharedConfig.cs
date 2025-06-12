using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 共享配置
    /// </summary>
    public class AssetSharedConfig 
    {
        /// <summary>
        /// 共享类型。 * PRIVATE: 私有，仅本租户可访问。 * PUBLIC: 公开，所有租户可访问。当前仅提供系统资产可公开访问。 * SHARED：共享，指定租户可访问。拥有者指定租户可访问。
        /// </summary>
        /// <value>共享类型。 * PRIVATE: 私有，仅本租户可访问。 * PUBLIC: 公开，所有租户可访问。当前仅提供系统资产可公开访问。 * SHARED：共享，指定租户可访问。拥有者指定租户可访问。</value>
        [JsonConverter(typeof(EnumClassConverter<SharedTypeEnum>))]
        public class SharedTypeEnum
        {
            /// <summary>
            /// Enum PRIVATE for value: PRIVATE
            /// </summary>
            public static readonly SharedTypeEnum PRIVATE = new SharedTypeEnum("PRIVATE");

            /// <summary>
            /// Enum PUBLIC for value: PUBLIC
            /// </summary>
            public static readonly SharedTypeEnum PUBLIC = new SharedTypeEnum("PUBLIC");

            /// <summary>
            /// Enum SHARED for value: SHARED
            /// </summary>
            public static readonly SharedTypeEnum SHARED = new SharedTypeEnum("SHARED");

            private static readonly Dictionary<string, SharedTypeEnum> StaticFields =
            new Dictionary<string, SharedTypeEnum>()
            {
                { "PRIVATE", PRIVATE },
                { "PUBLIC", PUBLIC },
                { "SHARED", SHARED },
            };

            private string _value;

            public SharedTypeEnum()
            {

            }

            public SharedTypeEnum(string value)
            {
                _value = value;
            }

            public static SharedTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SharedTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SharedTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SharedTypeEnum a, SharedTypeEnum b)
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

            public static bool operator !=(SharedTypeEnum a, SharedTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 共享类型。 * PRIVATE: 私有，仅本租户可访问。 * PUBLIC: 公开，所有租户可访问。当前仅提供系统资产可公开访问。 * SHARED：共享，指定租户可访问。拥有者指定租户可访问。
        /// </summary>
        [JsonProperty("shared_type", NullValueHandling = NullValueHandling.Ignore)]
        public SharedTypeEnum SharedType { get; set; }
        /// <summary>
        /// 共享过期时间。默认过期时间为30天，即共享当天+30的23:59:59。
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// 允许访问本资产的租户列表。
        /// </summary>
        [JsonProperty("allowed_project_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AllowedProjectIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssetSharedConfig {\n");
            sb.Append("  sharedType: ").Append(SharedType).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("  allowedProjectIds: ").Append(AllowedProjectIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssetSharedConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssetSharedConfig input)
        {
            if (input == null) return false;
            if (this.SharedType != input.SharedType) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;
            if (this.AllowedProjectIds != input.AllowedProjectIds || (this.AllowedProjectIds != null && input.AllowedProjectIds != null && !this.AllowedProjectIds.SequenceEqual(input.AllowedProjectIds))) return false;

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
                hashCode = hashCode * 59 + this.SharedType.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                if (this.AllowedProjectIds != null) hashCode = hashCode * 59 + this.AllowedProjectIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
