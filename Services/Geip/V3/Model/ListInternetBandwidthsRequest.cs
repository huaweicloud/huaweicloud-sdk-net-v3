using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Geip.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListInternetBandwidthsRequest 
    {
        /// <summary>
        /// Defines fields
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<FieldsEnum>))]
        public class FieldsEnum
        {
            /// <summary>
            /// Enum ID for value: id
            /// </summary>
            public static readonly FieldsEnum ID = new FieldsEnum("id");

            /// <summary>
            /// Enum NAME for value: name
            /// </summary>
            public static readonly FieldsEnum NAME = new FieldsEnum("name");

            /// <summary>
            /// Enum ISP for value: isp
            /// </summary>
            public static readonly FieldsEnum ISP = new FieldsEnum("isp");

            /// <summary>
            /// Enum INGRESS_SIZE for value: ingress_size
            /// </summary>
            public static readonly FieldsEnum INGRESS_SIZE = new FieldsEnum("ingress_size");

            /// <summary>
            /// Enum ACCESS_SITE for value: access_site
            /// </summary>
            public static readonly FieldsEnum ACCESS_SITE = new FieldsEnum("access_site");

            /// <summary>
            /// Enum SIZE for value: size
            /// </summary>
            public static readonly FieldsEnum SIZE = new FieldsEnum("size");

            /// <summary>
            /// Enum DESCRIPTION for value: description
            /// </summary>
            public static readonly FieldsEnum DESCRIPTION = new FieldsEnum("description");

            /// <summary>
            /// Enum CHARGE_MODE for value: charge_mode
            /// </summary>
            public static readonly FieldsEnum CHARGE_MODE = new FieldsEnum("charge_mode");

            /// <summary>
            /// Enum RATIO_95PEAK for value: ratio_95peak
            /// </summary>
            public static readonly FieldsEnum RATIO_95PEAK = new FieldsEnum("ratio_95peak");

            /// <summary>
            /// Enum FREEZEN_INFO for value: freezen_info
            /// </summary>
            public static readonly FieldsEnum FREEZEN_INFO = new FieldsEnum("freezen_info");

            /// <summary>
            /// Enum DOMAIN_ID for value: domain_id
            /// </summary>
            public static readonly FieldsEnum DOMAIN_ID = new FieldsEnum("domain_id");

            /// <summary>
            /// Enum STATUS for value: status
            /// </summary>
            public static readonly FieldsEnum STATUS = new FieldsEnum("status");

            /// <summary>
            /// Enum CREATED_AT for value: created_at
            /// </summary>
            public static readonly FieldsEnum CREATED_AT = new FieldsEnum("created_at");

            /// <summary>
            /// Enum UPDATED_AT for value: updated_at
            /// </summary>
            public static readonly FieldsEnum UPDATED_AT = new FieldsEnum("updated_at");

            /// <summary>
            /// Enum IS_PRE_PAID for value: is_pre_paid
            /// </summary>
            public static readonly FieldsEnum IS_PRE_PAID = new FieldsEnum("is_pre_paid");

            /// <summary>
            /// Enum TYPE for value: type
            /// </summary>
            public static readonly FieldsEnum TYPE = new FieldsEnum("type");

            /// <summary>
            /// Enum TAGS for value: tags
            /// </summary>
            public static readonly FieldsEnum TAGS = new FieldsEnum("tags");

            /// <summary>
            /// Enum SYS_TAGS for value: sys_tags
            /// </summary>
            public static readonly FieldsEnum SYS_TAGS = new FieldsEnum("sys_tags");

            /// <summary>
            /// Enum ENTERPRISE_PROJECT_ID for value: enterprise_project_id
            /// </summary>
            public static readonly FieldsEnum ENTERPRISE_PROJECT_ID = new FieldsEnum("enterprise_project_id");

            private static readonly Dictionary<string, FieldsEnum> StaticFields =
            new Dictionary<string, FieldsEnum>()
            {
                { "id", ID },
                { "name", NAME },
                { "isp", ISP },
                { "ingress_size", INGRESS_SIZE },
                { "access_site", ACCESS_SITE },
                { "size", SIZE },
                { "description", DESCRIPTION },
                { "charge_mode", CHARGE_MODE },
                { "ratio_95peak", RATIO_95PEAK },
                { "freezen_info", FREEZEN_INFO },
                { "domain_id", DOMAIN_ID },
                { "status", STATUS },
                { "created_at", CREATED_AT },
                { "updated_at", UPDATED_AT },
                { "is_pre_paid", IS_PRE_PAID },
                { "type", TYPE },
                { "tags", TAGS },
                { "sys_tags", SYS_TAGS },
                { "enterprise_project_id", ENTERPRISE_PROJECT_ID },
            };

            private string _value;

            public FieldsEnum()
            {

            }

            public FieldsEnum(string value)
            {
                _value = value;
            }

            public static FieldsEnum FromValue(string value)
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

                if (this.Equals(obj as FieldsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(FieldsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(FieldsEnum a, FieldsEnum b)
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

            public static bool operator !=(FieldsEnum a, FieldsEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Defines extFields
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<ExtFieldsEnum>))]
        public class ExtFieldsEnum
        {
            /// <summary>
            /// Enum GEIP_COUNT for value: geip_count
            /// </summary>
            public static readonly ExtFieldsEnum GEIP_COUNT = new ExtFieldsEnum("geip_count");

            /// <summary>
            /// Enum GEIP_SEGMENT_COUNT for value: geip_segment_count
            /// </summary>
            public static readonly ExtFieldsEnum GEIP_SEGMENT_COUNT = new ExtFieldsEnum("geip_segment_count");

            private static readonly Dictionary<string, ExtFieldsEnum> StaticFields =
            new Dictionary<string, ExtFieldsEnum>()
            {
                { "geip_count", GEIP_COUNT },
                { "geip_segment_count", GEIP_SEGMENT_COUNT },
            };

            private string _value;

            public ExtFieldsEnum()
            {

            }

            public ExtFieldsEnum(string value)
            {
                _value = value;
            }

            public static ExtFieldsEnum FromValue(string value)
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

                if (this.Equals(obj as ExtFieldsEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ExtFieldsEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ExtFieldsEnum a, ExtFieldsEnum b)
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

            public static bool operator !=(ExtFieldsEnum a, ExtFieldsEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Defines sortKey
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<SortKeyEnum>))]
        public class SortKeyEnum
        {
            /// <summary>
            /// Enum ID for value: id
            /// </summary>
            public static readonly SortKeyEnum ID = new SortKeyEnum("id");

            /// <summary>
            /// Enum SIZE for value: size
            /// </summary>
            public static readonly SortKeyEnum SIZE = new SortKeyEnum("size");

            /// <summary>
            /// Enum CREATED_AT for value: created_at
            /// </summary>
            public static readonly SortKeyEnum CREATED_AT = new SortKeyEnum("created_at");

            /// <summary>
            /// Enum UPDATED_AT for value: updated_at
            /// </summary>
            public static readonly SortKeyEnum UPDATED_AT = new SortKeyEnum("updated_at");

            private static readonly Dictionary<string, SortKeyEnum> StaticFields =
            new Dictionary<string, SortKeyEnum>()
            {
                { "id", ID },
                { "size", SIZE },
                { "created_at", CREATED_AT },
                { "updated_at", UPDATED_AT },
            };

            private string _value;

            public SortKeyEnum()
            {

            }

            public SortKeyEnum(string value)
            {
                _value = value;
            }

            public static SortKeyEnum FromValue(string value)
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

                if (this.Equals(obj as SortKeyEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortKeyEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortKeyEnum a, SortKeyEnum b)
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

            public static bool operator !=(SortKeyEnum a, SortKeyEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Defines sortDir
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<SortDirEnum>))]
        public class SortDirEnum
        {
            /// <summary>
            /// Enum ASC for value: asc
            /// </summary>
            public static readonly SortDirEnum ASC = new SortDirEnum("asc");

            /// <summary>
            /// Enum DESC for value: desc
            /// </summary>
            public static readonly SortDirEnum DESC = new SortDirEnum("desc");

            private static readonly Dictionary<string, SortDirEnum> StaticFields =
            new Dictionary<string, SortDirEnum>()
            {
                { "asc", ASC },
                { "desc", DESC },
            };

            private string _value;

            public SortDirEnum()
            {

            }

            public SortDirEnum(string value)
            {
                _value = value;
            }

            public static SortDirEnum FromValue(string value)
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

                if (this.Equals(obj as SortDirEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortDirEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortDirEnum a, SortDirEnum b)
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

            public static bool operator !=(SortDirEnum a, SortDirEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// Defines status
        /// </summary>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum FREEZED for value: freezed
            /// </summary>
            public static readonly StatusEnum FREEZED = new StatusEnum("freezed");

            /// <summary>
            /// Enum NORMAL for value: normal
            /// </summary>
            public static readonly StatusEnum NORMAL = new StatusEnum("normal");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "freezed", FREEZED },
                { "normal", NORMAL },
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
        /// 每页条数
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 分页起始点
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 分页起始点
        /// </summary>
        [SDKProperty("marker", IsQuery = true)]
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 翻页方向
        /// </summary>
        [SDKProperty("page_reverse", IsQuery = true)]
        [JsonProperty("page_reverse", NullValueHandling = NullValueHandling.Ignore)]
        public bool? PageReverse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("fields", IsQuery = true)]
        [JsonProperty("fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<FieldsEnum> Fields { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("ext-fields", IsQuery = true)]
        [JsonProperty("ext-fields", NullValueHandling = NullValueHandling.Ignore)]
        public List<ExtFieldsEnum> ExtFields { get; set; }
        /// <summary>
        /// 按照sort_key指定的字段排序
        /// </summary>
        [SDKProperty("sort_key", IsQuery = true)]
        [JsonProperty("sort_key", NullValueHandling = NullValueHandling.Ignore)]
        public List<SortKeyEnum> SortKey { get; set; }
        /// <summary>
        /// 排序的方向，倒序或者正序
        /// </summary>
        [SDKProperty("sort_dir", IsQuery = true)]
        [JsonProperty("sort_dir", NullValueHandling = NullValueHandling.Ignore)]
        public List<SortDirEnum> SortDir { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("id", IsQuery = true)]
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("size", IsQuery = true)]
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("name", IsQuery = true)]
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("name_like", IsQuery = true)]
        [JsonProperty("name_like", NullValueHandling = NullValueHandling.Ignore)]
        public string NameLike { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("access_site", IsQuery = true)]
        [JsonProperty("access_site", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AccessSite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public List<StatusEnum> Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EnterpriseProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("tags", IsQuery = true)]
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Type { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListInternetBandwidthsRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  pageReverse: ").Append(PageReverse).Append("\n");
            sb.Append("  fields: ").Append(Fields).Append("\n");
            sb.Append("  extFields: ").Append(ExtFields).Append("\n");
            sb.Append("  sortKey: ").Append(SortKey).Append("\n");
            sb.Append("  sortDir: ").Append(SortDir).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  nameLike: ").Append(NameLike).Append("\n");
            sb.Append("  accessSite: ").Append(AccessSite).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListInternetBandwidthsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListInternetBandwidthsRequest input)
        {
            if (input == null) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.PageReverse != input.PageReverse || (this.PageReverse != null && !this.PageReverse.Equals(input.PageReverse))) return false;
            if (this.Fields != input.Fields || (this.Fields != null && input.Fields != null && !this.Fields.SequenceEqual(input.Fields))) return false;
            if (this.ExtFields != input.ExtFields || (this.ExtFields != null && input.ExtFields != null && !this.ExtFields.SequenceEqual(input.ExtFields))) return false;
            if (this.SortKey != input.SortKey || (this.SortKey != null && input.SortKey != null && !this.SortKey.SequenceEqual(input.SortKey))) return false;
            if (this.SortDir != input.SortDir || (this.SortDir != null && input.SortDir != null && !this.SortDir.SequenceEqual(input.SortDir))) return false;
            if (this.Id != input.Id || (this.Id != null && input.Id != null && !this.Id.SequenceEqual(input.Id))) return false;
            if (this.Size != input.Size || (this.Size != null && input.Size != null && !this.Size.SequenceEqual(input.Size))) return false;
            if (this.Name != input.Name || (this.Name != null && input.Name != null && !this.Name.SequenceEqual(input.Name))) return false;
            if (this.NameLike != input.NameLike || (this.NameLike != null && !this.NameLike.Equals(input.NameLike))) return false;
            if (this.AccessSite != input.AccessSite || (this.AccessSite != null && input.AccessSite != null && !this.AccessSite.SequenceEqual(input.AccessSite))) return false;
            if (this.Status != input.Status || (this.Status != null && input.Status != null && !this.Status.SequenceEqual(input.Status))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && input.EnterpriseProjectId != null && !this.EnterpriseProjectId.SequenceEqual(input.EnterpriseProjectId))) return false;
            if (this.Tags != input.Tags || (this.Tags != null && input.Tags != null && !this.Tags.SequenceEqual(input.Tags))) return false;
            if (this.Type != input.Type || (this.Type != null && input.Type != null && !this.Type.SequenceEqual(input.Type))) return false;

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
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.PageReverse != null) hashCode = hashCode * 59 + this.PageReverse.GetHashCode();
                hashCode = hashCode * 59 + this.Fields.GetHashCode();
                hashCode = hashCode * 59 + this.ExtFields.GetHashCode();
                hashCode = hashCode * 59 + this.SortKey.GetHashCode();
                hashCode = hashCode * 59 + this.SortDir.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NameLike != null) hashCode = hashCode * 59 + this.NameLike.GetHashCode();
                if (this.AccessSite != null) hashCode = hashCode * 59 + this.AccessSite.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.Tags != null) hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                return hashCode;
            }
        }
    }
}
