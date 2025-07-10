using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cdn.V2.Model
{
    /// <summary>
    /// 共享缓存配置
    /// </summary>
    public class ListShareCacheGroupsConfig 
    {

        /// <summary>
        /// 共享缓存ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 共享缓存组名
        /// </summary>
        [JsonProperty("group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string GroupName { get; set; }

        /// <summary>
        /// 共享缓存创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public int? CreateTime { get; set; }

        /// <summary>
        /// 共享缓存域名记录
        /// </summary>
        [JsonProperty("share_cache_records", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListShareCacheGroupsRecord> ShareCacheRecords { get; set; }

        /// <summary>
        /// 共享缓存组主域名
        /// </summary>
        [JsonProperty("primary_domain", NullValueHandling = NullValueHandling.Ignore)]
        public string PrimaryDomain { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListShareCacheGroupsConfig {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  groupName: ").Append(GroupName).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  shareCacheRecords: ").Append(ShareCacheRecords).Append("\n");
            sb.Append("  primaryDomain: ").Append(PrimaryDomain).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListShareCacheGroupsConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListShareCacheGroupsConfig input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.GroupName != input.GroupName || (this.GroupName != null && !this.GroupName.Equals(input.GroupName))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.ShareCacheRecords != input.ShareCacheRecords || (this.ShareCacheRecords != null && input.ShareCacheRecords != null && !this.ShareCacheRecords.SequenceEqual(input.ShareCacheRecords))) return false;
            if (this.PrimaryDomain != input.PrimaryDomain || (this.PrimaryDomain != null && !this.PrimaryDomain.Equals(input.PrimaryDomain))) return false;

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
                if (this.GroupName != null) hashCode = hashCode * 59 + this.GroupName.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.ShareCacheRecords != null) hashCode = hashCode * 59 + this.ShareCacheRecords.GetHashCode();
                if (this.PrimaryDomain != null) hashCode = hashCode * 59 + this.PrimaryDomain.GetHashCode();
                return hashCode;
            }
        }
    }
}
