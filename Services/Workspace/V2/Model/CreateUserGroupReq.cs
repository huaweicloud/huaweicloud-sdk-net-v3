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
    public class CreateUserGroupReq 
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

            public static bool operator !=(PlatformTypeEnum a, PlatformTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 用户组名称。
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// 用户组类型。 * AD： AD域用户组 * LOCAL： 本地liteAs用户组
        /// </summary>
        [JsonProperty("platform_type", NullValueHandling = NullValueHandling.Ignore)]
        public PlatformTypeEnum PlatformType { get; set; }
        /// <summary>
        /// 用户组描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateUserGroupReq {\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  platformType: ").Append(PlatformType).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateUserGroupReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreateUserGroupReq input)
        {
            if (input == null) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.PlatformType != input.PlatformType) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;

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
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                hashCode = hashCode * 59 + this.PlatformType.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
