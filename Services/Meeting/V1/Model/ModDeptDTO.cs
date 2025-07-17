using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ModDeptDTO 
    {
        /// <summary>
        /// 其他用户对该部门下用户的访问权限： - UNLIMITED：默认，不做限制 - OPEN：公开，其他部门都可访问（无论对方权限如何配置） - CLOSE：隐藏，其他部门不可访问（暂未实现） - DESIGNATED_DEPARTMENT：指定部门能访问（暂未实现）
        /// </summary>
        /// <value>其他用户对该部门下用户的访问权限： - UNLIMITED：默认，不做限制 - OPEN：公开，其他部门都可访问（无论对方权限如何配置） - CLOSE：隐藏，其他部门不可访问（暂未实现） - DESIGNATED_DEPARTMENT：指定部门能访问（暂未实现）</value>
        [JsonConverter(typeof(EnumClassConverter<InPermissionEnum>))]
        public class InPermissionEnum
        {
            /// <summary>
            /// Enum UNLIMITED for value: UNLIMITED
            /// </summary>
            public static readonly InPermissionEnum UNLIMITED = new InPermissionEnum("UNLIMITED");

            /// <summary>
            /// Enum OPEN for value: OPEN
            /// </summary>
            public static readonly InPermissionEnum OPEN = new InPermissionEnum("OPEN");

            /// <summary>
            /// Enum CLOSE for value: CLOSE
            /// </summary>
            public static readonly InPermissionEnum CLOSE = new InPermissionEnum("CLOSE");

            /// <summary>
            /// Enum DESIGNATED_DEPARTMENT for value: DESIGNATED_DEPARTMENT
            /// </summary>
            public static readonly InPermissionEnum DESIGNATED_DEPARTMENT = new InPermissionEnum("DESIGNATED_DEPARTMENT");

            private static readonly Dictionary<string, InPermissionEnum> StaticFields =
            new Dictionary<string, InPermissionEnum>()
            {
                { "UNLIMITED", UNLIMITED },
                { "OPEN", OPEN },
                { "CLOSE", CLOSE },
                { "DESIGNATED_DEPARTMENT", DESIGNATED_DEPARTMENT },
            };

            private string _value;

            public InPermissionEnum()
            {

            }

            public InPermissionEnum(string value)
            {
                _value = value;
            }

            public static InPermissionEnum FromValue(string value)
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

                if (this.Equals(obj as InPermissionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InPermissionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InPermissionEnum a, InPermissionEnum b)
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

            public static bool operator !=(InPermissionEnum a, InPermissionEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 该部门下用户访问权限控制。 - UNLIMITED：不限制 - ONLY_SELF：仅能查询自己 - SELF_AND_CHILD_DEPARTMENT：该部门下用户能查询本部门及子部门通讯 - DESIGNATED_DEPARTMENT：该部门下用户能查询指定部门通讯录
        /// </summary>
        /// <value>该部门下用户访问权限控制。 - UNLIMITED：不限制 - ONLY_SELF：仅能查询自己 - SELF_AND_CHILD_DEPARTMENT：该部门下用户能查询本部门及子部门通讯 - DESIGNATED_DEPARTMENT：该部门下用户能查询指定部门通讯录</value>
        [JsonConverter(typeof(EnumClassConverter<OutPermissionEnum>))]
        public class OutPermissionEnum
        {
            /// <summary>
            /// Enum UNLIMITED for value: UNLIMITED
            /// </summary>
            public static readonly OutPermissionEnum UNLIMITED = new OutPermissionEnum("UNLIMITED");

            /// <summary>
            /// Enum ONLY_SELF for value: ONLY_SELF
            /// </summary>
            public static readonly OutPermissionEnum ONLY_SELF = new OutPermissionEnum("ONLY_SELF");

            /// <summary>
            /// Enum SELF_AND_CHILD_DEPARTMENT for value: SELF_AND_CHILD_DEPARTMENT
            /// </summary>
            public static readonly OutPermissionEnum SELF_AND_CHILD_DEPARTMENT = new OutPermissionEnum("SELF_AND_CHILD_DEPARTMENT");

            /// <summary>
            /// Enum DESIGNATED_DEPARTMENT for value: DESIGNATED_DEPARTMENT
            /// </summary>
            public static readonly OutPermissionEnum DESIGNATED_DEPARTMENT = new OutPermissionEnum("DESIGNATED_DEPARTMENT");

            private static readonly Dictionary<string, OutPermissionEnum> StaticFields =
            new Dictionary<string, OutPermissionEnum>()
            {
                { "UNLIMITED", UNLIMITED },
                { "ONLY_SELF", ONLY_SELF },
                { "SELF_AND_CHILD_DEPARTMENT", SELF_AND_CHILD_DEPARTMENT },
                { "DESIGNATED_DEPARTMENT", DESIGNATED_DEPARTMENT },
            };

            private string _value;

            public OutPermissionEnum()
            {

            }

            public OutPermissionEnum(string value)
            {
                _value = value;
            }

            public static OutPermissionEnum FromValue(string value)
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

                if (this.Equals(obj as OutPermissionEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(OutPermissionEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(OutPermissionEnum a, OutPermissionEnum b)
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

            public static bool operator !=(OutPermissionEnum a, OutPermissionEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 部门名称。
        /// </summary>
        [JsonProperty("deptName", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptName { get; set; }

        /// <summary>
        /// 父部门编码。
        /// </summary>
        [JsonProperty("parentDeptCode", NullValueHandling = NullValueHandling.Ignore)]
        public string ParentDeptCode { get; set; }

        /// <summary>
        /// 备注。
        /// </summary>
        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; set; }

        /// <summary>
        /// 其他用户对该部门下用户的访问权限： - UNLIMITED：默认，不做限制 - OPEN：公开，其他部门都可访问（无论对方权限如何配置） - CLOSE：隐藏，其他部门不可访问（暂未实现） - DESIGNATED_DEPARTMENT：指定部门能访问（暂未实现）
        /// </summary>
        [JsonProperty("inPermission", NullValueHandling = NullValueHandling.Ignore)]
        public InPermissionEnum InPermission { get; set; }
        /// <summary>
        /// 该部门下用户访问权限控制。 - UNLIMITED：不限制 - ONLY_SELF：仅能查询自己 - SELF_AND_CHILD_DEPARTMENT：该部门下用户能查询本部门及子部门通讯 - DESIGNATED_DEPARTMENT：该部门下用户能查询指定部门通讯录
        /// </summary>
        [JsonProperty("outPermission", NullValueHandling = NullValueHandling.Ignore)]
        public OutPermissionEnum OutPermission { get; set; }
        /// <summary>
        /// 允许访问的部门列表,仅outPermission为DESIGNATED_DEPARTMENT时有效，最多支持配置150个部门。
        /// </summary>
        [JsonProperty("designatedOutDeptCodes", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DesignatedOutDeptCodes { get; set; }

        /// <summary>
        /// 部门排序号，序号越小,部门排序越靠前。
        /// </summary>
        [JsonProperty("sortLevel", NullValueHandling = NullValueHandling.Ignore)]
        public int? SortLevel { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModDeptDTO {\n");
            sb.Append("  deptName: ").Append(DeptName).Append("\n");
            sb.Append("  parentDeptCode: ").Append(ParentDeptCode).Append("\n");
            sb.Append("  note: ").Append(Note).Append("\n");
            sb.Append("  inPermission: ").Append(InPermission).Append("\n");
            sb.Append("  outPermission: ").Append(OutPermission).Append("\n");
            sb.Append("  designatedOutDeptCodes: ").Append(DesignatedOutDeptCodes).Append("\n");
            sb.Append("  sortLevel: ").Append(SortLevel).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModDeptDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModDeptDTO input)
        {
            if (input == null) return false;
            if (this.DeptName != input.DeptName || (this.DeptName != null && !this.DeptName.Equals(input.DeptName))) return false;
            if (this.ParentDeptCode != input.ParentDeptCode || (this.ParentDeptCode != null && !this.ParentDeptCode.Equals(input.ParentDeptCode))) return false;
            if (this.Note != input.Note || (this.Note != null && !this.Note.Equals(input.Note))) return false;
            if (this.InPermission != input.InPermission) return false;
            if (this.OutPermission != input.OutPermission) return false;
            if (this.DesignatedOutDeptCodes != input.DesignatedOutDeptCodes || (this.DesignatedOutDeptCodes != null && input.DesignatedOutDeptCodes != null && !this.DesignatedOutDeptCodes.SequenceEqual(input.DesignatedOutDeptCodes))) return false;
            if (this.SortLevel != input.SortLevel || (this.SortLevel != null && !this.SortLevel.Equals(input.SortLevel))) return false;

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
                if (this.DeptName != null) hashCode = hashCode * 59 + this.DeptName.GetHashCode();
                if (this.ParentDeptCode != null) hashCode = hashCode * 59 + this.ParentDeptCode.GetHashCode();
                if (this.Note != null) hashCode = hashCode * 59 + this.Note.GetHashCode();
                hashCode = hashCode * 59 + this.InPermission.GetHashCode();
                hashCode = hashCode * 59 + this.OutPermission.GetHashCode();
                if (this.DesignatedOutDeptCodes != null) hashCode = hashCode * 59 + this.DesignatedOutDeptCodes.GetHashCode();
                if (this.SortLevel != null) hashCode = hashCode * 59 + this.SortLevel.GetHashCode();
                return hashCode;
            }
        }
    }
}
