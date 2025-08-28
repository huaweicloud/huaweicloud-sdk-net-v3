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
    /// Request Object
    /// </summary>
    public class ListGlobalConnectionBandwidthSitesRequest 
    {
        /// <summary>
        /// 站点类型： - Area: 大区 - SubArea: 区域 - Region: 城域
        /// </summary>
        /// <value>站点类型： - Area: 大区 - SubArea: 区域 - Region: 城域</value>
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

            public static bool operator !=(SiteTypeEnum a, SiteTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 每页返回的个数。 取值范围：1~1000。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 翻页信息，从上次API调用返回的翻页数据中获取，可填写前一页marker或者后一页marker，填入前一页previous_marker就向前翻页，后一页next_marker就向后翻页。 翻页过程中，查询条件不能修改，包括过滤条件、排序条件、limit。
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 根据ID查询，可查询多个ID。
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// 站点信息自定义英文名称。
        /// </summary>
        [SDKProperty("name_en", IsQuery = true)]
        [JsonProperty("name_en", NullValueHandling = NullValueHandling.Ignore)]
        public string NameEn { get; set; }

        /// <summary>
        /// 站点信息自定义中文名称。
        /// </summary>
        [SDKProperty("name_cn", IsQuery = true)]
        [JsonProperty("name_cn", NullValueHandling = NullValueHandling.Ignore)]
        public string NameCn { get; set; }

        /// <summary>
        /// 站点编码。
        /// </summary>
        [SDKProperty("site_code", IsQuery = true)]
        [JsonProperty("site_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteCode { get; set; }

        /// <summary>
        /// 站点类型： - Area: 大区 - SubArea: 区域 - Region: 城域
        /// </summary>
        [SDKProperty("site_type", IsQuery = true)]
        [JsonProperty("site_type", NullValueHandling = NullValueHandling.Ignore)]
        public SiteTypeEnum SiteType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListGlobalConnectionBandwidthSitesRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  nameEn: ").Append(NameEn).Append("\n");
            sb.Append("  nameCn: ").Append(NameCn).Append("\n");
            sb.Append("  siteCode: ").Append(SiteCode).Append("\n");
            sb.Append("  siteType: ").Append(SiteType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListGlobalConnectionBandwidthSitesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListGlobalConnectionBandwidthSitesRequest input)
        {
            if (input == null) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.Id != input.Id || (this.Id != null && input.Id != null && !this.Id.SequenceEqual(input.Id))) return false;
            if (this.NameEn != input.NameEn || (this.NameEn != null && !this.NameEn.Equals(input.NameEn))) return false;
            if (this.NameCn != input.NameCn || (this.NameCn != null && !this.NameCn.Equals(input.NameCn))) return false;
            if (this.SiteCode != input.SiteCode || (this.SiteCode != null && !this.SiteCode.Equals(input.SiteCode))) return false;
            if (this.SiteType != input.SiteType) return false;

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
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.NameEn != null) hashCode = hashCode * 59 + this.NameEn.GetHashCode();
                if (this.NameCn != null) hashCode = hashCode * 59 + this.NameCn.GetHashCode();
                if (this.SiteCode != null) hashCode = hashCode * 59 + this.SiteCode.GetHashCode();
                hashCode = hashCode * 59 + this.SiteType.GetHashCode();
                return hashCode;
            }
        }
    }
}
