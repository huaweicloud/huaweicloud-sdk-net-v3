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
    /// 站点信息。
    /// </summary>
    public class SiteInfo 
    {
        /// <summary>
        /// 配置状态。 - CENTER： 中心初始化 - IES： 边缘初始化
        /// </summary>
        /// <value>配置状态。 - CENTER： 中心初始化 - IES： 边缘初始化</value>
        [JsonConverter(typeof(EnumClassConverter<SiteTypeEnum>))]
        public class SiteTypeEnum
        {
            /// <summary>
            /// Enum CENTER for value: CENTER
            /// </summary>
            public static readonly SiteTypeEnum CENTER = new SiteTypeEnum("CENTER");

            /// <summary>
            /// Enum IES for value: IES
            /// </summary>
            public static readonly SiteTypeEnum IES = new SiteTypeEnum("IES");

            private static readonly Dictionary<string, SiteTypeEnum> StaticFields =
            new Dictionary<string, SiteTypeEnum>()
            {
                { "CENTER", CENTER },
                { "IES", IES },
            };

            private string _value;

            public SiteTypeEnum()
            {

            }

            public SiteTypeEnum(string value)
            {
                _value = value;
            }

            public static SiteTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SiteTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SiteTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SiteTypeEnum a, SiteTypeEnum b)
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

            public static bool operator !=(SiteTypeEnum a, SiteTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 站点id。
        /// </summary>
        [JsonProperty("site_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteId { get; set; }

        /// <summary>
        /// 站点名字。
        /// </summary>
        [JsonProperty("site_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteName { get; set; }

        /// <summary>
        /// 配置状态。 - CENTER： 中心初始化 - IES： 边缘初始化
        /// </summary>
        [JsonProperty("site_type", NullValueHandling = NullValueHandling.Ignore)]
        public SiteTypeEnum SiteType { get; set; }
        /// <summary>
        /// 项目ID。
        /// </summary>
        [JsonProperty("project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProjectId { get; set; }

        /// <summary>
        /// 站点状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SiteInfo {\n");
            sb.Append("  siteId: ").Append(SiteId).Append("\n");
            sb.Append("  siteName: ").Append(SiteName).Append("\n");
            sb.Append("  siteType: ").Append(SiteType).Append("\n");
            sb.Append("  projectId: ").Append(ProjectId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SiteInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SiteInfo input)
        {
            if (input == null) return false;
            if (this.SiteId != input.SiteId || (this.SiteId != null && !this.SiteId.Equals(input.SiteId))) return false;
            if (this.SiteName != input.SiteName || (this.SiteName != null && !this.SiteName.Equals(input.SiteName))) return false;
            if (this.SiteType != input.SiteType) return false;
            if (this.ProjectId != input.ProjectId || (this.ProjectId != null && !this.ProjectId.Equals(input.ProjectId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;

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
                if (this.SiteId != null) hashCode = hashCode * 59 + this.SiteId.GetHashCode();
                if (this.SiteName != null) hashCode = hashCode * 59 + this.SiteName.GetHashCode();
                hashCode = hashCode * 59 + this.SiteType.GetHashCode();
                if (this.ProjectId != null) hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
