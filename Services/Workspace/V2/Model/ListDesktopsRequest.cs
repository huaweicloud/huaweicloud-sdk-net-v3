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
    public class ListDesktopsRequest 
    {

        /// <summary>
        /// 桌面所属用户。
        /// </summary>
        [SDKProperty("user_name", IsQuery = true)]
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> UserName { get; set; }

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
        /// 桌面的sid列表，一次只能查询20个sid。
        /// </summary>
        [SDKProperty("sids", IsQuery = true)]
        [JsonProperty("sids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Sids { get; set; }

        /// <summary>
        /// 用于分页查询，查询的起始记录序号，从0开始。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 用于分页查询，取值范围0-1000，默认值1000。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 用于筛选指定站点下的桌面列表
        /// </summary>
        [SDKProperty("site_id", IsQuery = true)]
        [JsonProperty("site_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SiteId { get; set; }

        /// <summary>
        /// 桌面池ID,多个桌面池ID用逗号隔开。
        /// </summary>
        [SDKProperty("pool_id", IsQuery = true)]
        [JsonProperty("pool_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PoolId { get; set; }

        /// <summary>
        /// 企业项目ID
        /// </summary>
        [SDKProperty("enterprise_project_id", IsQuery = true)]
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 桌面类型，为空时查所有桌面。查询多个类型时用,隔开。 - DEDICATED：普通桌面，包括专享桌面、专属桌面等。 - SHARED: 多用户共享桌面。
        /// </summary>
        [SDKProperty("desktop_type", IsQuery = true)]
        [JsonProperty("desktop_type", NullValueHandling = NullValueHandling.Ignore)]
        public string DesktopType { get; set; }

        /// <summary>
        /// 是否为协同桌面
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
        /// 桌面的运行状态。
        /// </summary>
        [SDKProperty("status", IsQuery = true)]
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 桌面id，当前最多支持100个桌面id进行查询。
        /// </summary>
        [SDKProperty("desktop_id", IsQuery = true)]
        [JsonProperty("desktop_id", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> DesktopId { get; set; }

        /// <summary>
        /// 桌面的标签。样例： - key1&#x3D;value1。 - key1&#x3D;value1，key2&#x3D;value2。
        /// </summary>
        [SDKProperty("tag", IsQuery = true)]
        [JsonProperty("tag", NullValueHandling = NullValueHandling.Ignore)]
        public string Tag { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListDesktopsRequest {\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  computerName: ").Append(ComputerName).Append("\n");
            sb.Append("  desktopIp: ").Append(DesktopIp).Append("\n");
            sb.Append("  sids: ").Append(Sids).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  siteId: ").Append(SiteId).Append("\n");
            sb.Append("  poolId: ").Append(PoolId).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  desktopType: ").Append(DesktopType).Append("\n");
            sb.Append("  isShareDesktop: ").Append(IsShareDesktop).Append("\n");
            sb.Append("  subnetId: ").Append(SubnetId).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  desktopId: ").Append(DesktopId).Append("\n");
            sb.Append("  tag: ").Append(Tag).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListDesktopsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListDesktopsRequest input)
        {
            if (input == null) return false;
            if (this.UserName != input.UserName || (this.UserName != null && input.UserName != null && !this.UserName.SequenceEqual(input.UserName))) return false;
            if (this.ComputerName != input.ComputerName || (this.ComputerName != null && !this.ComputerName.Equals(input.ComputerName))) return false;
            if (this.DesktopIp != input.DesktopIp || (this.DesktopIp != null && !this.DesktopIp.Equals(input.DesktopIp))) return false;
            if (this.Sids != input.Sids || (this.Sids != null && input.Sids != null && !this.Sids.SequenceEqual(input.Sids))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.SiteId != input.SiteId || (this.SiteId != null && !this.SiteId.Equals(input.SiteId))) return false;
            if (this.PoolId != input.PoolId || (this.PoolId != null && !this.PoolId.Equals(input.PoolId))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.DesktopType != input.DesktopType || (this.DesktopType != null && !this.DesktopType.Equals(input.DesktopType))) return false;
            if (this.IsShareDesktop != input.IsShareDesktop || (this.IsShareDesktop != null && !this.IsShareDesktop.Equals(input.IsShareDesktop))) return false;
            if (this.SubnetId != input.SubnetId || (this.SubnetId != null && !this.SubnetId.Equals(input.SubnetId))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.DesktopId != input.DesktopId || (this.DesktopId != null && input.DesktopId != null && !this.DesktopId.SequenceEqual(input.DesktopId))) return false;
            if (this.Tag != input.Tag || (this.Tag != null && !this.Tag.Equals(input.Tag))) return false;

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
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.ComputerName != null) hashCode = hashCode * 59 + this.ComputerName.GetHashCode();
                if (this.DesktopIp != null) hashCode = hashCode * 59 + this.DesktopIp.GetHashCode();
                if (this.Sids != null) hashCode = hashCode * 59 + this.Sids.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.SiteId != null) hashCode = hashCode * 59 + this.SiteId.GetHashCode();
                if (this.PoolId != null) hashCode = hashCode * 59 + this.PoolId.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.DesktopType != null) hashCode = hashCode * 59 + this.DesktopType.GetHashCode();
                if (this.IsShareDesktop != null) hashCode = hashCode * 59 + this.IsShareDesktop.GetHashCode();
                if (this.SubnetId != null) hashCode = hashCode * 59 + this.SubnetId.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.DesktopId != null) hashCode = hashCode * 59 + this.DesktopId.GetHashCode();
                if (this.Tag != null) hashCode = hashCode * 59 + this.Tag.GetHashCode();
                return hashCode;
            }
        }
    }
}
