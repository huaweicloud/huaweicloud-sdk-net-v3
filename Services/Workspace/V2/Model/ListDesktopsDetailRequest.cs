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
    /// Request Object
    /// </summary>
    public class ListDesktopsDetailRequest 
    {
        /// <summary>
        /// 排序字段名称，需要结合sort_type字段一起使用。 - created 创建时间。 - computer_name 桌面名称。
        /// </summary>
        /// <value>排序字段名称，需要结合sort_type字段一起使用。 - created 创建时间。 - computer_name 桌面名称。</value>
        [JsonConverter(typeof(EnumClassConverter<SortFieldEnum>))]
        public class SortFieldEnum
        {
            /// <summary>
            /// Enum CREATED for value: created
            /// </summary>
            public static readonly SortFieldEnum CREATED = new SortFieldEnum("created");

            /// <summary>
            /// Enum COMPUTER_NAME for value: computer_name
            /// </summary>
            public static readonly SortFieldEnum COMPUTER_NAME = new SortFieldEnum("computer_name");

            private static readonly Dictionary<string, SortFieldEnum> StaticFields =
            new Dictionary<string, SortFieldEnum>()
            {
                { "created", CREATED },
                { "computer_name", COMPUTER_NAME },
            };

            private string _value;

            public SortFieldEnum()
            {

            }

            public SortFieldEnum(string value)
            {
                _value = value;
            }

            public static SortFieldEnum FromValue(string value)
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

                if (this.Equals(obj as SortFieldEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortFieldEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortFieldEnum a, SortFieldEnum b)
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

            public static bool operator !=(SortFieldEnum a, SortFieldEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 排序类型，默认升序，需要结合sort_field字段一起使用。 - ASC 升序。 - DESC 降序。
        /// </summary>
        /// <value>排序类型，默认升序，需要结合sort_field字段一起使用。 - ASC 升序。 - DESC 降序。</value>
        [JsonConverter(typeof(EnumClassConverter<SortTypeEnum>))]
        public class SortTypeEnum
        {
            /// <summary>
            /// Enum ASC for value: ASC
            /// </summary>
            public static readonly SortTypeEnum ASC = new SortTypeEnum("ASC");

            /// <summary>
            /// Enum DESC for value: DESC
            /// </summary>
            public static readonly SortTypeEnum DESC = new SortTypeEnum("DESC");

            private static readonly Dictionary<string, SortTypeEnum> StaticFields =
            new Dictionary<string, SortTypeEnum>()
            {
                { "ASC", ASC },
                { "DESC", DESC },
            };

            private string _value;

            public SortTypeEnum()
            {

            }

            public SortTypeEnum(string value)
            {
                _value = value;
            }

            public static SortTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SortTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SortTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SortTypeEnum a, SortTypeEnum b)
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

            public static bool operator !=(SortTypeEnum a, SortTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 桌面状态。  - ACTIVE：运行中。 - SHUTOFF：关机。 - ERROR：异常。 - HIBERNATED：休眠。
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 桌面所属用户，当传user_names时，本字段不生效。
        /// </summary>
        [SDKProperty("user_name", IsQuery = true)]
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 桌面所属用户，批量筛选，最多不超过100个用户。
        /// </summary>
        [SDKProperty("user_names", IsQuery = true)]
        [JsonProperty("user_names", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UserNames { get; set; }

        /// <summary>
        /// 排序字段名称，需要结合sort_type字段一起使用。 - created 创建时间。 - computer_name 桌面名称。
        /// </summary>
        [SDKProperty("sort_field", IsQuery = true)]
        [JsonProperty("sort_field", NullValueHandling = NullValueHandling.Ignore)]
        public SortFieldEnum SortField { get; set; }
        /// <summary>
        /// 排序类型，默认升序，需要结合sort_field字段一起使用。 - ASC 升序。 - DESC 降序。
        /// </summary>
        [SDKProperty("sort_type", IsQuery = true)]
        [JsonProperty("sort_type", NullValueHandling = NullValueHandling.Ignore)]
        public SortTypeEnum SortType { get; set; }
        /// <summary>
        /// 桌面名。
        /// </summary>
        [SDKProperty("computer_name", IsQuery = true)]
        [JsonProperty("computer_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ComputerName { get; set; }

        /// <summary>
        /// 桌面IP地址。
        /// </summary>
        [SDKProperty("desktop_ip", IsQuery = true)]
        [JsonProperty("desktop_ip", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopIp { get; set; }

        /// <summary>
        /// 用于分页查询，查询的起始记录序号，从0开始。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 用于分页查询，取值范围0-500，默认值500。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 桌面ID。
        /// </summary>
        [SDKProperty("desktop_id", IsQuery = true)]
        [JsonProperty("desktop_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// 桌面类型，为空时查所有桌面。 - DEDICATED：普通桌面，包括专享桌面、专属桌面等 - POOLED：池桌面，即桌面池里的桌面
        /// </summary>
        [SDKProperty("desktop_type", IsQuery = true)]
        [JsonProperty("desktop_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopType { get; set; }

        /// <summary>
        /// 桌面的标签。样例：  - key1&#x3D;value1。 - key1&#x3D;value1，key2&#x3D;value2。
        /// </summary>
        [SDKProperty("tag", IsQuery = true)]
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }

        /// <summary>
        /// 桌面池ID,多个桌面池ID用逗号隔开。
        /// </summary>
        [SDKProperty("pool_id", IsQuery = true)]
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolId { get; set; }

        /// <summary>
        /// 是否分配了用户。
        /// </summary>
        [SDKProperty("user_attached", IsQuery = true)]
        [JsonProperty("user_attached", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UserAttached { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 镜像ID。
        /// </summary>
        [SDKProperty("image_id", IsQuery = true)]
        [JsonProperty("image_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ImageId { get; set; }

        /// <summary>
        /// 计费模式，0：包周期，1：按需。
        /// </summary>
        [SDKProperty("charge_mode", IsQuery = true)]
        [JsonProperty("charge_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string ChargeMode { get; set; }

        /// <summary>
        /// 按照维护模式过滤。
        /// </summary>
        [SDKProperty("in_maintenance_mode", IsQuery = true)]
        [JsonProperty("in_maintenance_mode", NullValueHandling = NullValueHandling.Ignore)]
        public bool? InMaintenanceMode { get; set; }

        /// <summary>
        /// 是否为协同桌面。
        /// </summary>
        [SDKProperty("is_share_desktop", IsQuery = true)]
        [JsonProperty("is_share_desktop", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsShareDesktop { get; set; }

        /// <summary>
        /// 桌面的子网ID。
        /// </summary>
        [SDKProperty("subnet_id", IsQuery = true)]
        [JsonProperty("subnet_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubnetId { get; set; }

        /// <summary>
        /// 是否支持上网。
        /// </summary>
        [SDKProperty("is_support_internet", IsQuery = true)]
        [JsonProperty("is_support_internet", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSupportInternet { get; set; }

        /// <summary>
        /// 查询可用区。
        /// </summary>
        [SDKProperty("availability_zone", IsQuery = true)]
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailabilityZone { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDesktopsDetailRequest {\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  userNames: ").Append(UserNames).Append("\n");
            sb.Append("  sortField: ").Append(SortField).Append("\n");
            sb.Append("  sortType: ").Append(SortType).Append("\n");
            sb.Append("  computerName: ").Append(ComputerName).Append("\n");
            sb.Append("  desktopIp: ").Append(DesktopIp).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  desktopId: ").Append(DesktopId).Append("\n");
            sb.Append("  desktopType: ").Append(DesktopType).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  userAttached: ").Append(UserAttached).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  imageId: ").Append(ImageId).Append("\n");
            sb.Append("  chargeMode: ").Append(ChargeMode).Append("\n");
            sb.Append("  inMaintenanceMode: ").Append(InMaintenanceMode).Append("\n");
            sb.Append("  isShareDesktop: ").Append(IsShareDesktop).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  isSupportInternet: ").Append(IsSupportInternet).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDesktopsDetailRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDesktopsDetailRequest input)
        {
            if (input == null) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.UserNames != input.UserNames || (this.UserNames != null && input.UserNames != null && !this.UserNames.SequenceEqual(input.UserNames))) return false;
            if (this.SortField != input.SortField) return false;
            if (this.SortType != input.SortType) return false;
            if (this.ComputerName != input.ComputerName || (this.ComputerName != null && !this.ComputerName.Equals(input.ComputerName))) return false;
            if (this.DesktopIp != input.DesktopIp || (this.DesktopIp != null && !this.DesktopIp.Equals(input.DesktopIp))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.DesktopId != input.DesktopId || (this.DesktopId != null && input.DesktopId != null && !this.DesktopId.SequenceEqual(input.DesktopId))) return false;
            if (this.DesktopType != input.DesktopType || (this.DesktopType != null && !this.DesktopType.Equals(input.DesktopType))) return false;
            if (this.Tag != input.Tag || (this.Tag != null && !this.Tag.Equals(input.Tag))) return false;
            if (this.PoolId != input.PoolId || (this.PoolId != null && !this.PoolId.Equals(input.PoolId))) return false;
            if (this.UserAttached != input.UserAttached || (this.UserAttached != null && !this.UserAttached.Equals(input.UserAttached))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.ImageId != input.ImageId || (this.ImageId != null && !this.ImageId.Equals(input.ImageId))) return false;
            if (this.ChargeMode != input.ChargeMode || (this.ChargeMode != null && !this.ChargeMode.Equals(input.ChargeMode))) return false;
            if (this.InMaintenanceMode != input.InMaintenanceMode || (this.InMaintenanceMode != null && !this.InMaintenanceMode.Equals(input.InMaintenanceMode))) return false;
            if (this.IsShareDesktop != input.IsShareDesktop || (this.IsShareDesktop != null && !this.IsShareDesktop.Equals(input.IsShareDesktop))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.IsSupportInternet != input.IsSupportInternet || (this.IsSupportInternet != null && !this.IsSupportInternet.Equals(input.IsSupportInternet))) return false;
            if (this.AvailabilityZone != input.AvailabilityZone || (this.AvailabilityZone != null && !this.AvailabilityZone.Equals(input.AvailabilityZone))) return false;

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
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.UserNames != null) hashCode = hashCode * 59 + this.UserNames.GetHashCode();
                hashCode = hashCode * 59 + this.SortField.GetHashCode();
                hashCode = hashCode * 59 + this.SortType.GetHashCode();
                if (this.ComputerName != null) hashCode = hashCode * 59 + this.ComputerName.GetHashCode();
                if (this.DesktopIp != null) hashCode = hashCode * 59 + this.DesktopIp.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.DesktopId != null) hashCode = hashCode * 59 + this.DesktopId.GetHashCode();
                if (this.DesktopType != null) hashCode = hashCode * 59 + this.DesktopType.GetHashCode();
                if (this.Tag != null) hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.PoolId != null) hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.UserAttached != null) hashCode = hashCode * 59 + this.UserAttached.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.ImageId != null) hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.ChargeMode != null) hashCode = hashCode * 59 + this.ChargeMode.GetHashCode();
                if (this.InMaintenanceMode != null) hashCode = hashCode * 59 + this.InMaintenanceMode.GetHashCode();
                if (this.IsShareDesktop != null) hashCode = hashCode * 59 + this.IsShareDesktop.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.IsSupportInternet != null) hashCode = hashCode * 59 + this.IsSupportInternet.GetHashCode();
                if (this.AvailabilityZone != null) hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                return hashCode;
            }
        }
    }
}
