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
    /// Response Object
    /// </summary>
    public class ShowCorpResponse : SdkResponse
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("basicInfo", NullValueHandling = NullValueHandling.Ignore)]
        public QueryCorpBasicResultDTO BasicInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("adminInfo", NullValueHandling = NullValueHandling.Ignore)]
        public QueryAdminResultDTO AdminInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resInfo", NullValueHandling = NullValueHandling.Ignore)]
        public QueryCorpResResultDTO ResInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("groupDTO", NullValueHandling = NullValueHandling.Ignore)]
        public OrgGroupDTO GroupDTO { get; set; }

        /// <summary>
        /// 企业id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowCorpResponse {\n");
            sb.Append("  basicInfo: ").Append(BasicInfo).Append("\n");
            sb.Append("  adminInfo: ").Append(AdminInfo).Append("\n");
            sb.Append("  resInfo: ").Append(ResInfo).Append("\n");
            sb.Append("  groupDTO: ").Append(GroupDTO).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowCorpResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowCorpResponse input)
        {
            if (input == null) return false;
            if (this.BasicInfo != input.BasicInfo || (this.BasicInfo != null && !this.BasicInfo.Equals(input.BasicInfo))) return false;
            if (this.AdminInfo != input.AdminInfo || (this.AdminInfo != null && !this.AdminInfo.Equals(input.AdminInfo))) return false;
            if (this.ResInfo != input.ResInfo || (this.ResInfo != null && !this.ResInfo.Equals(input.ResInfo))) return false;
            if (this.GroupDTO != input.GroupDTO || (this.GroupDTO != null && !this.GroupDTO.Equals(input.GroupDTO))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;

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
                if (this.BasicInfo != null) hashCode = hashCode * 59 + this.BasicInfo.GetHashCode();
                if (this.AdminInfo != null) hashCode = hashCode * 59 + this.AdminInfo.GetHashCode();
                if (this.ResInfo != null) hashCode = hashCode * 59 + this.ResInfo.GetHashCode();
                if (this.GroupDTO != null) hashCode = hashCode * 59 + this.GroupDTO.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                return hashCode;
            }
        }
    }
}
