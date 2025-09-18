using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cts.V3.Model
{
    /// <summary>
    /// 用户信息。
    /// </summary>
    public class UserInfo 
    {
        /// <summary>
        /// 是否是根用户。 - 值为“true”时，表示操作者是根用户。 - 值为“false”时，表示操作者是委托会话身份、联邦身份或非根用户的 IAM 用户。
        /// </summary>
        /// <value>是否是根用户。 - 值为“true”时，表示操作者是根用户。 - 值为“false”时，表示操作者是委托会话身份、联邦身份或非根用户的 IAM 用户。</value>
        [JsonConverter(typeof(EnumClassConverter<PrincipalIsRootUserEnum>))]
        public class PrincipalIsRootUserEnum
        {
            /// <summary>
            /// Enum TRUE for value: true
            /// </summary>
            public static readonly PrincipalIsRootUserEnum TRUE = new PrincipalIsRootUserEnum("true");

            /// <summary>
            /// Enum FALSE for value: false
            /// </summary>
            public static readonly PrincipalIsRootUserEnum FALSE = new PrincipalIsRootUserEnum("false");

            private static readonly Dictionary<string, PrincipalIsRootUserEnum> StaticFields =
            new Dictionary<string, PrincipalIsRootUserEnum>()
            {
                { "true", TRUE },
                { "false", FALSE },
            };

            private string _value;

            public PrincipalIsRootUserEnum()
            {

            }

            public PrincipalIsRootUserEnum(string value)
            {
                _value = value;
            }

            public static PrincipalIsRootUserEnum FromValue(string value)
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

                if (this.Equals(obj as PrincipalIsRootUserEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PrincipalIsRootUserEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PrincipalIsRootUserEnum a, PrincipalIsRootUserEnum b)
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

            public static bool operator !=(PrincipalIsRootUserEnum a, PrincipalIsRootUserEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 用户ID，参见《云审计服务API参考》“获取账号ID和项目ID”章节。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 用户名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 用户名称。
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public BaseUser Domain { get; set; }

        /// <summary>
        /// 账号ID，参见《云审计服务API参考》“获取账号ID和项目ID”章节。
        /// </summary>
        [JsonProperty("account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// 访问密钥ID。
        /// </summary>
        [JsonProperty("access_key_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// 操作用户身份的 URN。 如果是 IAM 用户身份，格式如 iam::&lt;account-id&gt;:user:&lt;user-name&gt;。 如果是 IAM 委托会话 身份，格式如 sts::&lt;account-id&gt;:assumed-agency:&lt;agency-name&gt;/&lt;agency-session-name&gt;。 如果是 IAM 联邦身份，格式如 sts::&lt;account-id&gt;:external-user:&lt;idp_id&gt;/&lt;user-session-name&gt;。
        /// </summary>
        [JsonProperty("principal_urn", NullValueHandling = NullValueHandling.Ignore)]
        public string PrincipalUrn { get; set; }

        /// <summary>
        /// 操作用户身份Id。 - 如果是 IAM 用户身份，格式为 &lt;user-id&gt;。 - 如果是 IAM 委托会话身份，格式为 &lt;agency-id&gt;:&lt;agency-session-name&gt;。 - 如果是 IAM 联邦身份，格式为 &lt;idp_id&gt;:&lt;user-session-name&gt;
        /// </summary>
        [JsonProperty("principal_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 是否是根用户。 - 值为“true”时，表示操作者是根用户。 - 值为“false”时，表示操作者是委托会话身份、联邦身份或非根用户的 IAM 用户。
        /// </summary>
        [JsonProperty("principal_is_root_user", NullValueHandling = NullValueHandling.Ignore)]
        public PrincipalIsRootUserEnum PrincipalIsRootUser { get; set; }
        /// <summary>
        /// 操作者身份类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 发出请求的服务的名称。控制台操作时为[\&quot;service.console\&quot; ]
        /// </summary>
        [JsonProperty("invoked_by", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InvokedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("session_context", NullValueHandling = NullValueHandling.Ignore)]
        public SessionContext SessionContext { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserInfo {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  accountId: ").Append(AccountId).Append("\n");
            sb.Append("  accessKeyId: ").Append(AccessKeyId).Append("\n");
            sb.Append("  principalUrn: ").Append(PrincipalUrn).Append("\n");
            sb.Append("  principalId: ").Append(PrincipalId).Append("\n");
            sb.Append("  principalIsRootUser: ").Append(PrincipalIsRootUser).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  invokedBy: ").Append(InvokedBy).Append("\n");
            sb.Append("  sessionContext: ").Append(SessionContext).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserInfo input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.AccountId != input.AccountId || (this.AccountId != null && !this.AccountId.Equals(input.AccountId))) return false;
            if (this.AccessKeyId != input.AccessKeyId || (this.AccessKeyId != null && !this.AccessKeyId.Equals(input.AccessKeyId))) return false;
            if (this.PrincipalUrn != input.PrincipalUrn || (this.PrincipalUrn != null && !this.PrincipalUrn.Equals(input.PrincipalUrn))) return false;
            if (this.PrincipalId != input.PrincipalId || (this.PrincipalId != null && !this.PrincipalId.Equals(input.PrincipalId))) return false;
            if (this.PrincipalIsRootUser != input.PrincipalIsRootUser) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.InvokedBy != input.InvokedBy || (this.InvokedBy != null && input.InvokedBy != null && !this.InvokedBy.SequenceEqual(input.InvokedBy))) return false;
            if (this.SessionContext != input.SessionContext || (this.SessionContext != null && !this.SessionContext.Equals(input.SessionContext))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.AccountId != null) hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.AccessKeyId != null) hashCode = hashCode * 59 + this.AccessKeyId.GetHashCode();
                if (this.PrincipalUrn != null) hashCode = hashCode * 59 + this.PrincipalUrn.GetHashCode();
                if (this.PrincipalId != null) hashCode = hashCode * 59 + this.PrincipalId.GetHashCode();
                hashCode = hashCode * 59 + this.PrincipalIsRootUser.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.InvokedBy != null) hashCode = hashCode * 59 + this.InvokedBy.GetHashCode();
                if (this.SessionContext != null) hashCode = hashCode * 59 + this.SessionContext.GetHashCode();
                return hashCode;
            }
        }
    }
}
