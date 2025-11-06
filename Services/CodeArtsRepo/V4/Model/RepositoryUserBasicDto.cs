using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsRepo.V4.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RepositoryUserBasicDto 
    {
        /// <summary>
        /// **参数解释：** 用户状态。 **取值范围：** - active，激活。 - blocked，禁用。
        /// </summary>
        /// <value>**参数解释：** 用户状态。 **取值范围：** - active，激活。 - blocked，禁用。</value>
        [JsonConverter(typeof(EnumClassConverter<StateEnum>))]
        public class StateEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: active
            /// </summary>
            public static readonly StateEnum ACTIVE = new StateEnum("active");

            /// <summary>
            /// Enum BLOCKED for value: blocked
            /// </summary>
            public static readonly StateEnum BLOCKED = new StateEnum("blocked");

            private static readonly Dictionary<string, StateEnum> StaticFields =
            new Dictionary<string, StateEnum>()
            {
                { "active", ACTIVE },
                { "blocked", BLOCKED },
            };

            private string _value;

            public StateEnum()
            {

            }

            public StateEnum(string value)
            {
                _value = value;
            }

            public static StateEnum FromValue(string value)
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

                if (this.Equals(obj as StateEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StateEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StateEnum a, StateEnum b)
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

            public static bool operator !=(StateEnum a, StateEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：**  用户id **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }

        /// <summary>
        /// **参数解释：**  用户名称 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：**  用户名 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        /// <summary>
        /// **参数解释：** 用户状态。 **取值范围：** - active，激活。 - blocked，禁用。
        /// </summary>
        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public StateEnum State { get; set; }
        /// <summary>
        /// **参数解释：**  服务级权限状态 0：停用 1：启用 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("service_license_status", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceLicenseStatus { get; set; }

        /// <summary>
        /// **参数解释：**  用户中文名称 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("name_cn", NullValueHandling = NullValueHandling.Ignore)]
        public string NameCn { get; set; }

        /// <summary>
        /// **参数解释：**  用户昵称 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("nick_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NickName { get; set; }

        /// <summary>
        /// **参数解释：**  租户名称 **约束限制：** 不涉及。
        /// </summary>
        [JsonProperty("tenant_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TenantName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoryUserBasicDto {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  username: ").Append(Username).Append("\n");
            sb.Append("  state: ").Append(State).Append("\n");
            sb.Append("  serviceLicenseStatus: ").Append(ServiceLicenseStatus).Append("\n");
            sb.Append("  nameCn: ").Append(NameCn).Append("\n");
            sb.Append("  nickName: ").Append(NickName).Append("\n");
            sb.Append("  tenantName: ").Append(TenantName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RepositoryUserBasicDto);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RepositoryUserBasicDto input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Username != input.Username || (this.Username != null && !this.Username.Equals(input.Username))) return false;
            if (this.State != input.State) return false;
            if (this.ServiceLicenseStatus != input.ServiceLicenseStatus || (this.ServiceLicenseStatus != null && !this.ServiceLicenseStatus.Equals(input.ServiceLicenseStatus))) return false;
            if (this.NameCn != input.NameCn || (this.NameCn != null && !this.NameCn.Equals(input.NameCn))) return false;
            if (this.NickName != input.NickName || (this.NickName != null && !this.NickName.Equals(input.NickName))) return false;
            if (this.TenantName != input.TenantName || (this.TenantName != null && !this.TenantName.Equals(input.TenantName))) return false;

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
                if (this.Username != null) hashCode = hashCode * 59 + this.Username.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.ServiceLicenseStatus != null) hashCode = hashCode * 59 + this.ServiceLicenseStatus.GetHashCode();
                if (this.NameCn != null) hashCode = hashCode * 59 + this.NameCn.GetHashCode();
                if (this.NickName != null) hashCode = hashCode * 59 + this.NickName.GetHashCode();
                if (this.TenantName != null) hashCode = hashCode * 59 + this.TenantName.GetHashCode();
                return hashCode;
            }
        }
    }
}
