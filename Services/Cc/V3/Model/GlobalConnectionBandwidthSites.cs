using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cc.V3.Model
{
    /// <summary>
    /// 站点信息。
    /// </summary>
    public class GlobalConnectionBandwidthSites 
    {
        /// <summary>
        /// 功能说明：站点类型，必须跟站点编码对应，一段编码为大区，两段编码为区域，三段编码为城域。 取值范围： - Area: 大区站点 - SubArea: 区域站点 - Region: 城域站点
        /// </summary>
        /// <value>功能说明：站点类型，必须跟站点编码对应，一段编码为大区，两段编码为区域，三段编码为城域。 取值范围： - Area: 大区站点 - SubArea: 区域站点 - Region: 城域站点</value>
        [JsonConverter(typeof(EnumClassConverter<SiteTypeEnum>))]
        public class SiteTypeEnum
        {
            /// <summary>
            /// Enum AREA for value: Area
            /// </summary>
            public static readonly SiteTypeEnum AREA = new SiteTypeEnum("Area");

            /// <summary>
            /// Enum SUBAREA for value: SubArea
            /// </summary>
            public static readonly SiteTypeEnum SUBAREA = new SiteTypeEnum("SubArea");

            /// <summary>
            /// Enum REGION for value: Region
            /// </summary>
            public static readonly SiteTypeEnum REGION = new SiteTypeEnum("Region");

            private static readonly Dictionary<string, SiteTypeEnum> StaticFields =
            new Dictionary<string, SiteTypeEnum>()
            {
                { "Area", AREA },
                { "SubArea", SUBAREA },
                { "Region", REGION },
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
        /// 实例ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 实例描述。不支持 &lt;&gt;。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 实例创建时间。UTC时间格式，yyyy-MM-ddTHH:mm:ss。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 实例更新时间。UTC时间格式，yyyy-MM-ddTHH:mm:ss。
        /// </summary>
        [JsonProperty("updated_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// RegionID。
        /// </summary>
        [JsonProperty("region_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionId { get; set; }

        /// <summary>
        /// 功能说明：站点信息自定义的英文名称。 取值范围：1-255个字符
        /// </summary>
        [JsonProperty("name_en", NullValueHandling = NullValueHandling.Ignore)]
        public string NameEn { get; set; }

        /// <summary>
        /// 功能说明：站点信息自定义的中文名称。 取值范围：1-64个字符。
        /// </summary>
        [JsonProperty("name_cn", NullValueHandling = NullValueHandling.Ignore)]
        public string NameCn { get; set; }

        /// <summary>
        /// 功能说明：站点编码，格式为&lt;area_code&gt;[-&lt;subarea_code&gt;[-&lt;region_code&gt;]]。 取值范围：1-64个字符。
        /// </summary>
        [JsonProperty("site_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteCode { get; set; }

        /// <summary>
        /// 功能说明：站点类型，必须跟站点编码对应，一段编码为大区，两段编码为区域，三段编码为城域。 取值范围： - Area: 大区站点 - SubArea: 区域站点 - Region: 城域站点
        /// </summary>
        [JsonProperty("site_type", NullValueHandling = NullValueHandling.Ignore)]
        public SiteTypeEnum SiteType { get; set; }
        /// <summary>
        /// 功能说明：站点支持的服务列表，多个服务用\&quot;,\&quot;分隔。 取值范围：0-255个字符
        /// </summary>
        [JsonProperty("service_list", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("group_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<SiteGroupReferenceInfo> GroupList { get; set; }

        /// <summary>
        /// 功能说明：用于标记是中心还是边缘站点。中心：center 取值范围：0-255个字符。
        /// </summary>
        [JsonProperty("public_border_group", NullValueHandling = NullValueHandling.Ignore)]
        public string PublicBorderGroup { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GlobalConnectionBandwidthSites {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  updatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  regionId: ").Append(RegionId).Append("\n");
            sb.Append("  nameEn: ").Append(NameEn).Append("\n");
            sb.Append("  nameCn: ").Append(NameCn).Append("\n");
            sb.Append("  siteCode: ").Append(SiteCode).Append("\n");
            sb.Append("  siteType: ").Append(SiteType).Append("\n");
            sb.Append("  serviceList: ").Append(ServiceList).Append("\n");
            sb.Append("  groupList: ").Append(GroupList).Append("\n");
            sb.Append("  publicBorderGroup: ").Append(PublicBorderGroup).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GlobalConnectionBandwidthSites);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GlobalConnectionBandwidthSites input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.UpdatedAt != input.UpdatedAt || (this.UpdatedAt != null && !this.UpdatedAt.Equals(input.UpdatedAt))) return false;
            if (this.RegionId != input.RegionId || (this.RegionId != null && !this.RegionId.Equals(input.RegionId))) return false;
            if (this.NameEn != input.NameEn || (this.NameEn != null && !this.NameEn.Equals(input.NameEn))) return false;
            if (this.NameCn != input.NameCn || (this.NameCn != null && !this.NameCn.Equals(input.NameCn))) return false;
            if (this.SiteCode != input.SiteCode || (this.SiteCode != null && !this.SiteCode.Equals(input.SiteCode))) return false;
            if (this.SiteType != input.SiteType) return false;
            if (this.ServiceList != input.ServiceList || (this.ServiceList != null && !this.ServiceList.Equals(input.ServiceList))) return false;
            if (this.GroupList != input.GroupList || (this.GroupList != null && input.GroupList != null && !this.GroupList.SequenceEqual(input.GroupList))) return false;
            if (this.PublicBorderGroup != input.PublicBorderGroup || (this.PublicBorderGroup != null && !this.PublicBorderGroup.Equals(input.PublicBorderGroup))) return false;

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
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null) hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.RegionId != null) hashCode = hashCode * 59 + this.RegionId.GetHashCode();
                if (this.NameEn != null) hashCode = hashCode * 59 + this.NameEn.GetHashCode();
                if (this.NameCn != null) hashCode = hashCode * 59 + this.NameCn.GetHashCode();
                if (this.SiteCode != null) hashCode = hashCode * 59 + this.SiteCode.GetHashCode();
                hashCode = hashCode * 59 + this.SiteType.GetHashCode();
                if (this.ServiceList != null) hashCode = hashCode * 59 + this.ServiceList.GetHashCode();
                if (this.GroupList != null) hashCode = hashCode * 59 + this.GroupList.GetHashCode();
                if (this.PublicBorderGroup != null) hashCode = hashCode * 59 + this.PublicBorderGroup.GetHashCode();
                return hashCode;
            }
        }
    }
}
