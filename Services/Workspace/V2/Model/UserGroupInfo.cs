using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UserGroupInfo 
    {
        /// <summary>
        /// 用户组类型。 * AD： AD域用户组 * LOCAL： 本地liteAs用户组
        /// </summary>
        /// <value>用户组类型。 * AD： AD域用户组 * LOCAL： 本地liteAs用户组</value>
        [JsonConverter(typeof(EnumClassConverter<PlatformTypeEnum>))]
        public class PlatformTypeEnum
        {
            /// <summary>
            /// Enum AD for value: AD
            /// </summary>
            public static readonly PlatformTypeEnum AD = new PlatformTypeEnum("AD");

            /// <summary>
            /// Enum LOCAL for value: LOCAL
            /// </summary>
            public static readonly PlatformTypeEnum LOCAL = new PlatformTypeEnum("LOCAL");

            private static readonly Dictionary<string, PlatformTypeEnum> StaticFields =
            new Dictionary<string, PlatformTypeEnum>()
            {
                { "AD", AD },
                { "LOCAL", LOCAL },
            };

            private string _value;

            public PlatformTypeEnum()
            {

            }

            public PlatformTypeEnum(string value)
            {
                _value = value;
            }

            public static PlatformTypeEnum FromValue(string value)
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

                if (this.Equals(obj as PlatformTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PlatformTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PlatformTypeEnum a, PlatformTypeEnum b)
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

            public static bool operator !=(PlatformTypeEnum a, PlatformTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 用户组名。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 用户组ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 用户组对应的创建时间，UTC时间：yyyy-MM-ddTHH:mm:ss.SSSZ。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 用户组描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 用户列表中用户数。
        /// </summary>
        [JsonProperty("user_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? UserQuantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("parent", NullValueHandling = NullValueHandling.Ignore)]
        public UserGroupInfo Parent { get; set; }

        /// <summary>
        /// 用户组域Id。
        /// </summary>
        [JsonProperty("realm_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RealmId { get; set; }

        /// <summary>
        /// 用户组类型。 * AD： AD域用户组 * LOCAL： 本地liteAs用户组
        /// </summary>
        [JsonProperty("platform_type", NullValueHandling = NullValueHandling.Ignore)]
        public PlatformTypeEnum PlatformType { get; set; }
        /// <summary>
        /// 用户组专有名。
        /// </summary>
        [JsonProperty("group_dn", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupDn { get; set; }

        /// <summary>
        /// 用户组域名。
        /// </summary>
        [JsonProperty("domain", NullValueHandling = NullValueHandling.Ignore)]
        public string Domain { get; set; }

        /// <summary>
        /// 用户组sid。
        /// </summary>
        [JsonProperty("sid", NullValueHandling = NullValueHandling.Ignore)]
        public string Sid { get; set; }

        /// <summary>
        /// 用户列表中用户数。
        /// </summary>
        [JsonProperty("total_desktops", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalDesktops { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserGroupInfo {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  userQuantity: ").Append(UserQuantity).Append("\n");
            sb.Append("  parent: ").Append(Parent).Append("\n");
            sb.Append("  realmId: ").Append(RealmId).Append("\n");
            sb.Append("  platformType: ").Append(PlatformType).Append("\n");
            sb.Append("  groupDn: ").Append(GroupDn).Append("\n");
            sb.Append("  domain: ").Append(Domain).Append("\n");
            sb.Append("  sid: ").Append(Sid).Append("\n");
            sb.Append("  totalDesktops: ").Append(TotalDesktops).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserGroupInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UserGroupInfo input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.UserQuantity != input.UserQuantity || (this.UserQuantity != null && !this.UserQuantity.Equals(input.UserQuantity))) return false;
            if (this.Parent != input.Parent || (this.Parent != null && !this.Parent.Equals(input.Parent))) return false;
            if (this.RealmId != input.RealmId || (this.RealmId != null && !this.RealmId.Equals(input.RealmId))) return false;
            if (this.PlatformType != input.PlatformType) return false;
            if (this.GroupDn != input.GroupDn || (this.GroupDn != null && !this.GroupDn.Equals(input.GroupDn))) return false;
            if (this.Domain != input.Domain || (this.Domain != null && !this.Domain.Equals(input.Domain))) return false;
            if (this.Sid != input.Sid || (this.Sid != null && !this.Sid.Equals(input.Sid))) return false;
            if (this.TotalDesktops != input.TotalDesktops || (this.TotalDesktops != null && !this.TotalDesktops.Equals(input.TotalDesktops))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.UserQuantity != null) hashCode = hashCode * 59 + this.UserQuantity.GetHashCode();
                if (this.Parent != null) hashCode = hashCode * 59 + this.Parent.GetHashCode();
                if (this.RealmId != null) hashCode = hashCode * 59 + this.RealmId.GetHashCode();
                hashCode = hashCode * 59 + this.PlatformType.GetHashCode();
                if (this.GroupDn != null) hashCode = hashCode * 59 + this.GroupDn.GetHashCode();
                if (this.Domain != null) hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.Sid != null) hashCode = hashCode * 59 + this.Sid.GetHashCode();
                if (this.TotalDesktops != null) hashCode = hashCode * 59 + this.TotalDesktops.GetHashCode();
                return hashCode;
            }
        }
    }
}
