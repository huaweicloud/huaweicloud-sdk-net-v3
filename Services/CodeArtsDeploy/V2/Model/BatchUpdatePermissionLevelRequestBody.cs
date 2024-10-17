using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsDeploy.V2.Model
{
    /// <summary>
    /// 批量配置应用下鉴权级别请求体
    /// </summary>
    public class BatchUpdatePermissionLevelRequestBody 
    {
        /// <summary>
        /// 应用鉴权级别，instance：实例级；project：项目级
        /// </summary>
        /// <value>应用鉴权级别，instance：实例级；project：项目级</value>
        [JsonConverter(typeof(EnumClassConverter<PermissionLevelEnum>))]
        public class PermissionLevelEnum
        {
            /// <summary>
            /// Enum PROJECT for value: project
            /// </summary>
            public static readonly PermissionLevelEnum PROJECT = new PermissionLevelEnum("project");

            /// <summary>
            /// Enum INSTANCE for value: instance
            /// </summary>
            public static readonly PermissionLevelEnum INSTANCE = new PermissionLevelEnum("instance");

            private static readonly Dictionary<string, PermissionLevelEnum> StaticFields =
            new Dictionary<string, PermissionLevelEnum>()
            {
                { "project", PROJECT },
                { "instance", INSTANCE },
            };

            private string _value;

            public PermissionLevelEnum()
            {

            }

            public PermissionLevelEnum(string value)
            {
                _value = value;
            }

            public static PermissionLevelEnum FromValue(string value)
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

                if (this.Equals(obj as PermissionLevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PermissionLevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PermissionLevelEnum a, PermissionLevelEnum b)
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

            public static bool operator !=(PermissionLevelEnum a, PermissionLevelEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 应用鉴权级别，instance：实例级；project：项目级
        /// </summary>
        [JsonProperty("permission_level", NullValueHandling = NullValueHandling.Ignore)]
        public PermissionLevelEnum PermissionLevel { get; set; }
        /// <summary>
        /// 应用id列表
        /// </summary>
        [JsonProperty("application_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ApplicationIds { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchUpdatePermissionLevelRequestBody {\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  permissionLevel: ").Append(PermissionLevel).Append("\n");
            sb.Append("  applicationIds: ").Append(ApplicationIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchUpdatePermissionLevelRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchUpdatePermissionLevelRequestBody input)
        {
            if (input == null) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.PermissionLevel != input.PermissionLevel) return false;
            if (this.ApplicationIds != input.ApplicationIds || (this.ApplicationIds != null && input.ApplicationIds != null && !this.ApplicationIds.SequenceEqual(input.ApplicationIds))) return false;

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
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                hashCode = hashCode * 59 + this.PermissionLevel.GetHashCode();
                if (this.ApplicationIds != null) hashCode = hashCode * 59 + this.ApplicationIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
