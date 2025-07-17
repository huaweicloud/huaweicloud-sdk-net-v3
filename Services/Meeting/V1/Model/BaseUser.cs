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
    /// 用户基础信息。
    /// </summary>
    public class BaseUser 
    {

        /// <summary>
        /// 企业用户名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 后台自动识别是手机还是邮箱，若为手机号，则要求和国家码匹配。 &gt; * 当前中国站点企业支持使用邮箱或手机号进行邀请，手机仅支持+86开头的手机号。 &gt; * 当前国际站点企业仅支持使用邮箱进行邀请。 
        /// </summary>
        [JsonProperty("contact", NullValueHandling = NullValueHandling.Ignore)]
        public string Contact { get; set; }

        /// <summary>
        /// [[手机号所属的国家](https://support.huaweicloud.com/api-meeting/meeting_21_0109.html#ZH-CN_TOPIC_0212714591__table19371178135314)](tag:hws)[[手机号所属的国家](https://support.huaweicloud.com/intl/zh-cn/api-meeting/meeting_21_0109.html#ZH-CN_TOPIC_0212714591__table19371178135314)](tag:hk) 。 
        /// </summary>
        [JsonProperty("country", NullValueHandling = NullValueHandling.Ignore)]
        public string Country { get; set; }

        /// <summary>
        /// 部门编码，若不携带则默认根部门。
        /// </summary>
        [JsonProperty("deptCode", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptCode { get; set; }

        /// <summary>
        /// 职位。
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// 通讯录排序等级，序号越低优先级越高。
        /// </summary>
        [JsonProperty("sortLevel", NullValueHandling = NullValueHandling.Ignore)]
        public int? SortLevel { get; set; }

        /// <summary>
        /// 备注。
        /// </summary>
        [JsonProperty("desc", NullValueHandling = NullValueHandling.Ignore)]
        public string Desc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BaseUser {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  contact: ").Append(Contact).Append("\n");
            sb.Append("  country: ").Append(Country).Append("\n");
            sb.Append("  deptCode: ").Append(DeptCode).Append("\n");
            sb.Append("  title: ").Append(Title).Append("\n");
            sb.Append("  sortLevel: ").Append(SortLevel).Append("\n");
            sb.Append("  desc: ").Append(Desc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BaseUser);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BaseUser input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Contact != input.Contact || (this.Contact != null && !this.Contact.Equals(input.Contact))) return false;
            if (this.Country != input.Country || (this.Country != null && !this.Country.Equals(input.Country))) return false;
            if (this.DeptCode != input.DeptCode || (this.DeptCode != null && !this.DeptCode.Equals(input.DeptCode))) return false;
            if (this.Title != input.Title || (this.Title != null && !this.Title.Equals(input.Title))) return false;
            if (this.SortLevel != input.SortLevel || (this.SortLevel != null && !this.SortLevel.Equals(input.SortLevel))) return false;
            if (this.Desc != input.Desc || (this.Desc != null && !this.Desc.Equals(input.Desc))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Contact != null) hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.Country != null) hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.DeptCode != null) hashCode = hashCode * 59 + this.DeptCode.GetHashCode();
                if (this.Title != null) hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.SortLevel != null) hashCode = hashCode * 59 + this.SortLevel.GetHashCode();
                if (this.Desc != null) hashCode = hashCode * 59 + this.Desc.GetHashCode();
                return hashCode;
            }
        }
    }
}
