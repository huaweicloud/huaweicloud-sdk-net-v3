using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dns.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreatePrivateZoneReq 
    {

        /// <summary>
        /// 待创建的域名。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 域名的描述信息。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 域名类型。取值：private。
        /// </summary>
        [JsonProperty("zone_type", NullValueHandling = NullValueHandling.Ignore)]
        public string ZoneType { get; set; }

        /// <summary>
        /// 管理该zone的管理员邮箱。
        /// </summary>
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        /// <summary>
        /// 用于填写默认生成的SOA记录中有效缓存时间，以秒为单位。
        /// </summary>
        [JsonProperty("ttl", NullValueHandling = NullValueHandling.Ignore)]
        public string Ttl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("router", NullValueHandling = NullValueHandling.Ignore)]
        public Router Router { get; set; }

        /// <summary>
        /// 资源标签。
        /// </summary>
        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 域名关联的企业项目ID，长度不超过36个字符。  默认值为0。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatePrivateZoneReq {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  zoneType: ").Append(ZoneType).Append("\n");
            sb.Append("  email: ").Append(Email).Append("\n");
            sb.Append("  ttl: ").Append(Ttl).Append("\n");
            sb.Append("  router: ").Append(Router).Append("\n");
            sb.Append("  tags: ").Append(Tags).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatePrivateZoneReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatePrivateZoneReq input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ZoneType == input.ZoneType ||
                    (this.ZoneType != null &&
                    this.ZoneType.Equals(input.ZoneType))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Ttl == input.Ttl ||
                    (this.Ttl != null &&
                    this.Ttl.Equals(input.Ttl))
                ) && 
                (
                    this.Router == input.Router ||
                    (this.Router != null &&
                    this.Router.Equals(input.Router))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.EnterpriseProjectId == input.EnterpriseProjectId ||
                    (this.EnterpriseProjectId != null &&
                    this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ZoneType != null)
                    hashCode = hashCode * 59 + this.ZoneType.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Ttl != null)
                    hashCode = hashCode * 59 + this.Ttl.GetHashCode();
                if (this.Router != null)
                    hashCode = hashCode * 59 + this.Router.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
                if (this.EnterpriseProjectId != null)
                    hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                return hashCode;
            }
        }
    }
}
