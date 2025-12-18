using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V5.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListEntitiesForPolicyV5Request 
    {
        /// <summary>
        /// 实体类型，包含user、 group 和 agency三种类型。
        /// </summary>
        /// <value>实体类型，包含user、 group 和 agency三种类型。</value>
        [JsonConverter(typeof(EnumClassConverter<EntityTypeEnum>))]
        public class EntityTypeEnum
        {
            /// <summary>
            /// Enum USER for value: user
            /// </summary>
            public static readonly EntityTypeEnum USER = new EntityTypeEnum("user");

            /// <summary>
            /// Enum GROUP for value: group
            /// </summary>
            public static readonly EntityTypeEnum GROUP = new EntityTypeEnum("group");

            /// <summary>
            /// Enum AGENCY for value: agency
            /// </summary>
            public static readonly EntityTypeEnum AGENCY = new EntityTypeEnum("agency");

            private static readonly Dictionary<string, EntityTypeEnum> StaticFields =
            new Dictionary<string, EntityTypeEnum>()
            {
                { "user", USER },
                { "group", GROUP },
                { "agency", AGENCY },
            };

            private string _value;

            public EntityTypeEnum()
            {

            }

            public EntityTypeEnum(string value)
            {
                _value = value;
            }

            public static EntityTypeEnum FromValue(string value)
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

                if (this.Equals(obj as EntityTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(EntityTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(EntityTypeEnum a, EntityTypeEnum b)
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

            public static bool operator !=(EntityTypeEnum a, EntityTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 身份策略ID，长度为1到64个字符，只包含字母、数字和\&quot;-\&quot;的字符串。
        /// </summary>
        [SDKProperty("policy_id", IsPath = true)]
        [JsonProperty("policy_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PolicyId { get; set; }

        /// <summary>
        /// 实体类型，包含user、 group 和 agency三种类型。
        /// </summary>
        [SDKProperty("entity_type", IsQuery = true)]
        [JsonProperty("entity_type", NullValueHandling = NullValueHandling.Ignore)]
        public EntityTypeEnum EntityType { get; set; }
        /// <summary>
        /// 每页显示的条目数量，范围为1到200条，默认为100条。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页标记，长度为4到400个字符，只包含字母、数字、\&quot;+\&quot;、\&quot;/\&quot;、\&quot;&#x3D;\&quot;、\&quot;-\&quot;和\&quot;_\&quot;的字符串。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListEntitiesForPolicyV5Request {\n");
            sb.Append("  policyId: ").Append(PolicyId).Append("\n");
            sb.Append("  entityType: ").Append(EntityType).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListEntitiesForPolicyV5Request);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListEntitiesForPolicyV5Request input)
        {
            if (input == null) return false;
            if (this.PolicyId != input.PolicyId || (this.PolicyId != null && !this.PolicyId.Equals(input.PolicyId))) return false;
            if (this.EntityType != input.EntityType) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;

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
                if (this.PolicyId != null) hashCode = hashCode * 59 + this.PolicyId.GetHashCode();
                hashCode = hashCode * 59 + this.EntityType.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                return hashCode;
            }
        }
    }
}
