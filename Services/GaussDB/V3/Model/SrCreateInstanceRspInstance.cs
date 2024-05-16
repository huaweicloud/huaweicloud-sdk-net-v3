using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 实例信息。
    /// </summary>
    public class SrCreateInstanceRspInstance 
    {

        /// <summary>
        /// StarRocks实例ID，严格匹配UUID规则。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 可用区码。
        /// </summary>
        [JsonProperty("az_code", NullValueHandling = NullValueHandling.Ignore)]
        public string AzCode { get; set; }

        /// <summary>
        /// 可用区模式。  取值范围：  single：单可用区。  multi：多可用区。
        /// </summary>
        [JsonProperty("az_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string AzMode { get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("engine", NullValueHandling = NullValueHandling.Ignore)]
        public SrCreateInstanceRspInstanceEngine Engine { get; set; }

        /// <summary>
        /// 虚拟私有云ID。
        /// </summary>
        [JsonProperty("vpc_id", NullValueHandling = NullValueHandling.Ignore)]
        public string VpcId { get; set; }

        /// <summary>
        /// 安全组ID。
        /// </summary>
        [JsonProperty("security_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// 子网ID。
        /// </summary>
        [JsonProperty("sub_net_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubNetId { get; set; }

        /// <summary>
        /// 数据库用户。默认root。
        /// </summary>
        [JsonProperty("db_user", NullValueHandling = NullValueHandling.Ignore)]
        public string DbUser { get; set; }

        /// <summary>
        /// 数据库端口号。默认3306。
        /// </summary>
        [JsonProperty("port", NullValueHandling = NullValueHandling.Ignore)]
        public int? Port { get; set; }

        /// <summary>
        /// 部署模式。
        /// </summary>
        [JsonProperty("ha_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string HaMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pay_info", NullValueHandling = NullValueHandling.Ignore)]
        public SrCreateInstanceRspInstancePayInfo PayInfo { get; set; }

        /// <summary>
        /// SSL开关。
        /// </summary>
        [JsonProperty("enable_ssl", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSsl { get; set; }

        /// <summary>
        /// 实例状态。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 实例所在区域。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tags_info", NullValueHandling = NullValueHandling.Ignore)]
        public SrCreateInstanceRspInstanceTagsInfo TagsInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SrCreateInstanceRspInstance {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  azCode: ").Append(AzCode).Append("\n");
            sb.Append("  azMode: ").Append(AzMode).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  engine: ").Append(Engine).Append("\n");
            sb.Append("  vpcId: ").Append(VpcId).Append("\n");
            sb.Append("  securityGroupId: ").Append(SecurityGroupId).Append("\n");
            sb.Append("  subNetId: ").Append(SubNetId).Append("\n");
            sb.Append("  dbUser: ").Append(DbUser).Append("\n");
            sb.Append("  port: ").Append(Port).Append("\n");
            sb.Append("  haMode: ").Append(HaMode).Append("\n");
            sb.Append("  payInfo: ").Append(PayInfo).Append("\n");
            sb.Append("  enableSsl: ").Append(EnableSsl).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  tagsInfo: ").Append(TagsInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SrCreateInstanceRspInstance);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SrCreateInstanceRspInstance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.AzCode == input.AzCode ||
                    (this.AzCode != null &&
                    this.AzCode.Equals(input.AzCode))
                ) && 
                (
                    this.AzMode == input.AzMode ||
                    (this.AzMode != null &&
                    this.AzMode.Equals(input.AzMode))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Engine == input.Engine ||
                    (this.Engine != null &&
                    this.Engine.Equals(input.Engine))
                ) && 
                (
                    this.VpcId == input.VpcId ||
                    (this.VpcId != null &&
                    this.VpcId.Equals(input.VpcId))
                ) && 
                (
                    this.SecurityGroupId == input.SecurityGroupId ||
                    (this.SecurityGroupId != null &&
                    this.SecurityGroupId.Equals(input.SecurityGroupId))
                ) && 
                (
                    this.SubNetId == input.SubNetId ||
                    (this.SubNetId != null &&
                    this.SubNetId.Equals(input.SubNetId))
                ) && 
                (
                    this.DbUser == input.DbUser ||
                    (this.DbUser != null &&
                    this.DbUser.Equals(input.DbUser))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.HaMode == input.HaMode ||
                    (this.HaMode != null &&
                    this.HaMode.Equals(input.HaMode))
                ) && 
                (
                    this.PayInfo == input.PayInfo ||
                    (this.PayInfo != null &&
                    this.PayInfo.Equals(input.PayInfo))
                ) && 
                (
                    this.EnableSsl == input.EnableSsl ||
                    (this.EnableSsl != null &&
                    this.EnableSsl.Equals(input.EnableSsl))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.TagsInfo == input.TagsInfo ||
                    (this.TagsInfo != null &&
                    this.TagsInfo.Equals(input.TagsInfo))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.AzCode != null)
                    hashCode = hashCode * 59 + this.AzCode.GetHashCode();
                if (this.AzMode != null)
                    hashCode = hashCode * 59 + this.AzMode.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Engine != null)
                    hashCode = hashCode * 59 + this.Engine.GetHashCode();
                if (this.VpcId != null)
                    hashCode = hashCode * 59 + this.VpcId.GetHashCode();
                if (this.SecurityGroupId != null)
                    hashCode = hashCode * 59 + this.SecurityGroupId.GetHashCode();
                if (this.SubNetId != null)
                    hashCode = hashCode * 59 + this.SubNetId.GetHashCode();
                if (this.DbUser != null)
                    hashCode = hashCode * 59 + this.DbUser.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.HaMode != null)
                    hashCode = hashCode * 59 + this.HaMode.GetHashCode();
                if (this.PayInfo != null)
                    hashCode = hashCode * 59 + this.PayInfo.GetHashCode();
                if (this.EnableSsl != null)
                    hashCode = hashCode * 59 + this.EnableSsl.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.TagsInfo != null)
                    hashCode = hashCode * 59 + this.TagsInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
