using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 单个ACL账号响应体
    /// </summary>
    public class AclAccountResp 
    {
        /// <summary>
        /// 账号类型
        /// </summary>
        /// <value>账号类型</value>
        [JsonConverter(typeof(EnumClassConverter<AccountTypeEnum>))]
        public class AccountTypeEnum
        {
            /// <summary>
            /// Enum NORMAL for value: normal
            /// </summary>
            public static readonly AccountTypeEnum NORMAL = new AccountTypeEnum("normal");

            /// <summary>
            /// Enum DEFAULT for value: default
            /// </summary>
            public static readonly AccountTypeEnum DEFAULT = new AccountTypeEnum("default");

            private static readonly Dictionary<string, AccountTypeEnum> StaticFields =
            new Dictionary<string, AccountTypeEnum>()
            {
                { "normal", NORMAL },
                { "default", DEFAULT },
            };

            private string _value;

            public AccountTypeEnum()
            {

            }

            public AccountTypeEnum(string value)
            {
                _value = value;
            }

            public static AccountTypeEnum FromValue(string value)
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

                if (this.Equals(obj as AccountTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AccountTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AccountTypeEnum a, AccountTypeEnum b)
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

            public static bool operator !=(AccountTypeEnum a, AccountTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// ACL账号状态 取值范围： - CREATING：账号创建中。 - AVAILABLE：账号可用。 - CREATEFAILED：账号创建失败。 - DELETED：账号已删除。 - DELETEFAILED：账号删除失败。 - DELETING：账号删除中。 - UPDATING：账号更新中。 - ERROR：账号异常。 
        /// </summary>
        /// <value>ACL账号状态 取值范围： - CREATING：账号创建中。 - AVAILABLE：账号可用。 - CREATEFAILED：账号创建失败。 - DELETED：账号已删除。 - DELETEFAILED：账号删除失败。 - DELETING：账号删除中。 - UPDATING：账号更新中。 - ERROR：账号异常。 </value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum CREATING for value: CREATING
            /// </summary>
            public static readonly StatusEnum CREATING = new StatusEnum("CREATING");

            /// <summary>
            /// Enum AVAILABLE for value: AVAILABLE
            /// </summary>
            public static readonly StatusEnum AVAILABLE = new StatusEnum("AVAILABLE");

            /// <summary>
            /// Enum CREATEFAILED for value: CREATEFAILED
            /// </summary>
            public static readonly StatusEnum CREATEFAILED = new StatusEnum("CREATEFAILED");

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            public static readonly StatusEnum DELETED = new StatusEnum("DELETED");

            /// <summary>
            /// Enum DELETEFAILED for value: DELETEFAILED
            /// </summary>
            public static readonly StatusEnum DELETEFAILED = new StatusEnum("DELETEFAILED");

            /// <summary>
            /// Enum DELETING for value: DELETING
            /// </summary>
            public static readonly StatusEnum DELETING = new StatusEnum("DELETING");

            /// <summary>
            /// Enum UPDATING for value: UPDATING
            /// </summary>
            public static readonly StatusEnum UPDATING = new StatusEnum("UPDATING");

            /// <summary>
            /// Enum ERROR for value: ERROR
            /// </summary>
            public static readonly StatusEnum ERROR = new StatusEnum("ERROR");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "CREATING", CREATING },
                { "AVAILABLE", AVAILABLE },
                { "CREATEFAILED", CREATEFAILED },
                { "DELETED", DELETED },
                { "DELETEFAILED", DELETEFAILED },
                { "DELETING", DELETING },
                { "UPDATING", UPDATING },
                { "ERROR", ERROR },
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
        /// 账号权限
        /// </summary>
        /// <value>账号权限</value>
        [JsonConverter(typeof(EnumClassConverter<AccountRoleEnum>))]
        public class AccountRoleEnum
        {
            /// <summary>
            /// Enum READ for value: read
            /// </summary>
            public static readonly AccountRoleEnum READ = new AccountRoleEnum("read");

            /// <summary>
            /// Enum WRITE for value: write
            /// </summary>
            public static readonly AccountRoleEnum WRITE = new AccountRoleEnum("write");

            private static readonly Dictionary<string, AccountRoleEnum> StaticFields =
            new Dictionary<string, AccountRoleEnum>()
            {
                { "read", READ },
                { "write", WRITE },
            };

            private string _value;

            public AccountRoleEnum()
            {

            }

            public AccountRoleEnum(string value)
            {
                _value = value;
            }

            public static AccountRoleEnum FromValue(string value)
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

                if (this.Equals(obj as AccountRoleEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(AccountRoleEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(AccountRoleEnum a, AccountRoleEnum b)
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

            public static bool operator !=(AccountRoleEnum a, AccountRoleEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 账号ID
        /// </summary>
        [JsonProperty("account_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountId { get; set; }

        /// <summary>
        /// 账号名
        /// </summary>
        [JsonProperty("account_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AccountName { get; set; }

        /// <summary>
        /// 账号类型
        /// </summary>
        [JsonProperty("account_type", NullValueHandling = NullValueHandling.Ignore)]
        public AccountTypeEnum AccountType { get; set; }
        /// <summary>
        /// 账号所属实例ID
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// ACL账号状态 取值范围： - CREATING：账号创建中。 - AVAILABLE：账号可用。 - CREATEFAILED：账号创建失败。 - DELETED：账号已删除。 - DELETEFAILED：账号删除失败。 - DELETING：账号删除中。 - UPDATING：账号更新中。 - ERROR：账号异常。 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 账号权限
        /// </summary>
        [JsonProperty("account_role", NullValueHandling = NullValueHandling.Ignore)]
        public AccountRoleEnum AccountRole { get; set; }
        /// <summary>
        /// 账号描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 错误码（暂未使用，赋值为null）
        /// </summary>
        [JsonProperty("error_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AclAccountResp {\n");
            sb.Append("  accountId: ").Append(AccountId).Append("\n");
            sb.Append("  accountName: ").Append(AccountName).Append("\n");
            sb.Append("  accountType: ").Append(AccountType).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  accountRole: ").Append(AccountRole).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  errorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AclAccountResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AclAccountResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.AccountType == input.AccountType ||
                    (this.AccountType != null &&
                    this.AccountType.Equals(input.AccountType))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.AccountRole == input.AccountRole ||
                    (this.AccountRole != null &&
                    this.AccountRole.Equals(input.AccountRole))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
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
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.AccountType != null)
                    hashCode = hashCode * 59 + this.AccountType.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.AccountRole != null)
                    hashCode = hashCode * 59 + this.AccountRole.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ErrorCode != null)
                    hashCode = hashCode * 59 + this.ErrorCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
