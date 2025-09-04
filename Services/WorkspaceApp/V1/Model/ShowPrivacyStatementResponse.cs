using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowPrivacyStatementResponse : SdkResponse
    {

        /// <summary>
        /// 隐私声明版本号。
        /// </summary>
        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 隐私声明内容。
        /// </summary>
        [JsonProperty("content", NullValueHandling = NullValueHandling.Ignore)]
        public string Content { get; set; }

        /// <summary>
        /// 隐私声明发布时间。
        /// </summary>
        [JsonProperty("publish_time", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? PublishTime { get; set; }

        /// <summary>
        /// 隐私声明对应的语言。
        /// </summary>
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// 是否签署过历史隐私声明，非第一次签署，提示用户旧版过期需重新签署。
        /// </summary>
        [JsonProperty("signed_history_record", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SignedHistoryRecord { get; set; }

        /// <summary>
        /// 是否签署过当前最新的隐私申明 没有签署需需要提醒用户重新签署。
        /// </summary>
        [JsonProperty("signed_newest_record", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SignedNewestRecord { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowPrivacyStatementResponse {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  content: ").Append(Content).Append("\n");
            sb.Append("  publishTime: ").Append(PublishTime).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  signedHistoryRecord: ").Append(SignedHistoryRecord).Append("\n");
            sb.Append("  signedNewestRecord: ").Append(SignedNewestRecord).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowPrivacyStatementResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowPrivacyStatementResponse input)
        {
            if (input == null) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.Content != input.Content || (this.Content != null && !this.Content.Equals(input.Content))) return false;
            if (this.PublishTime != input.PublishTime || (this.PublishTime != null && !this.PublishTime.Equals(input.PublishTime))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.SignedHistoryRecord != input.SignedHistoryRecord || (this.SignedHistoryRecord != null && !this.SignedHistoryRecord.Equals(input.SignedHistoryRecord))) return false;
            if (this.SignedNewestRecord != input.SignedNewestRecord || (this.SignedNewestRecord != null && !this.SignedNewestRecord.Equals(input.SignedNewestRecord))) return false;

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
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Content != null) hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.PublishTime != null) hashCode = hashCode * 59 + this.PublishTime.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.SignedHistoryRecord != null) hashCode = hashCode * 59 + this.SignedHistoryRecord.GetHashCode();
                if (this.SignedNewestRecord != null) hashCode = hashCode * 59 + this.SignedNewestRecord.GetHashCode();
                return hashCode;
            }
        }
    }
}
