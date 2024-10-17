using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.RocketMQ.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class User 
    {
        /// <summary>
        /// 默认的主题权限。
        /// </summary>
        /// <value>默认的主题权限。</value>
        [JsonConverter(typeof(EnumClassConverter<DefaultTopicPermEnum>))]
        public class DefaultTopicPermEnum
        {
            /// <summary>
            /// Enum PUB for value: PUB
            /// </summary>
            public static readonly DefaultTopicPermEnum PUB = new DefaultTopicPermEnum("PUB");

            /// <summary>
            /// Enum SUB for value: SUB
            /// </summary>
            public static readonly DefaultTopicPermEnum SUB = new DefaultTopicPermEnum("SUB");

            /// <summary>
            /// Enum PUB_SUB for value: PUB|SUB
            /// </summary>
            public static readonly DefaultTopicPermEnum PUB_SUB = new DefaultTopicPermEnum("PUB|SUB");

            /// <summary>
            /// Enum DENY for value: DENY
            /// </summary>
            public static readonly DefaultTopicPermEnum DENY = new DefaultTopicPermEnum("DENY");

            private static readonly Dictionary<string, DefaultTopicPermEnum> StaticFields =
            new Dictionary<string, DefaultTopicPermEnum>()
            {
                { "PUB", PUB },
                { "SUB", SUB },
                { "PUB|SUB", PUB_SUB },
                { "DENY", DENY },
            };

            private string _value;

            public DefaultTopicPermEnum()
            {

            }

            public DefaultTopicPermEnum(string value)
            {
                _value = value;
            }

            public static DefaultTopicPermEnum FromValue(string value)
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

                if (this.Equals(obj as DefaultTopicPermEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DefaultTopicPermEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DefaultTopicPermEnum a, DefaultTopicPermEnum b)
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

            public static bool operator !=(DefaultTopicPermEnum a, DefaultTopicPermEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 默认的消费组权限。
        /// </summary>
        /// <value>默认的消费组权限。</value>
        [JsonConverter(typeof(EnumClassConverter<DefaultGroupPermEnum>))]
        public class DefaultGroupPermEnum
        {
            /// <summary>
            /// Enum SUB for value: SUB
            /// </summary>
            public static readonly DefaultGroupPermEnum SUB = new DefaultGroupPermEnum("SUB");

            /// <summary>
            /// Enum DENY for value: DENY
            /// </summary>
            public static readonly DefaultGroupPermEnum DENY = new DefaultGroupPermEnum("DENY");

            private static readonly Dictionary<string, DefaultGroupPermEnum> StaticFields =
            new Dictionary<string, DefaultGroupPermEnum>()
            {
                { "SUB", SUB },
                { "DENY", DENY },
            };

            private string _value;

            public DefaultGroupPermEnum()
            {

            }

            public DefaultGroupPermEnum(string value)
            {
                _value = value;
            }

            public static DefaultGroupPermEnum FromValue(string value)
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

                if (this.Equals(obj as DefaultGroupPermEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DefaultGroupPermEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DefaultGroupPermEnum a, DefaultGroupPermEnum b)
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

            public static bool operator !=(DefaultGroupPermEnum a, DefaultGroupPermEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 用户名，只能英文字母开头，且由英文字母、数字、中划线、下划线组成，长度为7~64个字符。
        /// </summary>
        [JsonProperty("access_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessKey { get; set; }

        /// <summary>
        /// 密钥。 8-32个字符。 至少包含以下字符中的3种：   - 大写字母   - 小写字母   - 数字   - 特殊字符&#x60;~!@#$%^&amp;*()-_&#x3D;+\\\\|[{}];:\\&#39;\\\&quot;,&lt;.&gt;/?密钥。 不能与名称或倒序的名称相同。
        /// </summary>
        [JsonProperty("secret_key", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretKey { get; set; }

        /// <summary>
        /// IP白名单。
        /// </summary>
        [JsonProperty("white_remote_address", NullValueHandling = NullValueHandling.Ignore)]
        public string WhiteRemoteAddress { get; set; }

        /// <summary>
        /// 是否为管理员。
        /// </summary>
        [JsonProperty("admin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Admin { get; set; }

        /// <summary>
        /// 默认的主题权限。
        /// </summary>
        [JsonProperty("default_topic_perm", NullValueHandling = NullValueHandling.Ignore)]
        public DefaultTopicPermEnum DefaultTopicPerm { get; set; }
        /// <summary>
        /// 默认的消费组权限。
        /// </summary>
        [JsonProperty("default_group_perm", NullValueHandling = NullValueHandling.Ignore)]
        public DefaultGroupPermEnum DefaultGroupPerm { get; set; }
        /// <summary>
        /// 特殊的主题权限。
        /// </summary>
        [JsonProperty("topic_perms", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserTopicPerms> TopicPerms { get; set; }

        /// <summary>
        /// 特殊的消费组权限。
        /// </summary>
        [JsonProperty("group_perms", NullValueHandling = NullValueHandling.Ignore)]
        public List<UserGroupPerms> GroupPerms { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  accessKey: ").Append(AccessKey).Append("\n");
            sb.Append("  secretKey: ").Append(SecretKey).Append("\n");
            sb.Append("  whiteRemoteAddress: ").Append(WhiteRemoteAddress).Append("\n");
            sb.Append("  admin: ").Append(Admin).Append("\n");
            sb.Append("  defaultTopicPerm: ").Append(DefaultTopicPerm).Append("\n");
            sb.Append("  defaultGroupPerm: ").Append(DefaultGroupPerm).Append("\n");
            sb.Append("  topicPerms: ").Append(TopicPerms).Append("\n");
            sb.Append("  groupPerms: ").Append(GroupPerms).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as User);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(User input)
        {
            if (input == null) return false;
            if (this.AccessKey != input.AccessKey || (this.AccessKey != null && !this.AccessKey.Equals(input.AccessKey))) return false;
            if (this.SecretKey != input.SecretKey || (this.SecretKey != null && !this.SecretKey.Equals(input.SecretKey))) return false;
            if (this.WhiteRemoteAddress != input.WhiteRemoteAddress || (this.WhiteRemoteAddress != null && !this.WhiteRemoteAddress.Equals(input.WhiteRemoteAddress))) return false;
            if (this.Admin != input.Admin || (this.Admin != null && !this.Admin.Equals(input.Admin))) return false;
            if (this.DefaultTopicPerm != input.DefaultTopicPerm) return false;
            if (this.DefaultGroupPerm != input.DefaultGroupPerm) return false;
            if (this.TopicPerms != input.TopicPerms || (this.TopicPerms != null && input.TopicPerms != null && !this.TopicPerms.SequenceEqual(input.TopicPerms))) return false;
            if (this.GroupPerms != input.GroupPerms || (this.GroupPerms != null && input.GroupPerms != null && !this.GroupPerms.SequenceEqual(input.GroupPerms))) return false;

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
                if (this.AccessKey != null) hashCode = hashCode * 59 + this.AccessKey.GetHashCode();
                if (this.SecretKey != null) hashCode = hashCode * 59 + this.SecretKey.GetHashCode();
                if (this.WhiteRemoteAddress != null) hashCode = hashCode * 59 + this.WhiteRemoteAddress.GetHashCode();
                if (this.Admin != null) hashCode = hashCode * 59 + this.Admin.GetHashCode();
                hashCode = hashCode * 59 + this.DefaultTopicPerm.GetHashCode();
                hashCode = hashCode * 59 + this.DefaultGroupPerm.GetHashCode();
                if (this.TopicPerms != null) hashCode = hashCode * 59 + this.TopicPerms.GetHashCode();
                if (this.GroupPerms != null) hashCode = hashCode * 59 + this.GroupPerms.GetHashCode();
                return hashCode;
            }
        }
    }
}
