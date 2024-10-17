using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Lts.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class CreatefavoriteReqbody 
    {

        /// <summary>
        /// 企业项目id
        /// </summary>
        [JsonProperty("eps_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EpsId { get; set; }

        /// <summary>
        /// 收藏资源id
        /// </summary>
        [JsonProperty("favorite_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FavoriteResourceId { get; set; }

        /// <summary>
        /// 收藏资源类型
        /// </summary>
        [JsonProperty("favorite_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public string FavoriteResourceType { get; set; }

        /// <summary>
        /// 日志组id
        /// </summary>
        [JsonProperty("log_group_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupId { get; set; }

        /// <summary>
        /// 日志组名称
        /// </summary>
        [JsonProperty("log_group_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogGroupName { get; set; }

        /// <summary>
        /// 日志流id
        /// </summary>
        [JsonProperty("log_stream_id", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamId { get; set; }

        /// <summary>
        /// 日志流名称
        /// </summary>
        [JsonProperty("log_stream_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LogStreamName { get; set; }

        /// <summary>
        /// 是否支持全局化，必填true，否则创建不了收藏
        /// </summary>
        [JsonProperty("is_global", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsGlobal { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreatefavoriteReqbody {\n");
            sb.Append("  epsId: ").Append(EpsId).Append("\n");
            sb.Append("  favoriteResourceId: ").Append(FavoriteResourceId).Append("\n");
            sb.Append("  favoriteResourceType: ").Append(FavoriteResourceType).Append("\n");
            sb.Append("  logGroupId: ").Append(LogGroupId).Append("\n");
            sb.Append("  logGroupName: ").Append(LogGroupName).Append("\n");
            sb.Append("  logStreamId: ").Append(LogStreamId).Append("\n");
            sb.Append("  logStreamName: ").Append(LogStreamName).Append("\n");
            sb.Append("  isGlobal: ").Append(IsGlobal).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreatefavoriteReqbody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CreatefavoriteReqbody input)
        {
            if (input == null) return false;
            if (this.EpsId != input.EpsId || (this.EpsId != null && !this.EpsId.Equals(input.EpsId))) return false;
            if (this.FavoriteResourceId != input.FavoriteResourceId || (this.FavoriteResourceId != null && !this.FavoriteResourceId.Equals(input.FavoriteResourceId))) return false;
            if (this.FavoriteResourceType != input.FavoriteResourceType || (this.FavoriteResourceType != null && !this.FavoriteResourceType.Equals(input.FavoriteResourceType))) return false;
            if (this.LogGroupId != input.LogGroupId || (this.LogGroupId != null && !this.LogGroupId.Equals(input.LogGroupId))) return false;
            if (this.LogGroupName != input.LogGroupName || (this.LogGroupName != null && !this.LogGroupName.Equals(input.LogGroupName))) return false;
            if (this.LogStreamId != input.LogStreamId || (this.LogStreamId != null && !this.LogStreamId.Equals(input.LogStreamId))) return false;
            if (this.LogStreamName != input.LogStreamName || (this.LogStreamName != null && !this.LogStreamName.Equals(input.LogStreamName))) return false;
            if (this.IsGlobal != input.IsGlobal || (this.IsGlobal != null && !this.IsGlobal.Equals(input.IsGlobal))) return false;

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
                if (this.EpsId != null) hashCode = hashCode * 59 + this.EpsId.GetHashCode();
                if (this.FavoriteResourceId != null) hashCode = hashCode * 59 + this.FavoriteResourceId.GetHashCode();
                if (this.FavoriteResourceType != null) hashCode = hashCode * 59 + this.FavoriteResourceType.GetHashCode();
                if (this.LogGroupId != null) hashCode = hashCode * 59 + this.LogGroupId.GetHashCode();
                if (this.LogGroupName != null) hashCode = hashCode * 59 + this.LogGroupName.GetHashCode();
                if (this.LogStreamId != null) hashCode = hashCode * 59 + this.LogStreamId.GetHashCode();
                if (this.LogStreamName != null) hashCode = hashCode * 59 + this.LogStreamName.GetHashCode();
                if (this.IsGlobal != null) hashCode = hashCode * 59 + this.IsGlobal.GetHashCode();
                return hashCode;
            }
        }
    }
}
