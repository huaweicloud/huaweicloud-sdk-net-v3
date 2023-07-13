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
        /// 用户名。
        /// </summary>
        [JsonProperty("access_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessKey { get; set; }

        /// <summary>
        /// 密钥。
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
            if (input == null)
                return false;

            return 
                (
                    this.AccessKey == input.AccessKey ||
                    (this.AccessKey != null &&
                    this.AccessKey.Equals(input.AccessKey))
                ) && 
                (
                    this.SecretKey == input.SecretKey ||
                    (this.SecretKey != null &&
                    this.SecretKey.Equals(input.SecretKey))
                ) && 
                (
                    this.WhiteRemoteAddress == input.WhiteRemoteAddress ||
                    (this.WhiteRemoteAddress != null &&
                    this.WhiteRemoteAddress.Equals(input.WhiteRemoteAddress))
                ) && 
                (
                    this.Admin == input.Admin ||
                    (this.Admin != null &&
                    this.Admin.Equals(input.Admin))
                ) && 
                (
                    this.DefaultTopicPerm == input.DefaultTopicPerm ||
                    (this.DefaultTopicPerm != null &&
                    this.DefaultTopicPerm.Equals(input.DefaultTopicPerm))
                ) && 
                (
                    this.DefaultGroupPerm == input.DefaultGroupPerm ||
                    (this.DefaultGroupPerm != null &&
                    this.DefaultGroupPerm.Equals(input.DefaultGroupPerm))
                ) && 
                (
                    this.TopicPerms == input.TopicPerms ||
                    this.TopicPerms != null &&
                    input.TopicPerms != null &&
                    this.TopicPerms.SequenceEqual(input.TopicPerms)
                ) && 
                (
                    this.GroupPerms == input.GroupPerms ||
                    this.GroupPerms != null &&
                    input.GroupPerms != null &&
                    this.GroupPerms.SequenceEqual(input.GroupPerms)
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
                if (this.AccessKey != null)
                    hashCode = hashCode * 59 + this.AccessKey.GetHashCode();
                if (this.SecretKey != null)
                    hashCode = hashCode * 59 + this.SecretKey.GetHashCode();
                if (this.WhiteRemoteAddress != null)
                    hashCode = hashCode * 59 + this.WhiteRemoteAddress.GetHashCode();
                if (this.Admin != null)
                    hashCode = hashCode * 59 + this.Admin.GetHashCode();
                if (this.DefaultTopicPerm != null)
                    hashCode = hashCode * 59 + this.DefaultTopicPerm.GetHashCode();
                if (this.DefaultGroupPerm != null)
                    hashCode = hashCode * 59 + this.DefaultGroupPerm.GetHashCode();
                if (this.TopicPerms != null)
                    hashCode = hashCode * 59 + this.TopicPerms.GetHashCode();
                if (this.GroupPerms != null)
                    hashCode = hashCode * 59 + this.GroupPerms.GetHashCode();
                return hashCode;
            }
        }
    }
}
